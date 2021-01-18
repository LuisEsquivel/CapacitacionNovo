Partial Class DsColores
    Partial Public Class TBLCOLORESDataTable
        Private Sub TBLCOLORESDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.NOMBRE_VARColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class
End Class

Namespace DsColoresTableAdapters

    Partial Public Class TBLCOLORESTableAdapter
    End Class
End Namespace
