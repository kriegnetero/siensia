Public Class Form5
    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub btn_enviar_review_Click(sender As Object, e As EventArgs) Handles btn_enviar_review.Click
        Try
            sql = $"select * from review where (nome_filme='{txt_nome_filme.Text}' and cod='{cod_geral}')"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                If txt_comentario.Text = "" Or
                    txt_nome_filme.Text = "" Then
                    MsgBox("Nome ou review inválidos", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
                    Exit Sub
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
                    MsgBox("Selecione pelo menos um gênero pra review", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Aviso")
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
                    sql = "select * from registro_acesso"
                    rs = db.Execute(sql)
                    Dim email As String = rs.Fields(2).Value
                    Dim id As String = rs.Fields(1).Value
                    sql = $"insert into review (nome_filme,nota,comentario,genero,cartaz,email,id) values ('{txt_nome_filme.Text}','{ln_nota.Value}','{txt_comentario.Text}','{itens}','{diretorio}','{email}','{id}')"
                    rs = db.Execute(sql)
                    MsgBox("Review gravada como sucesso! aguarde a aprovação", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                    txt_comentario.Clear()
                    txt_nome_filme.Clear()
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
                    img_cartaz.Load(Application.StartupPath & "\fotos\cartaz_filme.png")
                    txt_nome_filme.Focus()
                End If
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
                resp = MsgBox("Deseja editar a sua review ?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Aviso")
                If resp = MsgBoxResult.Yes Then
                    sql = $"update review set nome_filme='{txt_nome_filme.Text}',nota='{ln_nota.Value}',comentario='{txt_comentario.Text}',genero='{itens}',cartaz='{diretorio}' where cod='{cod_geral}'"
                    rs = db.Execute(sql)
                    MsgBox("Review atualizada !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                    txt_comentario.Clear()
                    txt_nome_filme.Clear()
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
                    img_cartaz.Load(Application.StartupPath & "\fotos\cartaz_filme.png")
                    txt_nome_filme.Focus()
                    Form6.Show()
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub img_cartaz_Click(sender As Object, e As EventArgs) Handles img_cartaz.Click
        With OpenFileDialog1
            .Title = "Selecione o cartaz do seu filme"
            .InitialDirectory = Application.StartupPath & "\fotos"
            .ShowDialog()
            diretorio = .FileName
            img_cartaz.Load(diretorio)
        End With

    End Sub
End Class