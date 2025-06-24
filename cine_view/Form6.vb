Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_perfil_form6()
        carregar_review_form6()
        carregar_fav_form6()
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub btn_gravar_senha_Click(sender As Object, e As EventArgs) Handles btn_gravar_senha.Click
        Try
            If txt_nova_senha.Text = "" Or txt_senha.Text = "" Then
                MsgBox("Preencha todos os campos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
            Else
                sql = $"select * from registro_acesso where senha='{txt_senha.Text}'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    resp = MsgBox("Deseja realmente alterar a sua senha ?", MsgBoxStyle.Information + MsgBoxStyle.YesNo)
                    If resp = MsgBoxResult.Yes Then
                        sql = $"update reviewer set senha='{txt_nova_senha.Text}'"
                        rs = db.Execute(sql)
                        MsgBox("Senha alterada com sucesso !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                        If Form3.btn_add_review.Visible = True Then
                            sql = $"update moderador set senha='{txt_nova_senha.Text}'"
                            rs = db.Execute(sql)
                            MsgBox("Senha de moderador alterada com sucesso !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                        End If
                    End If
                Else
                    MsgBox("Senha incorreta", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
                    txt_nova_senha.Clear()
                    txt_senha.Clear()
                    txt_senha.Focus()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub bnt_fav_gen_Click(sender As Object, e As EventArgs) Handles bnt_fav_gen.Click
        Try
            Dim lista4 As New List(Of String)
            If chk_acao.Checked Then
                lista4.Add(chk_acao.Text)
            End If
            If chk_animacao.Checked Then
                lista4.Add(chk_animacao.Text)
            End If
            If chk_aventura.Checked Then
                lista4.Add(chk_aventura.Text)
            End If
            If chk_comedia.Checked Then
                lista4.Add(chk_comedia.Text)
            End If
            If chk_doc.Checked Then
                lista4.Add(chk_doc.Text)
            End If
            If chk_drama.Checked Then
                lista4.Add(chk_drama.Text)
            End If
            If chk_fan.Checked Then
                lista4.Add(chk_fan.Text)
            End If
            If chk_musical.Checked Then
                lista4.Add(chk_musical.Text)
            End If
            If chk_romance.Checked Then
                lista4.Add(chk_romance.Text)
            End If
            If chk_scifi.Checked Then
                lista4.Add(chk_scifi.Text)
            End If
            If chk_suspense.Checked Then
                lista4.Add(chk_suspense.Text)
            End If
            If chk_terror.Checked Then
                lista4.Add(chk_terror.Text)
            End If
            sql = $"select * from registro_acesso"
            rs = db.Execute(sql)
            Dim email_log = rs.Fields(2).Value
            Dim item4 As String = String.Join(",", lista4)
            sql = $"update reviewer set fav_genero='{item4}' where email='{email_log}'"
            rs = db.Execute(sql)
            sql = $"update registro_acesso set fav_genero='{item4}' where email='{email_log}'"
            rs = db.Execute(sql)
            MsgBox("Favoritos atualizados com sucesso !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
            Form3.Show()
            Me.Close()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        With dgv_dados
            'botão excluir
            If .CurrentRow.Cells(4).Selected Then
                Dim cod = .CurrentRow.Cells(5).Value
                resp = MsgBox("Deseja realmente excluir a review ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Aviso")
                If resp = MsgBoxResult.Yes Then
                    sql = $"delete from review where cod='{cod}'"
                    rs = db.Execute(sql)
                    MsgBox("Review deletada com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                    carregar_review_form6()
                End If
                'botão editar
            ElseIf .CurrentRow.Cells(3).Selected Then
                cod_geral = .CurrentRow.Cells(5).Value
                Form5.Show()
                With Form5
                    sql = $"select * from review where cod='{cod_geral}'"
                    rs = db.Execute(sql)
                    .img_cartaz.Load(rs.Fields(4).Value)
                    diretorio = rs.Fields(4).Value
                    .txt_nome_filme.Text = rs.Fields(0).Value
                    .txt_comentario.Text = rs.Fields(2).Value
                    .ln_nota.Value = rs.Fields(1).Value
                    'Puxa as checkbox da review do filme
                    sql = $"select * from review where cod='{cod_geral}'"
                    rs = db.Execute(sql)
                    Dim lista3 As String = rs.Fields(3).Value
                    Dim item() = lista3.Split(","c)
                    .chk_animacao.Checked = False
                    .chk_aventura.Checked = False
                    .chk_comedia.Checked = False
                    .chk_doc.Checked = False
                    .chk_drama.Checked = False
                    .chk_fan.Checked = False
                    .chk_musical.Checked = False
                    .chk_romance.Checked = False
                    .chk_scifi.Checked = False
                    .chk_suspense.Checked = False
                    .chk_terror.Checked = False
                    For Each itens As String In item
                        Dim itemlimpo As String = itens.Trim
                        If itemlimpo = .chk_acao.Text Then
                            .chk_acao.Checked = True
                        End If
                        If itemlimpo = .chk_animacao.Text Then
                            .chk_animacao.Checked = True
                        End If
                        If itemlimpo = .chk_aventura.Text Then
                            .chk_aventura.Checked = True
                        End If
                        If itemlimpo = .chk_comedia.Text Then
                            .chk_comedia.Checked = True
                        End If
                        If itemlimpo = .chk_doc.Text Then
                            .chk_doc.Checked = True
                        End If
                        If itemlimpo = .chk_drama.Text Then
                            .chk_drama.Checked = True
                        End If
                        If itemlimpo = .chk_fan.Text Then
                            .chk_fan.Checked = True
                        End If
                        If itemlimpo = .chk_musical.Text Then
                            .chk_musical.Checked = True
                        End If
                        If itemlimpo = .chk_romance.Text Then
                            .chk_romance.Checked = True
                        End If
                        If itemlimpo = .chk_scifi.Text Then
                            .chk_scifi.Checked = True
                        End If
                        If itemlimpo = .chk_suspense.Text Then
                            .chk_suspense.Checked = True
                        End If
                        If itemlimpo = .chk_terror.Text Then
                            .chk_terror.Checked = True
                        End If
                    Next
                End With
            End If
        End With
    End Sub
End Class