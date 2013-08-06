Public Class Frm_Listado_Organizaciones
    Dim i As Integer
    Private Sub Frm_Listado_Organizaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TB_MIEMBROTableAdapter.Fill(Me.DataSet.TB_MIEMBRO)
        Me.TB_ORGANIZACIONTableAdapter.Fill(Me.DataSet.TB_ORGANIZACION)
        ToolTip1.IsBalloon = True
        Cb_Organizacion.Text = ""

        LLENAR_GRID(0)
        If Cb_Organizacion.Text = "" Then
            cantidad.Text = "0"

        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.Close()
        Frm_Inicio.Show()

    End Sub

    Private Sub LLENAR_GRID(ByVal pNumero As Integer, Optional ByVal val As Integer = 0)
        Try

            Dim miGESTOR As New DLL.cls_Gestor
            Dim myMiembro() As DLL.cls_Miembro
            DGV_Miembros.Columns.Clear()
            myMiembro = Nothing

            If (pNumero <> 0) Then
                myMiembro = miGESTOR.ConsultasOrganizacion(pNumero, 0)
            End If


            If (pNumero = 0) Then

            End If

            Dim myMiembros As DLL.cls_Miembro

            If (DGV_Miembros.RowCount = 0) Then
                DGV_Miembros.Columns.Add("NUM_MIEMBRO", "Numero de Miembro")
                DGV_Miembros.Columns.Add("NOMBRE", "Nombre")
                DGV_Miembros.Columns.Add("DIRRECCION", "Dirreccion")
                DGV_Miembros.Columns(0).Width = 145
                DGV_Miembros.Columns(1).Width = 180
                DGV_Miembros.Columns(2).Width = 275





            End If

            For Each myMiembros In myMiembro

                If (myMiembro IsNot Nothing) Then
                    DGV_Miembros.Rows.Add(myMiembros.newNum_Miembro, myMiembros.newNombre, myMiembros.newDireccion)
                End If

            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Cb_Organizacion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_Organizacion.TextChanged
        LLENAR_GRID(Cb_Organizacion.SelectedValue)
        cantidad.Text = DGV_Miembros.RowCount - 1

    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        PrintDocument1.Print()


    End Sub

    Private Sub printDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Definimos la fuente que vamos a usar para imprimir
        ' en este caso Arial de 10
        Dim printFont As System.Drawing.Font = New Font("Arial", 16)
        Dim topMargin As Double = e.MarginBounds.Top
        Dim yPos As Double = 0
        Dim linesPerPage As Double = 0
        Dim count As Integer = 0
        Dim texto As String = ""
        Dim colum1 As String = ""
        Dim colum2 As String = ""
        Dim colum3 As String = ""
        Dim colum4 As String = ""

        Dim row As System.Windows.Forms.DataGridViewRow

        ' Calculamos el número de líneas que caben en cada página
        linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics)

        e.Graphics.DrawString("Lista de Miembros por organizacion", New Font("ARIAL", 16, FontStyle.Bold), System.Drawing.Brushes.Black, 230, 10)
        e.Graphics.DrawString(Date.Today.ToShortDateString, New Font("ARIAL", 12, FontStyle.Regular), System.Drawing.Brushes.Black, 700, 15)
        e.Graphics.DrawString(Cb_Organizacion.Text, New Font("ARIAL", 14, FontStyle.Bold), System.Drawing.Brushes.Black, 300, 30)

        ' Imprimimos las cabeceras
        Dim header As DataGridViewHeaderCell
        For Each column As DataGridViewColumn In DGV_Miembros.Columns
            header = column.HeaderCell
            texto += vbTab + header.FormattedValue.ToString()
        Next

        yPos = topMargin + (count * printFont.GetHeight(e.Graphics))
        'e.Graphics.DrawString(texto, printFont, System.Drawing.Brushes.Black, 10, yPos)
        e.Graphics.DrawString("Numero de miembro                     Nombre                       Direccion  ", New Font("ARIAL", 12, FontStyle.Bold), System.Drawing.Brushes.Black, 50, yPos)
        ' Dejamos una línea de separación
        count += 2

        ' Recorremos las filas del DataGridView hasta que llegemos
        ' a las líneas que nos caben en cada página o al final del grid.
        While count < linesPerPage AndAlso i < DGV_Miembros.Rows.Count
            row = DGV_Miembros.Rows(i)
            texto = ""
            colum1 = ""
            colum2 = ""
            colum3 = ""
            colum4 = ""
            For Each celda As System.Windows.Forms.DataGridViewCell In row.Cells
                'Comprobamos que la celda tenga algún valor, en caso de 
                'permitir añadir filas esto es muy importante
                If celda.Value IsNot Nothing Then
                    'If texto = "" Then
                    '    texto += celda.Value.ToString()
                    'Else
                    '    texto += vbTab + vbTab + celda.Value.ToString()
                    'End If
                    If colum1 = "" Then
                        colum1 = celda.Value.ToString()
                    ElseIf colum1 <> "" And colum2 = "" Then
                        colum2 = celda.Value.ToString()
                    ElseIf colum1 <> "" And colum2 <> "" And colum3 = "" Then
                        colum3 = celda.Value.ToString()
                    Else
                        colum4 = celda.Value.ToString()
                    End If


                End If
            Next

            ' Calculamos la posición en la que se escribe la línea
            yPos = topMargin + (count * printFont.GetHeight(e.Graphics))


            ' Escribimos la línea con el objeto Graphics
            ' e.Graphics.DrawString(texto, printFont, System.Drawing.Brushes.Black, 10, yPos)
            e.Graphics.DrawString(colum1, New Font("ARIAL", 12, FontStyle.Regular), System.Drawing.Brushes.Black, 80, yPos)
            e.Graphics.DrawString(colum2, New Font("ARIAL", 12, FontStyle.Regular), System.Drawing.Brushes.Black, 300, yPos)
            e.Graphics.DrawString(colum3, New Font("ARIAL", 12, FontStyle.Regular), System.Drawing.Brushes.Black, 480, yPos)
            ' Incrementamos los contadores
            count += 1
            i += 1
        End While

        ' Una vez fuera del bucle comprobamos si nos quedan más filas
        ' por imprimir, si quedan saldrán en la siguente página
        If i < DGV_Miembros.Rows.Count Then
            e.HasMorePages = True
        Else

            e.Graphics.DrawString("Cantidad de Miembros " + cantidad.Text, printFont, System.Drawing.Brushes.Black, 470, yPos + 50)
            ' si llegamos al final, se establece HasMorePages a
            ' false para que se acabe la impresión
            e.HasMorePages = False
            ' Es necesario poner el contador a 0 porque, por ejemplo si se hace
            ' una impresión desde PrintPreviewDialog, se vuelve disparar este
            ' evento como si fuese la primera vez, y si i está con el valor de la
            ' última fila del grid no se imprime nada
            i = 0
        End If
    End Sub


End Class


