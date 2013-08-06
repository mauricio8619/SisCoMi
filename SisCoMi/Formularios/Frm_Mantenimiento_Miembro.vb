Public Class Frm_Mantenimiento_Miembro
    Private myGestor As New DLL.cls_Gestor
    Private myMiembro As New DLL.cls_Miembro
    Private fechaMinima As New DateTime(1920, 1, 1)
    Private fechaMaxima As DateTime = DateTime.Now

    
    
   
    
    Private Sub Frm_Mantenimiento_Miembro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet.TB_ORGANIZACION' Puede moverla o quitarla según sea necesario.
        Me.TB_ORGANIZACIONTableAdapter.Fill(Me.DataSet.TB_ORGANIZACION)
        ToolTip1.IsBalloon = True
        If txt_id_Miembro.Text = "" Then
            Me.txt_id_Miembro.Text = myGestor.ConsecutivoMiembro().ToString
            ComboBox1.Text = ""

        Else
            cargarDatosMiembro(txt_Num_Miembro.Text)
            cargarfoto(txt_id_Miembro.Text)
            ComboBox1.SelectedValue = txt_id_Organizacion.Text
        End If

        If lb_genero.Text = "Hombre" Then
            Hombre.Checked = True
        ElseIf lb_genero.Text = "Mujer" Then
            mujer.Checked = True

        End If

        If txt_Fecha_inves.Text = "01/01/1900" Then
            txt_Fecha_inves.Text = "00/00/0000"
        End If

        If txt_Fecha_Sella.Text = "01/01/1900" Then
            txt_Fecha_Sella.Text = "00/00/0000"
        End If

        If permit = "Secretario" Then
            PictureBox4.Enabled = False

        End If


    End Sub
    Private Sub cargarfoto(Optional ByVal id_Miembro As Integer = 0)
        Try

            Dim miGESTOR As New DLL.cls_Gestor
            Dim myfoto() As DLL.Cls_Foto

            myfoto = Nothing

            If (id_Miembro <> 0) Then
                myfoto = miGESTOR.Consultasfoto(id_Miembro)
            End If



            If (id_Miembro = 0) Then

            End If

            Dim myfotos As DLL.Cls_Foto



            For Each myfotos In myfoto
                If (myfotos IsNot Nothing) Then
                    'obtener valores
                    Dim DestinationFile = System.AppDomain.CurrentDomain.BaseDirectory
                    Dim des As String = DestinationFile.Replace("SisCoMi\bin\Debug\", "Imagenes\")
                    PicBox_Foto.ImageLocation = des + myfotos.newLocalizacion
                    




                End If

            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cargarDatosMiembro(Optional ByVal Num_Miembro As String = "")
        Try

            Dim miGESTOR As New DLL.cls_Gestor
            Dim myDato() As DLL.Cls_Datos

            myDato = Nothing

            If (Num_Miembro <> "") Then
                myDato = miGESTOR.ConsultasDatos(Num_Miembro)
            End If



            If (Num_Miembro = "") Then

            End If

            Dim myDatos As DLL.Cls_Datos

           

            For Each myDatos In myDato
                If (myDatos IsNot Nothing) Then
                    'obtener valores
                    txt_Fecha_baut.Text = myDatos.newFecha_Baut
                    txt_Fecha_Conf.Text = myDatos.newFecha_Conf
                    txt_Fecha_inves.Text = myDatos.newFecha_Inv
                    txt_Fecha_Sella.Text = myDatos.newFecha_Sell
                    txt_comentarios.Text = myDatos.newComentarios
                    txt_llamamiento_act.Text = myDatos.newLlamamiento_Act




                End If

            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.Close()
        Frm_Inicio.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        insertarDatos()


    End Sub

    Sub insertar()
        Try

        
            Dim CorrectoMiembro As Boolean
            'validacion de campos
            If (Me.txt_Nombre.Text <> "" And Me.txt_Fecha_baut.Text <> "" And Me.txt_Num_Miembro.Text <> "") Then

                'asignacion de valores
                CorrectoMiembro = myGestor.InsertarMiembro(Me.txt_id_Miembro.Text, Me.txt_Num_Miembro.Text, Me.txt_id_Miembro.Text, Me.txt_id_Organizacion.Text, Me.txt_Nombre.Text, Me.txt_Dirrecion.Text, Me.txt_Telefono.Text, Me.lb_genero.Text, Me.txt_Fecha.Text)

                If CorrectoMiembro = True Then
                    insertarFoto()
                    myGestor.agregarbitacora(myGestor.ConsecutivoBitacora().ToString, id_user, Date.Now.ToString, "Se Creo el Miembro " & Me.txt_Nombre.Text)


                Else
                    'MsgBox("Los datos no se guardaron verifique que los datos no hayan sido creados", MsgBoxStyle.Exclamation, Title:="SisCoMi")
                End If
            Else
                MsgBox("por favor llene todos los espacios requeridos", MsgBoxStyle.Critical, Title:="SisCoMi")

            End If
        Catch ex As Exception
            MsgBox("Los datos no se guardaron verifique que los datos no hayan sido creados y que todos los espacios se hayan completado", MsgBoxStyle.Exclamation, Title:="SisCoMi")
        End Try

    End Sub
    Sub insertarFoto()

        Dim CorrectoMiembro As Boolean
        'validacion de campos
        If (Me.lb_id_foto.Text <> "") Then

            'asignacion de valores
            CorrectoMiembro = myGestor.InsertarFoto(Me.txt_id_Miembro.Text, Me.lb_id_foto.Text)

            If CorrectoMiembro = True Then

                MsgBox("Datos almacenados correctamente", MsgBoxStyle.Information, Title:="SisCoMi")

            Else
                MsgBox("Los datos no se guardaron verifique que no existan", MsgBoxStyle.Exclamation, Title:="SisCoMi")
            End If
        Else
            MsgBox("por favor llene todos los espacios requeridos", MsgBoxStyle.Critical, Title:="SisCoMi")

        End If


    End Sub
    Sub insertarDatos()
        Dim fechaInves As DateTime
        Dim fechasella As DateTime
        Try


            Dim CorrectoMiembro As Boolean
            'validacion de campos
            If (Me.txt_Nombre.Text <> "" And Me.txt_Dirrecion.Text <> "") Then
                If txt_Fecha_inves.Text = "00/00/0000" Then
                    fechaInves = Nothing
                Else
                    fechaInves = txt_Fecha_inves.Text

                End If


                If txt_Fecha_Sella.Text = "00/00/0000" Then
                    fechasella = Nothing
                Else
                    fechasella = txt_Fecha_Sella.Text

                End If

                'asignacion de valores
                CorrectoMiembro = myGestor.InsertarDatos(Me.txt_Num_Miembro.Text, Me.txt_Fecha_baut.Text, Me.txt_Fecha_Conf.Text, fechasella, fechaInves, Me.txt_llamamiento_act.Text, Me.txt_comentarios.Text)

                If CorrectoMiembro = True Then
                    insertar()

                Else
                    MsgBox("Los datos no se guardaron verifique que no existan", MsgBoxStyle.Exclamation, Title:="SisCoMi")
                End If
            Else
                MsgBox("por favor llene todos los espacios requeridos", MsgBoxStyle.Critical, Title:="SisCoMi")

            End If
        Catch ex As Exception
            If txt_Fecha_inves.Text = "00/00/0000" Then
            Else
                MsgBox("Los datos no se guardaron verifique si completo todos los espacios", MsgBoxStyle.Exclamation, Title:="SisCoMi")
            End If

        End Try


    End Sub
    Sub modificar()
        Try

       
            Dim CorrectoMiembro As Boolean
            'Validacion
            If (Me.txt_Nombre.Text <> "" And Me.txt_Fecha_baut.Text <> "" And Me.txt_Num_Miembro.Text <> "") Then


                'Asignar valores
                CorrectoMiembro = myGestor.ModificarMiembro(Me.txt_id_Miembro.Text, Me.txt_Num_Miembro.Text, Me.txt_id_Miembro.Text, Me.txt_id_Organizacion.Text, Me.txt_Nombre.Text, Me.txt_Dirrecion.Text, Me.txt_Telefono.Text, Me.lb_genero.Text, Me.txt_Fecha.Text)


                If CorrectoMiembro = True Then

                    modificarDatos()
                    myGestor.agregarbitacora(myGestor.ConsecutivoBitacora().ToString, id_user, Date.Now.ToString, "Se Modifico el Miembro " & Me.txt_Nombre.Text)
                Else
                    MsgBox("Los datos no se guardaron verifique que no existan", MsgBoxStyle.Exclamation, Title:="SisCoMi")
                End If
            Else
                MsgBox("por favor llene todos los espacios requeridos", MsgBoxStyle.Critical, Title:="SisCoMi")

            End If
        Catch ex As Exception
            MsgBox("Los datos no se guardaron verifique si completo todos los espacios", MsgBoxStyle.Exclamation, Title:="SisCoMi")
        End Try

    End Sub

    Sub modificarDatos()

        Dim fechaInves As DateTime
        Dim fechasella As DateTime
        Try
            Dim CorrectoMiembro As Boolean
            'Validacion
            If (Me.txt_Nombre.Text <> "" And Me.txt_Fecha_baut.Text <> "" And Me.txt_Num_Miembro.Text <> "") Then

                If txt_Fecha_inves.Text = "00/00/0000" Then
                    fechaInves = Nothing
                Else
                    fechaInves = txt_Fecha_inves.Text

                End If


                If txt_Fecha_Sella.Text = "00/00/0000" Then
                    fechasella = Nothing
                Else
                    fechasella = txt_Fecha_Sella.Text

                End If


                'Asignar valores
                CorrectoMiembro = myGestor.ModificarDatos(Me.txt_Num_Miembro.Text, Me.txt_Fecha_baut.Text, Me.txt_Fecha_Conf.Text, fechasella, fechaInves, Me.txt_llamamiento_act.Text, Me.txt_comentarios.Text)

                If CorrectoMiembro = True Then
                    'myGestor.agregarbitacora(myGestor.ConsecutivoBitacora().ToString, Frm_Inicio.lb_User.Text, Date.Now.ToString, "Se Modifico el Usuario  " & Me.tx_User.Text)
                Else
                    MsgBox("Los datos no se guardaron verifique que no existan", MsgBoxStyle.Exclamation, Title:="SisCoMi")
                End If
            Else
                MsgBox("por favor llene todos los espacios requeridos", MsgBoxStyle.Critical, Title:="SisCoMi")

            End If
        Catch ex As Exception
            MsgBox("Los datos no se guardaron verifique si completo todos los espacios", MsgBoxStyle.Exclamation, Title:="SisCoMi")
        End Try

    End Sub

    'Funcion eliminar
    Sub Eliminar()

        Dim CorrectoMiembro As Boolean
        'validacion
        If (Me.txt_Nombre.Text <> "" And Me.txt_Fecha_baut.Text <> "" And Me.txt_Num_Miembro.Text <> "") Then

            'Asignar datos
            CorrectoMiembro = myGestor.EliminarMiembro(Me.txt_id_Miembro.Text)

            If CorrectoMiembro = True Then
                EliminarDatos()
                MsgBox("Datos Eliminados correctamente", MsgBoxStyle.Information, Title:="SisCoMI")
                myGestor.agregarbitacora(myGestor.ConsecutivoBitacora().ToString, id_user, Date.Now.ToString, "Se Elimino el Miembro " & Me.txt_Nombre.Text)
            Else
                'MsgBox("Los datos no se Eliminaron verifique que  existan", MsgBoxStyle.Exclamation, Title:="SisCoMi")
            End If
        Else
            MsgBox("por favor llene todos los espacios requeridos", MsgBoxStyle.Critical, Title:="SisCoMI")

        End If


    End Sub

    Sub EliminarDatos()

        Dim fechaInves As DateTime
        Dim fechasella As DateTime

        Dim CorrectoMiembro As Boolean
        'validacion
        If (Me.txt_Nombre.Text <> "" And Me.txt_Fecha_baut.Text <> "" And Me.txt_Num_Miembro.Text <> "") Then
            If txt_Fecha_inves.Text = "00/00/0000" Then
                fechaInves = Nothing
            Else
                fechaInves = txt_Fecha_inves.Text

            End If


            If txt_Fecha_Sella.Text = "00/00/0000" Then
                fechasella = Nothing
            Else
                fechasella = txt_Fecha_Sella.Text

            End If
            'Asignar datos
            CorrectoMiembro = myGestor.EliminarDatos(Me.txt_Num_Miembro.Text, Me.txt_Fecha_baut.Text, Me.txt_Fecha_Conf.Text, fechasella, fechaInves, Me.txt_llamamiento_act.Text, Me.txt_comentarios.Text)

            If CorrectoMiembro = True Then

            Else
                MsgBox("Los datos no se Eliminaron verifique que  existan", MsgBoxStyle.Exclamation, Title:="SisCoMi")
            End If
        Else
            MsgBox("por favor llene todos los espacios requeridos", MsgBoxStyle.Critical, Title:="SisCoMI")

        End If


    End Sub
    Sub Eliminarfoto()

        Dim CorrectoMiembro As Boolean
        'validacion
        If (Me.txt_Nombre.Text <> "" And Me.txt_Fecha_baut.Text <> "" And Me.txt_Num_Miembro.Text <> "") Then

            'Asignar datos
            CorrectoMiembro = myGestor.EliminarFoto(Me.txt_id_Miembro.Text)

            If CorrectoMiembro = True Then

            Else
                MsgBox("Los datos no se guardaron verifique que no existan", MsgBoxStyle.Exclamation, Title:="SisCoMi")
            End If
        Else
            MsgBox("por favor llene todos los espacios requeridos", MsgBoxStyle.Critical, Title:="SisCoMI")

        End If


    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        modificar()
        Eliminarfoto()
        insertarFoto()

    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Eliminar()
        Eliminarfoto()

    End Sub

    Private Sub PicBox_Foto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicBox_Foto.Click
        Dim openFD As New OpenFileDialog()

        With openFD
            Dim DestinationFile = System.AppDomain.CurrentDomain.BaseDirectory
            Dim des As String = DestinationFile.Replace("SisCoMi\bin\Debug\", "Imagenes\")
            .Title = "Seleccione la foto del miembro"
            .Multiselect = False
            .InitialDirectory = des
            If .ShowDialog = Windows.Forms.DialogResult.OK Then

                PicBox_Foto.ImageLocation = .FileName
                lb_id_foto.Text = .SafeFileName
            End If

        End With
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub txt_Fecha_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Fecha.Validating


        Try
            ' Obtenemos el texto del control
            '
            Dim fecha As DateTime = CDate(txt_Fecha.Text)

            If (fecha < fechaMinima) OrElse (fecha > fechaMaxima) Then
                MessageBox.Show("La Fecha no es valida")
                'e.Cancel = True
            End If

        Catch ex As Exception
            'e.Cancel = True
            MessageBox.Show("El formato de Fecha es erróneo ingrese la fecha en formato dd/mm/aaaa")
            txt_Fecha.Text = ""

        End Try
    End Sub

    Private Sub txt_Fecha_baut_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Fecha_baut.Validating


        Try
            fechaMinima = txt_Fecha.Text
            fechaMinima = fechaMinima.AddYears(8)
            ' Obtenemos el texto del control
            '
            Dim fecha As DateTime = CDate(txt_Fecha_baut.Text)

            If (fecha < fechaMinima) OrElse (fecha > fechaMaxima) Then
                MessageBox.Show("La Fecha no es valida debe ingresar una fecha almenos 8 años mayor que la fecha de nacimiento")
                'e.Cancel = True
            End If

        Catch ex As Exception
            'e.Cancel = True
            MessageBox.Show("El formato de Fecha es erróneo ingrese la fecha en formato dd/mm/aaaa")
            txt_Fecha_baut.Text = ""

        End Try
    End Sub

    Private Sub txt_Fecha_Conf_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Fecha_Conf.Validating

        Try
            fechaMinima = txt_Fecha_baut.Text
            ' Obtenemos el texto del control
            '
            Dim fecha As DateTime = CDate(txt_Fecha_Conf.Text)

            If (fecha < fechaMinima) OrElse (fecha > fechaMaxima) Then
                MessageBox.Show("La Fecha no es valida debe ingresar una fecha mayor a la fecha de bautismo")
                'e.Cancel = True
            End If

        Catch ex As Exception
            'e.Cancel = True
            MessageBox.Show("El formato de Fecha es erróneo ingrese la fecha en formato dd/mm/aaaa")
            txt_Fecha_Conf.Text = ""

        End Try
    End Sub

    Private Sub txt_Fecha_Sella_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Fecha_Sella.Validating
        If txt_Fecha_Sella.Text = "00/00/0000" Then
            txt_Fecha_Sella.Text = "00/00/0000"
        Else

            Try
                fechaMinima = txt_Fecha_inves.Text()
                ' Obtenemos el texto del control
                '
                Dim fecha As DateTime = CDate(txt_Fecha_Sella.Text)

                If (fecha < fechaMinima) OrElse (fecha > fechaMaxima) Then
                    MessageBox.Show("La Fecha no es valida debe ingresar una fecha mayor ala fecha de investidura")
                    'e.Cancel = True
                End If

            Catch ex As Exception
                'e.Cancel = True
                MessageBox.Show("El formato de Fecha es erróneo ingrese la fecha en formato dd/mm/aaaa")
                txt_Fecha_Sella.Text = ""

            End Try
        End If
    End Sub

    Private Sub txt_Fecha_inves_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Fecha_inves.Validating
        If txt_Fecha_inves.Text = "00/00/0000" Then
            txt_Fecha_inves.Text = "00/00/0000"

        Else

            fechaMinima = txt_Fecha_baut.Text
            fechaMinima = fechaMinima.AddYears(1)
            Try
                ' Obtenemos el texto del control
                '
                Dim fecha As DateTime = CDate(txt_Fecha_inves.Text)

                If (fecha < fechaMinima) OrElse (fecha > fechaMaxima) Then
                    MessageBox.Show("La Fecha no es valida debe ingresar una fecha al menos 1 año mayor que la fecha de bautismo")
                    'e.Cancel = True
                End If

            Catch ex As Exception
                'e.Cancel = True
                MessageBox.Show("El formato de Fecha es erróneo ingrese la fecha en formato dd/mm/aaaa")
                txt_Fecha_inves.Text = ""

            End Try
        End If
    End Sub

    Private Sub txt_Num_Miembro_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Num_Miembro.Validating
        If txt_Num_Miembro.Text.Length > 11 Then
        Else
            MessageBox.Show("El numero de miembro debe contener 11 numero o letras el formato debe de ser similar a este: 020-0256-368A")
        End If
    End Sub


    Private Sub txt_Nombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Nombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Hombre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hombre.CheckedChanged
        If Hombre.Checked = True Then
            lb_genero.Text = "Hombre"
        Else
            lb_genero.Text = "Mujer"
        End If


    End Sub

    Private Sub mujer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mujer.CheckedChanged
        If mujer.Checked = True Then
            lb_genero.Text = "Mujer"
        Else
            lb_genero.Text = "Hombre"
        End If
    End Sub

  
  
End Class