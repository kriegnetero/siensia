Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub

    Private Sub btn_cadastro_Click(sender As Object, e As EventArgs) Handles btn_cadastro.Click
        txt_usuario.Clear()
        txt_senha.Clear()
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Application.Exit()
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Try
            If txt_senha.Text = "" Or txt_usuario.Text = "" Then
                MsgBox("Preencha todos os campos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
                txt_usuario.Clear()
                txt_senha.Clear()
                txt_usuario.Focus()
            Else
                sql = $"SELECT r.* FROM reviewer r INNER JOIN lista_negra l ON r.email = l.email WHERE r.id = '{txt_usuario.Text}' OR r.email = '{txt_usuario.Text}'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    MsgBox("Usuário bloqueado! Contate o moderador", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
                    txt_usuario.Clear()
                    txt_senha.Clear()
                    txt_usuario.Focus()
                Else
                    sql = $"select * from reviewer where (id='{txt_usuario.Text}' or email='{txt_usuario.Text}') and senha='{txt_senha.Text}'"
                    rs = db.Execute(sql)
                    If rs.EOF = False Then
                        MsgBox("Usuário logado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                        Dim id, email, senha, foto, fav_genero As String
                        id = rs.Fields(0).Value
                        email = rs.Fields(1).Value
                        senha = rs.Fields(2).Value
                        foto = rs.Fields(3).Value
                        fav_genero = rs.Fields(4).Value
                        sql = $"insert into registro_acesso (id,email,senha,foto,fav_genero) values ('{id}','{email}','{senha}','{foto}','{fav_genero}')"
                        rs = db.Execute(sql)
                        txt_senha.Clear()
                        txt_usuario.Clear()
                        txt_usuario.Focus()
                        Form3.Show()
                        Me.Hide()
                    Else
                        sql = $"select * from reviewer where (id='{txt_usuario.Text}' or email='{txt_usuario.Text}')"
                        rs = db.Execute(sql)
                        If rs.EOF = False Then
                            MsgBox("Usuário ou senha incorretos !", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
                            txt_senha.Clear()
                            txt_usuario.Clear()
                            txt_usuario.Focus()
                        Else
                            MsgBox("Usuário não cadastrado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class
