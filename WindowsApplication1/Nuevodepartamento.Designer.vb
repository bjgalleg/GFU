<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nuevodepartamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nuevodepartamento))
        Me.txtfunciones = New System.Windows.Forms.TextBox()
        Me.txtnombredpto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtfunciones
        '
        Me.txtfunciones.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfunciones.ForeColor = System.Drawing.Color.Black
        Me.txtfunciones.Location = New System.Drawing.Point(367, 100)
        Me.txtfunciones.Name = "txtfunciones"
        Me.txtfunciones.Size = New System.Drawing.Size(224, 22)
        Me.txtfunciones.TabIndex = 61
        '
        'txtnombredpto
        '
        Me.txtnombredpto.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombredpto.ForeColor = System.Drawing.Color.Black
        Me.txtnombredpto.Location = New System.Drawing.Point(367, 61)
        Me.txtnombredpto.Name = "txtnombredpto"
        Me.txtnombredpto.Size = New System.Drawing.Size(224, 22)
        Me.txtnombredpto.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(89, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 17)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Descripcion de funciones"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(89, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 17)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Nombre del departamento"
        '
        'btnvolver
        '
        Me.btnvolver.BackColor = System.Drawing.Color.DarkRed
        Me.btnvolver.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvolver.ForeColor = System.Drawing.Color.White
        Me.btnvolver.Location = New System.Drawing.Point(401, 159)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(102, 39)
        Me.btnvolver.TabIndex = 57
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.DarkRed
        Me.btnguardar.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.White
        Me.btnguardar.Location = New System.Drawing.Point(195, 159)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(102, 39)
        Me.btnguardar.TabIndex = 56
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'Nuevodepartamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(668, 261)
        Me.Controls.Add(Me.txtfunciones)
        Me.Controls.Add(Me.txtnombredpto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.btnguardar)
        Me.Name = "Nuevodepartamento"
        Me.Text = "Nuevodepartamento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtfunciones As TextBox
    Friend WithEvents txtnombredpto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnvolver As Button
    Friend WithEvents btnguardar As Button
End Class
