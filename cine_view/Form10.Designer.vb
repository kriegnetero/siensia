<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form10))
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_busca = New System.Windows.Forms.ComboBox()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.Maroon
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_voltar.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.ForeColor = System.Drawing.Color.Transparent
        Me.btn_voltar.Location = New System.Drawing.Point(1156, 539)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(126, 50)
        Me.btn_voltar.TabIndex = 26
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'dgv_dados
        '
        Me.dgv_dados.AllowUserToAddRows = False
        Me.dgv_dados.AllowUserToDeleteRows = False
        Me.dgv_dados.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column4, Me.Column3, Me.Column1})
        Me.dgv_dados.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgv_dados.Location = New System.Drawing.Point(447, 174)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.ReadOnly = True
        Me.dgv_dados.RowHeadersWidth = 51
        Me.dgv_dados.RowTemplate.Height = 24
        Me.dgv_dados.Size = New System.Drawing.Size(835, 359)
        Me.dgv_dados.TabIndex = 25
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.Color.Maroon
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscar.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.ForeColor = System.Drawing.Color.Maroon
        Me.btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), System.Drawing.Image)
        Me.btn_buscar.Location = New System.Drawing.Point(447, 113)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(48, 50)
        Me.btn_buscar.TabIndex = 24
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(501, 128)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(471, 22)
        Me.txt_buscar.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Maroon
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(442, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(350, 27)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "LISTA DE REVIEW E RESPOSTA"
        '
        'cmb_busca
        '
        Me.cmb_busca.FormattingEnabled = True
        Me.cmb_busca.Location = New System.Drawing.Point(990, 128)
        Me.cmb_busca.Name = "cmb_busca"
        Me.cmb_busca.Size = New System.Drawing.Size(121, 24)
        Me.cmb_busca.TabIndex = 27
        '
        'Column2
        '
        Me.Column2.HeaderText = "E-MAIL/ID"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 405
        '
        'Column4
        '
        Me.Column4.HeaderText = "REVIEW/RESPOSTA"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 160
        '
        'Column3
        '
        Me.Column3.HeaderText = "EXCLUIR"
        Me.Column3.Image = CType(resources.GetObject("Column3.Image"), System.Drawing.Image)
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column3.Width = 125
        '
        'Column1
        '
        Me.Column1.HeaderText = "COD"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 125
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1848, 800)
        Me.Controls.Add(Me.cmb_busca)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.dgv_dados)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form10"
        Me.Text = "LISTA DE REVIEW E RESPOSTAS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_voltar As Button
    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents btn_buscar As Button
    Friend WithEvents txt_buscar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_busca As ComboBox
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewImageColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
End Class
