<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingresos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingresos))
        Me.cmbsubtipo = New System.Windows.Forms.ComboBox()
        Me.cmbproyecto = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdetalle = New System.Windows.Forms.TextBox()
        Me.txtmonto = New System.Windows.Forms.TextBox()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.txttipo = New System.Windows.Forms.TextBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbsubtipo
        '
        Me.cmbsubtipo.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsubtipo.FormattingEnabled = True
        Me.cmbsubtipo.Items.AddRange(New Object() {"Donaciones directas", "Patrocinios", "Compromisos", "Venta"})
        Me.cmbsubtipo.Location = New System.Drawing.Point(188, 97)
        Me.cmbsubtipo.Name = "cmbsubtipo"
        Me.cmbsubtipo.Size = New System.Drawing.Size(121, 25)
        Me.cmbsubtipo.TabIndex = 1
        '
        'cmbproyecto
        '
        Me.cmbproyecto.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbproyecto.FormattingEnabled = True
        Me.cmbproyecto.Location = New System.Drawing.Point(188, 126)
        Me.cmbproyecto.Name = "cmbproyecto"
        Me.cmbproyecto.Size = New System.Drawing.Size(121, 25)
        Me.cmbproyecto.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(97, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tipo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(97, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Subtipo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(97, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ProyectoID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(97, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(97, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Monto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(97, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Detalle"
        '
        'txtdetalle
        '
        Me.txtdetalle.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdetalle.Location = New System.Drawing.Point(188, 221)
        Me.txtdetalle.Name = "txtdetalle"
        Me.txtdetalle.Size = New System.Drawing.Size(100, 25)
        Me.txtdetalle.TabIndex = 9
        '
        'txtmonto
        '
        Me.txtmonto.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmonto.Location = New System.Drawing.Point(188, 191)
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(100, 25)
        Me.txtmonto.TabIndex = 10
        '
        'fecha
        '
        Me.fecha.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Location = New System.Drawing.Point(188, 154)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(200, 25)
        Me.fecha.TabIndex = 11
        '
        'txttipo
        '
        Me.txttipo.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttipo.Location = New System.Drawing.Point(188, 67)
        Me.txttipo.Name = "txttipo"
        Me.txttipo.ReadOnly = True
        Me.txttipo.Size = New System.Drawing.Size(100, 25)
        Me.txttipo.TabIndex = 12
        Me.txttipo.Text = "Ingreso"
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnguardar.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.btnguardar.Location = New System.Drawing.Point(89, 281)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(99, 23)
        Me.btnguardar.TabIndex = 141
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btnvolver
        '
        Me.btnvolver.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnvolver.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.btnvolver.Location = New System.Drawing.Point(194, 281)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(103, 23)
        Me.btnvolver.TabIndex = 140
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = False
        '
        'Ingresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(428, 404)
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
        Me.Name = "Ingresos"
        Me.Text = "Ingresos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbsubtipo As ComboBox
    Friend WithEvents cmbproyecto As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtdetalle As TextBox
    Friend WithEvents txtmonto As TextBox
    Friend WithEvents fecha As DateTimePicker
    Friend WithEvents txttipo As TextBox
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnvolver As Button
End Class
