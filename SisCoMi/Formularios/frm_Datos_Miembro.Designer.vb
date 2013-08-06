<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Datos_Miembro
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.lb_id_foto = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.PicBox_Foto = New System.Windows.Forms.PictureBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lb_genero = New System.Windows.Forms.Label
        Me.Hombre = New System.Windows.Forms.RadioButton
        Me.mujer = New System.Windows.Forms.RadioButton
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
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
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
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PicBox_Imagen = New System.Windows.Forms.PictureBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TBORGANIZACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New SisCoMi.DataSet
        Me.txt_id_Organizacion = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.TB_ORGANIZACIONTableAdapter = New SisCoMi.DataSetTableAdapters.TB_ORGANIZACIONTableAdapter
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PicBox_Foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBox_Imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBORGANIZACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Enabled = False
        Me.PictureBox2.Image = Global.SisCoMi.My.Resources.Resources._1350971165_Save
        Me.PictureBox2.Location = New System.Drawing.Point(418, 326)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(44, 38)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 34
        Me.PictureBox2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox2, "Guardar")
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.SisCoMi.My.Resources.Resources._1350964369_Log_Out
        Me.PictureBox4.Location = New System.Drawing.Point(18, 326)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(44, 38)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 35
        Me.PictureBox4.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox4, "Salir")
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(9, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.ShowToolTips = True
        Me.TabControl1.Size = New System.Drawing.Size(471, 308)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TabPage1.Controls.Add(Me.lb_id_foto)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.txt_id_Miembro)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txt_Fecha)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txt_Telefono)
        Me.TabPage1.Controls.Add(Me.txt_Dirrecion)
        Me.TabPage1.Controls.Add(Me.txt_Nombre)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(463, 282)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos Personales"
        '
        'lb_id_foto
        '
        Me.lb_id_foto.AutoSize = True
        Me.lb_id_foto.Location = New System.Drawing.Point(381, 167)
        Me.lb_id_foto.Name = "lb_id_foto"
        Me.lb_id_foto.Size = New System.Drawing.Size(25, 13)
        Me.lb_id_foto.TabIndex = 31
        Me.lb_id_foto.Text = "foto"
        Me.lb_id_foto.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PicBox_Foto)
        Me.GroupBox3.Location = New System.Drawing.Point(337, 32)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(121, 132)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Agregar Foto"
        '
        'PicBox_Foto
        '
        Me.PicBox_Foto.Location = New System.Drawing.Point(13, 20)
        Me.PicBox_Foto.Name = "PicBox_Foto"
        Me.PicBox_Foto.Size = New System.Drawing.Size(90, 106)
        Me.PicBox_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox_Foto.TabIndex = 16
        Me.PicBox_Foto.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lb_genero)
        Me.GroupBox2.Controls.Add(Me.Hombre)
        Me.GroupBox2.Controls.Add(Me.mujer)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 185)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 55)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Genero"
        '
        'lb_genero
        '
        Me.lb_genero.AutoSize = True
        Me.lb_genero.Location = New System.Drawing.Point(74, 39)
        Me.lb_genero.Name = "lb_genero"
        Me.lb_genero.Size = New System.Drawing.Size(40, 13)
        Me.lb_genero.TabIndex = 15
        Me.lb_genero.Text = "genero"
        Me.lb_genero.Visible = False
        '
        'Hombre
        '
        Me.Hombre.AutoSize = True
        Me.Hombre.Location = New System.Drawing.Point(7, 20)
        Me.Hombre.Name = "Hombre"
        Me.Hombre.Size = New System.Drawing.Size(60, 17)
        Me.Hombre.TabIndex = 13
        Me.Hombre.TabStop = True
        Me.Hombre.Text = "hombre"
        Me.Hombre.UseVisualStyleBackColor = True
        '
        'mujer
        '
        Me.mujer.AutoSize = True
        Me.mujer.Location = New System.Drawing.Point(115, 20)
        Me.mujer.Name = "mujer"
        Me.mujer.Size = New System.Drawing.Size(51, 17)
        Me.mujer.TabIndex = 14
        Me.mujer.TabStop = True
        Me.mujer.Text = "Mujer"
        Me.mujer.UseVisualStyleBackColor = True
        '
        'txt_id_Miembro
        '
        Me.txt_id_Miembro.Location = New System.Drawing.Point(274, 59)
        Me.txt_id_Miembro.Name = "txt_id_Miembro"
        Me.txt_id_Miembro.ReadOnly = True
        Me.txt_id_Miembro.Size = New System.Drawing.Size(57, 20)
        Me.txt_id_Miembro.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(201, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Id Miembro"
        '
        'txt_Fecha
        '
        Me.txt_Fecha.Location = New System.Drawing.Point(121, 158)
        Me.txt_Fecha.Mask = "00/00/0000"
        Me.txt_Fecha.Name = "txt_Fecha"
        Me.txt_Fecha.Size = New System.Drawing.Size(140, 20)
        Me.txt_Fecha.TabIndex = 26
        Me.txt_Fecha.ValidatingType = GetType(Date)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Fecha de Nacimiento"
        '
        'txt_Telefono
        '
        Me.txt_Telefono.Location = New System.Drawing.Point(72, 64)
        Me.txt_Telefono.Mask = "99-99-99-99"
        Me.txt_Telefono.Name = "txt_Telefono"
        Me.txt_Telefono.Size = New System.Drawing.Size(116, 20)
        Me.txt_Telefono.TabIndex = 24
        '
        'txt_Dirrecion
        '
        Me.txt_Dirrecion.Location = New System.Drawing.Point(72, 102)
        Me.txt_Dirrecion.Multiline = True
        Me.txt_Dirrecion.Name = "txt_Dirrecion"
        Me.txt_Dirrecion.Size = New System.Drawing.Size(259, 50)
        Me.txt_Dirrecion.TabIndex = 23
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(72, 29)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(259, 20)
        Me.txt_Nombre.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Telefono"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Direccion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Nombre"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Controls.Add(Me.txt_comentarios)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.txt_llamamiento_act)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.txt_Fecha_inves)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.txt_Fecha_Sella)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.txt_Fecha_Conf)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.txt_Fecha_baut)
        Me.TabPage2.Controls.Add(Me.txt_Num_Miembro)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(463, 282)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Datos Miembro"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SisCoMi.My.Resources.Resources._1350971165_Save
        Me.PictureBox1.Location = New System.Drawing.Point(428, 285)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'txt_comentarios
        '
        Me.txt_comentarios.Location = New System.Drawing.Point(245, 37)
        Me.txt_comentarios.Multiline = True
        Me.txt_comentarios.Name = "txt_comentarios"
        Me.txt_comentarios.Size = New System.Drawing.Size(210, 167)
        Me.txt_comentarios.TabIndex = 65
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(242, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 13)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "Comentarios:"
        '
        'txt_llamamiento_act
        '
        Me.txt_llamamiento_act.Location = New System.Drawing.Point(115, 232)
        Me.txt_llamamiento_act.Name = "txt_llamamiento_act"
        Me.txt_llamamiento_act.Size = New System.Drawing.Size(261, 20)
        Me.txt_llamamiento_act.TabIndex = 52
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 235)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 13)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "Llamamiento Actual"
        '
        'txt_Fecha_inves
        '
        Me.txt_Fecha_inves.Location = New System.Drawing.Point(116, 142)
        Me.txt_Fecha_inves.Mask = "00/00/0000"
        Me.txt_Fecha_inves.Name = "txt_Fecha_inves"
        Me.txt_Fecha_inves.Size = New System.Drawing.Size(116, 20)
        Me.txt_Fecha_inves.TabIndex = 62
        Me.txt_Fecha_inves.ValidatingType = GetType(Date)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 149)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 13)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Fecha Investidura"
        '
        'txt_Fecha_Sella
        '
        Me.txt_Fecha_Sella.Location = New System.Drawing.Point(115, 184)
        Me.txt_Fecha_Sella.Mask = "00/00/0000"
        Me.txt_Fecha_Sella.Name = "txt_Fecha_Sella"
        Me.txt_Fecha_Sella.Size = New System.Drawing.Size(116, 20)
        Me.txt_Fecha_Sella.TabIndex = 60
        Me.txt_Fecha_Sella.ValidatingType = GetType(Date)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 191)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 13)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Fecha Sellamiento"
        '
        'txt_Fecha_Conf
        '
        Me.txt_Fecha_Conf.Location = New System.Drawing.Point(115, 104)
        Me.txt_Fecha_Conf.Mask = "00/00/0000"
        Me.txt_Fecha_Conf.Name = "txt_Fecha_Conf"
        Me.txt_Fecha_Conf.Size = New System.Drawing.Size(116, 20)
        Me.txt_Fecha_Conf.TabIndex = 58
        Me.txt_Fecha_Conf.ValidatingType = GetType(Date)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 13)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Fecha Confirmacion"
        '
        'txt_Fecha_baut
        '
        Me.txt_Fecha_baut.Location = New System.Drawing.Point(115, 58)
        Me.txt_Fecha_baut.Mask = "00/00/0000"
        Me.txt_Fecha_baut.Name = "txt_Fecha_baut"
        Me.txt_Fecha_baut.Size = New System.Drawing.Size(116, 20)
        Me.txt_Fecha_baut.TabIndex = 56
        Me.txt_Fecha_baut.ValidatingType = GetType(Date)
        '
        'txt_Num_Miembro
        '
        Me.txt_Num_Miembro.Location = New System.Drawing.Point(115, 14)
        Me.txt_Num_Miembro.Mask = "AAA-AAAA-AAAA"
        Me.txt_Num_Miembro.Name = "txt_Num_Miembro"
        Me.txt_Num_Miembro.Size = New System.Drawing.Size(116, 20)
        Me.txt_Num_Miembro.TabIndex = 53
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Fecha Bautismo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Num Miembro"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TabPage3.Controls.Add(Me.PictureBox3)
        Me.TabPage3.Controls.Add(Me.PicBox_Imagen)
        Me.TabPage3.Controls.Add(Me.ComboBox1)
        Me.TabPage3.Controls.Add(Me.txt_id_Organizacion)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(463, 282)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Datos Organizacion"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.SisCoMi.My.Resources.Resources._1350971165_Save
        Me.PictureBox3.Location = New System.Drawing.Point(428, 288)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(44, 38)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 33
        Me.PictureBox3.TabStop = False
        '
        'PicBox_Imagen
        '
        Me.PicBox_Imagen.Location = New System.Drawing.Point(161, 98)
        Me.PicBox_Imagen.Name = "PicBox_Imagen"
        Me.PicBox_Imagen.Size = New System.Drawing.Size(151, 136)
        Me.PicBox_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicBox_Imagen.TabIndex = 23
        Me.PicBox_Imagen.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.TBORGANIZACIONBindingSource
        Me.ComboBox1.DisplayMember = "NOMBRE_ORGANIZACION"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(106, 62)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(230, 21)
        Me.ComboBox1.TabIndex = 22
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
        Me.txt_id_Organizacion.Location = New System.Drawing.Point(106, 21)
        Me.txt_id_Organizacion.Name = "txt_id_Organizacion"
        Me.txt_id_Organizacion.ReadOnly = True
        Me.txt_id_Organizacion.Size = New System.Drawing.Size(71, 20)
        Me.txt_id_Organizacion.TabIndex = 21
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(19, 70)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 13)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Nombre"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(19, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 13)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Id Organizacion"
        '
        'TB_ORGANIZACIONTableAdapter
        '
        Me.TB_ORGANIZACIONTableAdapter.ClearBeforeFill = True
        '
        'frm_Datos_Miembro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(492, 366)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.Name = "frm_Datos_Miembro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Miembro"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PicBox_Foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBox_Imagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBORGANIZACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents txt_comentarios As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_llamamiento_act As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_Fecha_inves As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_Fecha_Sella As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_Fecha_Conf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_Fecha_baut As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_Num_Miembro As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lb_id_foto As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PicBox_Foto As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lb_genero As System.Windows.Forms.Label
    Friend WithEvents Hombre As System.Windows.Forms.RadioButton
    Friend WithEvents mujer As System.Windows.Forms.RadioButton
    Friend WithEvents txt_id_Miembro As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_Fecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Telefono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_Dirrecion As System.Windows.Forms.TextBox
    Friend WithEvents txt_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PicBox_Imagen As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents txt_id_Organizacion As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents DataSet As SisCoMi.DataSet
    Friend WithEvents TBORGANIZACIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TB_ORGANIZACIONTableAdapter As SisCoMi.DataSetTableAdapters.TB_ORGANIZACIONTableAdapter
End Class
