<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reportes))
        Me.cmbtipo = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dataMovimientos = New System.Windows.Forms.DataGridView()
        Me.cmbproyecto = New System.Windows.Forms.ComboBox()
        Me.dthasta = New System.Windows.Forms.DateTimePicker()
        Me.dtdesde = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnmlimpiar = New System.Windows.Forms.Button()
        Me.btnmbuscar = New System.Windows.Forms.Button()
        Me.btnmvertodo = New System.Windows.Forms.Button()
        Me.txtsalperiodo = New System.Windows.Forms.TextBox()
        Me.txtgasto = New System.Windows.Forms.TextBox()
        Me.txtingreso = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnregresaringreso = New System.Windows.Forms.Button()
        CType(Me.dataMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbtipo
        '
        Me.cmbtipo.FormattingEnabled = True
        Me.cmbtipo.Items.AddRange(New Object() {"Ingresos", "Gastos"})
        Me.cmbtipo.Location = New System.Drawing.Point(212, 158)
        Me.cmbtipo.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmbtipo.Name = "cmbtipo"
        Me.cmbtipo.Size = New System.Drawing.Size(472, 25)
        Me.cmbtipo.TabIndex = 71
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(148, 178)
        Me.Label18.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(0, 17)
        Me.Label18.TabIndex = 70
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(85, 162)
        Me.Label19.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(43, 17)
        Me.Label19.TabIndex = 69
        Me.Label19.Text = "Tipo"
        '
        'dataMovimientos
        '
        Me.dataMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataMovimientos.Location = New System.Drawing.Point(83, 360)
        Me.dataMovimientos.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dataMovimientos.Name = "dataMovimientos"
        Me.dataMovimientos.Size = New System.Drawing.Size(596, 216)
        Me.dataMovimientos.TabIndex = 68
        '
        'cmbproyecto
        '
        Me.cmbproyecto.FormattingEnabled = True
        Me.cmbproyecto.Items.AddRange(New Object() {"Ingresos", "Gastos"})
        Me.cmbproyecto.Location = New System.Drawing.Point(212, 122)
        Me.cmbproyecto.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmbproyecto.Name = "cmbproyecto"
        Me.cmbproyecto.Size = New System.Drawing.Size(472, 25)
        Me.cmbproyecto.TabIndex = 67
        '
        'dthasta
        '
        Me.dthasta.Location = New System.Drawing.Point(212, 86)
        Me.dthasta.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dthasta.Name = "dthasta"
        Me.dthasta.Size = New System.Drawing.Size(472, 25)
        Me.dthasta.TabIndex = 66
        '
        'dtdesde
        '
        Me.dtdesde.Location = New System.Drawing.Point(212, 58)
        Me.dtdesde.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dtdesde.Name = "dtdesde"
        Me.dtdesde.Size = New System.Drawing.Size(472, 25)
        Me.dtdesde.TabIndex = 65
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(148, 141)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 17)
        Me.Label6.TabIndex = 64
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(85, 126)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 17)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Proyecto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(88, 98)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Hasta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(83, 68)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Desde:"
        '
        'btnmlimpiar
        '
        Me.btnmlimpiar.Location = New System.Drawing.Point(696, 206)
        Me.btnmlimpiar.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnmlimpiar.Name = "btnmlimpiar"
        Me.btnmlimpiar.Size = New System.Drawing.Size(125, 30)
        Me.btnmlimpiar.TabIndex = 60
        Me.btnmlimpiar.Text = "Limpiar"
        Me.btnmlimpiar.UseVisualStyleBackColor = True
        '
        'btnmbuscar
        '
        Me.btnmbuscar.Location = New System.Drawing.Point(696, 244)
        Me.btnmbuscar.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnmbuscar.Name = "btnmbuscar"
        Me.btnmbuscar.Size = New System.Drawing.Size(125, 30)
        Me.btnmbuscar.TabIndex = 59
        Me.btnmbuscar.Text = "Buscar"
        Me.btnmbuscar.UseVisualStyleBackColor = True
        '
        'btnmvertodo
        '
        Me.btnmvertodo.Location = New System.Drawing.Point(694, 158)
        Me.btnmvertodo.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnmvertodo.Name = "btnmvertodo"
        Me.btnmvertodo.Size = New System.Drawing.Size(152, 30)
        Me.btnmvertodo.TabIndex = 58
        Me.btnmvertodo.Text = "Ver Todo"
        Me.btnmvertodo.UseVisualStyleBackColor = True
        '
        'txtsalperiodo
        '
        Me.txtsalperiodo.Location = New System.Drawing.Point(330, 292)
        Me.txtsalperiodo.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtsalperiodo.Name = "txtsalperiodo"
        Me.txtsalperiodo.Size = New System.Drawing.Size(234, 25)
        Me.txtsalperiodo.TabIndex = 83
        '
        'txtgasto
        '
        Me.txtgasto.Location = New System.Drawing.Point(330, 250)
        Me.txtgasto.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtgasto.Name = "txtgasto"
        Me.txtgasto.Size = New System.Drawing.Size(234, 25)
        Me.txtgasto.TabIndex = 82
        '
        'txtingreso
        '
        Me.txtingreso.Location = New System.Drawing.Point(330, 203)
        Me.txtingreso.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtingreso.Name = "txtingreso"
        Me.txtingreso.Size = New System.Drawing.Size(234, 25)
        Me.txtingreso.TabIndex = 81
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(83, 299)
        Me.Label13.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(241, 17)
        Me.Label13.TabIndex = 80
        Me.Label13.Text = "Saldo de periodo seleccionado;"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(80, 253)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(128, 17)
        Me.Label14.TabIndex = 79
        Me.Label14.Text = "Total de gastos:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(83, 206)
        Me.Label15.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(144, 17)
        Me.Label15.TabIndex = 78
        Me.Label15.Text = "Total de Ingresos:"
        '
        'btnregresaringreso
        '
        Me.btnregresaringreso.Location = New System.Drawing.Point(694, 53)
        Me.btnregresaringreso.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnregresaringreso.Name = "btnregresaringreso"
        Me.btnregresaringreso.Size = New System.Drawing.Size(152, 30)
        Me.btnregresaringreso.TabIndex = 84
        Me.btnregresaringreso.Text = "Salir"
        Me.btnregresaringreso.UseVisualStyleBackColor = True
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(861, 667)
        Me.Controls.Add(Me.btnregresaringreso)
        Me.Controls.Add(Me.txtsalperiodo)
        Me.Controls.Add(Me.txtgasto)
        Me.Controls.Add(Me.txtingreso)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cmbtipo)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.dataMovimientos)
        Me.Controls.Add(Me.cmbproyecto)
        Me.Controls.Add(Me.dthasta)
        Me.Controls.Add(Me.dtdesde)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnmlimpiar)
        Me.Controls.Add(Me.btnmbuscar)
        Me.Controls.Add(Me.btnmvertodo)
        Me.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Reportes"
        Me.Text = "Reportes"
        CType(Me.dataMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbtipo As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents dataMovimientos As DataGridView
    Friend WithEvents cmbproyecto As ComboBox
    Friend WithEvents dthasta As DateTimePicker
    Friend WithEvents dtdesde As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnmlimpiar As Button
    Friend WithEvents btnmbuscar As Button
    Friend WithEvents btnmvertodo As Button
    Friend WithEvents txtsalperiodo As TextBox
    Friend WithEvents txtgasto As TextBox
    Friend WithEvents txtingreso As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnregresaringreso As Button
End Class
