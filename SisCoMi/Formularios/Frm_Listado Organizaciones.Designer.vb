<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Listado_Organizaciones
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
        Me.DGV_Miembros = New System.Windows.Forms.DataGridView
        Me.TBMIEMBROBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New SisCoMi.DataSet
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Cb_Organizacion = New System.Windows.Forms.ComboBox
        Me.TBORGANIZACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox6 = New System.Windows.Forms.PictureBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cantidad = New System.Windows.Forms.Label
        Me.TB_ORGANIZACIONTableAdapter = New SisCoMi.DataSetTableAdapters.TB_ORGANIZACIONTableAdapter
        Me.TB_MIEMBROTableAdapter = New SisCoMi.DataSetTableAdapters.TB_MIEMBROTableAdapter
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV_Miembros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBMIEMBROBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TBORGANIZACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGV_Miembros)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(649, 319)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de Miembros"
        '
        'DGV_Miembros
        '
        Me.DGV_Miembros.AllowUserToAddRows = False
        Me.DGV_Miembros.AllowUserToDeleteRows = False
        Me.DGV_Miembros.AllowUserToOrderColumns = True
        Me.DGV_Miembros.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.DGV_Miembros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Miembros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Miembros.Location = New System.Drawing.Point(3, 16)
        Me.DGV_Miembros.Name = "DGV_Miembros"
        Me.DGV_Miembros.ReadOnly = True
        Me.DGV_Miembros.Size = New System.Drawing.Size(643, 300)
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cb_Organizacion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 108)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar Organizacion"
        '
        'Cb_Organizacion
        '
        Me.Cb_Organizacion.DataSource = Me.TBORGANIZACIONBindingSource
        Me.Cb_Organizacion.DisplayMember = "NOMBRE_ORGANIZACION"
        Me.Cb_Organizacion.FormattingEnabled = True
        Me.Cb_Organizacion.Location = New System.Drawing.Point(90, 42)
        Me.Cb_Organizacion.Name = "Cb_Organizacion"
        Me.Cb_Organizacion.Size = New System.Drawing.Size(241, 21)
        Me.Cb_Organizacion.TabIndex = 3
        Me.Cb_Organizacion.ValueMember = "ID_ORGANIZACION"
        '
        'TBORGANIZACIONBindingSource
        '
        Me.TBORGANIZACIONBindingSource.DataMember = "TB_ORGANIZACION"
        Me.TBORGANIZACIONBindingSource.DataSource = Me.DataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.SisCoMi.My.Resources.Resources._1350971740_print
        Me.PictureBox6.Location = New System.Drawing.Point(143, 477)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(113, 88)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 15
        Me.PictureBox6.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox6, "Imprimir")
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.SisCoMi.My.Resources.Resources._1350970927_button_blue_repeat
        Me.PictureBox5.Location = New System.Drawing.Point(13, 477)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(113, 88)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 14
        Me.PictureBox5.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox5, "Refrescar")
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.SisCoMi.My.Resources.Resources._1350969715_back
        Me.PictureBox3.Location = New System.Drawing.Point(276, 477)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(113, 88)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox3, "Atrás")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SisCoMi.My.Resources.Resources._1350963463_Login_Manager
        Me.PictureBox1.Location = New System.Drawing.Point(438, 486)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Total de miembros")
        '
        'cantidad
        '
        Me.cantidad.AutoSize = True
        Me.cantidad.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cantidad.Location = New System.Drawing.Point(513, 507)
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Size = New System.Drawing.Size(22, 23)
        Me.cantidad.TabIndex = 17
        Me.cantidad.Text = "0"
        '
        'TB_ORGANIZACIONTableAdapter
        '
        Me.TB_ORGANIZACIONTableAdapter.ClearBeforeFill = True
        '
        'TB_MIEMBROTableAdapter
        '
        Me.TB_MIEMBROTableAdapter.ClearBeforeFill = True
        '
        'PrintDocument1
        '
        '
        'Frm_Listado_Organizaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(673, 573)
        Me.ControlBox = False
        Me.Controls.Add(Me.cantidad)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.Name = "Frm_Listado_Organizaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de miembros en organizacion"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGV_Miembros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBMIEMBROBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TBORGANIZACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_Miembros As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cantidad As System.Windows.Forms.Label
    Friend WithEvents Cb_Organizacion As System.Windows.Forms.ComboBox
    Friend WithEvents DataSet As SisCoMi.DataSet
    Friend WithEvents TBORGANIZACIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TB_ORGANIZACIONTableAdapter As SisCoMi.DataSetTableAdapters.TB_ORGANIZACIONTableAdapter
    Friend WithEvents TBMIEMBROBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TB_MIEMBROTableAdapter As SisCoMi.DataSetTableAdapters.TB_MIEMBROTableAdapter
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class
