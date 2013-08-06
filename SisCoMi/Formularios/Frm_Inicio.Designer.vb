<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Inicio
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.MiembrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.OrganizacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NuevaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.AdministradorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem
        Me.RestaurarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RespaldarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BitacoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ManualDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lb_fecha = New System.Windows.Forms.Label
        Me.lb_hora = New System.Windows.Forms.Label
        Me.lb_User = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip
        Me.FfToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.JToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem5, Me.ToolStripMenuItem4})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.ShowItemToolTips = True
        Me.MenuStrip1.Size = New System.Drawing.Size(715, 136)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.AccessibleDescription = "Miembro"
        Me.ToolStripMenuItem1.AccessibleName = "Miembro"
        Me.ToolStripMenuItem1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MiembrosToolStripMenuItem})
        Me.ToolStripMenuItem1.Image = Global.SisCoMi.My.Resources.Resources._1350963463_Login_Manager
        Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(140, 132)
        Me.ToolStripMenuItem1.ToolTipText = "Miembros"
        '
        'MiembrosToolStripMenuItem
        '
        Me.MiembrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.EditarToolStripMenuItem})
        Me.MiembrosToolStripMenuItem.Name = "MiembrosToolStripMenuItem"
        Me.MiembrosToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.MiembrosToolStripMenuItem.Text = "Miembros"
        Me.MiembrosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Image = Global.SisCoMi.My.Resources.Resources._1350964853_Add
        Me.NuevoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(228, 134)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Image = Global.SisCoMi.My.Resources.Resources._1350964904_desktop
        Me.EditarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(228, 134)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrganizacionesToolStripMenuItem})
        Me.ToolStripMenuItem2.Image = Global.SisCoMi.My.Resources.Resources._1350963625_organization
        Me.ToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(140, 132)
        Me.ToolStripMenuItem2.ToolTipText = "Organizaciones"
        '
        'OrganizacionesToolStripMenuItem
        '
        Me.OrganizacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaToolStripMenuItem, Me.EditarToolStripMenuItem1})
        Me.OrganizacionesToolStripMenuItem.Name = "OrganizacionesToolStripMenuItem"
        Me.OrganizacionesToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.OrganizacionesToolStripMenuItem.Text = "Organizaciones"
        '
        'NuevaToolStripMenuItem
        '
        Me.NuevaToolStripMenuItem.Image = Global.SisCoMi.My.Resources.Resources._1350964853_Add
        Me.NuevaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NuevaToolStripMenuItem.Name = "NuevaToolStripMenuItem"
        Me.NuevaToolStripMenuItem.Size = New System.Drawing.Size(254, 134)
        Me.NuevaToolStripMenuItem.Text = "Nueva"
        '
        'EditarToolStripMenuItem1
        '
        Me.EditarToolStripMenuItem1.Image = Global.SisCoMi.My.Resources.Resources._1350964904_desktop
        Me.EditarToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EditarToolStripMenuItem1.Name = "EditarToolStripMenuItem1"
        Me.EditarToolStripMenuItem1.Size = New System.Drawing.Size(254, 134)
        Me.EditarToolStripMenuItem1.Text = "Miembros "
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministradorToolStripMenuItem})
        Me.ToolStripMenuItem3.Image = Global.SisCoMi.My.Resources.Resources._1350963687_administrator
        Me.ToolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(140, 132)
        Me.ToolStripMenuItem3.ToolTipText = "Administrador"
        '
        'AdministradorToolStripMenuItem
        '
        Me.AdministradorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuarioToolStripMenuItem, Me.ToolStripMenuItem6, Me.BitacoraToolStripMenuItem})
        Me.AdministradorToolStripMenuItem.Name = "AdministradorToolStripMenuItem"
        Me.AdministradorToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.AdministradorToolStripMenuItem.Text = "Administrador"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem2})
        Me.UsuarioToolStripMenuItem.Image = Global.SisCoMi.My.Resources.Resources._1350964952_preferences_desktop_user_password
        Me.UsuarioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(280, 134)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'EditarToolStripMenuItem2
        '
        Me.EditarToolStripMenuItem2.Image = Global.SisCoMi.My.Resources.Resources._1350964904_desktop
        Me.EditarToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EditarToolStripMenuItem2.Name = "EditarToolStripMenuItem2"
        Me.EditarToolStripMenuItem2.Size = New System.Drawing.Size(226, 134)
        Me.EditarToolStripMenuItem2.Text = "Editar"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestaurarToolStripMenuItem, Me.RespaldarToolStripMenuItem})
        Me.ToolStripMenuItem6.Image = Global.SisCoMi.My.Resources.Resources._1350965004_Database_1
        Me.ToolStripMenuItem6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(280, 134)
        Me.ToolStripMenuItem6.Text = "Base de datos"
        '
        'RestaurarToolStripMenuItem
        '
        Me.RestaurarToolStripMenuItem.Image = Global.SisCoMi.My.Resources.Resources._1350965021_Database_Upload
        Me.RestaurarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RestaurarToolStripMenuItem.Name = "RestaurarToolStripMenuItem"
        Me.RestaurarToolStripMenuItem.Size = New System.Drawing.Size(254, 134)
        Me.RestaurarToolStripMenuItem.Text = "Restaurar"
        '
        'RespaldarToolStripMenuItem
        '
        Me.RespaldarToolStripMenuItem.Image = Global.SisCoMi.My.Resources.Resources._1350965026_download_database
        Me.RespaldarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RespaldarToolStripMenuItem.Name = "RespaldarToolStripMenuItem"
        Me.RespaldarToolStripMenuItem.Size = New System.Drawing.Size(254, 134)
        Me.RespaldarToolStripMenuItem.Text = "Respaldar"
        '
        'BitacoraToolStripMenuItem
        '
        Me.BitacoraToolStripMenuItem.Image = Global.SisCoMi.My.Resources.Resources._1350965159_security_yellow
        Me.BitacoraToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BitacoraToolStripMenuItem.Name = "BitacoraToolStripMenuItem"
        Me.BitacoraToolStripMenuItem.Size = New System.Drawing.Size(280, 134)
        Me.BitacoraToolStripMenuItem.Text = "Bitacora"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AyudaToolStripMenuItem})
        Me.ToolStripMenuItem5.Image = Global.SisCoMi.My.Resources.Resources._1350964632_Help
        Me.ToolStripMenuItem5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(140, 132)
        Me.ToolStripMenuItem5.ToolTipText = "Ayuda"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManualDeUsuarioToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'ManualDeUsuarioToolStripMenuItem
        '
        Me.ManualDeUsuarioToolStripMenuItem.Image = Global.SisCoMi.My.Resources.Resources._1350966379_BeOS_Help_book
        Me.ManualDeUsuarioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ManualDeUsuarioToolStripMenuItem.Name = "ManualDeUsuarioToolStripMenuItem"
        Me.ManualDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(306, 134)
        Me.ManualDeUsuarioToolStripMenuItem.Text = "Manual de Usuario"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Image = Global.SisCoMi.My.Resources.Resources._1350966437_system_software_installer
        Me.AcercaDeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(306, 134)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ToolStripMenuItem4.Image = Global.SisCoMi.My.Resources.Resources._1350964369_Log_Out
        Me.ToolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(140, 132)
        Me.ToolStripMenuItem4.ToolTipText = "Salir"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'lb_fecha
        '
        Me.lb_fecha.AutoSize = True
        Me.lb_fecha.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_fecha.Location = New System.Drawing.Point(139, 225)
        Me.lb_fecha.Name = "lb_fecha"
        Me.lb_fecha.Size = New System.Drawing.Size(56, 19)
        Me.lb_fecha.TabIndex = 3
        Me.lb_fecha.Text = "Fecha"
        '
        'lb_hora
        '
        Me.lb_hora.AutoSize = True
        Me.lb_hora.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_hora.Location = New System.Drawing.Point(539, 225)
        Me.lb_hora.Name = "lb_hora"
        Me.lb_hora.Size = New System.Drawing.Size(48, 19)
        Me.lb_hora.TabIndex = 4
        Me.lb_hora.Text = "Hora"
        '
        'lb_User
        '
        Me.lb_User.AutoSize = True
        Me.lb_User.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lb_User.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_User.Location = New System.Drawing.Point(599, 418)
        Me.lb_User.Name = "lb_User"
        Me.lb_User.Size = New System.Drawing.Size(53, 23)
        Me.lb_User.TabIndex = 6
        Me.lb_User.Text = "User"
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.OwnerDraw = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(140, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(447, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "La Iglesia de Jesucristo de Santos de los ultimos Dias "
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FfToolStripMenuItem, Me.JToolStripMenuItem, Me.LToolStripMenuItem, Me.UToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 359)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.ShowItemToolTips = True
        Me.MenuStrip2.Size = New System.Drawing.Size(715, 136)
        Me.MenuStrip2.TabIndex = 8
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'FfToolStripMenuItem
        '
        Me.FfToolStripMenuItem.Image = Global.SisCoMi.My.Resources.Resources._1365674703_iPhoto
        Me.FfToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FfToolStripMenuItem.Name = "FfToolStripMenuItem"
        Me.FfToolStripMenuItem.Size = New System.Drawing.Size(140, 132)
        Me.FfToolStripMenuItem.ToolTipText = "Fotos"
        '
        'JToolStripMenuItem
        '
        Me.JToolStripMenuItem.Image = Global.SisCoMi.My.Resources.Resources._1365674675_Binoculars
        Me.JToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.JToolStripMenuItem.Name = "JToolStripMenuItem"
        Me.JToolStripMenuItem.Size = New System.Drawing.Size(140, 132)
        Me.JToolStripMenuItem.ToolTipText = "Buscar Miembro"
        '
        'LToolStripMenuItem
        '
        Me.LToolStripMenuItem.Image = Global.SisCoMi.My.Resources.Resources._1350962045_checkin_key
        Me.LToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LToolStripMenuItem.Name = "LToolStripMenuItem"
        Me.LToolStripMenuItem.Size = New System.Drawing.Size(140, 132)
        Me.LToolStripMenuItem.ToolTipText = "Cerrar Session"
        '
        'UToolStripMenuItem
        '
        Me.UToolStripMenuItem.Image = Global.SisCoMi.My.Resources.Resources._1350967678_administrator
        Me.UToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UToolStripMenuItem.Name = "UToolStripMenuItem"
        Me.UToolStripMenuItem.Size = New System.Drawing.Size(140, 132)
        Me.UToolStripMenuItem.ToolTipText = "Usuario Actual"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(263, 316)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Rama San Ramón"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SisCoMi.My.Resources.Resources._1350967090_alarmd
        Me.PictureBox2.Location = New System.Drawing.Point(459, 207)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(61, 54)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SisCoMi.My.Resources.Resources._1350967056_calendar
        Me.PictureBox1.Location = New System.Drawing.Point(41, 207)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Frm_Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(715, 495)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lb_User)
        Me.Controls.Add(Me.lb_hora)
        Me.Controls.Add(Me.lb_fecha)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Frm_Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu de inicio"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MiembrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrganizacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministradorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManualDeUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestaurarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RespaldarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BitacoraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lb_fecha As System.Windows.Forms.Label
    Friend WithEvents lb_hora As System.Windows.Forms.Label
    Friend WithEvents lb_User As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents FfToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
