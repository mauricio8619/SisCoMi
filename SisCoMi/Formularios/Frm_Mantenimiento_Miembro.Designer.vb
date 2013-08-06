<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Mantenimiento_Miembro
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
        Me.mujer = New System.Windows.Forms.RadioButton
        Me.Hombre = New System.Windows.Forms.RadioButton
        Me.lb_genero = New System.Windows.Forms.Label
        Me.txt_id_Miembro = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_Fecha = New System.Windows.Forms.MaskedTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_Telefono = New System.Windows.Forms.MaskedTextBox
        Me.txt_Dirrecion = New System.Windows.Forms.TextBox
        Me.txt_Nombre = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txt_comentarios = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_llamamiento_act = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_Fecha_inves = New System.Windows.Forms.MaskedTextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txt_Fecha_Sella = New System.Windows.Forms.MaskedTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_Fecha_Conf = New System.Windows.Forms.MaskedTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_Fecha_baut = New System.Windows.Forms.MaskedTextBox
        Me.txt_Num_Miembro = New System.Windows.Forms.MaskedTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TBORGANIZACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New SisCoMi.DataSet
        Me.txt_id_Organizacion = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PicBox_Foto = New System.Windows.Forms.PictureBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.lb_id_foto = New System.Windows.Forms.Label
        Me.TB_ORGANIZACIONTableAdapter = New SisCoMi.DataSetTableAdapters.TB_ORGANIZACIONTableAdapter
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TBORGANIZACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBox_Foto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mujer)
        Me.GroupBox1.Controls.Add(Me.Hombre)
        Me.GroupBox1.Controls.Add(Me.lb_genero)
        Me.GroupBox1.Controls.Add(Me.txt_id_Miembro)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_Fecha)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_Telefono)
        Me.GroupBox1.Controls.Add(Me.txt_Dirrecion)
        Me.GroupBox1.Controls.Add(Me.txt_Nombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(504, 139)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'mujer
        '
        Me.mujer.AutoSize = True
        Me.mujer.Location = New System.Drawing.Point(434, 116)
        Me.mujer.Name = "mujer"
        Me.mujer.Size = New System.Drawing.Size(52, 17)
        Me.mujer.TabIndex = 14
        Me.mujer.TabStop = True
        Me.mujer.Text = "Mujer"
        Me.mujer.UseVisualStyleBackColor = True
        '
        'Hombre
        '
        Me.Hombre.AutoSize = True
        Me.Hombre.Location = New System.Drawing.Point(353, 116)
        Me.Hombre.Name = "Hombre"
        Me.Hombre.Size = New System.Drawing.Size(61, 17)
        Me.Hombre.TabIndex = 13
        Me.Hombre.TabStop = True
        Me.Hombre.Text = "hombre"
        Me.Hombre.UseVisualStyleBackColor = True
        '
        'lb_genero
        '
        Me.lb_genero.AutoSize = True
        Me.lb_genero.Location = New System.Drawing.Point(431, 96)
        Me.lb_genero.Name = "lb_genero"
        Me.lb_genero.Size = New System.Drawing.Size(41, 13)
        Me.lb_genero.TabIndex = 9
        Me.lb_genero.Text = "genero"
        Me.lb_genero.Visible = False
        '
        'txt_id_Miembro
        '
        Me.txt_id_Miembro.Location = New System.Drawing.Point(422, 29)
        Me.txt_id_Miembro.Name = "txt_id_Miembro"
        Me.txt_id_Miembro.ReadOnly = True
        Me.txt_id_Miembro.Size = New System.Drawing.Size(71, 21)
        Me.txt_id_Miembro.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(350, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Id Miembro"
        '
        'txt_Fecha
        '
        Me.txt_Fecha.Location = New System.Drawing.Point(353, 72)
        Me.txt_Fecha.Mask = "00/00/0000"
        Me.txt_Fecha.Name = "txt_Fecha"
        Me.txt_Fecha.Size = New System.Drawing.Size(140, 21)
        Me.txt_Fecha.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.txt_Fecha, "dd/mm/aaaa")
        Me.txt_Fecha.ValidatingType = GetType(Date)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(214, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Fecha de Nacimiento"
        '
        'txt_Telefono
        '
        Me.txt_Telefono.Location = New System.Drawing.Point(64, 72)
        Me.txt_Telefono.Mask = "99-99-99-99"
        Me.txt_Telefono.Name = "txt_Telefono"
        Me.txt_Telefono.Size = New System.Drawing.Size(116, 21)
        Me.txt_Telefono.TabIndex = 6
        '
        'txt_Dirrecion
        '
        Me.txt_Dirrecion.Location = New System.Drawing.Point(64, 105)
        Me.txt_Dirrecion.Multiline = True
        Me.txt_Dirrecion.Name = "txt_Dirrecion"
        Me.txt_Dirrecion.Size = New System.Drawing.Size(273, 31)
        Me.txt_Dirrecion.TabIndex = 5
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(64, 29)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(276, 21)
        Me.txt_Nombre.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Telefono"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Direccion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_comentarios)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txt_llamamiento_act)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txt_Fecha_inves)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txt_Fecha_Sella)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_Fecha_Conf)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txt_Fecha_baut)
        Me.GroupBox2.Controls.Add(Me.txt_Num_Miembro)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 168)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(649, 132)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Miembro"
        '
        'txt_comentarios
        '
        Me.txt_comentarios.Location = New System.Drawing.Point(471, 70)
        Me.txt_comentarios.Multiline = True
        Me.txt_comentarios.Name = "txt_comentarios"
        Me.txt_comentarios.Size = New System.Drawing.Size(155, 48)
        Me.txt_comentarios.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(468, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Comentarios:"
        '
        'txt_llamamiento_act
        '
        Me.txt_llamamiento_act.Location = New System.Drawing.Point(346, 21)
        Me.txt_llamamiento_act.Name = "txt_llamamiento_act"
        Me.txt_llamamiento_act.Size = New System.Drawing.Size(280, 20)
        Me.txt_llamamiento_act.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(239, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Llamamiento Actual"
        '
        'txt_Fecha_inves
        '
        Me.txt_Fecha_inves.Location = New System.Drawing.Point(346, 82)
        Me.txt_Fecha_inves.Mask = "00/00/0000"
        Me.txt_Fecha_inves.Name = "txt_Fecha_inves"
        Me.txt_Fecha_inves.Size = New System.Drawing.Size(116, 20)
        Me.txt_Fecha_inves.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.txt_Fecha_inves, "dd/mm/aaaa")
        Me.txt_Fecha_inves.ValidatingType = GetType(Date)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(239, 85)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Fecha Investidura"
        '
        'txt_Fecha_Sella
        '
        Me.txt_Fecha_Sella.Location = New System.Drawing.Point(346, 51)
        Me.txt_Fecha_Sella.Mask = "00/00/0000"
        Me.txt_Fecha_Sella.Name = "txt_Fecha_Sella"
        Me.txt_Fecha_Sella.Size = New System.Drawing.Size(116, 20)
        Me.txt_Fecha_Sella.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.txt_Fecha_Sella, "dd/mm/aaaa")
        Me.txt_Fecha_Sella.ValidatingType = GetType(Date)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(239, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Fecha Sellamiento"
        '
        'txt_Fecha_Conf
        '
        Me.txt_Fecha_Conf.Location = New System.Drawing.Point(114, 82)
        Me.txt_Fecha_Conf.Mask = "00/00/0000"
        Me.txt_Fecha_Conf.Name = "txt_Fecha_Conf"
        Me.txt_Fecha_Conf.Size = New System.Drawing.Size(116, 20)
        Me.txt_Fecha_Conf.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.txt_Fecha_Conf, "dd/mm/aaaa")
        Me.txt_Fecha_Conf.ValidatingType = GetType(Date)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Fecha Confirmacion"
        '
        'txt_Fecha_baut
        '
        Me.txt_Fecha_baut.Location = New System.Drawing.Point(114, 51)
        Me.txt_Fecha_baut.Mask = "00/00/0000"
        Me.txt_Fecha_baut.Name = "txt_Fecha_baut"
        Me.txt_Fecha_baut.Size = New System.Drawing.Size(116, 20)
        Me.txt_Fecha_baut.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.txt_Fecha_baut, "dd/mm/aaaa")
        Me.txt_Fecha_baut.ValidatingType = GetType(Date)
        '
        'txt_Num_Miembro
        '
        Me.txt_Num_Miembro.Location = New System.Drawing.Point(114, 22)
        Me.txt_Num_Miembro.Mask = "AAA-AAAA-AAAA"
        Me.txt_Num_Miembro.Name = "txt_Num_Miembro"
        Me.txt_Num_Miembro.Size = New System.Drawing.Size(116, 20)
        Me.txt_Num_Miembro.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Fecha Bautismo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Num Miembro"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Me.txt_id_Organizacion)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 327)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(649, 118)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de la Organizacion"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.TBORGANIZACIONBindingSource
        Me.ComboBox1.DisplayMember = "NOMBRE_ORGANIZACION"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(94, 60)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(266, 21)
        Me.ComboBox1.TabIndex = 17
        Me.ComboBox1.ValueMember = "ID_ORGANIZACION"
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
        'txt_id_Organizacion
        '
        Me.txt_id_Organizacion.Location = New System.Drawing.Point(94, 32)
        Me.txt_id_Organizacion.Name = "txt_id_Organizacion"
        Me.txt_id_Organizacion.ReadOnly = True
        Me.txt_id_Organizacion.Size = New System.Drawing.Size(71, 20)
        Me.txt_id_Organizacion.TabIndex = 16
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 68)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Nombre"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 35)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Id Organizacion"
        '
        'PicBox_Foto
        '
        Me.PicBox_Foto.Location = New System.Drawing.Point(535, 12)
        Me.PicBox_Foto.Name = "PicBox_Foto"
        Me.PicBox_Foto.Size = New System.Drawing.Size(126, 139)
        Me.PicBox_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox_Foto.TabIndex = 0
        Me.PicBox_Foto.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PicBox_Foto, "Foto de Miembro")
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.SisCoMi.My.Resources.Resources._1350970927_button_blue_repeat
        Me.PictureBox5.Location = New System.Drawing.Point(254, 473)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(113, 88)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 6
        Me.PictureBox5.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox5, "Modificar")
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.SisCoMi.My.Resources.Resources._1350970899__trash
        Me.PictureBox4.Location = New System.Drawing.Point(12, 473)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(113, 88)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox4, "Borrar")
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.SisCoMi.My.Resources.Resources._1350969715_back
        Me.PictureBox3.Location = New System.Drawing.Point(548, 473)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(113, 88)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox3, "Atrás")
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SisCoMi.My.Resources.Resources._1350971165_Save
        Me.PictureBox2.Location = New System.Drawing.Point(12, 473)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(113, 88)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox2, "Guardar")
        Me.PictureBox2.Visible = False
        '
        'lb_id_foto
        '
        Me.lb_id_foto.AutoSize = True
        Me.lb_id_foto.Location = New System.Drawing.Point(178, 157)
        Me.lb_id_foto.Name = "lb_id_foto"
        Me.lb_id_foto.Size = New System.Drawing.Size(25, 13)
        Me.lb_id_foto.TabIndex = 8
        Me.lb_id_foto.Text = "foto"
        Me.lb_id_foto.Visible = False
        '
        'TB_ORGANIZACIONTableAdapter
        '
        Me.TB_ORGANIZACIONTableAdapter.ClearBeforeFill = True
        '
        'Frm_Mantenimiento_Miembro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(673, 573)
        Me.ControlBox = False
        Me.Controls.Add(Me.lb_id_foto)
        Me.Controls.Add(Me.PicBox_Foto)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Frm_Mantenimiento_Miembro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario Miembro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.TBORGANIZACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBox_Foto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PicBox_Foto As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Telefono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_Dirrecion As System.Windows.Forms.TextBox
    Friend WithEvents txt_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_Fecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txt_id_Miembro As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_Num_Miembro As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_Fecha_inves As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_Fecha_Sella As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_Fecha_Conf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_Fecha_baut As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_comentarios As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_llamamiento_act As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_id_Organizacion As System.Windows.Forms.TextBox
    Friend WithEvents lb_id_foto As System.Windows.Forms.Label
    Friend WithEvents lb_genero As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DataSet As SisCoMi.DataSet
    Friend WithEvents TBORGANIZACIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TB_ORGANIZACIONTableAdapter As SisCoMi.DataSetTableAdapters.TB_ORGANIZACIONTableAdapter
    Friend WithEvents mujer As System.Windows.Forms.RadioButton
    Friend WithEvents Hombre As System.Windows.Forms.RadioButton
End Class
