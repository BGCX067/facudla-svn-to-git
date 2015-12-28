Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports Business
Public Class frm_Mantenedor_cliente
    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Dim rut_cli As String = Me.txtRut.Text
        Dim nombre_cli As String = Me.txtNombre.Text
        Dim direccion_cli As String = Me.txtDireccion.Text
        Dim razon_social_cli As String = Me.txtRazonsocial.Text
        Dim telefono_cli As String = Me.txtTelefono.Text
        Dim comuna_cli As String = Me.txtComuna.Text

        If rut_cli = "" Then
            MsgBox("Debe Ingresar Rut", MsgBoxStyle.Critical, "Mantenedor Cliente")
            Exit Sub
        End If

        '===============Consulta Rut si es que existe en la Base de Datos=========================================
        Dim oConsultaCliente As Business.Cls_bs_cliente = New Business.Cls_bs_cliente
        Dim respuesta As String = oConsultaCliente.Consulta_Cliente(rut_cli)
        '===============Si Existe Envia Mensaje de Actualizacion si respuesta del Usuario es YES Actualiza los datos=====  
        If respuesta.Equals("1") Then

            If MsgBox("Rut se encuentra registrado ¿Desea Actualizar los Datos?", MsgBoxStyle.YesNo, "Mantenedor Cliente") = MsgBoxResult.Yes Then
                Dim oActualizaCliente As Business.Cls_bs_cliente = New Business.Cls_bs_cliente
                oActualizaCliente.Actualiza_Cliente(rut_cli, nombre_cli, direccion_cli, razon_social_cli, telefono_cli, comuna_cli)
                MsgBox("Actualizacion Realiza con Exito", MsgBoxStyle.Information, "Mantenedor Cliente")
                Exit Sub
            End If

        End If
        '===============Graba Informacion sobre un nuevo Cliente========================================
        Dim oIngresoCliente As Business.Cls_bs_cliente = New Business.Cls_bs_cliente
        oIngresoCliente.Ingreso_Cliente(rut_cli, nombre_cli, direccion_cli, razon_social_cli, telefono_cli, comuna_cli)

    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        End
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim rut_cli As String = Me.txtRut.Text

        Dim oConsultaClienteGrilla As Business.Cls_bs_cliente = New Business.Cls_bs_cliente
        Dim dsTabla As DataTable = oConsultaClienteGrilla.Consulta_Cliente_Grilla(rut_cli)
        Me.dgClientes.DataSource = dsTabla
        dgClientes.Refresh()

        Call LimpiarTextBox(Me)
    End Sub
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim rut_cli As String = Me.txtRut.Text

        If MsgBox("¿Desea Eliminar los Datos del Cliente:" & Me.txtRut.Text, MsgBoxStyle.YesNo, "Mantenedor Cliente") = MsgBoxResult.Yes Then
            Dim oEliminaCliente As Business.Cls_bs_cliente = New Business.Cls_bs_cliente
            oEliminaCliente.Elimina_Cliente(rut_cli)
            MsgBox("Eliminacion Realiza con Exito", MsgBoxStyle.Information, "Mantenedor Cliente")
            Exit Sub
        End If

    End Sub
    Private Sub LimpiarTextBox(ByVal ofrm As Form)
        For Each oControl As Control In ofrm.Controls
            If TypeOf oControl Is TextBox Then
                oControl.Text = ""
            End If
        Next
    End Sub
    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        Call LimpiarTextBox(Me)
    End Sub
End Class
