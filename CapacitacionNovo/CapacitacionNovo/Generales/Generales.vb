Public Class Generales


    Public Shared ReadOnly Mes_de_Trabajo As Int16 = 8

    Public Shared ColorBtn As Int16 = 0

    Public Shared ReadOnly BtnImageNuevo As String = "Nuevo.jpg"
    Public Shared ReadOnly BtnImageModificar As String = "Modificar.jpg"
    Public Shared ReadOnly BtnImageGuardar As String = "Grabar.jpg"
    Public Shared ReadOnly BtnImageCancelar As String = "Cancelar.jpg"
    Public Shared ReadOnly BtnImageBuscar As String = "Buscar.jpg"
    Public Shared ReadOnly BtnImageImprimir As String = "Imprimir.jpg"
    Public Shared ReadOnly BtnImageExcel As String = "Excel.jpg"
    Public Shared ReadOnly BtnImageSalir As String = "Salir.jpg"
    Public Shared ReadOnly BtnIniciar As String = "Iniciar.jpg"
    Public Shared ReadOnly BtnBajas As String = "Bajas.jpg"
    Public Shared ReadOnly BtnBorrar As String = "Borrar.jpg"
    Public Shared ReadOnly btnRegresar As String = "Regresar.jpg"
    Public Shared ReadOnly BtnAgregar As String = "AGREGAR.jpg"

    Public Enum ColorBotones
        Naranja = 0
        Plata = 1
        Negro = 2
        Azul = 3
        Verde = 4
        Morado = 5
        AzulObscuro = 6
        Rojo = 7
        Violeta = 8
        Beige = 9
        Blanco = 10
    End Enum

    Public Enum EstadoBotones
        Inicial = 1
        Nuevo = 2
        Modificar = 3
        Buscar = 4

    End Enum

    Public Enum ReportesdeRegistros
        SELECCIONE = 0
        CONSECUTIVO_DE_REGISTRO_DE_SALIDAS = 1
        BITACORA_DE_REGISTROS = 2
        BITACORA_DE_REGISTROS_DETALLADA = 3
    End Enum

    Public Shared Function Buscar_Formularios_Activos(ByVal Formulario As Form)
        Dim FormulariosActivos As Integer
        For Each Forms As Form In Formulario.MdiChildren
            FormulariosActivos = FormulariosActivos + 1
        Next
        If FormulariosActivos > 0 Then
            Dim Opcion = MsgBox("Se encontraron Formularios Activos" + vbCrLf +
                                "¿Desea Cerrarlos?" + vbCrLf +
                                "NO SE GUARDARAN LOS CAMBIOS REALIZADOS", MsgBoxStyle.YesNo, MENSAJE_MSGBOX)
            If Opcion = MsgBoxResult.Yes Then
                Cerrar_Formularios_Activos(Formulario)
                Return False
            Else
                MsgBox("Los Formularios Deben cerrarse antes de salir del sistema", MsgBoxStyle.Information, MENSAJE_MSGBOX)
                Return True
            End If
        Else
            Return False
        End If
    End Function

    Private Shared Sub Cerrar_Formularios_Activos(ByVal Formulario As Form)
        For Each Forms As Form In Formulario.MdiChildren
            Forms.Close()
        Next
    End Sub



    Public Shared Sub ConfiguracionBotones(ByVal forma As Form, ByVal Color As ColorBotones)
        If IO.Directory.Exists(My.Application.Info.DirectoryPath & "\BOTONES\" & CInt(Color)) Then
            Dim directorio As String = My.Application.Info.DirectoryPath & "\BOTONES\" & CInt(Color) & "\"
            If forma.Controls("btnagregar") IsNot Nothing Then
                If IO.File.Exists(directorio & BtnAgregar) Then
                    CType(forma.Controls("btnagregar"), Button).Image = Bitmap.FromFile(directorio & BtnAgregar)
                End If
            End If
            If forma.Controls("btnnuevo") IsNot Nothing Then
                If IO.File.Exists(directorio & BtnImageNuevo) Then
                    CType(forma.Controls("btnnuevo"), Button).Image = Bitmap.FromFile(directorio & BtnImageNuevo)
                End If
            End If

            If forma.Controls("btnbajas") IsNot Nothing Then
                If IO.File.Exists(directorio & BtnBajas) Then
                    CType(forma.Controls("btnbajas"), Button).Image = Bitmap.FromFile(directorio & BtnBajas)
                End If
            End If

            If forma.Controls("btniniciar") IsNot Nothing Then
                If IO.File.Exists(directorio & BtnIniciar) Then
                    CType(forma.Controls("btniniciar"), Button).Image = Bitmap.FromFile(directorio & BtnIniciar)
                End If
            End If

            If forma.Controls("btnregresar") IsNot Nothing Then
                If IO.File.Exists(directorio & btnRegresar) Then
                    CType(forma.Controls("btnregresar"), Button).Image = Bitmap.FromFile(directorio & btnRegresar)
                End If
            End If

            If forma.Controls("btnBorrar") IsNot Nothing Then
                If IO.File.Exists(directorio & BtnBorrar) Then
                    CType(forma.Controls("btnBorrar"), Button).Image = Bitmap.FromFile(directorio & BtnBorrar)
                End If
            End If
            If forma.Controls("btnmodificar") IsNot Nothing Then
                If IO.File.Exists(directorio & BtnImageModificar) Then
                    CType(forma.Controls("btnmodificar"), Button).Image = Bitmap.FromFile(directorio & BtnImageModificar)
                End If
            End If
            If forma.Controls("btnguardar") IsNot Nothing Then
                If IO.File.Exists(directorio & BtnImageGuardar) Then
                    CType(forma.Controls("btnguardar"), Button).Image = Bitmap.FromFile(directorio & BtnImageGuardar)
                End If
            End If
            If forma.Controls("btncancelar") IsNot Nothing Then
                If IO.File.Exists(directorio & BtnImageCancelar) Then
                    CType(forma.Controls("btncancelar"), Button).Image = Bitmap.FromFile(directorio & BtnImageCancelar)
                End If
            End If
            If forma.Controls("btnbuscar") IsNot Nothing Then
                If IO.File.Exists(directorio & BtnImageBuscar) Then
                    CType(forma.Controls("btnbuscar"), Button).Image = Bitmap.FromFile(directorio & BtnImageBuscar)
                End If
            End If
            If forma.Controls("btnImprimir") IsNot Nothing Then
                If IO.File.Exists(directorio & BtnImageImprimir) Then
                    CType(forma.Controls("btnImprimir"), Button).Image = Bitmap.FromFile(directorio & BtnImageImprimir)
                End If
            End If
            If forma.Controls("btnexcel") IsNot Nothing Then
                If IO.File.Exists(directorio & BtnImageExcel) Then
                    CType(forma.Controls("btnexcel"), Button).Image = Bitmap.FromFile(directorio & BtnImageExcel)
                End If
            End If
            If forma.Controls("btnsalir") IsNot Nothing Then
                If IO.File.Exists(directorio & BtnImageSalir) Then
                    CType(forma.Controls("btnsalir"), Button).Image = Bitmap.FromFile(directorio & BtnImageSalir)
                End If
            End If
        End If
    End Sub

    Public Shared Sub HabilitarBotones(ByRef forma As Form, ByVal Estado As EstadoBotones)
        Select Case Estado
            Case EstadoBotones.Inicial

                If forma.Controls("btnnuevo") IsNot Nothing Then
                    CType(forma.Controls("btnnuevo"), Button).Enabled = True
                End If
                If forma.Controls("btnbajas") IsNot Nothing Then
                    CType(forma.Controls("btnbajas"), Button).Enabled = False
                End If
                If forma.Controls("btnBorrar") IsNot Nothing Then
                    CType(forma.Controls("btnBorrar"), Button).Enabled = True
                End If
                If forma.Controls("btnguardar") IsNot Nothing Then
                    CType(forma.Controls("btnguardar"), Button).Enabled = False
                End If
                If forma.Controls("btncancelar") IsNot Nothing Then
                    CType(forma.Controls("btncancelar"), Button).Enabled = False
                End If
                If forma.Controls("btnmodificar") IsNot Nothing Then
                    CType(forma.Controls("btnmodificar"), Button).Enabled = True
                End If
                If forma.Controls("btnsalir") IsNot Nothing Then
                    CType(forma.Controls("btnsalir"), Button).Enabled = True
                End If

                If forma.Controls("btnexcel") IsNot Nothing Then
                    CType(forma.Controls("btnexcel"), Button).Enabled = True
                End If
                If forma.Controls("btnbuscar") IsNot Nothing Then
                    CType(forma.Controls("btnbuscar"), Button).Enabled = True
                End If

            Case EstadoBotones.Modificar, EstadoBotones.Nuevo
                If forma.Controls("btnnuevo") IsNot Nothing Then
                    CType(forma.Controls("btnnuevo"), Button).Enabled = False
                End If
                If forma.Controls("btnBorrar") IsNot Nothing Then
                    CType(forma.Controls("btnBorrar"), Button).Enabled = False
                End If
                If forma.Controls("btnguardar") IsNot Nothing Then
                    CType(forma.Controls("btnguardar"), Button).Enabled = True
                End If
                If forma.Controls("btnmodificar") IsNot Nothing Then
                    CType(forma.Controls("btnmodificar"), Button).Enabled = False
                End If
                CType(forma.Controls("btncancelar"), Button).Enabled = True
                CType(forma.Controls("btnsalir"), Button).Enabled = False
                If forma.Controls("btnexcel") IsNot Nothing Then
                    CType(forma.Controls("btnexcel"), Button).Enabled = False
                End If
                If forma.Controls("btnbuscar") IsNot Nothing Then
                    CType(forma.Controls("btnbuscar"), Button).Enabled = False
                End If
            Case EstadoBotones.Buscar
                CType(forma.Controls("btnnuevo"), Button).Enabled = False
                CType(forma.Controls("btnguardar"), Button).Enabled = True
                If forma.Controls("btnmodificar") IsNot Nothing Then
                    CType(forma.Controls("btnmodificar"), Button).Enabled = False
                End If
                If forma.Controls("btnBorrar") IsNot Nothing Then
                    CType(forma.Controls("btnBorrar"), Button).Enabled = False
                End If
                CType(forma.Controls("btncancelar"), Button).Enabled = True
                CType(forma.Controls("btnsalir"), Button).Enabled = False
                If forma.Controls("btnexcel") IsNot Nothing Then
                    CType(forma.Controls("btnexcel"), Button).Enabled = False
                End If
                CType(forma.Controls("btnbuscar"), Button).Enabled = False
        End Select
    End Sub

    'REMOVER CERRAR EN PATALLAS

    Private Declare Function GetSystemMenu Lib "user32" (ByVal hwnd As Integer, ByVal bRevert As Integer) As Integer
    Private Declare Function RemoveMenu Lib "user32" (ByVal hMenu As Integer, ByVal nPosition As Integer, ByVal wFlags As Integer) As Integer
    Private Const SC_CLOSE = &HF060&
    Private Const MF_BYCOMMAND = &H0&

    Public Shared Function RemoveXButton(ByVal iHWND As Integer) As Integer
        Dim iSysMenu As Integer
        iSysMenu = GetSystemMenu(iHWND, False)
        Return RemoveMenu(iSysMenu, SC_CLOSE, MF_BYCOMMAND)
    End Function

    Public Shared CVE_EMPLEADO_VAR As String = "RTREVINO"
    Public Shared MENSAJE_MSGBOX As String = "Novosys"

    Public Enum ReportesdeAlmacen
        SELECCIONE = 0
        MOVIMIENTOS = 1
        EXISTENCIAS = 2
    End Enum


End Class
