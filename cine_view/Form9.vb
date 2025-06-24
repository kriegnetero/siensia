Public Class Form9
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            sql = $"select * from reviewer where email='{email7}'"
            rs = db.Execute(sql)
            lb_user.Text = rs.Fields(0).Value
            img_photo.Load(rs.Fields(3).Value)
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Form7.Show()
        Me.Close()
    End Sub
End Class