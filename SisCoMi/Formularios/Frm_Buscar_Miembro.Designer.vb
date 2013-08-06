<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Buscar_Miembro
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rb_Numero = New System.Windows.Forms.RadioButton
        Me.rb_Nombre = New System.Windows.Forms.RadioButton
        Me.txt_numero = New System.Windows.Forms.MaskedTextBox
        Me.txt_nombre = New System.Windows.Forms.TextBox
        Me.lb_Numero = New System.Windows.Forms.Label
        Me.lb_Nombre = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DGV_Miembros = New System.Windows.Forms.DataGridView
        Me.TBMIEMBROBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New SisCoMi.DataSet
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TB_MIEMBROTableAdapter = New SisCoMi.DataSetTableAdapters.TB_MIEMBROTableAdapter
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV_Miembros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBMIEMBROBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_Numero)
        Me.GroupBox1.Controls.Add(Me.rb_Nombre)
        Me.GroupBox1.Controls.Add(Me.txt_numero)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.lb_Numero)
        Me.GroupBox1.Controls.Add(Me.lb_Nombre)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 143)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar Miembro"
        '
        'rb_Numero
        '
        Me.rb_Numero.AutoSize = True
        Me.rb_Numero.Location = New System.Drawing.Point(190, 101)
        Me.rb_Numero.Name = "rb_Numero"
        Me.rb_Numero.Size = New System.Drawing.Size(161, 17)
        Me.rb_Numero.TabIndex = 5
        Me.rb_Numero.TabStop = True
        Me.rb_Numero.Text = "Por Numero de Miembro"
        Me.rb_Numero.UseVisualStyleBackColor = True
        '
        'rb_Nombre
        '
        Me.rb_Nombre.AutoSize = True
        Me.rb_Nombre.Location = New System.Drawing.Point(46, 101)
        Me.rb_Nombre.Name = "rb_Nombre"
        Me.rb_Nombre.Size = New System.Drawing.Size(91, 17)
        Me.rb_Nombre.TabIndex = 4
        Me.rb_Nombre.TabStop = True
        Me.rb_Nombre.Text = "Por Nombre"
        Me.rb_Nombre.UseVisualStyleBackColor = True
        '
        'txt_numero
        '
        Me.txt_numero.Location = New System.Drawing.Point(95, 42)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(117, 21)
        Me.txt_numero.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txt_numero, "Numero de miembro")
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(95, 42)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(241, 21)
        Me.txt_nombre.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txt_nombre, "Nombre de Miembro")
        '
        'lb_Numero
        '
        Me.lb_Numero.AutoSize = True
        Me.lb_Numero.Location = New System.Drawing.Point(21, 55)
        Me.lb_Numero.Name = "lb_Numero"
        Me.lb_Numero.Size = New System.Drawing.Size(51, 13)
        Me.lb_Numero.TabIndex = 1
        Me.lb_Numero.Text = "Numero"
        '
        'lb_Nombre
        '
        Me.lb_Nombre.AutoSize = True
        Me.lb_Nombre.Location = New System.Drawing.Point(21, 42)
        Me.lb_Nombre.Name = "lb_Nombre"
        Me.lb_Nombre.Size = New System.Drawing.Size(51, 13)
        Me.lb_Nombre.TabIndex = 0
        Me.lb_Nombre.Text = "Nombre"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGV_Miembros)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 174)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(649, 387)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de Miembros"
        '
        'DGV_Miembros
        '
        Me.DGV_Miembros.AllowUserToAddRows = False
        Me.DGV_Miembros.AllowUserToDeleteRows = False
        Me.DGV_Miembros.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.DGV_Miembros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Miembros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Miembros.Location = New System.Drawing.Point(3, 16)
        Me.DGV_Miembros.Name = "DGV_Miembros"
        Me.DGV_Miembros.ReadOnly = True
        Me.DGV_Miembros.Size = New System.Drawing.Size(643, 368)
        Me.DGV_Miembros.TabIndex = 0
        '
        'TBMIEMBROBindingSource
        '
        Me.TBMIEMBROBindingSource.DataMember = "TB_MIEMBRO"
        Me.TBMIEMBROBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SisCoMi.My.Resources.Resources._1350969715_back
        Me.PictureBox1.Location = New System.Drawing.Point(531, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Atrás")
        '
        'TB_MIEMBROTableAdapter
        '
        Me.TB_MIEMBROTableAdapter.ClearBeforeFill = True
        '
        'Frm_Buscar_Miembro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(673, 573)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Frm_Buscar_Miembro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Miembro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGV_Miembros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBMIEMBROBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lb_Numero As System.Windows.Forms.Label
    Friend WithEvents lb_Nombre As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_Miembros As System.Windows.Forms.DataGridView
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_numero As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents DataSet As SisCoMi.DataSet
    Friend WithEvents TBMIEMBROBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TB_MIEMBROTableAdapter As SisCoMi.DataSetTableAdapters.TB_MIEMBROTableAdapter
    Friend WithEvents rb_Numero As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Nombre As System.Windows.Forms.RadioButton
End Class
