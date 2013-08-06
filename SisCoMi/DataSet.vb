Partial Class DataSet
    Partial Class TB_USUARIODataTable

        Private Sub TB_USUARIODataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.CONTRASENAColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

    Partial Class TB_ORGANIZACIONDataTable

        Private Sub TB_ORGANIZACIONDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.NOMBRE_ORGANIZACIONColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

End Class

Namespace DataSetTableAdapters
    
    Partial Public Class TB_BITACORATableAdapter
    End Class
End Namespace
