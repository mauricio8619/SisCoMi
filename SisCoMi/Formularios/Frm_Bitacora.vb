Public Class Frm_Bitacora

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.Close()

    End Sub

    Private Sub Frm_Bitacora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.TB_USUARIOTableAdapter.Fill(Me.DataSet.TB_USUARIO)
        lb_Username.Visible = False
        cbx_Username.Visible = False

        lb_Placa.Visible = False
        dtp_Fecha.Visible = False

        LLENAR_GRID(0, Nothing)

    End Sub

    Private Sub rb_xUsuario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_xUsuario.CheckedChanged
        If rb_xUsuario.Checked = True Then
            lb_Username.Visible = True
            cbx_Username.Visible = True
            lb_Placa.Visible = False
            dtp_Fecha.Visible = False



        Else
            lb_Username.Visible = False
            cbx_Username.Visible = False

        End If
    End Sub

    Private Sub rb_xFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_xFecha.CheckedChanged
        If rb_xFecha.Checked = True Then

            lb_Placa.Visible = True
            dtp_Fecha.Visible = True
            lb_Username.Visible = False
            cbx_Username.Visible = False


        Else
            lb_Placa.Visible = False
            dtp_Fecha.Visible = False
            lb_Username.Visible = True
            cbx_Username.Visible = True

        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If cbx_Username.Visible = True Then
            If cbx_Username.Text = "" Then
                MsgBox("Debe seleccionar un usuario", MsgBoxStyle.Information)
            Else
                LLENAR_GRID(cbx_Username.SelectedValue, Nothing)
            End If
        ElseIf dtp_Fecha.Visible = True Then
            LLENAR_GRID(0, dtp_Fecha.Text)
        End If
    End Sub

    Private Sub LLENAR_GRID(ByVal pNumero As Integer, ByVal pfecha As Date)
        Try

            Dim miGESTOR As New DLL.cls_Gestor
            Dim myBitacoras() As DLL.cls_Bitacora
            DVG_Facturas.Columns.Clear()
            myBitacoras = Nothing

            If (pNumero <> 0) Then
                myBitacoras = miGESTOR.Consultasbitacoras(pNumero, Nothing)
            End If

            If (pfecha <> Nothing) Then
                myBitacoras = miGESTOR.Consultasbitacoras(0, pfecha)
            End If

            If (pNumero = 0 And pfecha = Nothing) Then
                myBitacoras = miGESTOR.Consultasbitacoras(0, Nothing)
            End If

            Dim myBitacora As DLL.cls_Bitacora

            If (DVG_Facturas.RowCount = 0) Then
                DVG_Facturas.Columns.Add("ID_BITACORA", "Numero del Cambio")
                DVG_Facturas.Columns.Add("Id_USUARIO", "Usuario del cambio")
                DVG_Facturas.Columns.Add("FECHA", "Fecha")
                DVG_Facturas.Columns.Add("CAMBIO", "Cambio")
                DVG_Facturas.Columns(0).Width = 50
                DVG_Facturas.Columns(1).Width = 50
                DVG_Facturas.Columns(2).Width = 120




            End If

            For Each myBitacora In myBitacoras

                If (myBitacora IsNot Nothing) Then
                    DVG_Facturas.Rows.Add(myBitacora.newid_bitacora, myBitacora.newid_usuario.newUsername, myBitacora.newfecha, myBitacora.newaccion)
                End If

            Next
        Catch ex As Exception

        End Try
    End Sub
End Class