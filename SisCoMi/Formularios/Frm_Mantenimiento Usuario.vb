Public Class Frm_Mantenimiento_Usuario
    Private myGestor As New DLL.cls_Gestor
    Private myUsuario As New DLL.Cls_Usuario

    Private Sub Frm_Mantenimiento_Usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.TB_USUARIOTableAdapter.Fill(Me.DataSet.TB_USUARIO)
        ToolTip1.IsBalloon = True
        Me.txt_IdUser.Text = myGestor.ConsecutivoUsuario().ToString

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.Close()
        Frm_Inicio.Show()

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        insertar()
        Me.TB_USUARIOTableAdapter.Fill(Me.DataSet.TB_USUARIO)

    End Sub
    'Funcioion insertar
    Sub insertar()
        
        Dim CorrectoUsuario As Boolean
        'validacion de campos
        If (Me.tx_User.Text <> "" And Me.txt_Contraseña.Text <> "" And Me.cbx_TipoUser.Text <> "") Then

            'asignacion de valores
            CorrectoUsuario = myGestor.InsertarUsuario(Me.txt_IdUser.Text, Me.tx_User.Text, Me.txt_Contraseña.Text, Me.cbx_TipoUser.Text)

            If CorrectoUsuario = True Then
                MsgBox("Datos almacenados correctamente", MsgBoxStyle.Information, Title:="SisCoMi")
                myGestor.agregarbitacora(myGestor.ConsecutivoBitacora().ToString, id_user, Date.Now.ToString, "Se Creo el Usuario " & Me.tx_User.Text)


            Else
                MsgBox("Puede que algunos datos no se hayan almacenado correctamente", MsgBoxStyle.Exclamation, Title:="SisCoMi")
            End If
        Else
            MsgBox("por favor llene todos los espacios requeridos", MsgBoxStyle.Critical, Title:="SisCoMi")

        End If


    End Sub
    'Funcion modificar
    Sub modificar()
      
        Dim CorrectoUsuario As Boolean
        'Validacion
        If (Me.tx_User.Text <> "" And Me.cbx_TipoUser.Text <> "") Then

            'Asignar valores
            CorrectoUsuario = myGestor.ModificarUsuario(Me.txt_IdUser.Text, Me.tx_User.Text, Me.txt_Contraseña.Text, Me.cbx_TipoUser.Text)


            If CorrectoUsuario = True Then
                MsgBox("Datos Modificados correctamente", MsgBoxStyle.Information, Title:="SisCoMi")
                myGestor.agregarbitacora(myGestor.ConsecutivoBitacora().ToString, id_user, Date.Now.ToString, "Se Modifico el Usuario " & Me.tx_User.Text)
            Else
                MsgBox("Puede que algunos datos no se hayan Modificado correctamente", MsgBoxStyle.Exclamation, Title:="SisCoMi")
            End If
        Else
            MsgBox("por favor llene todos los espacios requeridos", MsgBoxStyle.Critical, Title:="SisCoMi")

        End If


    End Sub
    'Funcion eliminar
    Sub Eliminar()
      
        Dim CorrectoUsuario As Boolean
        'validacion
        If (Me.tx_User.Text <> "" And Me.cbx_TipoUser.Text <> "") Then

            'Asignar datos
            CorrectoUsuario = myGestor.EliminarUsuario(Me.txt_IdUser.Text, Me.tx_User.Text, Me.txt_Contraseña.Text, Me.cbx_TipoUser.Text)

            If CorrectoUsuario = True Then
                MsgBox("Datos Eliminados correctamente", MsgBoxStyle.Information, Title:="SisCoMI")
                myGestor.agregarbitacora(myGestor.ConsecutivoBitacora().ToString, id_user, Date.Now.ToString, "Se Elimino el Usuario " & Me.tx_User.Text)
            Else
                MsgBox("Puede que algunos datos no se hayan Eliminado correctamente", MsgBoxStyle.Exclamation, Title:="SisCoMI")
            End If
        Else
            MsgBox("por favor llene todos los espacios requeridos", MsgBoxStyle.Critical, Title:="SisCoMI")

        End If


    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        modificar()
        Me.TB_USUARIOTableAdapter.Fill(Me.DataSet.TB_USUARIO)

    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Eliminar()
        Me.TB_USUARIOTableAdapter.Fill(Me.DataSet.TB_USUARIO)

    End Sub

    
    Private Sub DGV_Usuario_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Usuario.CellDoubleClick
        Try
            If Me.DGV_Usuario.CurrentRow.Cells.Item(0).Value = Nothing Or DGV_Usuario.CurrentRow.Cells.Item(1).Value = "" Then
                MsgBox("Dato nulo", MsgBoxStyle.Information)
            Else


                Me.txt_IdUser.Text = DGV_Usuario.CurrentRow.Cells.Item(0).Value
                Me.tx_User.Text = DGV_Usuario.CurrentRow.Cells.Item(2).Value
                Dim tipo As String = DGV_Usuario.CurrentRow.Cells.Item(3).Value
                If tipo = "Administrador" Then
                    Me.cbx_TipoUser.SelectedIndex = 0
                ElseIf tipo = "Secretario" Then
                    Me.cbx_TipoUser.SelectedIndex = 2
                ElseIf tipo = "Consejero" Then
                    Me.cbx_TipoUser.SelectedIndex = 1
                End If





            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_IdUser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_IdUser.TextChanged
        If myGestor.ConsecutivoUsuario().ToString <= txt_IdUser.Text Then
            PictureBox2.Enabled = True
            PictureBox4.Enabled = False
            PictureBox5.Enabled = False
        Else
            PictureBox2.Enabled = False
            PictureBox4.Enabled = True
            PictureBox5.Enabled = True
        End If
    End Sub
End Class