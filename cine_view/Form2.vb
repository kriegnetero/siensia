Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_nome.Focus()
        diretorio = Application.StartupPath & "\fotos\nova_foto.png"
    End Sub

    Private Sub btn_voltar_f1_Click(sender As Object, e As EventArgs) Handles btn_voltar_f1.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub img_photo_Click(sender As Object, e As EventArgs) Handles img_photo.Click
        With OpenFileDialog1
            .Title = "Selecione a sua foto de perfil"
            .InitialDirectory = Application.StartupPath & "\fotos"
            .ShowDialog()
            diretorio = .FileName
            img_photo.Load(diretorio)
        End With
    End Sub

    Private Sub btn_cadastro_Click(sender As Object, e As EventArgs) Handles btn_cadastro.Click
        Try
            'Gravar cadastro de usuário
            If txt_nome.Text = "" Or
                txt_senha.Text = "" Or
                txt_email.Text = "" Or
                txt_senha.Text = "" Or
                txt_confirmar_senha.Text = "" Then
                MsgBox("Preencha todos os campos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
            ElseIf chk_acao.Checked = False And
                    chk_animacao.Checked = False And
                    chk_aventura.Checked = False And
                    chk_comedia.Checked = False And
                    chk_doc.Checked = False And
                    chk_drama.Checked = False And
                    chk_fan.Checked = False And
                    chk_musical.Checked And
                    chk_romance.Checked = False And
                    chk_scifi.Checked = False And
                    chk_suspense.Checked = False And
                    chk_terror.Checked = False Then
                MsgBox("Escolha pelo menos um gênero de filme", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                Exit Sub
            Else
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
                sql = $"insert into reviewer (id,email,senha,foto,fav_genero) values ('{txt_nome.Text}','{txt_email.Text}','{txt_senha.Text}','{diretorio}','{itens}')"
                rs = db.Execute(sql)
                MsgBox("Usuário cadastrado com sucesso !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                Form1.Show()
                Me.Close()
                txt_confirmar_senha.Clear()
                txt_email.Clear()
                txt_nome.Clear()
                txt_senha.Clear()
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
                img_photo.Load(Application.StartupPath & "\fotos\nova_foto.png")
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub txt_nome_LostFocus(sender As Object, e As EventArgs) Handles txt_nome.LostFocus
        Try
            sql = $"select * from reviewer where id='{txt_nome.Text}'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                MsgBox("User name já utilizado", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
                txt_nome.Clear()
                txt_nome.Focus()
                Exit Sub
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class