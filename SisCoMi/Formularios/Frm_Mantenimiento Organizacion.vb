Public Class Frm_Mantenimiento_Organizacion

    Private myGestor As New DLL.cls_Gestor
    Private myOrganizacion As New DLL.Cls_organizacion

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.Close()
        Frm_Inicio.Show()

    End Sub

    Private Sub Frm_Mantenimiento_Organizacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TB_ORGANIZACIONTableAdapter.Fill(Me.DataSet.TB_ORGANIZACION)
        Me.txt_Id_org.Text = myGestor.ConsecutivoOrganizacion().ToString
        ToolTip1.IsBalloon = True

        If permit = "Secretario" Then
            PictureBox4.Enabled = False

        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        insertar()
        Me.TB_ORGANIZACIONTableAdapter.Fill(Me.DataSet.TB_ORGANIZACION)
        clear()

    End Sub

    Sub insertar()

        Dim CorrectoOrganizacion As Boolean
        'validacion de campos
        If (Me.txt_Id_org.Text <> "" And Me.txt_nom_org.Text <> "") Then

            'asignacion de valores
            CorrectoOrganizacion = myGestor.InsertarOrganizacion(Me.txt_Id_org.Text, Me.txt_nom_org.Text, Me.txt_Ubicacion.Text)

            If CorrectoOrganizacion = True Then
                MsgBox("Datos almacenados correctamente", MsgBoxStyle.Information, Title:="SisCoMi")
                myGestor.agregarbitacora(myGestor.ConsecutivoBitacora().ToString, id_user, Date.Now.ToString, "Se Creo la organizacion " & Me.txt_nom_org.Text)

            Else
                MsgBox("Los datos no se guardaron verifique que no existan", MsgBoxStyle.Exclamation, Title:="SisCoMi")
            End If
        Else
            MsgBox("por favor llene todos los espacios requeridos", MsgBoxStyle.Critical, Title:="SisCoMi")

        End If


    End Sub

    Sub Modificar()

        Dim CorrectoOrganizacion As Boolean
        'validacion de campos
        If (Me.txt_Id_org.Text <> "" And Me.txt_nom_org.Text <> "") Then

            'asignacion de valores
            CorrectoOrganizacion = myGestor.ModificarOrganizacion(Me.txt_Id_org.Text, Me.txt_nom_org.Text, Me.txt_Ubicacion.Text)

            If CorrectoOrganizacion = True Then
                MsgBox("Datos Modificados correctamente", MsgBoxStyle.Information, Title:="SisCoMi")
                myGestor.agregarbitacora(myGestor.ConsecutivoBitacora().ToString, id_user, Date.Now.ToString, "Se Modifico la organizacion " & Me.txt_nom_org.Text)

            Else
                MsgBox("Los datos no se Modificaron verifique que  existan", MsgBoxStyle.Exclamation, Title:="SisCoMi")
            End If
        Else
            MsgBox("por favor llene todos los espacios requeridos", MsgBoxStyle.Critical, Title:="SisCoMi")

        End If


    End Sub

    Sub Eliminar()

        Dim CorrectoOrganizacion As Boolean
        'validacion de campos
        If (Me.txt_Id_org.Text <> "" And Me.txt_nom_org.Text <> "") Then

            'asignacion de valores
            CorrectoOrganizacion = myGestor.EliminarOrganizacion(Me.txt_Id_org.Text)

            If CorrectoOrganizacion = True Then
                MsgBox("Datos Eliminados correctamente", MsgBoxStyle.Information, Title:="SisCoMi")
                myGestor.agregarbitacora(myGestor.ConsecutivoBitacora().ToString, id_user, Date.Now.ToString, "Se Elimino la organizacion " & Me.txt_nom_org.Text)

            Else
                MsgBox("Los datos no se Eliminaron verifique que  existan", MsgBoxStyle.Exclamation, Title:="SisCoMi")
            End If
        Else
            MsgBox("por favor llene todos los espacios requeridos", MsgBoxStyle.Critical, Title:="SisCoMi")

        End If


    End Sub


    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Modificar()
        Me.TB_ORGANIZACIONTableAdapter.Fill(Me.DataSet.TB_ORGANIZACION)
        clear()

    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Eliminar()
        Me.TB_ORGANIZACIONTableAdapter.Fill(Me.DataSet.TB_ORGANIZACION)
        clear()

    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        Try
            If Me.DataGridView1.CurrentRow.Cells.Item(0).Value = Nothing Or DataGridView1.CurrentRow.Cells.Item(1).Value = "" Then
                MsgBox("Dato nulo", MsgBoxStyle.Information)
            Else


                Me.txt_Id_org.Text = DataGridView1.CurrentRow.Cells.Item(0).Value
                Me.txt_nom_org.Text = DataGridView1.CurrentRow.Cells.Item(1).Value
                Me.txt_Ubicacion.Text = DataGridView1.CurrentRow.Cells.Item(2).Value
               


            End If
        Catch ex As Exception

        End Try
    End Sub
    Sub clear()
        Me.txt_Id_org.Text = myGestor.ConsecutivoOrganizacion().ToString
        Me.txt_nom_org.Text = ""
        Me.txt_Ubicacion.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        clear()

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim openFD As New OpenFileDialog()

        With openFD
            Dim DestinationFile = System.AppDomain.CurrentDomain.BaseDirectory
            Dim des As String = DestinationFile.Replace("SisCoMi\bin\Debug\", "Imagenes\")
            .Title = "Seleccione la Imagen dela Organizacion"
            .Multiselect = False
            .InitialDirectory = des
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                txt_Ubicacion.Text = .SafeFileName
                PicBox_Image.ImageLocation = .FileName

            End If

        End With
    End Sub

    Private Sub txt_Ubicacion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Ubicacion.TextChanged
        Dim DestinationFile = System.AppDomain.CurrentDomain.BaseDirectory
        Dim des As String = DestinationFile.Replace("SisCoMi\bin\Debug\", "Imagenes\")
        PicBox_Image.ImageLocation = des + txt_Ubicacion.Text

    End Sub

    
   
    Private Sub txt_Id_org_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Id_org.TextChanged
        If myGestor.ConsecutivoOrganizacion().ToString <= txt_Id_org.Text Then
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