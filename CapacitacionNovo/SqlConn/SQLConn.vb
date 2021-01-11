Imports System.Data
Imports System.Data.SqlClient

Namespace ADONet

    Public Class SQLConn

#Region "Atributos"

        Private sqlCnn As SqlConnection
        Private sqlCmd As SqlCommand
        Private sqlAdapt As SqlDataAdapter

#End Region

#Region "Propiedades"

        ''' <summary>
        ''' Propiedad de tipo string que permite leer y especificar la cadena de conexion
        ''' </summary>
        Public Property strConn() As String
            Get
                Return sqlCnn.ConnectionString
            End Get
            Set(ByVal value As String)
                sqlCnn.ConnectionString = value
            End Set
        End Property

        ''' <summary>
        ''' Propiedad de tipo CommandType que permite leer y especificar el tipo de comando a ejecutar (Procedimiento, Texto o Tabla Directa)
        ''' </summary>
        Public Property cmdType() As CommandType
            Get
                Return sqlCmd.CommandType
            End Get
            Set(ByVal value As CommandType)
                sqlCmd.CommandType = value
            End Set
        End Property

        ''' <summary>
        ''' Propiedad de tipo string que permite leer y especificar la consulta a ejecutar (Nombre del procedimiento o consulta de SQL)
        ''' </summary>
        Public Property cmdText() As String
            Get
                Return sqlCmd.CommandText
            End Get
            Set(ByVal value As String)
                sqlCmd.CommandText = value
            End Set
        End Property

        Public ReadOnly Property Parametros() As SqlParameterCollection
            Get
                Return sqlCmd.Parameters
            End Get
        End Property

#End Region

#Region "Constructor"

        ''' <summary>
        ''' Constructor de la clase
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub New()

            sqlCnn = New SqlConnection()
            sqlCmd = New SqlCommand()
            sqlCmd.Connection = sqlCnn

        End Sub

        ''' <summary>
        ''' Constructor de la clase
        ''' </summary>
        ''' <param name="strConexion">Permite especifica la cadena de conexion de servidor SQL</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal strConexion As String)

            sqlCnn = New SqlConnection()
            sqlCnn.ConnectionString = strConexion
            sqlCmd = New SqlCommand()
            sqlCmd.Connection = sqlCnn

        End Sub

#End Region

#Region "Métodos y Funciones"

        ''' <summary>
        ''' Permite agregar un nuevo parámetro al commando
        ''' </summary>
        ''' <param name="name">Nombre del parametro</param>
        ''' <param name="value">Valor que se le asignará al parámetro</param>
        ''' <param name="type">Tipo de dato de sql al que corresponde el parámetro</param>
        ''' <param name="size">Tamaño de parametro</param>
        ''' <param name="direction">Direccion del parámetro (Entrada, Salida o Entrada/Salida)</param>
        ''' <remarks></remarks>
        Public Sub AddParam(ByVal name As String, ByVal value As Object, ByVal type As SqlDbType, ByVal size As Integer, ByVal direction As ParameterDirection)

            Dim param As New SqlParameter
            param.ParameterName = name
            param.Value = value
            param.SqlDbType = type
            param.Size = size
            param.Direction = direction

            sqlCmd.Parameters.Add(param)

        End Sub

        ''' <summary>
        ''' Permite agregar un nuevo parámetro al comando
        ''' </summary>
        ''' <param name="name">Nombre del parámetro</param>
        ''' <param name="value">Valor del parámetro</param>
        ''' <param name="type">Tipo de dato sql al que corresponde el parámetro</param>
        ''' <remarks></remarks>
        Public Sub AddParam(ByVal name As String, ByVal value As Object, ByVal type As SqlDbType)

            Dim param As New SqlParameter
            param.ParameterName = name
            param.Value = value
            param.SqlDbType = type

            sqlCmd.Parameters.Add(param)

        End Sub


        ''' <summary>
        ''' Permite agregar un nuevo parámetro al comando
        ''' </summary>
        ''' <param name="name">Nombre del parámetro</param>
        ''' <param name="value">Valor del parámetro</param>
        ''' <param name="type">Tipo de dato sql al que corresponde el parámetro</param>
        ''' <remarks></remarks>
        Public Sub AddParamDecimal(ByVal name As String, ByVal value As Object, ByVal type As SqlDbType, ByVal presicion As Byte, ByVal scale As Byte, Optional ByVal direction As ParameterDirection = ParameterDirection.Input)

            Dim param As New SqlParameter
            param.ParameterName = name
            param.Value = value
            param.SqlDbType = type
            param.Precision = presicion
            param.Scale = scale
            param.Direction = direction
            sqlCmd.Parameters.Add(param)

        End Sub

        ''' <summary>
        ''' Ejecuta el comando y retorna el número de registros afectados
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ExecuteNonQuery() As Integer

            Try
                sqlCnn.Open()
                Return sqlCmd.ExecuteNonQuery
            Catch ex As Exception
                Throw ex
            Finally
                CloseConnection()
            End Try

        End Function

        ''' <summary>
        ''' Ejecuta el comando y retorna el valor del primer renglon y primera columna de la consulta
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ExecuteScalar() As Object

            Try
                sqlCnn.Open()
                Return sqlCmd.ExecuteScalar
            Catch ex As Exception
                Throw ex
            Finally
                CloseConnection()
            End Try

        End Function

        ''' <summary>
        ''' Permite llenar un conjunto de datos de acuerdo al comando a ejecutar
        ''' </summary>
        ''' <param name="ds">Conjunto de Datos a llenar</param>
        ''' <remarks></remarks>
        Public Sub FillDs(ByRef ds As DataSet)

            Try
                sqlAdapt = New SqlDataAdapter(sqlCmd)
                sqlCnn.Open()
                sqlAdapt.Fill(ds)
            Catch ex As Exception
                Throw ex
            Finally
                CloseConnection()
            End Try

        End Sub

        ''' <summary>
        ''' Permite llenar un conjunto de datos de acuerdo al comando a ejecutar
        ''' </summary>
        ''' <param name="ds">Conjunto de Datos a llenar</param>
        ''' <remarks></remarks>
        Public Sub FillDs(ByRef ds As DataSet, ByVal tablesName() As String)

            Try
                sqlAdapt = New SqlDataAdapter(sqlCmd)
                If ds.Tables.Count > 0 Then
                    Dim tableName As String = "Table"
                    For i = 0 To tablesName.Length - 1
                        sqlAdapt.TableMappings.Add(tableName, tablesName(i))
                        tableName = "Table" + (i + 1).ToString
                    Next
                End If
                sqlCnn.Open()
                sqlAdapt.Fill(ds)
            Catch ex As Exception
                Throw ex
            Finally
                CloseConnection()
            End Try
        End Sub

        ''' <summary>
        ''' Permite llenar una tabla de datos de acuerdo al comando a ejecutar
        ''' </summary>
        ''' <param name="dt">Tabla de datos a llenar</param>
        ''' <remarks></remarks>
        Public Sub FillDt(ByRef dt As DataTable)
            Try
                sqlAdapt = New SqlDataAdapter(sqlCmd)
                sqlCnn.Open()
                sqlAdapt.Fill(dt)
            Catch ex As Exception
                Throw ex
            Finally
                CloseConnection()
            End Try

        End Sub

        ''' <summary>
        ''' Ejecuta el comando y regresa los datos en un SQLDataReader
        ''' </summary>
        ''' <returns>SQLDataReader</returns>
        ''' <remarks></remarks>
        Public Function SQLReader() As SqlDataReader

            Try
                sqlCnn.Open()
                Return sqlCmd.ExecuteReader()
            Catch ex As Exception
                Throw ex
            End Try

        End Function

        ''' <summary>
        ''' Verfiica si la conexión ya esta cerrada en caso contrario cerrarla
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub CloseConnection()

            If Not sqlCnn.State = ConnectionState.Closed Then
                sqlCnn.Close()
            End If

        End Sub

#End Region

    End Class

End Namespace
