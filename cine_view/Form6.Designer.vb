<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.user_photo = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bnt_fav_gen = New System.Windows.Forms.Button()
        Me.chk_musical = New System.Windows.Forms.CheckBox()
        Me.chk_romance = New System.Windows.Forms.CheckBox()
        Me.chk_fan = New System.Windows.Forms.CheckBox()
        Me.chk_scifi = New System.Windows.Forms.CheckBox()
        Me.chk_animacao = New System.Windows.Forms.CheckBox()
        Me.chk_doc = New System.Windows.Forms.CheckBox()
        Me.chk_aventura = New System.Windows.Forms.CheckBox()
        Me.chk_comedia = New System.Windows.Forms.CheckBox()
        Me.chk_drama = New System.Windows.Forms.CheckBox()
        Me.chk_suspense = New System.Windows.Forms.CheckBox()
        Me.chk_terror = New System.Windows.Forms.CheckBox()
        Me.chk_acao = New System.Windows.Forms.CheckBox()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lb_user = New System.Windows.Forms.Label()
        Me.lb_email = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.btn_gravar_senha = New System.Windows.Forms.Button()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.txt_nova_senha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.user_photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'user_photo
        '
        Me.user_photo.BackColor = System.Drawing.Color.Firebrick
        Me.user_photo.Image = CType(resources.GetObject("user_photo.Image"), System.Drawing.Image)
        Me.user_photo.Location = New System.Drawing.Point(28, 26)
        Me.user_photo.Name = "user_photo"
        Me.user_photo.Size = New System.Drawing.Size(105, 113)
        Me.user_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.user_photo.TabIndex = 1
        Me.user_photo.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.bnt_fav_gen)
        Me.Panel1.Controls.Add(Me.chk_musical)
        Me.Panel1.Controls.Add(Me.chk_romance)
        Me.Panel1.Controls.Add(Me.chk_fan)
        Me.Panel1.Controls.Add(Me.chk_scifi)
        Me.Panel1.Controls.Add(Me.chk_animacao)
        Me.Panel1.Controls.Add(Me.chk_doc)
        Me.Panel1.Controls.Add(Me.chk_aventura)
        Me.Panel1.Controls.Add(Me.chk_comedia)
        Me.Panel1.Controls.Add(Me.chk_drama)
        Me.Panel1.Controls.Add(Me.chk_suspense)
        Me.Panel1.Controls.Add(Me.chk_terror)
        Me.Panel1.Controls.Add(Me.chk_acao)
        Me.Panel1.Controls.Add(Me.btn_home)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lb_user)
        Me.Panel1.Controls.Add(Me.lb_email)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.dgv_dados)
        Me.Panel1.Controls.Add(Me.user_photo)
        Me.Panel1.Controls.Add(Me.btn_gravar_senha)
        Me.Panel1.Controls.Add(Me.txt_senha)
        Me.Panel1.Controls.Add(Me.txt_nova_senha)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(134, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1146, 758)
        Me.Panel1.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Maroon
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(94, 469)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(355, 27)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "ALTERAR GÊNEROS FAVORITOS"
        '
        'bnt_fav_gen
        '
        Me.bnt_fav_gen.BackColor = System.Drawing.Color.Maroon
        Me.bnt_fav_gen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bnt_fav_gen.Font = New System.Drawing.Font("Monotype Corsiva", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnt_fav_gen.ForeColor = System.Drawing.Color.White
        Me.bnt_fav_gen.Location = New System.Drawing.Point(138, 637)
        Me.bnt_fav_gen.Name = "bnt_fav_gen"
        Me.bnt_fav_gen.Size = New System.Drawing.Size(242, 41)
        Me.bnt_fav_gen.TabIndex = 61
        Me.bnt_fav_gen.Text = "ATUALIZAR GÊNERO"
        Me.bnt_fav_gen.UseVisualStyleBackColor = False
        '
        'chk_musical
        '
        Me.chk_musical.AutoSize = True
        Me.chk_musical.BackColor = System.Drawing.Color.Maroon
        Me.chk_musical.Font = New System.Drawing.Font("Monotype Corsiva", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_musical.ForeColor = System.Drawing.Color.White
        Me.chk_musical.Location = New System.Drawing.Point(341, 583)
        Me.chk_musical.Name = "chk_musical"
        Me.chk_musical.Size = New System.Drawing.Size(84, 19)
        Me.chk_musical.TabIndex = 60
        Me.chk_musical.Text = "MUSICAL"
        Me.chk_musical.UseVisualStyleBackColor = False
        '
        'chk_romance
        '
        Me.chk_romance.AutoSize = True
        Me.chk_romance.BackColor = System.Drawing.Color.Maroon
        Me.chk_romance.Font = New System.Drawing.Font("Monotype Corsiva", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_romance.ForeColor = System.Drawing.Color.White
        Me.chk_romance.Location = New System.Drawing.Point(232, 583)
        Me.chk_romance.Name = "chk_romance"
        Me.chk_romance.Size = New System.Drawing.Size(88, 19)
        Me.chk_romance.TabIndex = 59
        Me.chk_romance.Text = "ROMANCE"
        Me.chk_romance.UseVisualStyleBackColor = False
        '
        'chk_fan
        '
        Me.chk_fan.AutoSize = True
        Me.chk_fan.BackColor = System.Drawing.Color.Maroon
        Me.chk_fan.Font = New System.Drawing.Font("Monotype Corsiva", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_fan.ForeColor = System.Drawing.Color.White
        Me.chk_fan.Location = New System.Drawing.Point(99, 582)
        Me.chk_fan.Name = "chk_fan"
        Me.chk_fan.Size = New System.Drawing.Size(88, 19)
        Me.chk_fan.TabIndex = 58
        Me.chk_fan.Text = "FANTASIA"
        Me.chk_fan.UseVisualStyleBackColor = False
        '
        'chk_scifi
        '
        Me.chk_scifi.AutoSize = True
        Me.chk_scifi.BackColor = System.Drawing.Color.Maroon
        Me.chk_scifi.Font = New System.Drawing.Font("Monotype Corsiva", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_scifi.ForeColor = System.Drawing.Color.White
        Me.chk_scifi.Location = New System.Drawing.Point(341, 558)
        Me.chk_scifi.Name = "chk_scifi"
        Me.chk_scifi.Size = New System.Drawing.Size(64, 19)
        Me.chk_scifi.TabIndex = 57
        Me.chk_scifi.Text = "SCI-FI"
        Me.chk_scifi.UseVisualStyleBackColor = False
        '
        'chk_animacao
        '
        Me.chk_animacao.AutoSize = True
        Me.chk_animacao.BackColor = System.Drawing.Color.Maroon
        Me.chk_animacao.Font = New System.Drawing.Font("Monotype Corsiva", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_animacao.ForeColor = System.Drawing.Color.White
        Me.chk_animacao.Location = New System.Drawing.Point(232, 558)
        Me.chk_animacao.Name = "chk_animacao"
        Me.chk_animacao.Size = New System.Drawing.Size(93, 19)
        Me.chk_animacao.TabIndex = 56
        Me.chk_animacao.Text = "ANIMAÇÃO"
        Me.chk_animacao.UseVisualStyleBackColor = False
        '
        'chk_doc
        '
        Me.chk_doc.AutoSize = True
        Me.chk_doc.BackColor = System.Drawing.Color.Maroon
        Me.chk_doc.Font = New System.Drawing.Font("Monotype Corsiva", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_doc.ForeColor = System.Drawing.Color.White
        Me.chk_doc.Location = New System.Drawing.Point(99, 557)
        Me.chk_doc.Name = "chk_doc"
        Me.chk_doc.Size = New System.Drawing.Size(127, 19)
        Me.chk_doc.TabIndex = 55
        Me.chk_doc.Text = "DOCUMENTÁRIO"
        Me.chk_doc.UseVisualStyleBackColor = False
        '
        'chk_aventura
        '
        Me.chk_aventura.AutoSize = True
        Me.chk_aventura.BackColor = System.Drawing.Color.Maroon
        Me.chk_aventura.Font = New System.Drawing.Font("Monotype Corsiva", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_aventura.ForeColor = System.Drawing.Color.White
        Me.chk_aventura.Location = New System.Drawing.Point(341, 530)
        Me.chk_aventura.Name = "chk_aventura"
        Me.chk_aventura.Size = New System.Drawing.Size(95, 19)
        Me.chk_aventura.TabIndex = 54
        Me.chk_aventura.Text = "AVENTURA"
        Me.chk_aventura.UseVisualStyleBackColor = False
        '
        'chk_comedia
        '
        Me.chk_comedia.AutoSize = True
        Me.chk_comedia.BackColor = System.Drawing.Color.Maroon
        Me.chk_comedia.Font = New System.Drawing.Font("Monotype Corsiva", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_comedia.ForeColor = System.Drawing.Color.White
        Me.chk_comedia.Location = New System.Drawing.Point(232, 531)
        Me.chk_comedia.Name = "chk_comedia"
        Me.chk_comedia.Size = New System.Drawing.Size(85, 19)
        Me.chk_comedia.TabIndex = 53
        Me.chk_comedia.Text = "COMÉDIA"
        Me.chk_comedia.UseVisualStyleBackColor = False
        '
        'chk_drama
        '
        Me.chk_drama.AutoSize = True
        Me.chk_drama.BackColor = System.Drawing.Color.Maroon
        Me.chk_drama.Font = New System.Drawing.Font("Monotype Corsiva", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_drama.ForeColor = System.Drawing.Color.White
        Me.chk_drama.Location = New System.Drawing.Point(99, 529)
        Me.chk_drama.Name = "chk_drama"
        Me.chk_drama.Size = New System.Drawing.Size(73, 19)
        Me.chk_drama.TabIndex = 52
        Me.chk_drama.Text = "DRAMA"
        Me.chk_drama.UseVisualStyleBackColor = False
        '
        'chk_suspense
        '
        Me.chk_suspense.AutoSize = True
        Me.chk_suspense.BackColor = System.Drawing.Color.Maroon
        Me.chk_suspense.Font = New System.Drawing.Font("Monotype Corsiva", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_suspense.ForeColor = System.Drawing.Color.White
        Me.chk_suspense.Location = New System.Drawing.Point(341, 505)
        Me.chk_suspense.Name = "chk_suspense"
        Me.chk_suspense.Size = New System.Drawing.Size(90, 19)
        Me.chk_suspense.TabIndex = 51
        Me.chk_suspense.Text = "SUSPENSE"
        Me.chk_suspense.UseVisualStyleBackColor = False
        '
        'chk_terror
        '
        Me.chk_terror.AutoSize = True
        Me.chk_terror.BackColor = System.Drawing.Color.Maroon
        Me.chk_terror.Font = New System.Drawing.Font("Monotype Corsiva", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_terror.ForeColor = System.Drawing.Color.White
        Me.chk_terror.Location = New System.Drawing.Point(232, 505)
        Me.chk_terror.Name = "chk_terror"
        Me.chk_terror.Size = New System.Drawing.Size(76, 19)
        Me.chk_terror.TabIndex = 50
        Me.chk_terror.Text = "TERROR"
        Me.chk_terror.UseVisualStyleBackColor = False
        '
        'chk_acao
        '
        Me.chk_acao.AutoSize = True
        Me.chk_acao.BackColor = System.Drawing.Color.Maroon
        Me.chk_acao.Font = New System.Drawing.Font("Monotype Corsiva", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_acao.ForeColor = System.Drawing.Color.White
        Me.chk_acao.Location = New System.Drawing.Point(99, 499)
        Me.chk_acao.Name = "chk_acao"
        Me.chk_acao.Size = New System.Drawing.Size(60, 19)
        Me.chk_acao.TabIndex = 49
        Me.chk_acao.Text = "AÇÃO"
        Me.chk_acao.UseVisualStyleBackColor = False
        '
        'btn_home
        '
        Me.btn_home.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_home.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_home.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_home.Image = CType(resources.GetObject("btn_home.Image"), System.Drawing.Image)
        Me.btn_home.Location = New System.Drawing.Point(28, 465)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(48, 50)
        Me.btn_home.TabIndex = 19
        Me.btn_home.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Maroon
        Me.Label7.Font = New System.Drawing.Font("Monotype Corsiva", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(23, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(192, 27)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "SUAS ANÁLISES:"
        '
        'lb_user
        '
        Me.lb_user.AutoSize = True
        Me.lb_user.BackColor = System.Drawing.Color.Transparent
        Me.lb_user.Font = New System.Drawing.Font("Monotype Corsiva", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_user.ForeColor = System.Drawing.Color.White
        Me.lb_user.Location = New System.Drawing.Point(147, 55)
        Me.lb_user.Name = "lb_user"
        Me.lb_user.Size = New System.Drawing.Size(79, 27)
        Me.lb_user.TabIndex = 11
        Me.lb_user.Text = "NOME"
        '
        'lb_email
        '
        Me.lb_email.AutoSize = True
        Me.lb_email.BackColor = System.Drawing.Color.Transparent
        Me.lb_email.Font = New System.Drawing.Font("Monotype Corsiva", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_email.ForeColor = System.Drawing.Color.White
        Me.lb_email.Location = New System.Drawing.Point(147, 117)
        Me.lb_email.Name = "lb_email"
        Me.lb_email.Size = New System.Drawing.Size(79, 27)
        Me.lb_email.TabIndex = 10
        Me.lb_email.Text = "NOME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Maroon
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(147, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 27)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "E-MAIL:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Maroon
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(147, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(233, 27)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "NOME DE USUÁRIO:"
        '
        'dgv_dados
        '
        Me.dgv_dados.AllowUserToAddRows = False
        Me.dgv_dados.AllowUserToDeleteRows = False
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column4, Me.Column5, Me.Column2, Me.Column1, Me.Column7})
        Me.dgv_dados.Location = New System.Drawing.Point(28, 189)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.ReadOnly = True
        Me.dgv_dados.RowHeadersWidth = 51
        Me.dgv_dados.RowTemplate.Height = 24
        Me.dgv_dados.Size = New System.Drawing.Size(813, 270)
        Me.dgv_dados.TabIndex = 7
        '
        'btn_gravar_senha
        '
        Me.btn_gravar_senha.BackColor = System.Drawing.Color.Maroon
        Me.btn_gravar_senha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_gravar_senha.Font = New System.Drawing.Font("Monotype Corsiva", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gravar_senha.ForeColor = System.Drawing.Color.White
        Me.btn_gravar_senha.Location = New System.Drawing.Point(855, 211)
        Me.btn_gravar_senha.Name = "btn_gravar_senha"
        Me.btn_gravar_senha.Size = New System.Drawing.Size(242, 41)
        Me.btn_gravar_senha.TabIndex = 5
        Me.btn_gravar_senha.Text = "GRAVAR NOVA SENHA"
        Me.btn_gravar_senha.UseVisualStyleBackColor = False
        '
        'txt_senha
        '
        Me.txt_senha.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_senha.ForeColor = System.Drawing.Color.White
        Me.txt_senha.Location = New System.Drawing.Point(855, 85)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(213, 22)
        Me.txt_senha.TabIndex = 4
        '
        'txt_nova_senha
        '
        Me.txt_nova_senha.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_nova_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nova_senha.ForeColor = System.Drawing.Color.White
        Me.txt_nova_senha.Location = New System.Drawing.Point(855, 164)
        Me.txt_nova_senha.Name = "txt_nova_senha"
        Me.txt_nova_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_nova_senha.Size = New System.Drawing.Size(213, 22)
        Me.txt_nova_senha.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Maroon
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(850, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "SENHA ATUAL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(850, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NOVA SENHA"
        '
        'Column3
        '
        Me.Column3.HeaderText = "NOME"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "NOTA"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "COMENTÁRIO"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "EDITAR"
        Me.Column2.Image = CType(resources.GetObject("Column2.Image"), System.Drawing.Image)
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 125
        '
        'Column1
        '
        Me.Column1.HeaderText = "EXCLUIR"
        Me.Column1.Image = CType(resources.GetObject("Column1.Image"), System.Drawing.Image)
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 125
        '
        'Column7
        '
        Me.Column7.HeaderText = "cod"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 125
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1848, 800)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form6"
        Me.Text = "PERFIL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.user_photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents user_photo As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents btn_gravar_senha As Button
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents txt_nova_senha As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lb_user As Label
    Friend WithEvents lb_email As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_home As Button
    Friend WithEvents chk_musical As CheckBox
    Friend WithEvents chk_romance As CheckBox
    Friend WithEvents chk_fan As CheckBox
    Friend WithEvents chk_scifi As CheckBox
    Friend WithEvents chk_animacao As CheckBox
    Friend WithEvents chk_doc As CheckBox
    Friend WithEvents chk_aventura As CheckBox
    Friend WithEvents chk_comedia As CheckBox
    Friend WithEvents chk_drama As CheckBox
    Friend WithEvents chk_suspense As CheckBox
    Friend WithEvents chk_terror As CheckBox
    Friend WithEvents chk_acao As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents bnt_fav_gen As Button
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewImageColumn
    Friend WithEvents Column1 As DataGridViewImageColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
