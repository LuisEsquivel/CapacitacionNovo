Imports System.Data.SqlClient

Public Module Globales


    Public ConeccionBD As String = System.Configuration.ConfigurationManager.ConnectionStrings("CapacitacionNovo").ConnectionString


    'Public acceso As String = ""
    'Public empleadoLogueado As String = ""
    'Public usuarioYaExiste As String = ""
    'Public claveSucursalYaExiste As String = ""
    'Public activoYaExiste As String = ""
    'Public claveDeActivo As String = ""
    'Public nombreDeProducto As String = ""


    Public Enum Accion
        Consultar = 1
        Agregar = 2
        Modificar = 3
        ConsultaAdicional = 4
        Maestro_Detalle = 5
        Eliminar = 6
        Accion_Adicional = 7
        ConsultaAdicional2 = 8
        BajaDocumento = 9
        ConsultaAdicional3 = 10
        Reporte = 11
        Accion_Adicional2 = 12
        ConsultaAdicional4 = 13
        ConsultaAdicional5 = 14
    End Enum

End Module
