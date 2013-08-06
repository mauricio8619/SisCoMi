Imports System.Data.SqlClient
Public Class Frm_Restaurar
    Private myGestor As New DLL.cls_Gestor

    Private Sub Frm_Restaurar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolTip1.IsBalloon = True
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.Close()
        Frm_Inicio.Show()

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Dim openFD As New OpenFileDialog()

        With openFD
            .Title = "Seleccionar archivos de Backup"
            .Filter = "Archivos Backup (*.bak)|*.bak"
            .RestoreDirectory = True
            .Multiselect = False
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txt_Dirrectorio.Text = .FileName
            End If

        End With
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If txt_Dirrectorio.Text <> "" Then
            If restaurar_basededatos() = True Then
                MessageBox.Show("Base de Datos Restaurada satisfactoriamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
                myGestor.agregarbitacora(myGestor.ConsecutivoBitacora().ToString, id_user, Date.Now.ToString, "Se Restauro la base de datos")
            Else
                MessageBox.Show("Error al Restaurar la Base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Seleccione la ruta del archivo de restauración", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Function restaurar_basededatos() As Boolean
        Dim sBackup As String = "USE master ALTER DATABASE SisCoMi SET SINGLE_USER WITH ROLLBACK IMMEDIATE RESTORE DATABASE SisCoMi FROM DISK = '" & Me.txt_Dirrectorio.Text & "'" & " WITH REPLACE ALTER DATABASE SisCoMi SET MULTI_USER "
        Dim conecsb As New SqlConnectionStringBuilder
        conecsb.DataSource = "MAURICIO-LAPTOP\SQLEXPRESS"
        conecsb.InitialCatalog = "master"
        conecsb.IntegratedSecurity = True
        conecsb.UserID = "sa"
        conecsb.Password = "darling22"

        Using con As New SqlConnection(conecsb.ConnectionString)
            Try
                con.Open()
                Dim cmdRestore As New SqlCommand(sBackup, con)
                cmdRestore.ExecuteNonQuery()
                restaurar_basededatos = True
            Catch ex As Exception
                restaurar_basededatos = False
                MessageBox.Show(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Function
End Class