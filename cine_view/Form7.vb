Public Class Form7
    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub btn_responder_Click(sender As Object, e As EventArgs) Handles btn_responder.Click
        Form8.Show()
        sql = $"select * from registro_acesso"
        rs = db.Execute(sql)
        With Form8
            .img_foto.Load(rs.Fields(4).Value)
        End With
        Me.Close()
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_dados_form7()
        carregar_resp_f7()
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        With dgv_dados
            If .CurrentRow.Cells(2).Selected Then
                Dim texto As String = .CurrentRow.Cells(1).Value
                email7 = .CurrentRow.Cells(0).Value
                Form9.Show()
                With Form9
                    .txt_analise.Text = texto
                End With
                Me.Close()
            End If
        End With
    End Sub
End Class