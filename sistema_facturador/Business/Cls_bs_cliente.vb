Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports DataAccess
Public Class Cls_bs_cliente
    Public Sub Ingreso_Cliente(ByVal rut_cli As String, _
    ByVal nombre_cli As String, ByVal direccion_cli As String, _
    ByVal razon_social_cli As String, ByVal telefono_cli As String, _
    ByVal comuna_cli As String)
        Dim oIngresoCliente As DataAccess.Cls_da_cliente = New DataAccess.Cls_da_cliente
        oIngresoCliente.Ingreso_Cliente(rut_cli, nombre_cli, direccion_cli, razon_social_cli, telefono_cli, comuna_cli)
    End Sub
    Public Function Consulta_Cliente(ByVal rut_cli As String) As String
        Dim oConsultaCliente As DataAccess.Cls_da_cliente = New DataAccess.Cls_da_cliente
        Dim respuesta As String = oConsultaCliente.Consulta_Cliente(rut_cli)
        Return respuesta
    End Function
    Public Sub Actualiza_Cliente(ByVal rut_cli As String, _
    ByVal nombre_cli As String, ByVal direccion_cli As String, _
    ByVal razon_social_cli As String, ByVal telefono_cli As String, _
    ByVal comuna_cli As String)
        Dim oActualizaCliente As DataAccess.Cls_da_cliente = New DataAccess.Cls_da_cliente
        oActualizaCliente.Actualiza_Cliente(rut_cli, nombre_cli, direccion_cli, razon_social_cli, telefono_cli, comuna_cli)
    End Sub
    Public Function Consulta_Cliente_Grilla(ByVal rut_cli As String) As DataTable
        Dim oConsultaClientegrilla As DataAccess.Cls_da_cliente = New DataAccess.Cls_da_cliente
        Dim dsTabla As DataTable = oConsultaClientegrilla.Consulta_Cliente_Grilla(rut_cli)
        Return dsTabla
    End Function
    Public Sub Elimina_Cliente(ByVal rut_cli As String)
        Dim oIngresoCliente As DataAccess.Cls_da_cliente = New DataAccess.Cls_da_cliente
        oIngresoCliente.Elimina_Cliente(rut_cli)
    End Sub
End Class
