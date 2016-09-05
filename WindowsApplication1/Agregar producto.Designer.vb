<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarProducto))
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtstock
        '
        Me.txtstock.Location = New System.Drawing.Point(186, 137)
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(100, 20)
        Me.txtstock.TabIndex = 168
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(186, 75)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(100, 20)
        Me.txtnombre.TabIndex = 167
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnguardar.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.btnguardar.Location = New System.Drawing.Point(98, 214)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(99, 23)
        Me.btnguardar.TabIndex = 166
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btnvolver
        '
        Me.btnvolver.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnvolver.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.btnvolver.Location = New System.Drawing.Point(203, 214)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(103, 23)
        Me.btnvolver.TabIndex = 165
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = False
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(186, 104)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(100, 20)
        Me.txtprecio.TabIndex = 164
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(52, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 17)
        Me.Label4.TabIndex = 163
        Me.Label4.Text = "Stock inicial"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(52, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 162
        Me.Label3.Text = "Precio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(52, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 161
        Me.Label2.Text = "Nombre"
        '
        'AgregarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(388, 291)
        Me.Controls.Add(Me.txtstock)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "AgregarProducto"
        Me.Text = "Agregar producto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtstock As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnvolver As Button
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
