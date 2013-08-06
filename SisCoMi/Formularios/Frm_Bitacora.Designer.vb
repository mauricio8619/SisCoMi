<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Bitacora
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
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cbx_Username = New System.Windows.Forms.ComboBox
        Me.TBUSUARIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New SisCoMi.DataSet
        Me.dtp_Fecha = New System.Windows.Forms.DateTimePicker
        Me.rb_xFecha = New System.Windows.Forms.RadioButton
        Me.rb_xUsuario = New System.Windows.Forms.RadioButton
        Me.lb_Placa = New System.Windows.Forms.Label
        Me.lb_Username = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DVG_Facturas = New System.Windows.Forms.DataGridView
        Me.TB_USUARIOTableAdapter = New SisCoMi.DataSetTableAdapters.TB_USUARIOTableAdapter
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBUSUARIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DVG_Facturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.SisCoMi.My.Resources.Resources._1350969715_back
        Me.PictureBox3.Location = New System.Drawing.Point(533, 44)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(113, 88)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.cbx_Username)
        Me.GroupBox1.Controls.Add(Me.dtp_Fecha)
        Me.GroupBox1.Controls.Add(Me.rb_xFecha)
        Me.GroupBox1.Controls.Add(Me.rb_xUsuario)
        Me.GroupBox1.Controls.Add(Me.lb_Placa)
        Me.GroupBox1.Controls.Add(Me.lb_Username)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 106)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar Bitacora"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SisCoMi.My.Resources.Resources._1353878295_gnome_searchtool
        Me.PictureBox1.Location = New System.Drawing.Point(348, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'cbx_Username
        '
        Me.cbx_Username.DataSource = Me.TBUSUARIOBindingSource
        Me.cbx_Username.DisplayMember = "USERNAME"
        Me.cbx_Username.FormattingEnabled = True
        Me.cbx_Username.Location = New System.Drawing.Point(75, 34)
        Me.cbx_Username.Name = "cbx_Username"
        Me.cbx_Username.Size = New System.Drawing.Size(149, 21)
        Me.cbx_Username.TabIndex = 25
        Me.cbx_Username.ValueMember = "ID_USUARIO"
        '
        'TBUSUARIOBindingSource
        '
        Me.TBUSUARIOBindingSource.DataMember = "TB_USUARIO"
        Me.TBUSUARIOBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtp_Fecha
        '
        Me.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecha.Location = New System.Drawing.Point(88, 46)
        Me.dtp_Fecha.Name = "dtp_Fecha"
        Me.dtp_Fecha.Size = New System.Drawing.Size(103, 20)
        Me.dtp_Fecha.TabIndex = 24
        '
        'rb_xFecha
        '
        Me.rb_xFecha.AutoSize = True
        Me.rb_xFecha.Location = New System.Drawing.Point(39, 88)
        Me.rb_xFecha.Name = "rb_xFecha"
        Me.rb_xFecha.Size = New System.Drawing.Size(83, 17)
        Me.rb_xFecha.TabIndex = 23
        Me.rb_xFecha.Text = "Por Fecha"
        Me.rb_xFecha.UseVisualStyleBackColor = True
        '
        'rb_xUsuario
        '
        Me.rb_xUsuario.AutoSize = True
        Me.rb_xUsuario.Location = New System.Drawing.Point(233, 88)
        Me.rb_xUsuario.Name = "rb_xUsuario"
        Me.rb_xUsuario.Size = New System.Drawing.Size(91, 17)
        Me.rb_xUsuario.TabIndex = 22
        Me.rb_xUsuario.Text = "Por Usuario"
        Me.rb_xUsuario.UseVisualStyleBackColor = True
        '
        'lb_Placa
        '
        Me.lb_Placa.AutoSize = True
        Me.lb_Placa.Location = New System.Drawing.Point(32, 50)
        Me.lb_Placa.Name = "lb_Placa"
        Me.lb_Placa.Size = New System.Drawing.Size(42, 13)
        Me.lb_Placa.TabIndex = 18
        Me.lb_Placa.Text = "Fecha"
        '
        'lb_Username
        '
        Me.lb_Username.AutoSize = True
        Me.lb_Username.Location = New System.Drawing.Point(14, 37)
        Me.lb_Username.Name = "lb_Username"
        Me.lb_Username.Size = New System.Drawing.Size(63, 13)
        Me.lb_Username.TabIndex = 0
        Me.lb_Username.Text = "Username"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DVG_Facturas)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 155)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(660, 367)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Movimientos del sistema"
        '
        'DVG_Facturas
        '
        Me.DVG_Facturas.AllowUserToAddRows = False
        Me.DVG_Facturas.AllowUserToDeleteRows = False
        Me.DVG_Facturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DVG_Facturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DVG_Facturas.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.DVG_Facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DVG_Facturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DVG_Facturas.GridColor = System.Drawing.SystemColors.Highlight
        Me.DVG_Facturas.Location = New System.Drawing.Point(3, 16)
        Me.DVG_Facturas.Name = "DVG_Facturas"
        Me.DVG_Facturas.ReadOnly = True
        Me.DVG_Facturas.Size = New System.Drawing.Size(654, 348)
        Me.DVG_Facturas.TabIndex = 0
        '
        'TB_USUARIOTableAdapter
        '
        Me.TB_USUARIOTableAdapter.ClearBeforeFill = True
        '
        'Frm_Bitacora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(692, 543)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.MinimizeBox = False
        Me.Name = "Frm_Bitacora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bitacora de cambios"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBUSUARIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DVG_Facturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbx_Username As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents rb_xFecha As System.Windows.Forms.RadioButton
    Friend WithEvents rb_xUsuario As System.Windows.Forms.RadioButton
    Friend WithEvents lb_Placa As System.Windows.Forms.Label
    Friend WithEvents lb_Username As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DVG_Facturas As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DataSet As SisCoMi.DataSet
    Friend WithEvents TBUSUARIOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TB_USUARIOTableAdapter As SisCoMi.DataSetTableAdapters.TB_USUARIOTableAdapter
End Class
