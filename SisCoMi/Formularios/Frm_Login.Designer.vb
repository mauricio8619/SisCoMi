<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Login
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
        Me.txt_Username = New System.Windows.Forms.TextBox
        Me.txt_Contrasena = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_Entrar = New System.Windows.Forms.Button
        Me.lb_Salir = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txt_Username
        '
        Me.txt_Username.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Username.Location = New System.Drawing.Point(115, 29)
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.Size = New System.Drawing.Size(163, 22)
        Me.txt_Username.TabIndex = 0
        '
        'txt_Contrasena
        '
        Me.txt_Contrasena.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Contrasena.Location = New System.Drawing.Point(115, 74)
        Me.txt_Contrasena.Name = "txt_Contrasena"
        Me.txt_Contrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_Contrasena.Size = New System.Drawing.Size(163, 22)
        Me.txt_Contrasena.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraseña"
        '
        'btn_Entrar
        '
        Me.btn_Entrar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Entrar.Image = Global.SisCoMi.My.Resources.Resources._1350962307_keepassx
        Me.btn_Entrar.Location = New System.Drawing.Point(294, 30)
        Me.btn_Entrar.Name = "btn_Entrar"
        Me.btn_Entrar.Size = New System.Drawing.Size(90, 66)
        Me.btn_Entrar.TabIndex = 4
        Me.btn_Entrar.Text = "Entrar"
        Me.btn_Entrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Entrar.UseVisualStyleBackColor = True
        '
        'lb_Salir
        '
        Me.lb_Salir.AutoSize = True
        Me.lb_Salir.BackColor = System.Drawing.Color.Transparent
        Me.lb_Salir.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Salir.Location = New System.Drawing.Point(320, 137)
        Me.lb_Salir.Name = "lb_Salir"
        Me.lb_Salir.Size = New System.Drawing.Size(33, 14)
        Me.lb_Salir.TabIndex = 5
        Me.lb_Salir.Text = "Salir"
        '
        'Frm_Login
        '
        Me.AcceptButton = Me.btn_Entrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.BackgroundImage = Global.SisCoMi.My.Resources.Resources._1350962045_checkin_key
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(396, 160)
        Me.ControlBox = False
        Me.Controls.Add(Me.lb_Salir)
        Me.Controls.Add(Me.btn_Entrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Contrasena)
        Me.Controls.Add(Me.txt_Username)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.Name = "Frm_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login SisCoMi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Username As System.Windows.Forms.TextBox
    Friend WithEvents txt_Contrasena As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_Entrar As System.Windows.Forms.Button
    Friend WithEvents lb_Salir As System.Windows.Forms.Label

End Class
