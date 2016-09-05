<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificardepartamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modificardepartamento))
        Me.btnbusdepart = New System.Windows.Forms.Button()
        Me.txtfunciones = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.cmbdpto = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnbusdepart
        '
        Me.btnbusdepart.BackColor = System.Drawing.Color.DarkRed
        Me.btnbusdepart.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbusdepart.ForeColor = System.Drawing.Color.White
        Me.btnbusdepart.Location = New System.Drawing.Point(580, 66)
        Me.btnbusdepart.Name = "btnbusdepart"
        Me.btnbusdepart.Size = New System.Drawing.Size(75, 23)
        Me.btnbusdepart.TabIndex = 63
        Me.btnbusdepart.Text = "Buscar"
        Me.btnbusdepart.UseVisualStyleBackColor = False
        '
        'txtfunciones
        '
        Me.txtfunciones.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfunciones.ForeColor = System.Drawing.Color.Black
        Me.txtfunciones.Location = New System.Drawing.Point(336, 106)
        Me.txtfunciones.Name = "txtfunciones"
        Me.txtfunciones.Size = New System.Drawing.Size(224, 22)
        Me.txtfunciones.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(58, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 17)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Descripcion de funciones"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(58, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 17)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Nombre del departamento"
        '
        'btnvolver
        '
        Me.btnvolver.BackColor = System.Drawing.Color.DarkRed
        Me.btnvolver.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvolver.ForeColor = System.Drawing.Color.White
        Me.btnvolver.Location = New System.Drawing.Point(370, 165)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(102, 39)
        Me.btnvolver.TabIndex = 49
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.DarkRed
        Me.btnguardar.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.White
        Me.btnguardar.Location = New System.Drawing.Point(164, 165)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(102, 39)
        Me.btnguardar.TabIndex = 48
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'cmbdpto
        '
        Me.cmbdpto.FormattingEnabled = True
        Me.cmbdpto.Location = New System.Drawing.Point(336, 79)
        Me.cmbdpto.Name = "cmbdpto"
        Me.cmbdpto.Size = New System.Drawing.Size(203, 21)
        Me.cmbdpto.TabIndex = 64
        '
        'Modificardepartamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(667, 297)
        Me.Controls.Add(Me.cmbdpto)
        Me.Controls.Add(Me.btnbusdepart)
        Me.Controls.Add(Me.txtfunciones)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.btnguardar)
        Me.Name = "Modificardepartamento"
        Me.Text = "Modificar departamento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnbusdepart As Button
    Friend WithEvents txtfunciones As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnvolver As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents cmbdpto As ComboBox
End Class
