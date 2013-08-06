Public Class Frm_Buscar_Miembro

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
        Frm_Inicio.Show()

    End Sub

    Private Sub Frm_Buscar_Miembro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet.TB_MIEMBRO' Puede moverla o quitarla según sea necesario.
        Me.TB_MIEMBROTableAdapter.Fill(Me.DataSet.TB_MIEMBRO)
        ToolTip1.IsBalloon = True

        LLENAR_GRID()

        lb_Numero.Visible = False
        txt_numero.Visible = False
        lb_Nombre.Visible = False
        txt_nombre.Visible = False

    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGV_Miembros.DoubleClick
        Try
            If DGV_Miembros.CurrentRow.Cells.Item(0).Value = Nothing Or DGV_Miembros.CurrentRow.Cells.Item(1).Value = "" Then
                MsgBox("Dato nulo", MsgBoxStyle.Information)
            Else

                Frm_Mantenimiento_Miembro.txt_id_Miembro.Text = DGV_Miembros.CurrentRow.Cells.Item(0).Value
                Frm_Mantenimiento_Miembro.txt_Num_Miembro.Text = DGV_Miembros.CurrentRow.Cells.Item(1).Value
                Frm_Mantenimiento_Miembro.lb_id_foto.Text = DGV_Miembros.CurrentRow.Cells.Item(2).Value
                Frm_Mantenimiento_Miembro.ComboBox1.SelectedItem = DGV_Miembros.CurrentRow.Cells.Item(3).Value
                Frm_Mantenimiento_Miembro.txt_id_Organizacion.Text = DGV_Miembros.CurrentRow.Cells.Item(3).Value
                Frm_Mantenimiento_Miembro.txt_Nombre.Text = DGV_Miembros.CurrentRow.Cells.Item(4).Value
                Frm_Mantenimiento_Miembro.txt_Dirrecion.Text = DGV_Miembros.CurrentRow.Cells.Item(5).Value
                Frm_Mantenimiento_Miembro.txt_Telefono.Text = DGV_Miembros.CurrentRow.Cells.Item(6).Value
                Frm_Mantenimiento_Miembro.lb_genero.Text = DGV_Miembros.CurrentRow.Cells.Item(7).Value
                Frm_Mantenimiento_Miembro.txt_Fecha.Text = DGV_Miembros.CurrentRow.Cells.Item(8).Value


                Me.Close()
                Frm_Mantenimiento_Miembro.Show()



            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LLENAR_GRID(Optional ByVal pNumero_Miembro As String = "", Optional ByVal pNombre As String = "")
        Try

            Dim miGESTOR As New DLL.cls_Gestor
            Dim myMiembro() As DLL.cls_Miembro
            DGV_Miembros.Columns.Clear()
            myMiembro = Nothing

            If (pNumero_Miembro <> "") Then
                myMiembro = miGESTOR.ConsultasMiembro(pNumero_Miembro, pNombre)
            End If


            If (pNombre <> "") Then
                myMiembro = miGESTOR.ConsultasMiembro(pNumero_Miembro, pNombre)
            End If

            If (pNombre = "" Or pNumero_Miembro = "") Then

            End If

            Dim myMiembros As DLL.cls_Miembro

            If (DGV_Miembros.RowCount = 0) Then
                DGV_Miembros.Columns.Add("ID_MIEMBRO", "ID Miembro")
                DGV_Miembros.Columns.Add("NUM_MIEMBRO", "Numero de Miembro")
                DGV_Miembros.Columns.Add("ID_FOTO", "id_foto")
                DGV_Miembros.Columns.Add("ID_ORGANIZACION", "id_organizacion")
                DGV_Miembros.Columns.Add("NOMBRE", "Nombre")
                DGV_Miembros.Columns.Add("DIRRECCION", "Dirreccion")
                DGV_Miembros.Columns.Add("TELEFONO", "Telefono")
                DGV_Miembros.Columns.Add("GENERO", "Genero")
                DGV_Miembros.Columns.Add("FECHA_NAC", "FECHA Nac")
                DGV_Miembros.Columns(4).Width = 150
                DGV_Miembros.Columns(5).Width = 150
                DGV_Miembros.Columns(0).Visible = False
                DGV_Miembros.Columns(2).Visible = False
                DGV_Miembros.Columns(3).Visible = False
                DGV_Miembros.Columns(8).Visible = False



            End If

            For Each myMiembros In myMiembro

                If (myMiembro IsNot Nothing) Then
                    DGV_Miembros.Rows.Add(myMiembros.newId_Miembro, myMiembros.newNum_Miembro, myMiembros.newLocalizacion_Foto, myMiembros.newid_Organizacion, myMiembros.newNombre, myMiembros.newDireccion, myMiembros.newTelefono, myMiembros.newGenero, myMiembros.newFecha_Nac)
                End If

            Next
        Catch ex As Exception

        End Try
    End Sub

    

    Private Sub rb_Numero_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Numero.CheckedChanged
        If rb_Numero.Checked = True Then
            lb_Numero.Visible = True
            txt_numero.Visible = True
            lb_Nombre.Visible = False
            txt_nombre.Visible = False



        Else
            lb_Numero.Visible = False
            txt_numero.Visible = False

        End If
    End Sub

    Private Sub rb_Nombre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Nombre.CheckedChanged
        If rb_Nombre.Checked = True Then
            lb_Numero.Visible = False
            txt_numero.Visible = False
            lb_Nombre.Visible = True
            txt_nombre.Visible = True



        Else
            lb_Numero.Visible = True
            txt_numero.Visible = True

        End If
    End Sub

    Private Sub txt_nombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_nombre.TextChanged
        LLENAR_GRID("", txt_nombre.Text)
    End Sub

    Private Sub txt_numero_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_numero.TextChanged
        LLENAR_GRID(txt_numero.Text, "")
    End Sub
End Class