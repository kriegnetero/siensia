<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_enviar_review = New System.Windows.Forms.Button()
        Me.ln_nota = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nome_filme = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.img_cartaz = New System.Windows.Forms.PictureBox()
        Me.txt_comentario = New System.Windows.Forms.RichTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ln_nota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_cartaz, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.chk_musical)
        Me.GroupBox1.Controls.Add(Me.chk_romance)
        Me.GroupBox1.Controls.Add(Me.chk_fan)
        Me.GroupBox1.Controls.Add(Me.chk_scifi)
        Me.GroupBox1.Controls.Add(Me.chk_animacao)
        Me.GroupBox1.Controls.Add(Me.chk_doc)
        Me.GroupBox1.Controls.Add(Me.chk_aventura)
        Me.GroupBox1.Controls.Add(Me.chk_comedia)
        Me.GroupBox1.Controls.Add(Me.chk_drama)
        Me.GroupBox1.Controls.Add(Me.chk_suspense)
        Me.GroupBox1.Controls.Add(Me.chk_terror)
        Me.GroupBox1.Controls.Add(Me.chk_acao)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btn_enviar_review)
        Me.GroupBox1.Controls.Add(Me.ln_nota)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_nome_filme)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.img_cartaz)
        Me.GroupBox1.Controls.Add(Me.txt_comentario)
        Me.GroupBox1.Font = New System.Drawing.Font("Monotype Corsiva", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(422, 264)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(859, 448)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "NOVA AVALIAÇÃO"
        '
        'chk_musical
        '
        Me.chk_musical.AutoSize = True
        Me.chk_musical.BackColor = System.Drawing.Color.Maroon
        Me.chk_musical.Font = New System.Drawing.Font("Monotype Corsiva", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_musical.ForeColor = System.Drawing.Color.White
        Me.chk_musical.Location = New System.Drawing.Point(484, 151)
        Me.chk_musical.Name = "chk_musical"
        Me.chk_musical.Size = New System.Drawing.Size(84, 19)
        Me.chk_musical.TabIndex = 48
        Me.chk_musical.Text = "MUSICAL"
        Me.chk_musical.UseVisualStyleBackColor = False
        '
        'chk_romance
        '
        Me.chk_romance.AutoSize = True
        Me.chk_romance.BackColor = System.Drawing.Color.Maroon
        Me.chk_romance.Font = New System.Drawing.Font("Monotype Corsiva", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_romance.ForeColor = System.Drawing.Color.White
        Me.chk_romance.Location = New System.Drawing.Point(375, 151)
        Me.chk_romance.Name = "chk_romance"
        Me.chk_romance.Size = New System.Drawing.Size(88, 19)
        Me.chk_romance.TabIndex = 47
        Me.chk_romance.Text = "ROMANCE"
        Me.chk_romance.UseVisualStyleBackColor = False
        '
        'chk_fan
        '
        Me.chk_fan.AutoSize = True
        Me.chk_fan.BackColor = System.Drawing.Color.Maroon
        Me.chk_fan.Font = New System.Drawing.Font("Monotype Corsiva", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_fan.ForeColor = System.Drawing.Color.White
        Me.chk_fan.Location = New System.Drawing.Point(242, 150)
        Me.chk_fan.Name = "chk_fan"
        Me.chk_fan.Size = New System.Drawing.Size(88, 19)
        Me.chk_fan.TabIndex = 46
        Me.chk_fan.Text = "FANTASIA"
        Me.chk_fan.UseVisualStyleBackColor = False
        '
        'chk_scifi
        '
        Me.chk_scifi.AutoSize = True
        Me.chk_scifi.BackColor = System.Drawing.Color.Maroon
        Me.chk_scifi.Font = New System.Drawing.Font("Monotype Corsiva", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_scifi.ForeColor = System.Drawing.Color.White
        Me.chk_scifi.Location = New System.Drawing.Point(484, 126)
        Me.chk_scifi.Name = "chk_scifi"
        Me.chk_scifi.Size = New System.Drawing.Size(64, 19)
        Me.chk_scifi.TabIndex = 45
        Me.chk_scifi.Text = "SCI-FI"
        Me.chk_scifi.UseVisualStyleBackColor = False
        '
        'chk_animacao
        '
        Me.chk_animacao.AutoSize = True
        Me.chk_animacao.BackColor = System.Drawing.Color.Maroon
        Me.chk_animacao.Font = New System.Drawing.Font("Monotype Corsiva", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_animacao.ForeColor = System.Drawing.Color.White
        Me.chk_animacao.Location = New System.Drawing.Point(375, 126)
        Me.chk_animacao.Name = "chk_animacao"
        Me.chk_animacao.Size = New System.Drawing.Size(93, 19)
        Me.chk_animacao.TabIndex = 44
        Me.chk_animacao.Text = "ANIMAÇÃO"
        Me.chk_animacao.UseVisualStyleBackColor = False
        '
        'chk_doc
        '
        Me.chk_doc.AutoSize = True
        Me.chk_doc.BackColor = System.Drawing.Color.Maroon
        Me.chk_doc.Font = New System.Drawing.Font("Monotype Corsiva", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_doc.ForeColor = System.Drawing.Color.White
        Me.chk_doc.Location = New System.Drawing.Point(242, 125)
        Me.chk_doc.Name = "chk_doc"
        Me.chk_doc.Size = New System.Drawing.Size(127, 19)
        Me.chk_doc.TabIndex = 43
        Me.chk_doc.Text = "DOCUMENTÁRIO"
        Me.chk_doc.UseVisualStyleBackColor = False
        '
        'chk_aventura
        '
        Me.chk_aventura.AutoSize = True
        Me.chk_aventura.BackColor = System.Drawing.Color.Maroon
        Me.chk_aventura.Font = New System.Drawing.Font("Monotype Corsiva", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_aventura.ForeColor = System.Drawing.Color.White
        Me.chk_aventura.Location = New System.Drawing.Point(484, 98)
        Me.chk_aventura.Name = "chk_aventura"
        Me.chk_aventura.Size = New System.Drawing.Size(95, 19)
        Me.chk_aventura.TabIndex = 42
        Me.chk_aventura.Text = "AVENTURA"
        Me.chk_aventura.UseVisualStyleBackColor = False
        '
        'chk_comedia
        '
        Me.chk_comedia.AutoSize = True
        Me.chk_comedia.BackColor = System.Drawing.Color.Maroon
        Me.chk_comedia.Font = New System.Drawing.Font("Monotype Corsiva", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_comedia.ForeColor = System.Drawing.Color.White
        Me.chk_comedia.Location = New System.Drawing.Point(375, 99)
        Me.chk_comedia.Name = "chk_comedia"
        Me.chk_comedia.Size = New System.Drawing.Size(85, 19)
        Me.chk_comedia.TabIndex = 41
        Me.chk_comedia.Text = "COMÉDIA"
        Me.chk_comedia.UseVisualStyleBackColor = False
        '
        'chk_drama
        '
        Me.chk_drama.AutoSize = True
        Me.chk_drama.BackColor = System.Drawing.Color.Maroon
        Me.chk_drama.Font = New System.Drawing.Font("Monotype Corsiva", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_drama.ForeColor = System.Drawing.Color.White
        Me.chk_drama.Location = New System.Drawing.Point(242, 97)
        Me.chk_drama.Name = "chk_drama"
        Me.chk_drama.Size = New System.Drawing.Size(73, 19)
        Me.chk_drama.TabIndex = 40
        Me.chk_drama.Text = "DRAMA"
        Me.chk_drama.UseVisualStyleBackColor = False
        '
        'chk_suspense
        '
        Me.chk_suspense.AutoSize = True
        Me.chk_suspense.BackColor = System.Drawing.Color.Maroon
        Me.chk_suspense.Font = New System.Drawing.Font("Monotype Corsiva", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_suspense.ForeColor = System.Drawing.Color.White
        Me.chk_suspense.Location = New System.Drawing.Point(484, 73)
        Me.chk_suspense.Name = "chk_suspense"
        Me.chk_suspense.Size = New System.Drawing.Size(90, 19)
        Me.chk_suspense.TabIndex = 39
        Me.chk_suspense.Text = "SUSPENSE"
        Me.chk_suspense.UseVisualStyleBackColor = False
        '
        'chk_terror
        '
        Me.chk_terror.AutoSize = True
        Me.chk_terror.BackColor = System.Drawing.Color.Maroon
        Me.chk_terror.Font = New System.Drawing.Font("Monotype Corsiva", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_terror.ForeColor = System.Drawing.Color.White
        Me.chk_terror.Location = New System.Drawing.Point(375, 73)
        Me.chk_terror.Name = "chk_terror"
        Me.chk_terror.Size = New System.Drawing.Size(76, 19)
        Me.chk_terror.TabIndex = 38
        Me.chk_terror.Text = "TERROR"
        Me.chk_terror.UseVisualStyleBackColor = False
        '
        'chk_acao
        '
        Me.chk_acao.AutoSize = True
        Me.chk_acao.BackColor = System.Drawing.Color.Maroon
        Me.chk_acao.Font = New System.Drawing.Font("Monotype Corsiva", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_acao.ForeColor = System.Drawing.Color.White
        Me.chk_acao.Location = New System.Drawing.Point(242, 67)
        Me.chk_acao.Name = "chk_acao"
        Me.chk_acao.Size = New System.Drawing.Size(60, 19)
        Me.chk_acao.TabIndex = 37
        Me.chk_acao.Text = "AÇÃO"
        Me.chk_acao.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Maroon
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(24, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 27)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "COMENTÁRIO:"
        '
        'btn_enviar_review
        '
        Me.btn_enviar_review.BackColor = System.Drawing.Color.Maroon
        Me.btn_enviar_review.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_enviar_review.Font = New System.Drawing.Font("Monotype Corsiva", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enviar_review.ForeColor = System.Drawing.Color.White
        Me.btn_enviar_review.Location = New System.Drawing.Point(603, 318)
        Me.btn_enviar_review.Name = "btn_enviar_review"
        Me.btn_enviar_review.Size = New System.Drawing.Size(187, 48)
        Me.btn_enviar_review.TabIndex = 16
        Me.btn_enviar_review.Text = "ENVIAR ANÁLISE"
        Me.btn_enviar_review.UseVisualStyleBackColor = False
        '
        'ln_nota
        '
        Me.ln_nota.Location = New System.Drawing.Point(116, 122)
        Me.ln_nota.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.ln_nota.Name = "ln_nota"
        Me.ln_nota.Size = New System.Drawing.Size(45, 27)
        Me.ln_nota.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Maroon
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(38, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 27)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "NOTA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Maroon
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(583, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(255, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ADIONE O CARTAZ DO FILME"
        '
        'txt_nome_filme
        '
        Me.txt_nome_filme.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_nome_filme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nome_filme.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_filme.ForeColor = System.Drawing.Color.White
        Me.txt_nome_filme.Location = New System.Drawing.Point(29, 79)
        Me.txt_nome_filme.Name = "txt_nome_filme"
        Me.txt_nome_filme.Size = New System.Drawing.Size(198, 27)
        Me.txt_nome_filme.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Maroon
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(24, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 27)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "NOME DO FILME:"
        '
        'img_cartaz
        '
        Me.img_cartaz.BackColor = System.Drawing.Color.DarkGray
        Me.img_cartaz.Image = CType(resources.GetObject("img_cartaz.Image"), System.Drawing.Image)
        Me.img_cartaz.Location = New System.Drawing.Point(636, 79)
        Me.img_cartaz.Name = "img_cartaz"
        Me.img_cartaz.Size = New System.Drawing.Size(187, 191)
        Me.img_cartaz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_cartaz.TabIndex = 3
        Me.img_cartaz.TabStop = False
        '
        'txt_comentario
        '
        Me.txt_comentario.BackColor = System.Drawing.Color.DarkGray
        Me.txt_comentario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_comentario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_comentario.ForeColor = System.Drawing.Color.White
        Me.txt_comentario.Location = New System.Drawing.Point(29, 210)
        Me.txt_comentario.Name = "txt_comentario"
        Me.txt_comentario.Size = New System.Drawing.Size(536, 220)
        Me.txt_comentario.TabIndex = 2
        Me.txt_comentario.Text = ""
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btn_home)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(422, 156)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(859, 85)
        Me.Panel2.TabIndex = 3
        '
        'btn_home
        '
        Me.btn_home.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_home.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_home.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_home.Image = CType(resources.GetObject("btn_home.Image"), System.Drawing.Image)
        Me.btn_home.Location = New System.Drawing.Point(29, 18)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(48, 50)
        Me.btn_home.TabIndex = 18
        Me.btn_home.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(296, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CINE VIEW "
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1848, 800)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form5"
        Me.Text = "CADASTRO DE REVIEW"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ln_nota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_cartaz, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_comentario As RichTextBox
    Friend WithEvents img_cartaz As PictureBox
    Friend WithEvents txt_nome_filme As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ln_nota As NumericUpDown
    Friend WithEvents btn_enviar_review As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_home As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
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
End Class
