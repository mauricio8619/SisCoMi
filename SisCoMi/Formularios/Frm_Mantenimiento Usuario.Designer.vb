<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Mantenimiento_Usuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DGV_Usuario = New System.Windows.Forms.DataGridView
        Me.IDUSUARIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CONTRASENA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.USERNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TIPODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TBUSUARIOBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New SisCoMi.DataSet
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cbx_TipoUser = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_IdUser = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_Contraseña = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tx_User = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.TBUSUARIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TB_USUARIOTableAdapter = New SisCoMi.DataSetTableAdapters.TB_USUARIOTableAdapter
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV_Usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBUSUARIOBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBUSUARIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGV_Usuario)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(9, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(492, 195)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de Usuarios"
        '
        'DGV_Usuario
        '
        Me.DGV_Usuario.AllowUserToAddRows = False
        Me.DGV_Usuario.AllowUserToDeleteRows = False
        Me.DGV_Usuario.AutoGenerateColumns = False
        Me.DGV_Usuario.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.DGV_Usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Usuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDUSUARIODataGridViewTextBoxColumn, Me.CONTRASENA, Me.USERNAMEDataGridViewTextBoxColumn, Me.TIPODataGridViewTextBoxColumn})
        Me.DGV_Usuario.DataSource = Me.TBUSUARIOBindingSource1
        Me.DGV_Usuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Usuario.Location = New System.Drawing.Point(3, 17)
        Me.DGV_Usuario.Name = "DGV_Usuario"
        Me.DGV_Usuario.ReadOnly = True
        Me.DGV_Usuario.Size = New System.Drawing.Size(486, 175)
        Me.DGV_Usuario.TabIndex = 0
        '
        'IDUSUARIODataGridViewTextBoxColumn
        '
        Me.IDUSUARIODataGridViewTextBoxColumn.DataPropertyName = "ID_USUARIO"
        Me.IDUSUARIODataGridViewTextBoxColumn.HeaderText = "ID_USUARIO"
        Me.IDUSUARIODataGridViewTextBoxColumn.Name = "IDUSUARIODataGridViewTextBoxColumn"
        Me.IDUSUARIODataGridViewTextBoxColumn.ReadOnly = True
        Me.IDUSUARIODataGridViewTextBoxColumn.Width = 140
        '
        'CONTRASENA
        '
        Me.CONTRASENA.DataPropertyName = "CONTRASENA"
        Me.CONTRASENA.HeaderText = "CONTRASENA"
        Me.CONTRASENA.Name = "CONTRASENA"
        Me.CONTRASENA.ReadOnly = True
        Me.CONTRASENA.Visible = False
        '
        'USERNAMEDataGridViewTextBoxColumn
        '
        Me.USERNAMEDataGridViewTextBoxColumn.DataPropertyName = "USERNAME"
        Me.USERNAMEDataGridViewTextBoxColumn.HeaderText = "USERNAME"
        Me.USERNAMEDataGridViewTextBoxColumn.Name = "USERNAMEDataGridViewTextBoxColumn"
        Me.USERNAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.USERNAMEDataGridViewTextBoxColumn.Width = 150
        '
        'TIPODataGridViewTextBoxColumn
        '
        Me.TIPODataGridViewTextBoxColumn.DataPropertyName = "TIPO"
        Me.TIPODataGridViewTextBoxColumn.HeaderText = "TIPO"
        Me.TIPODataGridViewTextBoxColumn.Name = "TIPODataGridViewTextBoxColumn"
        Me.TIPODataGridViewTextBoxColumn.ReadOnly = True
        Me.TIPODataGridViewTextBoxColumn.Width = 150
        '
        'TBUSUARIOBindingSource1
        '
        Me.TBUSUARIOBindingSource1.DataMember = "TB_USUARIO"
        Me.TBUSUARIOBindingSource1.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbx_TipoUser)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txt_IdUser)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txt_Contraseña)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.tx_User)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(9, 225)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(489, 129)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Usuario"
        '
        'cbx_TipoUser
        '
        Me.cbx_TipoUser.FormattingEnabled = True
        Me.cbx_TipoUser.Items.AddRange(New Object() {"Administrador", "Consejero", "Secretario"})
        Me.cbx_TipoUser.Location = New System.Drawing.Point(118, 101)
        Me.cbx_TipoUser.Name = "cbx_TipoUser"
        Me.cbx_TipoUser.Size = New System.Drawing.Size(143, 21)
        Me.cbx_TipoUser.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Tipo de Usuario"
        '
        'txt_IdUser
        '
        Me.txt_IdUser.Location = New System.Drawing.Point(362, 36)
        Me.txt_IdUser.Name = "txt_IdUser"
        Me.txt_IdUser.ReadOnly = True
        Me.txt_IdUser.Size = New System.Drawing.Size(69, 21)
        Me.txt_IdUser.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(281, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "ID Usuario"
        '
        'txt_Contraseña
        '
        Me.txt_Contraseña.Location = New System.Drawing.Point(118, 70)
        Me.txt_Contraseña.Name = "txt_Contraseña"
        Me.txt_Contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_Contraseña.Size = New System.Drawing.Size(143, 21)
        Me.txt_Contraseña.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Contraseña"
        '
        'tx_User
        '
        Me.tx_User.Location = New System.Drawing.Point(118, 36)
        Me.tx_User.Name = "tx_User"
        Me.tx_User.Size = New System.Drawing.Size(143, 21)
        Me.tx_User.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Username"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.SisCoMi.My.Resources.Resources._1350970927_button_blue_repeat
        Me.PictureBox5.Location = New System.Drawing.Point(258, 360)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(113, 88)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 20
        Me.PictureBox5.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox5, "Refrescar")
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.SisCoMi.My.Resources.Resources._1350970899__trash
        Me.PictureBox4.Location = New System.Drawing.Point(139, 360)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(113, 88)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 19
        Me.PictureBox4.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox4, "Eliminar")
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.SisCoMi.My.Resources.Resources._1350969715_back
        Me.PictureBox3.Location = New System.Drawing.Point(387, 360)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(113, 88)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 18
        Me.PictureBox3.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox3, "Atrás")
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SisCoMi.My.Resources.Resources._1350971165_Save
        Me.PictureBox2.Location = New System.Drawing.Point(7, 360)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(113, 88)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox2, "Guardar")
        '
        'TBUSUARIOBindingSource
        '
        Me.TBUSUARIOBindingSource.DataMember = "TB_USUARIO"
        Me.TBUSUARIOBindingSource.DataSource = Me.DataSet
        '
        'TB_USUARIOTableAdapter
        '
        Me.TB_USUARIOTableAdapter.ClearBeforeFill = True
        '
        'Frm_Mantenimiento_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(523, 465)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.Name = "Frm_Mantenimiento_Usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario Usuario"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGV_Usuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBUSUARIOBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBUSUARIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_Usuario As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tx_User As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents cbx_TipoUser As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_IdUser As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataSet As SisCoMi.DataSet
    Friend WithEvents TBUSUARIOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TB_USUARIOTableAdapter As SisCoMi.DataSetTableAdapters.TB_USUARIOTableAdapter
    Friend WithEvents txt_Contraseña As System.Windows.Forms.TextBox
    Friend WithEvents TBUSUARIOBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents IDUSUARIODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONTRASENA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USERNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
