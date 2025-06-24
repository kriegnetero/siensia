<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_analise = New System.Windows.Forms.RichTextBox()
        Me.lb_user = New System.Windows.Forms.Label()
        Me.img_photo = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.img_photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txt_analise)
        Me.Panel1.Controls.Add(Me.lb_user)
        Me.Panel1.Controls.Add(Me.img_photo)
        Me.Panel1.Location = New System.Drawing.Point(352, 220)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(979, 426)
        Me.Panel1.TabIndex = 4
        '
        'txt_analise
        '
        Me.txt_analise.BackColor = System.Drawing.Color.Maroon
        Me.txt_analise.Enabled = False
        Me.txt_analise.ForeColor = System.Drawing.Color.Black
        Me.txt_analise.Location = New System.Drawing.Point(201, 79)
        Me.txt_analise.Name = "txt_analise"
        Me.txt_analise.Size = New System.Drawing.Size(549, 181)
        Me.txt_analise.TabIndex = 20
        Me.txt_analise.Text = ""
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
        Me.img_photo.Location = New System.Drawing.Point(27, 33)
        Me.img_photo.Name = "img_photo"
        Me.img_photo.Size = New System.Drawing.Size(114, 124)
        Me.img_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_photo.TabIndex = 1
        Me.img_photo.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btn_voltar)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(352, 97)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(979, 85)
        Me.Panel2.TabIndex = 5
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.ForeColor = System.Drawing.Color.White
        Me.btn_voltar.Location = New System.Drawing.Point(783, 18)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(142, 50)
        Me.btn_voltar.TabIndex = 18
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(384, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CINE VIEW "
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1848, 800)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form9"
        Me.Text = "COMENTÁRIO DO CHAT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.img_photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_analise As RichTextBox
    Friend WithEvents lb_user As Label
    Friend WithEvents img_photo As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_voltar As Button
    Friend WithEvents Label1 As Label
End Class
