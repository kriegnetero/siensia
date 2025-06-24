Public Class Form11
    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_review_form11()
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Try
            With dgv_dados
                If .CurrentRow.Cells(3).Selected Then
                    Dim cod As String = .CurrentRow.Cells(2).Value
                    Dim review As String = .CurrentRow.Cells(1).Value
                    sql = $"select * from a_review where (cod='{cod}' and stat='yes')"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        MsgBox("Review já aprovada", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                    Else
                        resp = MsgBox("Deseja aprovar essa review ?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Aviso")
                        If resp = MsgBoxResult.Yes Then
                            sql = $"insert into a_review (cod,stat,review) values ('{cod}','yes','{review}')"
                            rs = db.Execute(sql)
                            MsgBox("Análise aprovada !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                        End If
                    End If
                End If
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class