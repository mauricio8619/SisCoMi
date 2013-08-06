Imports System.Text
Imports System.Data.SqlClient
Public Class Frm_Respaldar
    Private myGestor As New DLL.cls_Gestor

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.Close()
        Frm_Inicio.Show()
    End Sub

    Private Sub Frm_Respaldar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolTip1.IsBalloon = True
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim Directorio As New FolderBrowserDialog

        If Directorio.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.txt_Dirrectorio.Text = Directorio.SelectedPath
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If txt_Dirrectorio.Text <> "" Then
            If txt_nombre.Text <> "" Then
                If txt_Descripcion.Text <> "" Then
                    If crear_backup() = True Then
                        MessageBox.Show("Backup creado satisfactoriamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        myGestor.agregarbitacora(myGestor.ConsecutivoBitacora().ToString, id_user, Date.Now.ToString, "Se creo un back up de la base de datos")

                    Else
                        MessageBox.Show("Error al crear el Backup", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Ingrese una descripcion del Backup", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show("Ingrese el nombre del Backup", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            MessageBox.Show("Seleccione la ruta donde se creara el Backup", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Function crear_backup() As Boolean
        Dim conecsb As New SqlConnectionStringBuilder
        conecsb.DataSource = "MAURICIO-LAPTOP\SQLEXPRESS"
        conecsb.InitialCatalog = "SisCoMi"
        conecsb.IntegratedSecurity = True

        If txt_Dirrectorio.Text.Length <> 3 Then
            txt_Dirrectorio.Text = txt_Dirrectorio.Text + "\" + txt_nombre.Text + ".bak"
        Else
            txt_Dirrectorio.Text = txt_Dirrectorio.Text + txt_nombre.Text + ".bak"
        End If

        Using con As New SqlConnection(conecsb.ConnectionString)
            Try
                con.Open()
                Dim sCmd As New StringBuilder

                sCmd.Append("BACKUP DATABASE SisCoMi TO  DISK = N'" + txt_Dirrectorio.Text + "' ")
                sCmd.Append("WITH DESCRIPTION = N'" + txt_Descripcion.Text + "', NOFORMAT, NOINIT, ")
                sCmd.Append("NAME = N'" + txt_nombre.Text + "', SKIP, NOREWIND, NOUNLOAD,  STATS = 10")
                Dim cmd As New SqlCommand(sCmd.ToString, con)
                cmd.ExecuteNonQuery()
                crear_backup = True
            Catch ex As Exception
                crear_backup = False
                MessageBox.Show(ex.Message)
            Finally
                con.Close()
            End Try
        End Using

    End Function
End Class