<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Mantenimiento_Organizacion
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.txt_Ubicacion = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.txt_nom_org = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_Id_org = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.IDORGANIZACIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NOMBREORGANIZACIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Imagen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TBORGANIZACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New SisCoMi.DataSet
        Me.TBORGANIZACIONBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TB_ORGANIZACIONTableAdapter = New SisCoMi.DataSetTableAdapters.TB_ORGANIZACIONTableAdapter
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PicBox_Image = New System.Windows.Forms.PictureBox
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBORGANIZACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBORGANIZACIONBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PicBox_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.txt_Ubicacion)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.txt_nom_org)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txt_Id_org)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(10, 318)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(454, 129)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de la Organizacion"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(395, 98)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(38, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txt_Ubicacion
        '
        Me.txt_Ubicacion.Location = New System.Drawing.Point(157, 100)
        Me.txt_Ubicacion.Name = "txt_Ubicacion"
        Me.txt_Ubicacion.Size = New System.Drawing.Size(232, 21)
        Me.txt_Ubicacion.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Imagen Organizacion"
        '
        'Button1
        '
        Me.Button1.Image = Global.SisCoMi.My.Resources.Resources._1353481746_edit_clear
        Me.Button1.Location = New System.Drawing.Point(298, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 39)
        Me.Button1.TabIndex = 7
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_nom_org
        '
        Me.txt_nom_org.Location = New System.Drawing.Point(157, 70)
        Me.txt_nom_org.Name = "txt_nom_org"
        Me.txt_nom_org.Size = New System.Drawing.Size(268, 21)
        Me.txt_nom_org.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nombre Organizacion"
        '
        'txt_Id_org
        '
        Me.txt_Id_org.Location = New System.Drawing.Point(157, 39)
        Me.txt_Id_org.Name = "txt_Id_org"
        Me.txt_Id_org.ReadOnly = True
        Me.txt_Id_org.Size = New System.Drawing.Size(54, 21)
        Me.txt_Id_org.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Id Organizacion"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.SisCoMi.My.Resources.Resources._1350970927_button_blue_repeat
        Me.PictureBox5.Location = New System.Drawing.Point(248, 473)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(113, 88)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 11
        Me.PictureBox5.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox5, "Modificar")
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.SisCoMi.My.Resources.Resources._1350970899__trash
        Me.PictureBox4.Location = New System.Drawing.Point(129, 473)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(113, 88)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 10
        Me.PictureBox4.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox4, "Eliminar")
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.SisCoMi.My.Resources.Resources._1350969715_back
        Me.PictureBox3.Location = New System.Drawing.Point(367, 473)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(113, 88)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox3, "Atrás")
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SisCoMi.My.Resources.Resources._1350971165_Save
        Me.PictureBox2.Location = New System.Drawing.Point(10, 473)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(113, 88)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox2, "Guardar")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(644, 290)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de Organizaciones"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDORGANIZACIONDataGridViewTextBoxColumn, Me.NOMBREORGANIZACIONDataGridViewTextBoxColumn, Me.Imagen})
        Me.DataGridView1.DataSource = Me.TBORGANIZACIONBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(638, 271)
        Me.DataGridView1.TabIndex = 0
        '
        'IDORGANIZACIONDataGridViewTextBoxColumn
        '
        Me.IDORGANIZACIONDataGridViewTextBoxColumn.DataPropertyName = "ID_ORGANIZACION"
        Me.IDORGANIZACIONDataGridViewTextBoxColumn.HeaderText = "ID_ORGANIZACION"
        Me.IDORGANIZACIONDataGridViewTextBoxColumn.Name = "IDORGANIZACIONDataGridViewTextBoxColumn"
        '
        'NOMBREORGANIZACIONDataGridViewTextBoxColumn
        '
        Me.NOMBREORGANIZACIONDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE_ORGANIZACION"
        Me.NOMBREORGANIZACIONDataGridViewTextBoxColumn.HeaderText = "NOMBRE_ORGANIZACION"
        Me.NOMBREORGANIZACIONDataGridViewTextBoxColumn.Name = "NOMBREORGANIZACIONDataGridViewTextBoxColumn"
        Me.NOMBREORGANIZACIONDataGridViewTextBoxColumn.Width = 300
        '
        'Imagen
        '
        Me.Imagen.DataPropertyName = "IMAGEN"
        Me.Imagen.FillWeight = 180.0!
        Me.Imagen.HeaderText = "Imagen"
        Me.Imagen.Name = "Imagen"
        Me.Imagen.ReadOnly = True
        Me.Imagen.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Imagen.Width = 190
        '
        'TBORGANIZACIONBindingSource
        '
        Me.TBORGANIZACIONBindingSource.DataMember = "TB_ORGANIZACION"
        Me.TBORGANIZACIONBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBORGANIZACIONBindingSource1
        '
        Me.TBORGANIZACIONBindingSource1.DataMember = "TB_ORGANIZACION"
        Me.TBORGANIZACIONBindingSource1.DataSource = Me.DataSet
        '
        'TB_ORGANIZACIONTableAdapter
        '
        Me.TB_ORGANIZACIONTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PicBox_Image)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(470, 318)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(184, 129)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Imagen de Organizacion"
        '
        'PicBox_Image
        '
        Me.PicBox_Image.Location = New System.Drawing.Point(15, 19)
        Me.PicBox_Image.Name = "PicBox_Image"
        Me.PicBox_Image.Size = New System.Drawing.Size(152, 104)
        Me.PicBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicBox_Image.TabIndex = 0
        Me.PicBox_Image.TabStop = False
        '
        'Frm_Mantenimiento_Organizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(666, 573)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.MaximizeBox = False
        Me.Name = "Frm_Mantenimiento_Organizacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario Organizaciones"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBORGANIZACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBORGANIZACIONBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PicBox_Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_nom_org As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_Id_org As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet As SisCoMi.DataSet
    Friend WithEvents TBORGANIZACIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TB_ORGANIZACIONTableAdapter As SisCoMi.DataSetTableAdapters.TB_ORGANIZACIONTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txt_Ubicacion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBORGANIZACIONBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents IDORGANIZACIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBREORGANIZACIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Imagen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PicBox_Image As System.Windows.Forms.PictureBox
End Class
