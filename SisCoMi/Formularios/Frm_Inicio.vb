Public Class Frm_Inicio


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lb_fecha.Click

    End Sub

    Private Sub Frm_Inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolTip1.IsBalloon = True
        lb_fecha.Text = Date.Now.Date
        lb_User.Text = Frm_Login.txt_Username.Text
        Cargar_IDUsario(lb_User.Text)
        If permit <> "Administrador" Then
            ToolStripMenuItem3.Enabled = False

        End If
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        Me.Visible = False
        frm_Datos_Miembro.Show()


    End Sub

    Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click
        Me.Visible = False
        Frm_Buscar_Miembro.Show()

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
        Frm_Login.Show()
        Frm_Login.txt_Contrasena.Text = ""
        Frm_Login.txt_Username.Text = ""

    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        Frm_Login.Dispose()
        Me.Dispose()

    End Sub

    Private Sub NuevaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevaToolStripMenuItem.Click
        Frm_Mantenimiento_Organizacion.Show()

    End Sub

    Private Sub EditarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem1.Click
        Frm_Listado_Organizaciones.Show()
    End Sub

    Private Sub EditarToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem2.Click
        Frm_Mantenimiento_Usuario.Show()

    End Sub

    Private Sub RestaurarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestaurarToolStripMenuItem.Click
        Frm_Restaurar.Show()
        Me.Close()

    End Sub

    Private Sub RespaldarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RespaldarToolStripMenuItem.Click
        Frm_Respaldar.Show()
        Me.Close()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lb_hora.Text = Date.Now.ToLongTimeString
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Frm_Acerca_de.Show()

    End Sub

    Private Sub BitacoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BitacoraToolStripMenuItem.Click
        Frm_Bitacora.Show()

    End Sub

    Private Sub Cargar_IDUsario(Optional ByVal pUsername As String = "")
        Try

            Dim miGESTOR As New DLL.cls_Gestor
            Dim myUsuario() As DLL.Cls_Usuario
            myUsuario = Nothing

            If (pUsername <> "") Then
                myUsuario = miGESTOR.ConsultasUsuario(pUsername)
            End If

            If (pUsername = "") Then

            End If

            Dim myid As DLL.Cls_Usuario

            For Each myid In myUsuario
                If (myUsuario IsNot Nothing) Then
                    'obtener valores
                    id_user = myid.newid_Usuario
                    permit = myid.newTipo_usuario
                End If

            Next






        Catch ex As Exception

        End Try
    End Sub

    Private Sub ManualDeUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManualDeUsuarioToolStripMenuItem.Click
        Dim psi As New ProcessStartInfo
        Dim des As String = System.AppDomain.CurrentDomain.BaseDirectory
        psi.UseShellExecute = True
        Dim DestinationFile As String = des.Replace("SisCoMi\bin\Debug\", "manual de usuario.pdf")
        psi.FileName = DestinationFile
        Process.Start(psi)
    End Sub

    Private Sub LToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LToolStripMenuItem.Click
        Me.Dispose()
        Frm_Login.Show()
        Frm_Login.txt_Contrasena.Text = ""
        Frm_Login.txt_Username.Text = ""
    End Sub

    Private Sub JToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JToolStripMenuItem.Click
        Me.Visible = False
        Frm_Buscar_Miembro.Show()
    End Sub

    Private Sub FfToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FfToolStripMenuItem.Click
        Me.Visible = False
        Frm_Mantenimiento_Foto.Show()
    End Sub

   
End Class