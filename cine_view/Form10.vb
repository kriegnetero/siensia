Public Class Form10
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With cmb_busca.Items
            .Add("review")
            .Add("resposta")
        End With
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        clicar_form10()
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        With dgv_dados
            If .CurrentRow.Cells(2).Selected Then
                Dim campo As String = .CurrentRow.Cells(0).Value
                Dim cod As String = .CurrentRow.Cells(3).Value
                If cmb_busca.Text = "review" Then
                    resp = MsgBox("Deseja exluir a review ?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Aviso")
                    If resp = MsgBoxResult.Yes Then
                        sql = $"delete from review where (id='{campo}' and cod='{cod}')"
                        rs = db.Execute(sql)
                        MsgBox("Review excluida com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                        clicar_form10()
                    End If
                ElseIf cmb_busca.Text = "resposta" Then
                    resp = MsgBox("Deseja exluir a resposta ?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Aviso")
                    If resp = MsgBoxResult.Yes Then
                        sql = $"delete from resposta where (email='{campo}' and id_reposta='{cod}')"
                        rs = db.Execute(sql)
                        MsgBox("Resposta excluida com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                        clicar_form10()
                    End If
                End If
                End If
        End With
    End Sub
End Class