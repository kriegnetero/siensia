Imports System.Xml

Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_reviewer_form4()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub btn_list_rr_Click(sender As Object, e As EventArgs) Handles btn_list_rr.Click
        Form10.Show()
        Me.Close()
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        'botões do grid
        Try
            With dgv_dados
                Dim email As String = .CurrentRow.Cells(1).Value
                sql = "select * from registro_acesso"
                rs = db.Execute(sql)
                Dim log As String = rs.Fields(2).Value
                Dim senha As String = rs.Fields(3).Value
                If .CurrentRow.Cells(2).Selected = True Then
                    'excluir
                    If log = email Then
                        MsgBox("Você não pode excluir a sí mesmo", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
                        Exit Sub
                    Else
                        resp = MsgBox($"Deseja remover o usuário: '{ .CurrentRow.Cells(0).Value}' ?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Aviso")
                        If resp = MsgBoxResult.Yes Then
                            sql = $"delete from reviewer where email='{email}'"
                            rs = db.Execute(sql)
                            sql = $"delete from review where email='{email}'"
                            rs = db.Execute(sql)
                            MsgBox("Usuário removido com sucesso !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                            carregar_reviewer_form4()
                        End If
                    End If
                    'bloquear
                ElseIf .CurrentRow.Cells(3).Selected = True Then
                    If email = log Then
                        MsgBox("Você não pode bloquear/desbloquear a sí mesmo", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
                        Exit Sub
                    End If
                    sql = $"select * from lista_negra where email='{email}'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        resp = MsgBox($"Deseja desbloquer o usuário: '{ .CurrentRow.Cells(0).Value}' ?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Aviso")
                        If resp = MsgBoxResult.Yes Then
                            sql = $"delete from lista_negra where email='{email}'"
                            rs = db.Execute(sql)
                            MsgBox("Usuário desbloqueado com sucesso !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                        End If
                    Else
                        sql = $"insert into lista_negra (email) values ('{email}')"
                        rs = db.Execute(sql)
                        resp = MsgBox($"Deseja bloquear o usuário: '{ .CurrentRow.Cells(0).Value}' ?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Aviso")
                        If resp = MsgBoxResult.Yes Then
                            MsgBox("Usuário bloqueado com sucesso !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                        End If
                    End If
                    'botão de moderador
                ElseIf .CurrentRow.Cells(4).Selected Then
                    If email = log Then
                        MsgBox("Você não pode promover/remover a sí mesmo da moderação", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
                        Exit Sub
                    End If
                    sql = $"select * from moderador where (email='{email}' and senha='{senha}')"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        resp = MsgBox($"Deseja remover mod de '{ .CurrentRow.Cells(0).Value}' ?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Aviso")
                        If resp = MsgBoxResult.Yes Then
                            sql = $"delete from moderador where (email='{email}' and senha='{senha}'"
                            rs = db.Execute(sql)
                            MsgBox("Reviewer removido da moderação com sucesso !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                        End If
                    Else
                        resp = MsgBox($"Deseja promover '{ .CurrentRow.Cells(0).Value}' a mod ?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Aviso")
                        If resp = MsgBoxResult.Yes Then
                            sql = $"insert into moderador (email,senha) values ('{email}','{senha}')"
                            rs = db.Execute(sql)
                            MsgBox("Promoção concluída !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                        End If
                    End If

                End If
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            sql = $"select * from reviewer where id='{txt_busca.Text}'"
            rs = db.Execute(sql)
            With dgv_dados
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, Nothing, Nothing, Nothing)
                    rs.MoveNext()
                Loop
                If txt_busca.Text = "" Then
                    carregar_reviewer_form4()
                End If
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class