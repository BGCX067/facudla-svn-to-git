<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Mantenedor_cliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Mantenedor_cliente))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.lblRut = New System.Windows.Forms.Label
        Me.txtRut = New System.Windows.Forms.TextBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtDireccion = New System.Windows.Forms.TextBox
        Me.txtRazonsocial = New System.Windows.Forms.TextBox
        Me.txtTelefono = New System.Windows.Forms.TextBox
        Me.txtComuna = New System.Windows.Forms.TextBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.lblDireccion = New System.Windows.Forms.Label
        Me.lblRazonsocial = New System.Windows.Forms.Label
        Me.lblTelefono = New System.Windows.Forms.Label
        Me.lblComuna = New System.Windows.Forms.Label
        Me.btnGrabar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.dgClientes = New System.Windows.Forms.DataGridView
        Me.rut_cli = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nombre_cli = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.direccion_cli = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.razon_social_cli = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.telefono_cli = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.comuna_cli = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnBuscar = New System.Windows.Forms.Button
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRut
        '
        Me.lblRut.AutoSize = True
        Me.lblRut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRut.Location = New System.Drawing.Point(12, 9)
        Me.lblRut.Name = "lblRut"
        Me.lblRut.Size = New System.Drawing.Size(31, 13)
        Me.lblRut.TabIndex = 0
        Me.lblRut.Text = "Rut:"
        '
        'txtRut
        '
        Me.txtRut.Location = New System.Drawing.Point(101, 6)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(100, 20)
        Me.txtRut.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(101, 32)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(321, 20)
        Me.txtNombre.TabIndex = 2
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(101, 58)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(321, 20)
        Me.txtDireccion.TabIndex = 3
        '
        'txtRazonsocial
        '
        Me.txtRazonsocial.Location = New System.Drawing.Point(101, 84)
        Me.txtRazonsocial.Name = "txtRazonsocial"
        Me.txtRazonsocial.Size = New System.Drawing.Size(321, 20)
        Me.txtRazonsocial.TabIndex = 4
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(101, 110)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono.TabIndex = 5
        '
        'txtComuna
        '
        Me.txtComuna.Location = New System.Drawing.Point(101, 136)
        Me.txtComuna.Name = "txtComuna"
        Me.txtComuna.Size = New System.Drawing.Size(100, 20)
        Me.txtComuna.TabIndex = 6
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(12, 35)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(54, 13)
        Me.lblNombre.TabIndex = 7
        Me.lblNombre.Text = "Nombre:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(12, 61)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(65, 13)
        Me.lblDireccion.TabIndex = 8
        Me.lblDireccion.Text = "Direccion:"
        '
        'lblRazonsocial
        '
        Me.lblRazonsocial.AutoSize = True
        Me.lblRazonsocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazonsocial.Location = New System.Drawing.Point(12, 87)
        Me.lblRazonsocial.Name = "lblRazonsocial"
        Me.lblRazonsocial.Size = New System.Drawing.Size(86, 13)
        Me.lblRazonsocial.TabIndex = 9
        Me.lblRazonsocial.Text = "Razon Social:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(12, 113)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(61, 13)
        Me.lblTelefono.TabIndex = 10
        Me.lblTelefono.Text = "Telefono:"
        '
        'lblComuna
        '
        Me.lblComuna.AutoSize = True
        Me.lblComuna.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComuna.Location = New System.Drawing.Point(12, 139)
        Me.lblComuna.Name = "lblComuna"
        Me.lblComuna.Size = New System.Drawing.Size(56, 13)
        Me.lblComuna.TabIndex = 11
        Me.lblComuna.Text = "Comuna:"
        '
        'btnGrabar
        '
        Me.btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), System.Drawing.Image)
        Me.btnGrabar.Location = New System.Drawing.Point(524, 130)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(30, 26)
        Me.btnGrabar.TabIndex = 12
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(628, 130)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(26, 26)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.Location = New System.Drawing.Point(560, 130)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(28, 26)
        Me.btnLimpiar.TabIndex = 14
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'dgClientes
        '
        Me.dgClientes.AllowUserToAddRows = False
        Me.dgClientes.AllowUserToDeleteRows = False
        Me.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.rut_cli, Me.nombre_cli, Me.direccion_cli, Me.razon_social_cli, Me.telefono_cli, Me.comuna_cli})
        Me.dgClientes.Location = New System.Drawing.Point(12, 162)
        Me.dgClientes.Name = "dgClientes"
        Me.dgClientes.ReadOnly = True
        Me.dgClientes.Size = New System.Drawing.Size(644, 150)
        Me.dgClientes.TabIndex = 16
        '
        'rut_cli
        '
        Me.rut_cli.DataPropertyName = "rut_cli"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rut_cli.DefaultCellStyle = DataGridViewCellStyle1
        Me.rut_cli.HeaderText = "Rut "
        Me.rut_cli.Name = "rut_cli"
        Me.rut_cli.ReadOnly = True
        '
        'nombre_cli
        '
        Me.nombre_cli.DataPropertyName = "nombre_cli"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre_cli.DefaultCellStyle = DataGridViewCellStyle2
        Me.nombre_cli.HeaderText = "Nombre"
        Me.nombre_cli.Name = "nombre_cli"
        Me.nombre_cli.ReadOnly = True
        '
        'direccion_cli
        '
        Me.direccion_cli.DataPropertyName = "direccion_cli"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.direccion_cli.DefaultCellStyle = DataGridViewCellStyle3
        Me.direccion_cli.HeaderText = "Dirección"
        Me.direccion_cli.Name = "direccion_cli"
        Me.direccion_cli.ReadOnly = True
        '
        'razon_social_cli
        '
        Me.razon_social_cli.DataPropertyName = "razon_social_cli"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.razon_social_cli.DefaultCellStyle = DataGridViewCellStyle4
        Me.razon_social_cli.HeaderText = "Razon Social"
        Me.razon_social_cli.Name = "razon_social_cli"
        Me.razon_social_cli.ReadOnly = True
        '
        'telefono_cli
        '
        Me.telefono_cli.DataPropertyName = "telefono_cli"
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telefono_cli.DefaultCellStyle = DataGridViewCellStyle5
        Me.telefono_cli.HeaderText = "Telefono"
        Me.telefono_cli.Name = "telefono_cli"
        Me.telefono_cli.ReadOnly = True
        '
        'comuna_cli
        '
        Me.comuna_cli.DataPropertyName = "comuna_cli"
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comuna_cli.DefaultCellStyle = DataGridViewCellStyle6
        Me.comuna_cli.HeaderText = "Comuna"
        Me.comuna_cli.Name = "comuna_cli"
        Me.comuna_cli.ReadOnly = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.Location = New System.Drawing.Point(594, 130)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(28, 26)
        Me.btnEliminar.TabIndex = 17
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.AccessibleName = ""
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(490, 130)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(28, 26)
        Me.btnBuscar.TabIndex = 15
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'frm_Mantenedor_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(664, 323)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.dgClientes)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.lblComuna)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblRazonsocial)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtComuna)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtRazonsocial)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtRut)
        Me.Controls.Add(Me.lblRut)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Mantenedor_cliente"
        Me.Text = "Mantenedor Cliente"
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRut As System.Windows.Forms.Label
    Friend WithEvents txtRut As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtRazonsocial As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtComuna As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents lblRazonsocial As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents lblComuna As System.Windows.Forms.Label
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents dgClientes As System.Windows.Forms.DataGridView
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents rut_cli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_cli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents direccion_cli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents razon_social_cli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telefono_cli As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comuna_cli As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
