<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.user_photo = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.chk_musical = New System.Windows.Forms.CheckBox()
        Me.chk_romance = New System.Windows.Forms.CheckBox()
        Me.btn_sair = New System.Windows.Forms.Button()
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
        Me.btn_limpar = New System.Windows.Forms.Button()
        Me.txt_busca = New System.Windows.Forms.TextBox()
        Me.btn_mod = New System.Windows.Forms.Button()
        Me.btn_add_review = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btn_aprove = New System.Windows.Forms.Button()
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.user_photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Firebrick
        Me.Panel1.Controls.Add(Me.user_photo)
        Me.Panel1.Location = New System.Drawing.Point(236, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(127, 657)
        Me.Panel1.TabIndex = 1
        '
        'user_photo
        '
        Me.user_photo.BackColor = System.Drawing.Color.Firebrick
        Me.user_photo.Image = CType(resources.GetObject("user_photo.Image"), System.Drawing.Image)
        Me.user_photo.Location = New System.Drawing.Point(17, 12)
        Me.user_photo.Name = "user_photo"
        Me.user_photo.Size = New System.Drawing.Size(105, 113)
        Me.user_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.user_photo.TabIndex = 0
        Me.user_photo.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Controls.Add(Me.btn_buscar)
        Me.Panel2.Controls.Add(Me.chk_musical)
        Me.Panel2.Controls.Add(Me.chk_romance)
        Me.Panel2.Controls.Add(Me.btn_sair)
        Me.Panel2.Controls.Add(Me.chk_fan)
        Me.Panel2.Controls.Add(Me.chk_scifi)
        Me.Panel2.Controls.Add(Me.chk_animacao)
        Me.Panel2.Controls.Add(Me.chk_doc)
        Me.Panel2.Controls.Add(Me.chk_aventura)
        Me.Panel2.Controls.Add(Me.chk_comedia)
        Me.Panel2.Controls.Add(Me.chk_drama)
        Me.Panel2.Controls.Add(Me.chk_suspense)
        Me.Panel2.Controls.Add(Me.chk_terror)
        Me.Panel2.Controls.Add(Me.chk_acao)
        Me.Panel2.Controls.Add(Me.btn_limpar)
        Me.Panel2.Controls.Add(Me.txt_busca)
        Me.Panel2.Location = New System.Drawing.Point(364, 36)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1031, 657)
        Me.Panel2.TabIndex = 2
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.Color.Maroon
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscar.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.ForeColor = System.Drawing.Color.Maroon
        Me.btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), System.Drawing.Image)
        Me.btn_buscar.Location = New System.Drawing.Point(24, 12)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(48, 50)
        Me.btn_buscar.TabIndex = 13
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'chk_musical
        '
        Me.chk_musical.AutoSize = True
        Me.chk_musical.BackColor = System.Drawing.Color.Maroon
        Me.chk_musical.Font = New System.Drawing.Font("Monotype Corsiva", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_musical.ForeColor = System.Drawing.Color.White
        Me.chk_musical.Location = New System.Drawing.Point(842, 82)
        Me.chk_musical.Name = "chk_musical"
        Me.chk_musical.Size = New System.Drawing.Size(102, 24)
        Me.chk_musical.TabIndex = 48
        Me.chk_musical.Text = "MUSICAL"
        Me.chk_musical.UseVisualStyleBackColor = False
        '
        'chk_romance
        '
        Me.chk_romance.AutoSize = True
        Me.chk_romance.BackColor = System.Drawing.Color.Maroon
        Me.chk_romance.Font = New System.Drawing.Font("Monotype Corsiva", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_romance.ForeColor = System.Drawing.Color.White
        Me.chk_romance.Location = New System.Drawing.Point(722, 81)
        Me.chk_romance.Name = "chk_romance"
        Me.chk_romance.Size = New System.Drawing.Size(108, 24)
        Me.chk_romance.TabIndex = 47
        Me.chk_romance.Text = "ROMANCE"
        Me.chk_romance.UseVisualStyleBackColor = False
        '
        'btn_sair
        '
        Me.btn_sair.BackColor = System.Drawing.Color.Maroon
        Me.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sair.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sair.ForeColor = System.Drawing.Color.Maroon
        Me.btn_sair.Image = CType(resources.GetObject("btn_sair.Image"), System.Drawing.Image)
        Me.btn_sair.Location = New System.Drawing.Point(983, 66)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(48, 50)
        Me.btn_sair.TabIndex = 13
        Me.btn_sair.UseVisualStyleBackColor = False
        '
        'chk_fan
        '
        Me.chk_fan.AutoSize = True
        Me.chk_fan.BackColor = System.Drawing.Color.Maroon
        Me.chk_fan.Font = New System.Drawing.Font("Monotype Corsiva", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_fan.ForeColor = System.Drawing.Color.White
        Me.chk_fan.Location = New System.Drawing.Point(922, 253)
        Me.chk_fan.Name = "chk_fan"
        Me.chk_fan.Size = New System.Drawing.Size(109, 24)
        Me.chk_fan.TabIndex = 46
        Me.chk_fan.Text = "FANTASIA"
        Me.chk_fan.UseVisualStyleBackColor = False
        '
        'chk_scifi
        '
        Me.chk_scifi.AutoSize = True
        Me.chk_scifi.BackColor = System.Drawing.Color.Maroon
        Me.chk_scifi.Font = New System.Drawing.Font("Monotype Corsiva", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_scifi.ForeColor = System.Drawing.Color.White
        Me.chk_scifi.Location = New System.Drawing.Point(842, 57)
        Me.chk_scifi.Name = "chk_scifi"
        Me.chk_scifi.Size = New System.Drawing.Size(75, 24)
        Me.chk_scifi.TabIndex = 45
        Me.chk_scifi.Text = "SCI-FI"
        Me.chk_scifi.UseVisualStyleBackColor = False
        '
        'chk_animacao
        '
        Me.chk_animacao.AutoSize = True
        Me.chk_animacao.BackColor = System.Drawing.Color.Maroon
        Me.chk_animacao.Font = New System.Drawing.Font("Monotype Corsiva", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_animacao.ForeColor = System.Drawing.Color.White
        Me.chk_animacao.Location = New System.Drawing.Point(722, 56)
        Me.chk_animacao.Name = "chk_animacao"
        Me.chk_animacao.Size = New System.Drawing.Size(115, 24)
        Me.chk_animacao.TabIndex = 44
        Me.chk_animacao.Text = "ANIMAÇÃO"
        Me.chk_animacao.UseVisualStyleBackColor = False
        '
        'chk_doc
        '
        Me.chk_doc.AutoSize = True
        Me.chk_doc.BackColor = System.Drawing.Color.Maroon
        Me.chk_doc.Font = New System.Drawing.Font("Monotype Corsiva", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_doc.ForeColor = System.Drawing.Color.White
        Me.chk_doc.Location = New System.Drawing.Point(566, 56)
        Me.chk_doc.Name = "chk_doc"
        Me.chk_doc.Size = New System.Drawing.Size(158, 24)
        Me.chk_doc.TabIndex = 43
        Me.chk_doc.Text = "DOCUMENTÁRIO"
        Me.chk_doc.UseVisualStyleBackColor = False
        '
        'chk_aventura
        '
        Me.chk_aventura.AutoSize = True
        Me.chk_aventura.BackColor = System.Drawing.Color.Maroon
        Me.chk_aventura.Font = New System.Drawing.Font("Monotype Corsiva", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_aventura.ForeColor = System.Drawing.Color.White
        Me.chk_aventura.Location = New System.Drawing.Point(842, 29)
        Me.chk_aventura.Name = "chk_aventura"
        Me.chk_aventura.Size = New System.Drawing.Size(119, 24)
        Me.chk_aventura.TabIndex = 42
        Me.chk_aventura.Text = "AVENTURA"
        Me.chk_aventura.UseVisualStyleBackColor = False
        '
        'chk_comedia
        '
        Me.chk_comedia.AutoSize = True
        Me.chk_comedia.BackColor = System.Drawing.Color.Maroon
        Me.chk_comedia.Font = New System.Drawing.Font("Monotype Corsiva", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_comedia.ForeColor = System.Drawing.Color.White
        Me.chk_comedia.Location = New System.Drawing.Point(722, 29)
        Me.chk_comedia.Name = "chk_comedia"
        Me.chk_comedia.Size = New System.Drawing.Size(104, 24)
        Me.chk_comedia.TabIndex = 41
        Me.chk_comedia.Text = "COMÉDIA"
        Me.chk_comedia.UseVisualStyleBackColor = False
        '
        'chk_drama
        '
        Me.chk_drama.AutoSize = True
        Me.chk_drama.BackColor = System.Drawing.Color.Maroon
        Me.chk_drama.Font = New System.Drawing.Font("Monotype Corsiva", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_drama.ForeColor = System.Drawing.Color.White
        Me.chk_drama.Location = New System.Drawing.Point(566, 28)
        Me.chk_drama.Name = "chk_drama"
        Me.chk_drama.Size = New System.Drawing.Size(89, 24)
        Me.chk_drama.TabIndex = 40
        Me.chk_drama.Text = "DRAMA"
        Me.chk_drama.UseVisualStyleBackColor = False
        '
        'chk_suspense
        '
        Me.chk_suspense.AutoSize = True
        Me.chk_suspense.BackColor = System.Drawing.Color.Maroon
        Me.chk_suspense.Font = New System.Drawing.Font("Monotype Corsiva", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_suspense.ForeColor = System.Drawing.Color.White
        Me.chk_suspense.Location = New System.Drawing.Point(842, 4)
        Me.chk_suspense.Name = "chk_suspense"
        Me.chk_suspense.Size = New System.Drawing.Size(111, 24)
        Me.chk_suspense.TabIndex = 39
        Me.chk_suspense.Text = "SUSPENSE"
        Me.chk_suspense.UseVisualStyleBackColor = False
        '
        'chk_terror
        '
        Me.chk_terror.AutoSize = True
        Me.chk_terror.BackColor = System.Drawing.Color.Maroon
        Me.chk_terror.Font = New System.Drawing.Font("Monotype Corsiva", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_terror.ForeColor = System.Drawing.Color.White
        Me.chk_terror.Location = New System.Drawing.Point(722, 3)
        Me.chk_terror.Name = "chk_terror"
        Me.chk_terror.Size = New System.Drawing.Size(91, 24)
        Me.chk_terror.TabIndex = 38
        Me.chk_terror.Text = "TERROR"
        Me.chk_terror.UseVisualStyleBackColor = False
        '
        'chk_acao
        '
        Me.chk_acao.AutoSize = True
        Me.chk_acao.BackColor = System.Drawing.Color.Maroon
        Me.chk_acao.Font = New System.Drawing.Font("Monotype Corsiva", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_acao.ForeColor = System.Drawing.Color.White
        Me.chk_acao.Location = New System.Drawing.Point(566, 3)
        Me.chk_acao.Name = "chk_acao"
        Me.chk_acao.Size = New System.Drawing.Size(72, 24)
        Me.chk_acao.TabIndex = 37
        Me.chk_acao.Text = "AÇÃO"
        Me.chk_acao.UseVisualStyleBackColor = False
        '
        'btn_limpar
        '
        Me.btn_limpar.BackColor = System.Drawing.Color.Maroon
        Me.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_limpar.Font = New System.Drawing.Font("Monotype Corsiva", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpar.ForeColor = System.Drawing.Color.White
        Me.btn_limpar.Location = New System.Drawing.Point(78, 41)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(101, 29)
        Me.btn_limpar.TabIndex = 14
        Me.btn_limpar.Text = "LIMPAR"
        Me.btn_limpar.UseVisualStyleBackColor = False
        '
        'txt_busca
        '
        Me.txt_busca.Location = New System.Drawing.Point(78, 13)
        Me.txt_busca.Name = "txt_busca"
        Me.txt_busca.Size = New System.Drawing.Size(471, 22)
        Me.txt_busca.TabIndex = 13
        '
        'btn_mod
        '
        Me.btn_mod.BackColor = System.Drawing.Color.Maroon
        Me.btn_mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mod.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mod.ForeColor = System.Drawing.Color.Maroon
        Me.btn_mod.Image = CType(resources.GetObject("btn_mod.Image"), System.Drawing.Image)
        Me.btn_mod.Location = New System.Drawing.Point(39, 76)
        Me.btn_mod.Name = "btn_mod"
        Me.btn_mod.Size = New System.Drawing.Size(48, 50)
        Me.btn_mod.TabIndex = 12
        Me.btn_mod.UseVisualStyleBackColor = False
        Me.btn_mod.Visible = False
        '
        'btn_add_review
        '
        Me.btn_add_review.BackColor = System.Drawing.Color.DarkGray
        Me.btn_add_review.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_review.ForeColor = System.Drawing.Color.White
        Me.btn_add_review.Image = CType(resources.GetObject("btn_add_review.Image"), System.Drawing.Image)
        Me.btn_add_review.Location = New System.Drawing.Point(39, 16)
        Me.btn_add_review.Name = "btn_add_review"
        Me.btn_add_review.Size = New System.Drawing.Size(56, 54)
        Me.btn_add_review.TabIndex = 1
        Me.btn_add_review.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(701, 167)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(127, 657)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Maroon
        Me.Panel4.Controls.Add(Me.btn_aprove)
        Me.Panel4.Controls.Add(Me.btn_add_review)
        Me.Panel4.Controls.Add(Me.btn_mod)
        Me.Panel4.Location = New System.Drawing.Point(236, 167)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(127, 657)
        Me.Panel4.TabIndex = 3
        '
        'btn_aprove
        '
        Me.btn_aprove.BackColor = System.Drawing.Color.Maroon
        Me.btn_aprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aprove.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aprove.ForeColor = System.Drawing.Color.Maroon
        Me.btn_aprove.Image = CType(resources.GetObject("btn_aprove.Image"), System.Drawing.Image)
        Me.btn_aprove.Location = New System.Drawing.Point(39, 122)
        Me.btn_aprove.Name = "btn_aprove"
        Me.btn_aprove.Size = New System.Drawing.Size(48, 50)
        Me.btn_aprove.TabIndex = 13
        Me.btn_aprove.UseVisualStyleBackColor = False
        Me.btn_aprove.Visible = False
        '
        'dgv_dados
        '
        Me.dgv_dados.AllowUserToAddRows = False
        Me.dgv_dados.AllowUserToDeleteRows = False
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column4, Me.Column3, Me.Column2, Me.Column5, Me.Column6})
        Me.dgv_dados.GridColor = System.Drawing.Color.DarkGray
        Me.dgv_dados.Location = New System.Drawing.Point(369, 167)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.ReadOnly = True
        Me.dgv_dados.RowHeadersWidth = 51
        Me.dgv_dados.RowTemplate.Height = 24
        Me.dgv_dados.Size = New System.Drawing.Size(1026, 657)
        Me.dgv_dados.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Image = CType(resources.GetObject("Column1.Image"), System.Drawing.Image)
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "REVIEWER"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "FILME"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "REVIEW"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 217
        '
        'Column5
        '
        Me.Column5.HeaderText = ""
        Me.Column5.Image = CType(resources.GetObject("Column5.Image"), System.Drawing.Image)
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "cod"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 125
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1848, 823)
        Me.Controls.Add(Me.dgv_dados)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.Text = "FEED"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.user_photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents user_photo As PictureBox
    Friend WithEvents btn_add_review As Button
    Friend WithEvents btn_mod As Button
    Friend WithEvents btn_limpar As Button
    Friend WithEvents btn_sair As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dgv_dados As DataGridView
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
    Friend WithEvents txt_busca As TextBox
    Friend WithEvents Column1 As DataGridViewImageColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
    Friend WithEvents btn_buscar As Button
    Friend WithEvents btn_aprove As Button
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
