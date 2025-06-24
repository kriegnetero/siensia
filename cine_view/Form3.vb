Imports System.Security.Cryptography.X509Certificates

Public Class Form3
    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        sql = "delete from registro_acesso"
        rs = db.Execute(sql)
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_dados_form3()
        carregar_review_form3()
    End Sub

    Private Sub btn_add_review_Click(sender As Object, e As EventArgs) Handles btn_add_review.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub user_photo_Click(sender As Object, e As EventArgs) Handles user_photo.Click
        Form6.Show()
        Me.Close()
    End Sub

    Private Sub btn_aprove_Click(sender As Object, e As EventArgs) Handles btn_aprove.Click
        Form11.Show()
        Me.Close()
    End Sub

    Private Sub btn_mod_Click(sender As Object, e As EventArgs) Handles btn_mod.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        With dgv_dados
            Try
                If .CurrentRow.Cells(4).Selected Then
                    Dim id As String = .CurrentRow.Cells(1).Value
                    Dim cod As String = .CurrentRow.Cells(5).Value
                    cod_rr = cod
                    id_r = id
                    Form7.Show()
                    Form7.lb_user.Text = .CurrentRow.Cells(1).Value
                    Me.Close()
                End If
            Catch ex As Exception
                Exit Sub
            End Try
        End With
    End Sub

    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        txt_busca.Clear()
        chk_acao.Checked = False
        chk_animacao.Checked = False
        chk_aventura.Checked = False
        chk_comedia.Checked = False
        chk_doc.Checked = False
        chk_drama.Checked = False
        chk_fan.Checked = False
        chk_musical.Checked = False
        chk_romance.Checked = False
        chk_scifi.Checked = False
        chk_suspense.Checked = False
        chk_terror.Checked = False
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim lista2 As New List(Of String)
        If chk_acao.Checked Then
            lista2.Add(chk_acao.Text)
        End If
        If chk_animacao.Checked Then
            lista2.Add(chk_animacao.Text)
        End If
        If chk_aventura.Checked Then
            lista2.Add(chk_aventura.Text)
        End If
        If chk_comedia.Checked Then
            lista2.Add(chk_comedia.Text)
        End If
        If chk_doc.Checked Then
            lista2.Add(chk_doc.Text)
        End If
        If chk_drama.Checked Then
            lista2.Add(chk_drama.Text)
        End If
        If chk_fan.Checked Then
            lista2.Add(chk_fan.Text)
        End If
        If chk_musical.Checked Then
            lista2.Add(chk_musical.Text)
        End If
        If chk_romance.Checked Then
            lista2.Add(chk_romance.Text)
        End If
        If chk_scifi.Checked Then
            lista2.Add(chk_scifi.Text)
        End If
        If chk_suspense.Checked Then
            lista2.Add(chk_suspense.Text)
        End If
        If chk_terror.Checked Then
            lista2.Add(chk_terror.Text)
        End If
        Dim itens As String = String.Join(",", lista2)
        sql = $"SELECT r.* FROM review r JOIN a_review ar ON r.cod = ar.cod WHERE ar.stat = 'yes' AND r.genero = '{itens}' AND r.nome_filme = '{txt_busca.Text}'"
        rs = db.Execute(sql)
        With dgv_dados
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(Nothing, rs.Fields(7).Value, rs.Fields(0).Value, rs.Fields(2).Value, Nothing, rs.Fields(6).Value)
                rs.MoveNext()
            Loop
        End With
    End Sub
End Class