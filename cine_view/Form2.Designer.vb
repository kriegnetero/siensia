<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.btn_cadastro = New System.Windows.Forms.Button()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.txt_confirmar_senha = New System.Windows.Forms.TextBox()
        Me.btn_voltar_f1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chk_acao = New System.Windows.Forms.CheckBox()
        Me.chk_terror = New System.Windows.Forms.CheckBox()
        Me.chk_suspense = New System.Windows.Forms.CheckBox()
        Me.chk_drama = New System.Windows.Forms.CheckBox()
        Me.chk_comedia = New System.Windows.Forms.CheckBox()
        Me.chk_aventura = New System.Windows.Forms.CheckBox()
        Me.chk_doc = New System.Windows.Forms.CheckBox()
        Me.chk_animacao = New System.Windows.Forms.CheckBox()
        Me.chk_scifi = New System.Windows.Forms.CheckBox()
        Me.chk_fan = New System.Windows.Forms.CheckBox()
        Me.chk_romance = New System.Windows.Forms.CheckBox()
        Me.chk_musical = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.img_photo = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.img_photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_cadastro
        '
        Me.btn_cadastro.BackColor = System.Drawing.Color.Maroon
        Me.btn_cadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cadastro.Font = New System.Drawing.Font("Monotype Corsiva", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastro.ForeColor = System.Drawing.Color.White
        Me.btn_cadastro.Location = New System.Drawing.Point(596, 549)
        Me.btn_cadastro.Name = "btn_cadastro"
        Me.btn_cadastro.Size = New System.Drawing.Size(178, 60)
        Me.btn_cadastro.TabIndex = 11
        Me.btn_cadastro.Text = "CADASTRAR-SE"
        Me.btn_cadastro.UseVisualStyleBackColor = False
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_email.ForeColor = System.Drawing.Color.White
        Me.txt_email.Location = New System.Drawing.Point(837, 341)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(330, 22)
        Me.txt_email.TabIndex = 9
        '
        'txt_nome
        '
        Me.txt_nome.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nome.ForeColor = System.Drawing.Color.White
        Me.txt_nome.Location = New System.Drawing.Point(837, 283)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(330, 22)
        Me.txt_nome.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(704, 277)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 27)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "NOME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(704, 336)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 27)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "E-MAIL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(582, 434)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(228, 27)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "CONFIRMAR SENHA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(709, 380)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 27)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "SENHA"
        '
        'txt_senha
        '
        Me.txt_senha.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_senha.ForeColor = System.Drawing.Color.White
        Me.txt_senha.Location = New System.Drawing.Point(837, 380)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(330, 22)
        Me.txt_senha.TabIndex = 15
        '
        'txt_confirmar_senha
        '
        Me.txt_confirmar_senha.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_confirmar_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_confirmar_senha.ForeColor = System.Drawing.Color.White
        Me.txt_confirmar_senha.Location = New System.Drawing.Point(837, 434)
        Me.txt_confirmar_senha.Name = "txt_confirmar_senha"
        Me.txt_confirmar_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_confirmar_senha.Size = New System.Drawing.Size(330, 22)
        Me.txt_confirmar_senha.TabIndex = 16
        '
        'btn_voltar_f1
        '
        Me.btn_voltar_f1.BackColor = System.Drawing.Color.Maroon
        Me.btn_voltar_f1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar_f1.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar_f1.ForeColor = System.Drawing.Color.Maroon
        Me.btn_voltar_f1.Image = CType(resources.GetObject("btn_voltar_f1.Image"), System.Drawing.Image)
        Me.btn_voltar_f1.Location = New System.Drawing.Point(462, 187)
        Me.btn_voltar_f1.Name = "btn_voltar_f1"
        Me.btn_voltar_f1.Size = New System.Drawing.Size(48, 50)
        Me.btn_voltar_f1.TabIndex = 20
        Me.btn_voltar_f1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(582, 490)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(247, 27)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "GÊNEROS FAVORITOS"
        '
        'chk_acao
        '
        Me.chk_acao.AutoSize = True
        Me.chk_acao.BackColor = System.Drawing.Color.Maroon
        Me.chk_acao.Font = New System.Drawing.Font("Monotype Corsiva", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_acao.ForeColor = System.Drawing.Color.White
        Me.chk_acao.Location = New System.Drawing.Point(846, 490)
        Me.chk_acao.Name = "chk_acao"
        Me.chk_acao.Size = New System.Drawing.Size(72, 24)
        Me.chk_acao.TabIndex = 25
        Me.chk_acao.Text = "AÇÃO"
        Me.chk_acao.UseVisualStyleBackColor = False
        '
        'chk_terror
        '
        Me.chk_terror.AutoSize = True
        Me.chk_terror.BackColor = System.Drawing.Color.Maroon
        Me.chk_terror.Font = New System.Drawing.Font("Monotype Corsiva", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_terror.ForeColor = System.Drawing.Color.White
        Me.chk_terror.Location = New System.Drawing.Point(1024, 490)
        Me.chk_terror.Name = "chk_terror"
        Me.chk_terror.Size = New System.Drawing.Size(91, 24)
        Me.chk_terror.TabIndex = 26
        Me.chk_terror.Text = "TERROR"
        Me.chk_terror.UseVisualStyleBackColor = False
        '
        'chk_suspense
        '
        Me.chk_suspense.AutoSize = True
        Me.chk_suspense.BackColor = System.Drawing.Color.Maroon
        Me.chk_suspense.Font = New System.Drawing.Font("Monotype Corsiva", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_suspense.ForeColor = System.Drawing.Color.White
        Me.chk_suspense.Location = New System.Drawing.Point(1149, 490)
        Me.chk_suspense.Name = "chk_suspense"
        Me.chk_suspense.Size = New System.Drawing.Size(111, 24)
        Me.chk_suspense.TabIndex = 27
        Me.chk_suspense.Text = "SUSPENSE"
        Me.chk_suspense.UseVisualStyleBackColor = False
        '
        'chk_drama
        '
        Me.chk_drama.AutoSize = True
        Me.chk_drama.BackColor = System.Drawing.Color.Maroon
        Me.chk_drama.Font = New System.Drawing.Font("Monotype Corsiva", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_drama.ForeColor = System.Drawing.Color.White
        Me.chk_drama.Location = New System.Drawing.Point(846, 515)
        Me.chk_drama.Name = "chk_drama"
        Me.chk_drama.Size = New System.Drawing.Size(89, 24)
        Me.chk_drama.TabIndex = 28
        Me.chk_drama.Text = "DRAMA"
        Me.chk_drama.UseVisualStyleBackColor = False
        '
        'chk_comedia
        '
        Me.chk_comedia.AutoSize = True
        Me.chk_comedia.BackColor = System.Drawing.Color.Maroon
        Me.chk_comedia.Font = New System.Drawing.Font("Monotype Corsiva", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_comedia.ForeColor = System.Drawing.Color.White
        Me.chk_comedia.Location = New System.Drawing.Point(1024, 516)
        Me.chk_comedia.Name = "chk_comedia"
        Me.chk_comedia.Size = New System.Drawing.Size(104, 24)
        Me.chk_comedia.TabIndex = 29
        Me.chk_comedia.Text = "COMÉDIA"
        Me.chk_comedia.UseVisualStyleBackColor = False
        '
        'chk_aventura
        '
        Me.chk_aventura.AutoSize = True
        Me.chk_aventura.BackColor = System.Drawing.Color.Maroon
        Me.chk_aventura.Font = New System.Drawing.Font("Monotype Corsiva", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_aventura.ForeColor = System.Drawing.Color.White
        Me.chk_aventura.Location = New System.Drawing.Point(1149, 515)
        Me.chk_aventura.Name = "chk_aventura"
        Me.chk_aventura.Size = New System.Drawing.Size(119, 24)
        Me.chk_aventura.TabIndex = 30
        Me.chk_aventura.Text = "AVENTURA"
        Me.chk_aventura.UseVisualStyleBackColor = False
        '
        'chk_doc
        '
        Me.chk_doc.AutoSize = True
        Me.chk_doc.BackColor = System.Drawing.Color.Maroon
        Me.chk_doc.Font = New System.Drawing.Font("Monotype Corsiva", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_doc.ForeColor = System.Drawing.Color.White
        Me.chk_doc.Location = New System.Drawing.Point(846, 543)
        Me.chk_doc.Name = "chk_doc"
        Me.chk_doc.Size = New System.Drawing.Size(158, 24)
        Me.chk_doc.TabIndex = 31
        Me.chk_doc.Text = "DOCUMENTÁRIO"
        Me.chk_doc.UseVisualStyleBackColor = False
        '
        'chk_animacao
        '
        Me.chk_animacao.AutoSize = True
        Me.chk_animacao.BackColor = System.Drawing.Color.Maroon
        Me.chk_animacao.Font = New System.Drawing.Font("Monotype Corsiva", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_animacao.ForeColor = System.Drawing.Color.White
        Me.chk_animacao.Location = New System.Drawing.Point(1024, 543)
        Me.chk_animacao.Name = "chk_animacao"
        Me.chk_animacao.Size = New System.Drawing.Size(115, 24)
        Me.chk_animacao.TabIndex = 32
        Me.chk_animacao.Text = "ANIMAÇÃO"
        Me.chk_animacao.UseVisualStyleBackColor = False
        '
        'chk_scifi
        '
        Me.chk_scifi.AutoSize = True
        Me.chk_scifi.BackColor = System.Drawing.Color.Maroon
        Me.chk_scifi.Font = New System.Drawing.Font("Monotype Corsiva", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_scifi.ForeColor = System.Drawing.Color.White
        Me.chk_scifi.Location = New System.Drawing.Point(1149, 543)
        Me.chk_scifi.Name = "chk_scifi"
        Me.chk_scifi.Size = New System.Drawing.Size(75, 24)
        Me.chk_scifi.TabIndex = 33
        Me.chk_scifi.Text = "SCI-FI"
        Me.chk_scifi.UseVisualStyleBackColor = False
        '
        'chk_fan
        '
        Me.chk_fan.AutoSize = True
        Me.chk_fan.BackColor = System.Drawing.Color.Maroon
        Me.chk_fan.Font = New System.Drawing.Font("Monotype Corsiva", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_fan.ForeColor = System.Drawing.Color.White
        Me.chk_fan.Location = New System.Drawing.Point(846, 568)
        Me.chk_fan.Name = "chk_fan"
        Me.chk_fan.Size = New System.Drawing.Size(109, 24)
        Me.chk_fan.TabIndex = 34
        Me.chk_fan.Text = "FANTASIA"
        Me.chk_fan.UseVisualStyleBackColor = False
        '
        'chk_romance
        '
        Me.chk_romance.AutoSize = True
        Me.chk_romance.BackColor = System.Drawing.Color.Maroon
        Me.chk_romance.Font = New System.Drawing.Font("Monotype Corsiva", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_romance.ForeColor = System.Drawing.Color.White
        Me.chk_romance.Location = New System.Drawing.Point(1024, 568)
        Me.chk_romance.Name = "chk_romance"
        Me.chk_romance.Size = New System.Drawing.Size(108, 24)
        Me.chk_romance.TabIndex = 35
        Me.chk_romance.Text = "ROMANCE"
        Me.chk_romance.UseVisualStyleBackColor = False
        '
        'chk_musical
        '
        Me.chk_musical.AutoSize = True
        Me.chk_musical.BackColor = System.Drawing.Color.Maroon
        Me.chk_musical.Font = New System.Drawing.Font("Monotype Corsiva", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_musical.ForeColor = System.Drawing.Color.White
        Me.chk_musical.Location = New System.Drawing.Point(1149, 568)
        Me.chk_musical.Name = "chk_musical"
        Me.chk_musical.Size = New System.Drawing.Size(102, 24)
        Me.chk_musical.TabIndex = 36
        Me.chk_musical.Text = "MUSICAL"
        Me.chk_musical.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Monotype Corsiva", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(560, 277)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 15)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "ADICIONAR FOTO"
        '
        'img_photo
        '
        Me.img_photo.Image = CType(resources.GetObject("img_photo.Image"), System.Drawing.Image)
        Me.img_photo.Location = New System.Drawing.Point(573, 297)
        Me.img_photo.Name = "img_photo"
        Me.img_photo.Size = New System.Drawing.Size(108, 120)
        Me.img_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_photo.TabIndex = 38
        Me.img_photo.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1848, 800)
        Me.Controls.Add(Me.img_photo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.chk_musical)
        Me.Controls.Add(Me.chk_romance)
        Me.Controls.Add(Me.chk_fan)
        Me.Controls.Add(Me.chk_scifi)
        Me.Controls.Add(Me.chk_animacao)
        Me.Controls.Add(Me.chk_doc)
        Me.Controls.Add(Me.chk_aventura)
        Me.Controls.Add(Me.chk_comedia)
        Me.Controls.Add(Me.chk_drama)
        Me.Controls.Add(Me.chk_suspense)
        Me.Controls.Add(Me.chk_terror)
        Me.Controls.Add(Me.chk_acao)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_voltar_f1)
        Me.Controls.Add(Me.txt_confirmar_senha)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_cadastro)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "CADASTRO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.img_photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cadastro As Button
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents txt_confirmar_senha As TextBox
    Friend WithEvents btn_voltar_f1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents chk_acao As CheckBox
    Friend WithEvents chk_terror As CheckBox
    Friend WithEvents chk_suspense As CheckBox
    Friend WithEvents chk_drama As CheckBox
    Friend WithEvents chk_comedia As CheckBox
    Friend WithEvents chk_aventura As CheckBox
    Friend WithEvents chk_doc As CheckBox
    Friend WithEvents chk_animacao As CheckBox
    Friend WithEvents chk_scifi As CheckBox
    Friend WithEvents chk_fan As CheckBox
    Friend WithEvents chk_romance As CheckBox
    Friend WithEvents chk_musical As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents img_photo As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
