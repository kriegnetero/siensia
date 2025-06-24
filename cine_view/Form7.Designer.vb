<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.img_cartaz = New System.Windows.Forms.PictureBox()
        Me.btn_responder = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.txt_analise = New System.Windows.Forms.RichTextBox()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.lb_user = New System.Windows.Forms.Label()
        Me.img_photo = New System.Windows.Forms.PictureBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.img_cartaz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.img_cartaz)
        Me.Panel1.Controls.Add(Me.btn_responder)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dgv_dados)
        Me.Panel1.Controls.Add(Me.txt_analise)
        Me.Panel1.Controls.Add(Me.btn_home)
        Me.Panel1.Controls.Add(Me.lb_user)
        Me.Panel1.Controls.Add(Me.img_photo)
        Me.Panel1.Location = New System.Drawing.Point(224, 124)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1055, 588)
        Me.Panel1.TabIndex = 3
        '
        'img_cartaz
        '
        Me.img_cartaz.BackColor = System.Drawing.Color.DarkGray
        Me.img_cartaz.Image = CType(resources.GetObject("img_cartaz.Image"), System.Drawing.Image)
        Me.img_cartaz.Location = New System.Drawing.Point(770, 69)
        Me.img_cartaz.Name = "img_cartaz"
        Me.img_cartaz.Size = New System.Drawing.Size(223, 230)
        Me.img_cartaz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_cartaz.TabIndex = 27
        Me.img_cartaz.TabStop = False
        '
        'btn_responder
        '
        Me.btn_responder.BackColor = System.Drawing.Color.Maroon
        Me.btn_responder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_responder.Font = New System.Drawing.Font("Monotype Corsiva", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_responder.ForeColor = System.Drawing.Color.White
        Me.btn_responder.Location = New System.Drawing.Point(633, 31)
        Me.btn_responder.Name = "btn_responder"
        Me.btn_responder.Size = New System.Drawing.Size(117, 37)
        Me.btn_responder.TabIndex = 26
        Me.btn_responder.Text = "RESPONDER"
        Me.btn_responder.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Maroon
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(342, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 27)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "COMENTOU"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(196, 288)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 27)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "CHAT"
        '
        'dgv_dados
        '
        Me.dgv_dados.AllowUserToAddRows = False
        Me.dgv_dados.AllowUserToDeleteRows = False
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgv_dados.Location = New System.Drawing.Point(195, 318)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.ReadOnly = True
        Me.dgv_dados.RowHeadersWidth = 51
        Me.dgv_dados.RowTemplate.Height = 24
        Me.dgv_dados.Size = New System.Drawing.Size(555, 210)
        Me.dgv_dados.TabIndex = 21
        '
        'txt_analise
        '
        Me.txt_analise.BackColor = System.Drawing.Color.Maroon
        Me.txt_analise.Enabled = False
        Me.txt_analise.Location = New System.Drawing.Point(201, 79)
        Me.txt_analise.Name = "txt_analise"
        Me.txt_analise.Size = New System.Drawing.Size(549, 181)
        Me.txt_analise.TabIndex = 20
        Me.txt_analise.Text = ""
        '
        'btn_home
        '
        Me.btn_home.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_home.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_home.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_home.Image = CType(resources.GetObject("btn_home.Image"), System.Drawing.Image)
        Me.btn_home.Location = New System.Drawing.Point(985, 10)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(48, 50)
        Me.btn_home.TabIndex = 19
        Me.btn_home.UseVisualStyleBackColor = False
        '
        'lb_user
        '
        Me.lb_user.AutoSize = True
        Me.lb_user.BackColor = System.Drawing.Color.Maroon
        Me.lb_user.Font = New System.Drawing.Font("Monotype Corsiva", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_user.ForeColor = System.Drawing.Color.White
        Me.lb_user.Location = New System.Drawing.Point(205, 33)
        Me.lb_user.Name = "lb_user"
        Me.lb_user.Size = New System.Drawing.Size(115, 27)
        Me.lb_user.TabIndex = 8
        Me.lb_user.Text = "USUÁRIO"
        '
        'img_photo
        '
        Me.img_photo.BackColor = System.Drawing.Color.Firebrick
        Me.img_photo.Image = CType(resources.GetObject("img_photo.Image"), System.Drawing.Image)
        Me.img_photo.Location = New System.Drawing.Point(73, 33)
        Me.img_photo.Name = "img_photo"
        Me.img_photo.Size = New System.Drawing.Size(114, 124)
        Me.img_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_photo.TabIndex = 1
        Me.img_photo.TabStop = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "REVIEWER"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "COMENTÁRIO"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = ""
        Me.Column3.Image = CType(resources.GetObject("Column3.Image"), System.Drawing.Image)
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 125
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1848, 800)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form7"
        Me.Text = "REVIEW"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.img_cartaz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_home As Button
    Friend WithEvents lb_user As Label
    Friend WithEvents img_photo As PictureBox
    Friend WithEvents txt_analise As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_responder As Button
    Friend WithEvents img_cartaz As PictureBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewImageColumn
End Class
