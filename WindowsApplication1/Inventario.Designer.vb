<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventario))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtactual = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btningreso_producto = New System.Windows.Forms.Button()
        Me.cbocedula = New System.Windows.Forms.ComboBox()
        Me.cboproducto = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnsacar_producto = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(150, 190)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 17)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Stock disponible"
        '
        'txtactual
        '
        Me.txtactual.Enabled = False
        Me.txtactual.Location = New System.Drawing.Point(382, 186)
        Me.txtactual.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtactual.Name = "txtactual"
        Me.txtactual.Size = New System.Drawing.Size(139, 25)
        Me.txtactual.TabIndex = 25
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(382, 228)
        Me.txtcantidad.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(139, 25)
        Me.txtcantidad.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(150, 231)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 17)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Cantidad"
        '
        'btningreso_producto
        '
        Me.btningreso_producto.Location = New System.Drawing.Point(108, 323)
        Me.btningreso_producto.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btningreso_producto.Name = "btningreso_producto"
        Me.btningreso_producto.Size = New System.Drawing.Size(202, 37)
        Me.btningreso_producto.TabIndex = 22
        Me.btningreso_producto.Text = "Ingresar Producto"
        Me.btningreso_producto.UseVisualStyleBackColor = True
        '
        'cbocedula
        '
        Me.cbocedula.FormattingEnabled = True
        Me.cbocedula.Location = New System.Drawing.Point(382, 94)
        Me.cbocedula.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cbocedula.Name = "cbocedula"
        Me.cbocedula.Size = New System.Drawing.Size(199, 25)
        Me.cbocedula.TabIndex = 19
        '
        'cboproducto
        '
        Me.cboproducto.FormattingEnabled = True
        Me.cboproducto.Items.AddRange(New Object() {"2"})
        Me.cboproducto.Location = New System.Drawing.Point(382, 146)
        Me.cboproducto.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cboproducto.Name = "cboproducto"
        Me.cboproducto.Size = New System.Drawing.Size(199, 25)
        Me.cboproducto.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(150, 98)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 17)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Cedula persona"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(150, 150)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Codigo Producto"
        '
        'btnsacar_producto
        '
        Me.btnsacar_producto.Location = New System.Drawing.Point(435, 323)
        Me.btnsacar_producto.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnsacar_producto.Name = "btnsacar_producto"
        Me.btnsacar_producto.Size = New System.Drawing.Size(202, 37)
        Me.btnsacar_producto.TabIndex = 27
        Me.btnsacar_producto.Text = "Sacar Producto"
        Me.btnsacar_producto.UseVisualStyleBackColor = True
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1152, 622)
        Me.Controls.Add(Me.btnsacar_producto)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtactual)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btningreso_producto)
        Me.Controls.Add(Me.cbocedula)
        Me.Controls.Add(Me.cboproducto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Inventario"
        Me.Text = "Ingresarproducto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents txtactual As TextBox
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btningreso_producto As Button
    Friend WithEvents cbocedula As ComboBox
    Friend WithEvents cboproducto As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnsacar_producto As Button
End Class
