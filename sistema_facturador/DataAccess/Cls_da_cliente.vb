Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class Cls_da_cliente
    Public Sub Ingreso_Cliente(ByVal rut_cli As String, _
    ByVal nombre_cli As String, ByVal direccion_cli As String, _
    ByVal razon_social_cli As String, ByVal telefono_cli As String, _
    ByVal comuna_cli As String)
        Dim Cmd As New SqlCommand
        Try
            With Cmd
                .Connection = New SqlConnection(ConfigurationManager.AppSettings.Get("CADENA_CONEXION").ToString)
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_i_cliente"
                .Parameters.Add("@rut_cli", SqlDbType.VarChar, 11) : .Parameters(0).Value = rut_cli
                .Parameters.Add("@nombre_cli", SqlDbType.VarChar, 30) : .Parameters(1).Value = nombre_cli
                .Parameters.Add("@direccion_cli", SqlDbType.VarChar, 20) : .Parameters(2).Value = direccion_cli
                .Parameters.Add("@razon_social_cli", SqlDbType.VarChar, 30) : .Parameters(3).Value = razon_social_cli
                .Parameters.Add("@telefono_cli", SqlDbType.VarChar, 10) : .Parameters(4).Value = telefono_cli
                .Parameters.Add("@comuna_cli", SqlDbType.VarChar, 15) : .Parameters(5).Value = comuna_cli
                .Connection.Open()
                .ExecuteNonQuery()
                .Connection.Close()
            End With
        Catch ex As Exception
            If (Cmd.Connection.State = ConnectionState.Open) Then
                Cmd.Connection.Close()
            End If
        End Try
    End Sub
    Public Function Consulta_Cliente(ByVal rut_cli As String) As String

        Dim myConnection As New SqlConnection(ConfigurationManager.AppSettings.Get("CADENA_CONEXION").ToString)
        Dim myCommand As New SqlCommand
        Dim SqlAdapter As New SqlDataAdapter
        Dim Parameters() As SqlParameter
        Dim ds As New DataSet
        Dim respuesta As String = "0"

        myConnection.Open()
        myCommand.Connection = myConnection
        myCommand.CommandType = CommandType.StoredProcedure
        myCommand.CommandText = "sp_c_cliente"
        ReDim Parameters(0)
        Parameters(0) = New SqlParameter("@rut_cli", rut_cli)
        For X As Integer = 0 To Parameters.Length - 1
            myCommand.Parameters.Add(Parameters(X))
        Next
        SqlAdapter.SelectCommand = myCommand
        SqlAdapter.Fill(ds)
        If ds.Tables.Count > 0 Then
            respuesta = ds.Tables(0).Rows(0).Item(0).ToString
        End If
        myConnection.Close()
        myConnection.Dispose()
        myConnection = Nothing

        Return respuesta

    End Function
    Public Sub Actualiza_Cliente(ByVal rut_cli As String, _
        ByVal nombre_cli As String, ByVal direccion_cli As String, _
        ByVal razon_social_cli As String, ByVal telefono_cli As String, _
        ByVal comuna_cli As String)
        Dim Cmd As New SqlCommand
        Try
            With Cmd
                .Connection = New SqlConnection(ConfigurationManager.AppSettings.Get("CADENA_CONEXION").ToString)
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_u_cliente"
                .Parameters.Add("@rut_cli", SqlDbType.VarChar, 11) : .Parameters(0).Value = rut_cli
                .Parameters.Add("@nombre_cli", SqlDbType.VarChar, 30) : .Parameters(1).Value = nombre_cli
                .Parameters.Add("@direccion_cli", SqlDbType.VarChar, 20) : .Parameters(2).Value = direccion_cli
                .Parameters.Add("@razon_social_cli", SqlDbType.VarChar, 30) : .Parameters(3).Value = razon_social_cli
                .Parameters.Add("@telefono_cli", SqlDbType.VarChar, 10) : .Parameters(4).Value = telefono_cli
                .Parameters.Add("@comuna_cli", SqlDbType.VarChar, 15) : .Parameters(5).Value = comuna_cli
                .Connection.Open()
                .ExecuteNonQuery()
                .Connection.Close()
            End With
        Catch ex As Exception
            If (Cmd.Connection.State = ConnectionState.Open) Then
                Cmd.Connection.Close()
            End If
        End Try
    End Sub
    Public Function Consulta_Cliente_Grilla(ByVal rut_cli As String) As DataTable

        Dim myConnection As New SqlConnection(ConfigurationManager.AppSettings.Get("CADENA_CONEXION").ToString)
        Dim myCommand As New SqlCommand
        Dim SqlAdapter As New SqlDataAdapter
        Dim Parameters() As SqlParameter
        Dim ds As New DataSet
        Dim dsTabla As DataTable = Nothing

        myConnection.Open()
        myCommand.Connection = myConnection
        myCommand.CommandType = CommandType.StoredProcedure
        myCommand.CommandText = "sp_c_cliente_grilla"


        ReDim Parameters(0)
        Parameters(0) = New SqlParameter("@rut_cli", rut_cli)
        For X As Integer = 0 To Parameters.Length - 1
            myCommand.Parameters.Add(Parameters(X))
        Next

        SqlAdapter.SelectCommand = myCommand
        SqlAdapter.Fill(ds)
        If ds.Tables.Count > 0 Then
            dsTabla = ds.Tables(0)
        End If
        myConnection.Close()
        myConnection.Dispose()
        myConnection = Nothing

        Return dsTabla

    End Function
    Public Sub Elimina_Cliente(ByVal rut_cli As String)
        Dim Cmd As New SqlCommand
        Try
            With Cmd
                .Connection = New SqlConnection(ConfigurationManager.AppSettings.Get("CADENA_CONEXION").ToString)
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_d_cliente"
                .Parameters.Add("@rut_cli", SqlDbType.VarChar, 11) : .Parameters(0).Value = rut_cli
                .Connection.Open()
                .ExecuteNonQuery()
                .Connection.Close()
            End With
        Catch ex As Exception
            If (Cmd.Connection.State = ConnectionState.Open) Then
                Cmd.Connection.Close()
            End If
        End Try
    End Sub
End Class
