<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificarproducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modificarproducto))
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Departamento = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.cmbpersona = New System.Windows.Forms.ComboBox()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnguardar.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.btnguardar.Location = New System.Drawing.Point(122, 267)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(99, 23)
        Me.btnguardar.TabIndex = 155
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btnvolver
        '
        Me.btnvolver.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnvolver.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.btnvolver.Location = New System.Drawing.Point(227, 267)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(103, 23)
        Me.btnvolver.TabIndex = 154
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = False
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(210, 157)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(100, 20)
        Me.txtprecio.TabIndex = 153
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(102, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 17)
        Me.Label4.TabIndex = 147
        Me.Label4.Text = "Stock inicial"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(102, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 146
        Me.Label3.Text = "Precio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(102, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 145
        Me.Label2.Text = "Nombre"
        '
        'Departamento
        '
        Me.Departamento.AccessibleDescription = "Label1"
        Me.Departamento.AutoSize = True
        Me.Departamento.BackColor = System.Drawing.Color.Transparent
        Me.Departamento.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Departamento.ForeColor = System.Drawing.Color.White
        Me.Departamento.Location = New System.Drawing.Point(87, 100)
        Me.Departamento.Name = "Departamento"
        Me.Departamento.Size = New System.Drawing.Size(69, 17)
        Me.Departamento.TabIndex = 144
        Me.Departamento.Text = "Persona"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(210, 128)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(100, 20)
        Me.txtnombre.TabIndex = 157
        '
        'txtstock
        '
        Me.txtstock.Location = New System.Drawing.Point(210, 190)
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(100, 20)
        Me.txtstock.TabIndex = 158
        '
        'cmbpersona
        '
        Me.cmbpersona.FormattingEnabled = True
        Me.cmbpersona.Location = New System.Drawing.Point(210, 100)
        Me.cmbpersona.Name = "cmbpersona"
        Me.cmbpersona.Size = New System.Drawing.Size(121, 21)
        Me.cmbpersona.TabIndex = 159
        '
        'txtbuscar
        '
        Me.txtbuscar.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.txtbuscar.Location = New System.Drawing.Point(210, 58)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(100, 24)
        Me.txtbuscar.TabIndex = 198
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 17)
        Me.Label1.TabIndex = 197
        Me.Label1.Text = "Ingrese  código de producto"
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnbuscar.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.btnbuscar.Location = New System.Drawing.Point(346, 55)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscar.TabIndex = 196
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'Modificarproducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(528, 436)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.cmbpersona)
        Me.Controls.Add(Me.txtstock)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Departamento)
        Me.Name = "Modificarproducto"
        Me.Text = "Modificar producto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnguardar As Button
    Friend WithEvents btnvolver As Button
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Departamento As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtstock As TextBox
    Friend WithEvents cmbpersona As ComboBox
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnbuscar As Button
End Class
