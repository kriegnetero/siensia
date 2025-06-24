Module Mod_geral
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql, diretorio, resp As String
    Public cod_geral As String
    Public cod_r, cartaz As String
    Public id_r, cod_rr As String
    Public email7 As String


    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=ALFRED;Initial Catalog=cine_view;trusted_connection=yes;")
            MsgBox("Conexão realizada com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
        Catch ex As Exception
            MsgBox("Erro ao conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub
    Sub carregar_dados_form3()
        Try
            With Form3
                'carregar foto
                sql = $"select * from registro_acesso"
                rs = db.Execute(sql)
                .user_photo.Load(rs.Fields(4).Value)
                'verificar se é mod ou não
                sql = $"SELECT r.* FROM registro_acesso r INNER JOIN moderador m ON r.email = m.email;"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    .btn_mod.Visible = True
                    .btn_aprove.Visible = True
                End If
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Sub carregar_perfil_form6()
        Try
            With Form6
                sql = $"select * from registro_acesso"
                rs = db.Execute(sql)
                .user_photo.Load(rs.Fields(4).Value)
                .lb_email.Text = rs.Fields(2).Value
                .lb_user.Text = rs.Fields(1).Value
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Sub carregar_review_form6()
        Try
            With Form6.dgv_dados
                sql = $"SELECT r.* FROM review r INNER JOIN registro_acesso m ON r.email = m.email;"
                rs = db.Execute(sql)
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, Nothing, Nothing, rs.Fields(6).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Sub carregar_fav_form6()
        With Form6
            'Trás o gênero favorito que foi guardado e joga nas checkbox
            sql = "select * from registro_acesso"
            rs = db.Execute(sql)
            Dim lista3 As String = rs.Fields(5).Value
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
    End Sub
    Sub carregar_review_form3()
        Try
            sql = $"select * from registro_acesso"
            rs = db.Execute(sql)
            Dim fav_genero = rs.Fields(5).Value
            sql = $"SELECT r.* FROM review r INNER JOIN a_review ar ON r.cod = ar.cod WHERE ar.stat = 'yes' AND r.genero = '{fav_genero}'"
            rs = db.Execute(sql)
            With Form3.dgv_dados
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(Nothing, rs.Fields(7).Value, rs.Fields(0).Value, rs.Fields(2).Value, Nothing, rs.Fields(6).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Sub carregar_review_form11()
        With Form11.dgv_dados
            sql = $"select * from review"
            rs = db.Execute(sql)
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(7).Value, rs.Fields(2).Value, rs.Fields(6).Value, Nothing)
                rs.MoveNext()
            Loop
        End With
    End Sub
    Sub carregar_reviewer_form4()
        With Form4.dgv_dados
            sql = $"select * from reviewer"
            rs = db.Execute(sql)
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, Nothing, Nothing, Nothing)
                rs.MoveNext()
            Loop
        End With
    End Sub
    Sub carregar_dados_form7()
        sql = $"select * from reviewer where id='{id_r}'"
        rs = db.Execute(sql)
        Dim foto As String = rs.Fields(3).Value
        sql = $"select * from review where (id='{id_r}' and cod='{cod_rr}')"
        rs = db.Execute(sql)
        cartaz = rs.Fields(4).Value
        cod_r = rs.Fields(6).Value
        With Form7
            .img_photo.Load(foto)
            .img_cartaz.Load(cartaz)
            .txt_analise.Text = rs.Fields(2).Value
        End With
    End Sub
    Sub carregar_resp_f7()
        With Form7.dgv_dados
            sql = $"select * from resposta where cod = '{cod_rr}'"
            rs = db.Execute(sql)
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(3).Value, rs.Fields(2).Value, Nothing)
                rs.MoveNext()
            Loop
        End With
    End Sub
    Sub clicar_form10()
        With Form10
            If .cmb_busca.Text = "review" Then
                sql = $"select * from review where id='{ .txt_buscar.Text}'"
                rs = db.Execute(sql)
                With .dgv_dados
                    .Rows.Clear()
                    Do While rs.EOF = False
                        .Rows.Add(rs.Fields(7).Value, rs.Fields(2).Value, Nothing, rs.Fields(6).Value)
                        rs.MoveNext()
                    Loop
                End With
            Else
                sql = $"select * from resposta where email='{ .txt_buscar.Text}'"
                rs = db.Execute(sql)
                With .dgv_dados
                    .Rows.Clear()
                    Do While rs.EOF = False
                        .Rows.Add(rs.Fields(3).Value, rs.Fields(2).Value, Nothing, rs.Fields(1).Value)
                        rs.MoveNext()
                    Loop
                End With
            End If
        End With
    End Sub
End Module
