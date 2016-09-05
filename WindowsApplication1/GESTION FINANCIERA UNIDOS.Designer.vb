<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Menú = New System.Windows.Forms.MenuStrip()
        Me.PERSONASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarNuevaPersonaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarPersonaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarRegistroPersonaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FINANZASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarIngresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarGastosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INVENTARIOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarProductoNuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PROYECTOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarNuevoProyectoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarDatosProyectoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarProyectoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VincularVoluntariosAProyectoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DEPARTAMENTOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoDepartamentiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarDepartamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarDepartamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btningresar = New System.Windows.Forms.Button()
        Me.txtcedula = New System.Windows.Forms.TextBox()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.btnsalirprograma = New System.Windows.Forms.Button()
        Me.Menú.SuspendLayout()
        Me.SuspendLayout()
        '
        'Menú
        '
        Me.Menú.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PERSONASToolStripMenuItem, Me.FINANZASToolStripMenuItem, Me.INVENTARIOSToolStripMenuItem, Me.PROYECTOSToolStripMenuItem, Me.DEPARTAMENTOSToolStripMenuItem})
        Me.Menú.Location = New System.Drawing.Point(0, 0)
        Me.Menú.Name = "Menú"
        Me.Menú.Size = New System.Drawing.Size(760, 24)
        Me.Menú.TabIndex = 0
        Me.Menú.Text = "Menú"
        Me.Menú.Visible = False
        '
        'PERSONASToolStripMenuItem
        '
        Me.PERSONASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarNuevaPersonaToolStripMenuItem, Me.ModificarPersonaToolStripMenuItem, Me.EliminarRegistroPersonaToolStripMenuItem})
        Me.PERSONASToolStripMenuItem.Name = "PERSONASToolStripMenuItem"
        Me.PERSONASToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.PERSONASToolStripMenuItem.Text = "PERSONAS"
        '
        'IngresarNuevaPersonaToolStripMenuItem
        '
        Me.IngresarNuevaPersonaToolStripMenuItem.Name = "IngresarNuevaPersonaToolStripMenuItem"
        Me.IngresarNuevaPersonaToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.IngresarNuevaPersonaToolStripMenuItem.Text = "Ingresar nueva persona"
        '
        'ModificarPersonaToolStripMenuItem
        '
        Me.ModificarPersonaToolStripMenuItem.Name = "ModificarPersonaToolStripMenuItem"
        Me.ModificarPersonaToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.ModificarPersonaToolStripMenuItem.Text = "Modificar persona"
        '
        'EliminarRegistroPersonaToolStripMenuItem
        '
        Me.EliminarRegistroPersonaToolStripMenuItem.Name = "EliminarRegistroPersonaToolStripMenuItem"
        Me.EliminarRegistroPersonaToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.EliminarRegistroPersonaToolStripMenuItem.Text = "Eliminar registro persona"
        '
        'FINANZASToolStripMenuItem
        '
        Me.FINANZASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarIngresosToolStripMenuItem, Me.RegistrarGastosToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.FINANZASToolStripMenuItem.Name = "FINANZASToolStripMenuItem"
        Me.FINANZASToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.FINANZASToolStripMenuItem.Text = "FINANZAS"
        '
        'RegistrarIngresosToolStripMenuItem
        '
        Me.RegistrarIngresosToolStripMenuItem.Name = "RegistrarIngresosToolStripMenuItem"
        Me.RegistrarIngresosToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.RegistrarIngresosToolStripMenuItem.Text = "Registrar ingresos"
        '
        'RegistrarGastosToolStripMenuItem
        '
        Me.RegistrarGastosToolStripMenuItem.Name = "RegistrarGastosToolStripMenuItem"
        Me.RegistrarGastosToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.RegistrarGastosToolStripMenuItem.Text = "Registrar gastos"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'INVENTARIOSToolStripMenuItem
        '
        Me.INVENTARIOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarProductoToolStripMenuItem, Me.VentasToolStripMenuItem})
        Me.INVENTARIOSToolStripMenuItem.Name = "INVENTARIOSToolStripMenuItem"
        Me.INVENTARIOSToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.INVENTARIOSToolStripMenuItem.Text = "INVENTARIO"
        '
        'RegistrarProductoToolStripMenuItem
        '
        Me.RegistrarProductoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarProductoNuevoToolStripMenuItem, Me.ModificarProductoToolStripMenuItem, Me.EliminarProductoToolStripMenuItem})
        Me.RegistrarProductoToolStripMenuItem.Name = "RegistrarProductoToolStripMenuItem"
        Me.RegistrarProductoToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.RegistrarProductoToolStripMenuItem.Text = "Productos"
        '
        'RegistrarProductoNuevoToolStripMenuItem
        '
        Me.RegistrarProductoNuevoToolStripMenuItem.Name = "RegistrarProductoNuevoToolStripMenuItem"
        Me.RegistrarProductoNuevoToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.RegistrarProductoNuevoToolStripMenuItem.Text = "Registrar producto nuevo"
        '
        'ModificarProductoToolStripMenuItem
        '
        Me.ModificarProductoToolStripMenuItem.Name = "ModificarProductoToolStripMenuItem"
        Me.ModificarProductoToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.ModificarProductoToolStripMenuItem.Text = "Modificar producto"
        '
        'EliminarProductoToolStripMenuItem
        '
        Me.EliminarProductoToolStripMenuItem.Name = "EliminarProductoToolStripMenuItem"
        Me.EliminarProductoToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.EliminarProductoToolStripMenuItem.Text = "Eliminar producto"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.VentasToolStripMenuItem.Text = "Ingreso y salida de producto"
        '
        'PROYECTOSToolStripMenuItem
        '
        Me.PROYECTOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarNuevoProyectoToolStripMenuItem, Me.ModificarDatosProyectoToolStripMenuItem, Me.EliminarProyectoToolStripMenuItem, Me.VincularVoluntariosAProyectoToolStripMenuItem})
        Me.PROYECTOSToolStripMenuItem.Name = "PROYECTOSToolStripMenuItem"
        Me.PROYECTOSToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.PROYECTOSToolStripMenuItem.Text = "PROYECTOS"
        '
        'IngresarNuevoProyectoToolStripMenuItem
        '
        Me.IngresarNuevoProyectoToolStripMenuItem.Name = "IngresarNuevoProyectoToolStripMenuItem"
        Me.IngresarNuevoProyectoToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.IngresarNuevoProyectoToolStripMenuItem.Text = "Ingresar nuevo proyecto"
        '
        'ModificarDatosProyectoToolStripMenuItem
        '
        Me.ModificarDatosProyectoToolStripMenuItem.Name = "ModificarDatosProyectoToolStripMenuItem"
        Me.ModificarDatosProyectoToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.ModificarDatosProyectoToolStripMenuItem.Text = "Modificar datos proyecto"
        '
        'EliminarProyectoToolStripMenuItem
        '
        Me.EliminarProyectoToolStripMenuItem.Name = "EliminarProyectoToolStripMenuItem"
        Me.EliminarProyectoToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.EliminarProyectoToolStripMenuItem.Text = "Eliminar proyecto"
        '
        'VincularVoluntariosAProyectoToolStripMenuItem
        '
        Me.VincularVoluntariosAProyectoToolStripMenuItem.Name = "VincularVoluntariosAProyectoToolStripMenuItem"
        Me.VincularVoluntariosAProyectoToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.VincularVoluntariosAProyectoToolStripMenuItem.Text = "Vincular voluntarios a proyecto"
        '
        'DEPARTAMENTOSToolStripMenuItem
        '
        Me.DEPARTAMENTOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoDepartamentiToolStripMenuItem, Me.ModificarDepartamentosToolStripMenuItem, Me.EliminarDepartamentoToolStripMenuItem})
        Me.DEPARTAMENTOSToolStripMenuItem.Name = "DEPARTAMENTOSToolStripMenuItem"
        Me.DEPARTAMENTOSToolStripMenuItem.Size = New System.Drawing.Size(114, 20)
        Me.DEPARTAMENTOSToolStripMenuItem.Text = "DEPARTAMENTOS"
        '
        'NuevoDepartamentiToolStripMenuItem
        '
        Me.NuevoDepartamentiToolStripMenuItem.Name = "NuevoDepartamentiToolStripMenuItem"
        Me.NuevoDepartamentiToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.NuevoDepartamentiToolStripMenuItem.Text = "Nuevo departamento"
        '
        'ModificarDepartamentosToolStripMenuItem
        '
        Me.ModificarDepartamentosToolStripMenuItem.Name = "ModificarDepartamentosToolStripMenuItem"
        Me.ModificarDepartamentosToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.ModificarDepartamentosToolStripMenuItem.Text = "Modificar departamentos"
        '
        'EliminarDepartamentoToolStripMenuItem
        '
        Me.EliminarDepartamentoToolStripMenuItem.Name = "EliminarDepartamentoToolStripMenuItem"
        Me.EliminarDepartamentoToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.EliminarDepartamentoToolStripMenuItem.Text = "Eliminar departamento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(251, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(234, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "ORGANIZACIÓN MISIONERA"
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.Color.DarkRed
        Me.btnsalir.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.ForeColor = System.Drawing.Color.White
        Me.btnsalir.Location = New System.Drawing.Point(479, 230)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(81, 31)
        Me.btnsalir.TabIndex = 15
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(179, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(207, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Usuario"
        '
        'btnlimpiar
        '
        Me.btnlimpiar.BackColor = System.Drawing.Color.DarkRed
        Me.btnlimpiar.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpiar.ForeColor = System.Drawing.Color.White
        Me.btnlimpiar.Location = New System.Drawing.Point(479, 187)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(81, 29)
        Me.btnlimpiar.TabIndex = 12
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = False
        '
        'btningresar
        '
        Me.btningresar.BackColor = System.Drawing.Color.DarkRed
        Me.btningresar.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btningresar.ForeColor = System.Drawing.Color.White
        Me.btningresar.Location = New System.Drawing.Point(479, 144)
        Me.btningresar.Name = "btningresar"
        Me.btningresar.Size = New System.Drawing.Size(81, 29)
        Me.btningresar.TabIndex = 11
        Me.btningresar.Text = "Ingresar"
        Me.btningresar.UseVisualStyleBackColor = False
        '
        'txtcedula
        '
        Me.txtcedula.Location = New System.Drawing.Point(280, 207)
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcedula.Size = New System.Drawing.Size(184, 20)
        Me.txtcedula.TabIndex = 10
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(280, 166)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(184, 20)
        Me.txtusuario.TabIndex = 9
        '
        'btnsalirprograma
        '
        Me.btnsalirprograma.BackColor = System.Drawing.Color.DarkRed
        Me.btnsalirprograma.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalirprograma.ForeColor = System.Drawing.Color.White
        Me.btnsalirprograma.Location = New System.Drawing.Point(642, 54)
        Me.btnsalirprograma.Name = "btnsalirprograma"
        Me.btnsalirprograma.Size = New System.Drawing.Size(81, 29)
        Me.btnsalirprograma.TabIndex = 17
        Me.btnsalirprograma.Text = "Salir"
        Me.btnsalirprograma.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(760, 476)
        Me.Controls.Add(Me.btnsalirprograma)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btningresar)
        Me.Controls.Add(Me.txtcedula)
        Me.Controls.Add(Me.txtusuario)
        Me.Controls.Add(Me.Menú)
        Me.MainMenuStrip = Me.Menú
        Me.Name = "Form1"
        Me.Text = "ORGANIZACIÓN UNIDOS"
        Me.Menú.ResumeLayout(False)
        Me.Menú.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Menú As MenuStrip
    Friend WithEvents PERSONASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FINANZASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarIngresosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarGastosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PROYECTOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresarNuevoProyectoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarDatosProyectoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarProyectoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents INVENTARIOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VincularVoluntariosAProyectoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarProductoNuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DEPARTAMENTOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoDepartamentiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents btnsalir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents btningresar As Button
    Friend WithEvents txtcedula As TextBox
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarDepartamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarDepartamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresarNuevaPersonaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarPersonaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarRegistroPersonaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnsalirprograma As Button
End Class
