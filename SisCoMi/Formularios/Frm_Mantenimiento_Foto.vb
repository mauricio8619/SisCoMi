Imports System.IO
Public Class Frm_Mantenimiento_Foto

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.Close()
        Frm_Inicio.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim openFD As New OpenFileDialog()

        With openFD
            .Title = "Seleccione la foto "
            .Multiselect = False
            .InitialDirectory = ""
            If .ShowDialog = Windows.Forms.DialogResult.OK Then

                PicBox_Foto.ImageLocation = .FileName
                txt_localizacion.Text = .FileName
                btn_eliminar.Enabled = True
                btn_Guardar.Enabled = True
            End If

        End With
    End Sub

    Private Sub Frm_Mantenimiento_Foto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub



    Private Sub txt_nombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        Dim SourceFile, DestinationFile As String
        SourceFile = txt_localizacion.Text
        DestinationFile = System.AppDomain.CurrentDomain.BaseDirectory
        If SourceFile.Length > 0 And DestinationFile.Length > 0 And txt_nombre.Text.Length > 0 And cb_ext.Text.Length > 0 Then
            Dim des As String = DestinationFile.Replace("SisCoMi\bin\Debug\", "Imagenes\" + txt_nombre.Text + "." + cb_ext.Text)
            FileCopy(SourceFile, des)
            btn_Guardar.Enabled = False
            MsgBox("Imagen Guardada correctamente", MsgBoxStyle.Information, Title:="SisCoMi")
        Else
            MsgBox("Todos los Espacios Son Requeridos Para Guardar la Foto", MsgBoxStyle.Critical, Title:="SisCoMi")
        End If

    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click
        Dim SourceFile As String = txt_localizacion.Text
        If SourceFile.Length > 0 Then
            File.Delete(SourceFile)
            btn_eliminar.Enabled = False
            MsgBox("Imagen Eliminada correctamente", MsgBoxStyle.Information, Title:="SisCoMi")
        Else
            MsgBox("Debe selecionar la imagen a Eliminar", MsgBoxStyle.Critical, Title:="SisCoMi")
        End If


    End Sub

    
End Class