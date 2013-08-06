Public Class Frm_Login
    Public usuario As String
    Private intento As Integer = 3



    Private Sub btn_Entrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Entrar.Click
        validar_Usuario()


    End Sub

    Private Sub lb_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lb_Salir.Click
        Me.Dispose()

    End Sub

    Private Sub validar_Usuario()


        If Me.txt_Username.Text <> "" And Me.txt_Contrasena.Text <> "" Then


            Dim miGestor As New DLL.cls_Gestor

            If miGestor.ValidarUsuarios(Me.txt_Username.Text, Me.txt_Contrasena.Text) = True Then

                usuario = Me.txt_Username.Text
                MsgBox("Bienvenido al Sistema" & " " & txt_Username.Text, MsgBoxStyle.Information, Title:="SisCoMi")
                Me.Visible = False
                Frm_Inicio.Show()
            Else
                intento = intento - 1
                MsgBox("Datos incorrectos solo tiene " & intento & " oportunidades", MsgBoxStyle.Exclamation, Title:="SisCoMi")
                If intento = 0 Then
                    MsgBox("Si olvido la clave o username llame al adminnistrador", MsgBoxStyle.Exclamation, Title:="SisCoMi")
                    Me.Dispose()

                End If



            End If
        Else
            MsgBox("Por favor llene todos los espacios ", MsgBoxStyle.Information)

        End If

    End Sub
End Class
