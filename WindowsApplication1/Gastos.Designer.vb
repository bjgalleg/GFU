<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gastos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gastos))
        Me.txttipo = New System.Windows.Forms.TextBox()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.txtmonto = New System.Windows.Forms.TextBox()
        Me.txtdetalle = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbproyecto = New System.Windows.Forms.ComboBox()
        Me.cmbsubtipo = New System.Windows.Forms.ComboBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txttipo
        '
        Me.txttipo.Location = New System.Drawing.Point(245, 135)
        Me.txttipo.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txttipo.Name = "txttipo"
        Me.txttipo.ReadOnly = True
        Me.txttipo.Size = New System.Drawing.Size(164, 25)
        Me.txttipo.TabIndex = 24
        Me.txttipo.Text = "Gasto"
        '
        'fecha
        '
        Me.fecha.Location = New System.Drawing.Point(245, 248)
        Me.fecha.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(331, 25)
        Me.fecha.TabIndex = 23
        '
        'txtmonto
        '
        Me.txtmonto.Location = New System.Drawing.Point(245, 297)
        Me.txtmonto.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(164, 25)
        Me.txtmonto.TabIndex = 22
        '
        'txtdetalle
        '
        Me.txtdetalle.Location = New System.Drawing.Point(245, 336)
        Me.txtdetalle.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtdetalle.Name = "txtdetalle"
        Me.txtdetalle.Size = New System.Drawing.Size(164, 25)
        Me.txtdetalle.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(93, 336)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 17)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Detalle"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(93, 297)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 17)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Monto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(93, 259)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 17)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(93, 212)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 17)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "ProyectoID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(93, 174)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Subtipo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(93, 139)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Tipo"
        '
        'cmbproyecto
        '
        Me.cmbproyecto.FormattingEnabled = True
        Me.cmbproyecto.Location = New System.Drawing.Point(245, 212)
        Me.cmbproyecto.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmbproyecto.Name = "cmbproyecto"
        Me.cmbproyecto.Size = New System.Drawing.Size(199, 25)
        Me.cmbproyecto.TabIndex = 14
        '
        'cmbsubtipo
        '
        Me.cmbsubtipo.FormattingEnabled = True
        Me.cmbsubtipo.Items.AddRange(New Object() {"Gasto administrativos", "Gastos operativos"})
        Me.cmbsubtipo.Location = New System.Drawing.Point(245, 174)
        Me.cmbsubtipo.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cmbsubtipo.Name = "cmbsubtipo"
        Me.cmbsubtipo.Size = New System.Drawing.Size(199, 25)
        Me.cmbsubtipo.TabIndex = 13
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnguardar.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.btnguardar.Location = New System.Drawing.Point(155, 400)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(165, 30)
        Me.btnguardar.TabIndex = 141
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btnvolver
        '
        Me.btnvolver.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnvolver.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.btnvolver.Location = New System.Drawing.Point(330, 400)
        Me.btnvolver.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(172, 30)
        Me.btnvolver.TabIndex = 140
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = False
        '
        'Gastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(670, 497)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.txttipo)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.txtmonto)
        Me.Controls.Add(Me.txtdetalle)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbproyecto)
        Me.Controls.Add(Me.cmbsubtipo)
        Me.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Gastos"
        Me.Text = "Gastos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txttipo As TextBox
    Friend WithEvents fecha As DateTimePicker
    Friend WithEvents txtmonto As TextBox
    Friend WithEvents txtdetalle As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbproyecto As ComboBox
    Friend WithEvents cmbsubtipo As ComboBox
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnvolver As Button
End Class
