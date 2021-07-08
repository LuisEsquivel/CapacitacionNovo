Partial Class DSProductos
    Partial Public Class TBLPRODUCTOSDataTable
        Private Sub TBLPRODUCTOSDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.CVE_PRODUCTOS_ALTA_VARColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class
End Class
