<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eliminarregistropersona
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Eliminarregistropersona))
        Me.txtced = New System.Windows.Forms.TextBox()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.ced = New System.Windows.Forms.Label()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtced
        '
        Me.txtced.Location = New System.Drawing.Point(145, 128)
        Me.txtced.Name = "txtced"
        Me.txtced.Size = New System.Drawing.Size(161, 20)
        Me.txtced.TabIndex = 15
        '
        'btneliminar
        '
        Me.btneliminar.BackColor = System.Drawing.Color.DarkRed
        Me.btneliminar.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar.ForeColor = System.Drawing.Color.White
        Me.btneliminar.Location = New System.Drawing.Point(130, 177)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 12
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = False
        '
        'ced
        '
        Me.ced.AutoSize = True
        Me.ced.BackColor = System.Drawing.Color.Transparent
        Me.ced.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ced.ForeColor = System.Drawing.Color.White
        Me.ced.Location = New System.Drawing.Point(155, 95)
        Me.ced.Name = "ced"
        Me.ced.Size = New System.Drawing.Size(151, 17)
        Me.ced.TabIndex = 14
        Me.ced.Text = "Ingrese No. Cédula"
        '
        'btnvolver
        '
        Me.btnvolver.BackColor = System.Drawing.Color.DarkRed
        Me.btnvolver.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvolver.ForeColor = System.Drawing.Color.White
        Me.btnvolver.Location = New System.Drawing.Point(247, 177)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(75, 23)
        Me.btnvolver.TabIndex = 13
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = False
        '
        'Eliminarregistropersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(456, 360)
        Me.Controls.Add(Me.txtced)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.ced)
        Me.Controls.Add(Me.btnvolver)
        Me.Name = "Eliminarregistropersona"
        Me.Text = "Eliminar registro persona"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtced As TextBox
    Friend WithEvents btneliminar As Button
    Friend WithEvents ced As Label
    Friend WithEvents btnvolver As Button
End Class
