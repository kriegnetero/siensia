<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.btn_enviar = New System.Windows.Forms.Button()
        Me.txt_resposta = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_voltar)
        Me.Panel1.Controls.Add(Me.btn_home)
        Me.Panel1.Controls.Add(Me.btn_enviar)
        Me.Panel1.Controls.Add(Me.txt_resposta)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.img_foto)
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(135, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1146, 748)
        Me.Panel1.TabIndex = 4
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.Maroon
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar.Font = New System.Drawing.Font("Monotype Corsiva", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.ForeColor = System.Drawing.Color.White
        Me.btn_voltar.Location = New System.Drawing.Point(512, 131)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(117, 37)
        Me.btn_voltar.TabIndex = 27
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'btn_home
        '
        Me.btn_home.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_home.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_home.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_home.Image = CType(resources.GetObject("btn_home.Image"), System.Drawing.Image)
        Me.btn_home.Location = New System.Drawing.Point(780, 118)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(48, 50)
        Me.btn_home.TabIndex = 26
        Me.btn_home.UseVisualStyleBackColor = False
        '
        'btn_enviar
        '
        Me.btn_enviar.BackColor = System.Drawing.Color.Maroon
        Me.btn_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_enviar.Font = New System.Drawing.Font("Monotype Corsiva", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enviar.ForeColor = System.Drawing.Color.White
        Me.btn_enviar.Location = New System.Drawing.Point(657, 131)
        Me.btn_enviar.Name = "btn_enviar"
        Me.btn_enviar.Size = New System.Drawing.Size(117, 37)
        Me.btn_enviar.TabIndex = 25
        Me.btn_enviar.Text = "ENVIAR"
        Me.btn_enviar.UseVisualStyleBackColor = False
        '
        'txt_resposta
        '
        Me.txt_resposta.BackColor = System.Drawing.Color.Maroon
        Me.txt_resposta.ForeColor = System.Drawing.Color.White
        Me.txt_resposta.Location = New System.Drawing.Point(239, 174)
        Me.txt_resposta.Name = "txt_resposta"
        Me.txt_resposta.Size = New System.Drawing.Size(605, 318)
        Me.txt_resposta.TabIndex = 0
        Me.txt_resposta.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Maroon
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(234, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 27)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "RESPOSTA"
        '
        'img_foto
        '
        Me.img_foto.BackColor = System.Drawing.Color.Firebrick
        Me.img_foto.Image = CType(resources.GetObject("img_foto.Image"), System.Drawing.Image)
        Me.img_foto.Location = New System.Drawing.Point(96, 128)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(114, 124)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto.TabIndex = 1
        Me.img_foto.TabStop = False
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1848, 800)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form8"
        Me.Text = "COMENTAR REVIEW"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_resposta As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents btn_enviar As Button
    Friend WithEvents btn_home As Button
    Friend WithEvents btn_voltar As Button
End Class
