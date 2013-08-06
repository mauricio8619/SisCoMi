Public Class frm_Datos_Miembro

    Private fechaMinima As New DateTime(1920, 1, 1)
    Private fechaMaxima As DateTime = DateTime.Now
    Private myGestor As New DLL.cls_Gestor


    Private Sub frm_Datos_Miembro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet.TB_ORGANIZACION' Puede moverla o quitarla según sea necesario.
        Me.TB_ORGANIZACIONTableAdapter.Fill(Me.DataSet.TB_ORGANIZACION)
        Me.txt_id_Miembro.Text = myGestor.ConsecutivoMiembro().ToString
    End Sub

    Private Sub txt_Fecha_baut_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)


        Try
            fechaMinima = txt_Fecha.Text
            fechaMinima = fechaMinima.AddYears(8)
            ' Obtenemos el texto del control

            Dim fecha As DateTime = CDate(txt_Fecha_baut.Text)

            If (fecha < fechaMinima) OrElse (fecha > fechaMaxima) Then
                MessageBox.Show("La Fecha no es valida debe ingresar una fecha almenos 8 años mayor que la fecha de nacimiento")
                txt_Fecha_baut.Text = ""
                'e.Cancel = True
            End If

        Catch ex As Exception
            'e.Cancel = True
            MessageBox.Show("El formato de Fecha es erróneo ingrese la fecha en formato dd/mm/aaaa")
            txt_Fecha_baut.Text = ""

        End Try
    End Sub

    Private Sub txt_Fecha_Conf_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)

        Try
            fechaMinima = txt_Fecha_baut.Text
            ' Obtenemos el texto del control
            '
            Dim fecha As DateTime = CDate(txt_Fecha_Conf.Text)

            If (fecha < fechaMinima) OrElse (fecha > fechaMaxima) Then
                MessageBox.Show("La Fecha no es valida debe ingresar una fecha mayor a la fecha de bautismo")
                txt_Fecha_Conf.Text = ""
                'e.Cancel = True
            End If

        Catch ex As Exception
            'e.Cancel = True
            MessageBox.Show("El formato de Fecha es erróneo ingrese la fecha en formato dd/mm/aaaa")
            txt_Fecha_Conf.Text = ""

        End Try
    End Sub


    Private Sub txt_Fecha_Sella_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
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
                    txt_Fecha_Sella.Text = ""
                    'e.Cancel = True
                End If

            Catch ex As Exception
                'e.Cancel = True
                MessageBox.Show("El formato de Fecha es erróneo ingrese la fecha en formato dd/mm/aaaa")
                txt_Fecha_Sella.Text = ""

            End Try
        End If
    End Sub

    Private Sub txt_Fecha_inves_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
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
                    txt_Fecha_inves.Text = ""
                    'e.Cancel = True
                End If

            Catch ex As Exception
                'e.Cancel = True
                MessageBox.Show("El formato de Fecha es erróneo ingrese la fecha en formato dd/mm/aaaa")
                txt_Fecha_inves.Text = ""

            End Try
        End If
    End Sub

    Private Sub txt_Num_Miembro_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If txt_Num_Miembro.Text.Length > 11 Then
        Else
            MessageBox.Show("El numero de miembro debe contener 11 numero o letras el formato debe de ser similar a este: 020-0256-368A")
            txt_Num_Miembro.Text = ""
        End If
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub txt_Fecha_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Fecha.Validating
        Try
            ' Obtenemos el texto del control
            '
            Dim fecha As DateTime = CDate(txt_Fecha.Text)

            If (fecha < fechaMinima) OrElse (fecha > fechaMaxima) Then
                MessageBox.Show("La Fecha no es valida debe ingresar una fecha de nacimiento valida")
                txt_Fecha.Text = ""
                'e.Cancel = True
            End If

        Catch ex As Exception
            'e.Cancel = True
            MessageBox.Show("El formato de Fecha es erróneo ingrese la fecha en formato dd/mm/aaaa")
            txt_Fecha.Text = ""

        End Try
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub txt_Fecha_baut_Validating_1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Fecha_baut.Validating
        Try
            fechaMinima = CDate(txt_Fecha.Text)
            fechaMinima = fechaMinima.AddYears(8)
            ' Obtenemos el texto del control

            Dim fecha As DateTime = CDate(txt_Fecha_baut.Text)

            If (fecha < fechaMinima) OrElse (fecha > fechaMaxima) Then
                MessageBox.Show("La Fecha no es valida debe ingresar una fecha almenos 8 años mayor que la fecha de nacimiento")
                txt_Fecha_baut.Text = ""
                'e.Cancel = True
            End If

        Catch ex As Exception
            'e.Cancel = True
            MessageBox.Show("El formato de Fecha es erróneo ingrese la fecha en formato dd/mm/aaaa")
            txt_Fecha_baut.Text = ""

        End Try
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

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub txt_Fecha_Conf_Validating_1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Fecha_Conf.Validating
        Try
            fechaMinima = txt_Fecha_baut.Text
            ' Obtenemos el texto del control
            '
            Dim fecha As DateTime = CDate(txt_Fecha_Conf.Text)

            If (fecha < fechaMinima) OrElse (fecha > fechaMaxima) Then
                MessageBox.Show("La Fecha no es valida debe ingresar una fecha mayor a la fecha de bautismo")
                txt_Fecha_Conf.Text = ""
                'e.Cancel = True
            End If

        Catch ex As Exception
            'e.Cancel = True
            MessageBox.Show("El formato de Fecha es erróneo ingrese la fecha en formato dd/mm/aaaa")
            txt_Fecha_Conf.Text = ""

        End Try
    End Sub

    Private Sub txt_Num_Miembro_Validating_1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Num_Miembro.Validating
        If txt_Num_Miembro.Text.Length > 11 Then
        Else
            MessageBox.Show("El numero de miembro debe contener 11 numero o letras el formato debe de ser similar a este: 020-0256-368A")
            txt_Num_Miembro.Text = ""
        End If
    End Sub

    Private Sub txt_Fecha_inves_Validating_1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Fecha_inves.Validating
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
                    txt_Fecha_inves.Text = ""
                    'e.Cancel = True
                End If

            Catch ex As Exception
                'e.Cancel = True
                MessageBox.Show("El formato de Fecha es erróneo ingrese la fecha en formato dd/mm/aaaa")
                txt_Fecha_inves.Text = ""

            End Try
        End If
    End Sub

    Private Sub txt_Fecha_Sella_Validating_1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_Fecha_Sella.Validating
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
                    txt_Fecha_Sella.Text = ""
                    'e.Cancel = True
                End If

            Catch ex As Exception
                'e.Cancel = True
                MessageBox.Show("El formato de Fecha es erróneo ingrese la fecha en formato dd/mm/aaaa")
                txt_Fecha_Sella.Text = ""

            End Try
        End If
    End Sub

    Private Sub ComboBox1_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedValueChanged
        Me.txt_id_Organizacion.Text = Me.ComboBox1.SelectedValue
        cargarImagen(Me.ComboBox1.SelectedValue)
    End Sub
    Private Sub cargarImagen(Optional ByVal id_organizacion As Integer = 0)
        Try

            Dim miGESTOR As New DLL.cls_Gestor
            Dim myOrganizacion() As DLL.Cls_organizacion
            myOrganizacion = Nothing



            If (id_organizacion <> 0) Then
                myOrganizacion = miGESTOR.ConsultasImagen(id_organizacion)
            End If



            If (id_organizacion = 0) Then

            End If
            Dim myOrganizaciones As DLL.Cls_organizacion



            For Each myOrganizaciones In myOrganizacion
                If (myOrganizaciones IsNot Nothing) Then
                    'obtener valores
                    Dim DestinationFile = System.AppDomain.CurrentDomain.BaseDirectory
                    Dim des As String = DestinationFile.Replace("SisCoMi\bin\Debug\", "Imagenes\")
                    PicBox_Imagen.ImageLocation = des + myOrganizaciones.newImagen



                End If

            Next


        Catch ex As Exception

        End Try
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

    Private Sub PictureBox4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Dim Aviso As String
        Aviso = MsgBox("¡Asegurese de guardar todos los datos!", MsgBoxStyle.YesNo, Title:="¿Desea salir de esta Pantalla?")

        If Aviso = 6 Then
            Me.Close()
            Frm_Inicio.Show()

        End If
    End Sub
   

    Private Sub TabPage3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage3.Enter
        PictureBox2.Enabled = True
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        insertarDatos()
    End Sub
    Sub insertarDatos()
        Dim fechaInves As DateTime
        Dim fechasella As DateTime
        Try


            Dim CorrectoMiembro As Boolean
            'validacion de campos
            If (txt_Nombre.Text <> "" And txt_Dirrecion.Text <> "") Then
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
                CorrectoMiembro = myGestor.InsertarDatos(txt_Num_Miembro.Text, txt_Fecha_baut.Text, txt_Fecha_Conf.Text, fechasella, fechaInves, txt_llamamiento_act.Text, txt_comentarios.Text)

                If CorrectoMiembro = True Then
                    insertar()

                Else
                    MsgBox("Los datos de miembro no se guardaron verifique que no existan", MsgBoxStyle.Exclamation, Title:="SisCoMi")
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

    Sub insertar()
        Try


            Dim CorrectoMiembro As Boolean
            'validacion de campos
            If (txt_Nombre.Text <> "" And txt_Fecha_baut.Text <> "" And txt_Num_Miembro.Text <> "") Then

                'asignacion de valores
                CorrectoMiembro = myGestor.InsertarMiembro(txt_id_Miembro.Text, txt_Num_Miembro.Text, txt_id_Miembro.Text, Me.txt_id_Organizacion.Text, txt_Nombre.Text, txt_Dirrecion.Text, txt_Telefono.Text, lb_genero.Text, txt_Fecha.Text)

                If CorrectoMiembro = True Then
                    insertarFoto()
                    myGestor.agregarbitacora(myGestor.ConsecutivoBitacora().ToString, id_user, Date.Now.ToString, "Se Creo el Miembro " & txt_Nombre.Text)


                Else
                    'MsgBox("Los datos no se guardaron verifique que los datos no hayan sido creados", MsgBoxStyle.Exclamation, Title:="SisCoMi")
                End If
            Else
                MsgBox("por favor llene todos los espacios requeridos", MsgBoxStyle.Critical, Title:="SisCoMi")

            End If
        Catch ex As Exception
            MsgBox("Los datos personales no se guardaron verifique que los datos no hayan sido creados y que todos los espacios se hayan completado", MsgBoxStyle.Exclamation, Title:="SisCoMi")
        End Try

    End Sub

    Sub insertarFoto()

        Dim CorrectoMiembro As Boolean
        'validacion de campos
        If (lb_id_foto.Text <> "") Then

            'asignacion de valores
            CorrectoMiembro = myGestor.InsertarFoto(txt_id_Miembro.Text, lb_id_foto.Text)

            If CorrectoMiembro = True Then

                MsgBox("Datos almacenados correctamente", MsgBoxStyle.Information, Title:="SisCoMi")
                Me.Close()
                Frm_Inicio.Show()



            Else
                MsgBox("Los datos no se guardaron verifique que no existan", MsgBoxStyle.Exclamation, Title:="SisCoMi")
            End If
        Else
            MsgBox("por favor llene todos los espacios requeridos", MsgBoxStyle.Critical, Title:="SisCoMi")

        End If


    End Sub

End Class