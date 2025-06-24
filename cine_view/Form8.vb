Public Class Form8
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Form7.Show()
        Me.Close()
    End Sub

    Private Sub btn_enviar_Click(sender As Object, e As EventArgs) Handles btn_enviar.Click
        sql = $"select * from registro_acesso"
        rs = db.Execute(sql)
        Dim email As String = rs.Fields(2).Value
        sql = $"insert into resposta (cod,resposta,email) values('{cod_r}','{txt_resposta.Text}','{email}')"
        rs = db.Execute(sql)
        MsgBox("Resposta enviada", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
        txt_resposta.Clear()
    End Sub
End Class