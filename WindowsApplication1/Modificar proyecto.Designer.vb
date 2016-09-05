<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificarproyecto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modificarproyecto))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txttipo = New System.Windows.Forms.ComboBox()
        Me.ffinal = New System.Windows.Forms.DateTimePicker()
        Me.finicio = New System.Windows.Forms.DateTimePicker()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.Tipo = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.Departamento = New System.Windows.Forms.Label()
        Me.cmbdpto = New System.Windows.Forms.ComboBox()
        Me.txtproyecto = New System.Windows.Forms.TextBox()
        Me.txtcomunidad = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(41, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(173, 19)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Nombre de Proyecto"
        '
        'txttipo
        '
        Me.txttipo.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttipo.FormattingEnabled = True
        Me.txttipo.Items.AddRange(New Object() {"Proyecto colaborativo", "Proyecto único", "Misión universitaria", "Misión comunitaria"})
        Me.txttipo.Location = New System.Drawing.Point(302, 174)
        Me.txttipo.Name = "txttipo"
        Me.txttipo.Size = New System.Drawing.Size(295, 27)
        Me.txttipo.TabIndex = 50
        '
        'ffinal
        '
        Me.ffinal.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ffinal.Location = New System.Drawing.Point(302, 250)
        Me.ffinal.Name = "ffinal"
        Me.ffinal.Size = New System.Drawing.Size(295, 26)
        Me.ffinal.TabIndex = 49
        '
        'finicio
        '
        Me.finicio.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.finicio.Location = New System.Drawing.Point(302, 213)
        Me.finicio.Name = "finicio"
        Me.finicio.Size = New System.Drawing.Size(295, 26)
        Me.finicio.TabIndex = 48
        '
        'btnvolver
        '
        Me.btnvolver.BackColor = System.Drawing.Color.DarkRed
        Me.btnvolver.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvolver.ForeColor = System.Drawing.Color.White
        Me.btnvolver.Location = New System.Drawing.Point(364, 374)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(100, 26)
        Me.btnvolver.TabIndex = 47
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.DarkRed
        Me.btnguardar.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.White
        Me.btnguardar.Location = New System.Drawing.Point(226, 374)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(103, 26)
        Me.btnguardar.TabIndex = 46
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'Tipo
        '
        Me.Tipo.AutoSize = True
        Me.Tipo.BackColor = System.Drawing.Color.Transparent
        Me.Tipo.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tipo.ForeColor = System.Drawing.Color.White
        Me.Tipo.Location = New System.Drawing.Point(49, 173)
        Me.Tipo.Name = "Tipo"
        Me.Tipo.Size = New System.Drawing.Size(47, 19)
        Me.Tipo.TabIndex = 59
        Me.Tipo.Text = "Tipo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(52, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 19)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Fecha final"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(52, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 19)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Fecha inicio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(52, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 19)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Comunidad"
        '
        'txtbuscar
        '
        Me.txtbuscar.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.txtbuscar.Location = New System.Drawing.Point(302, 44)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(100, 24)
        Me.txtbuscar.TabIndex = 201
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(65, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 17)
        Me.Label3.TabIndex = 200
        Me.Label3.Text = "Ingrese  código de proyecto"
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnbuscar.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.btnbuscar.Location = New System.Drawing.Point(438, 41)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscar.TabIndex = 199
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'Departamento
        '
        Me.Departamento.AutoSize = True
        Me.Departamento.BackColor = System.Drawing.Color.Transparent
        Me.Departamento.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Departamento.ForeColor = System.Drawing.Color.White
        Me.Departamento.Location = New System.Drawing.Point(49, 285)
        Me.Departamento.Name = "Departamento"
        Me.Departamento.Size = New System.Drawing.Size(126, 19)
        Me.Departamento.TabIndex = 203
        Me.Departamento.Text = "Departamento"
        '
        'cmbdpto
        '
        Me.cmbdpto.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdpto.FormattingEnabled = True
        Me.cmbdpto.Items.AddRange(New Object() {"Proyecto colaborativo", "Proyecto único", "Misión universitaria", "Misión comunitaria"})
        Me.cmbdpto.Location = New System.Drawing.Point(302, 286)
        Me.cmbdpto.Name = "cmbdpto"
        Me.cmbdpto.Size = New System.Drawing.Size(295, 27)
        Me.cmbdpto.TabIndex = 202
        '
        'txtproyecto
        '
        Me.txtproyecto.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproyecto.Location = New System.Drawing.Point(299, 106)
        Me.txtproyecto.Name = "txtproyecto"
        Me.txtproyecto.Size = New System.Drawing.Size(295, 26)
        Me.txtproyecto.TabIndex = 204
        '
        'txtcomunidad
        '
        Me.txtcomunidad.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcomunidad.Location = New System.Drawing.Point(299, 138)
        Me.txtcomunidad.Name = "txtcomunidad"
        Me.txtcomunidad.Size = New System.Drawing.Size(295, 26)
        Me.txtcomunidad.TabIndex = 205
        '
        'Modificarproyecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(639, 480)
        Me.Controls.Add(Me.txtcomunidad)
        Me.Controls.Add(Me.txtproyecto)
        Me.Controls.Add(Me.Departamento)
        Me.Controls.Add(Me.cmbdpto)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.Tipo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txttipo)
        Me.Controls.Add(Me.ffinal)
        Me.Controls.Add(Me.finicio)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.btnguardar)
        Me.Name = "Modificarproyecto"
        Me.Text = "Modificar proyecto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents txttipo As ComboBox
    Friend WithEvents ffinal As DateTimePicker
    Friend WithEvents finicio As DateTimePicker
    Friend WithEvents btnvolver As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents Tipo As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnbuscar As Button
    Friend WithEvents Departamento As Label
    Friend WithEvents cmbdpto As ComboBox
    Friend WithEvents txtproyecto As TextBox
    Friend WithEvents txtcomunidad As TextBox
End Class
