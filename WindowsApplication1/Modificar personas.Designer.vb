<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificarpersonas
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modificarpersonas))
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.UNIDOSBGDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UNIDOSBGDataSet = New WindowsApplication1.UNIDOSBGDataSet()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.cmbtipo = New System.Windows.Forms.ComboBox()
        Me.ti1 = New System.Windows.Forms.Label()
        Me.cmbdpto = New System.Windows.Forms.ComboBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbestado = New System.Windows.Forms.ComboBox()
        Me.txtcarrera = New System.Windows.Forms.TextBox()
        Me.txtuniversidad = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.est1 = New System.Windows.Forms.Label()
        Me.car1 = New System.Windows.Forms.Label()
        Me.uni1 = New System.Windows.Forms.Label()
        Me.dpto1 = New System.Windows.Forms.Label()
        Me.fec1 = New System.Windows.Forms.Label()
        Me.mail1 = New System.Windows.Forms.Label()
        Me.tel1 = New System.Windows.Forms.Label()
        Me.nom1 = New System.Windows.Forms.Label()
        Me.Tipo = New System.Windows.Forms.Label()
        CType(Me.UNIDOSBGDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UNIDOSBGDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtbuscar
        '
        Me.txtbuscar.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.txtbuscar.Location = New System.Drawing.Point(227, 28)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(100, 24)
        Me.txtbuscar.TabIndex = 195
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(18, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(203, 17)
        Me.Label3.TabIndex = 194
        Me.Label3.Text = "Ingrese número de cédula"
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnbuscar.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.btnbuscar.Location = New System.Drawing.Point(346, 25)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscar.TabIndex = 193
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'UNIDOSBGDataSetBindingSource
        '
        Me.UNIDOSBGDataSetBindingSource.DataSource = Me.UNIDOSBGDataSet
        Me.UNIDOSBGDataSetBindingSource.Position = 0
        '
        'UNIDOSBGDataSet
        '
        Me.UNIDOSBGDataSet.DataSetName = "UNIDOSBGDataSet"
        Me.UNIDOSBGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnguardar.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.btnguardar.Location = New System.Drawing.Point(495, 153)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(99, 23)
        Me.btnguardar.TabIndex = 170
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btnvolver
        '
        Me.btnvolver.BackColor = System.Drawing.Color.DarkOrchid
        Me.btnvolver.Font = New System.Drawing.Font("Cooper Black", 11.0!)
        Me.btnvolver.Location = New System.Drawing.Point(495, 266)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(103, 23)
        Me.btnvolver.TabIndex = 169
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = False
        '
        'cmbtipo
        '
        Me.cmbtipo.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtipo.ForeColor = System.Drawing.Color.Black
        Me.cmbtipo.FormattingEnabled = True
        Me.cmbtipo.Items.AddRange(New Object() {"Voluntario", "Donante", "Cliente"})
        Me.cmbtipo.Location = New System.Drawing.Point(134, 106)
        Me.cmbtipo.Name = "cmbtipo"
        Me.cmbtipo.Size = New System.Drawing.Size(272, 23)
        Me.cmbtipo.TabIndex = 217
        '
        'ti1
        '
        Me.ti1.AutoSize = True
        Me.ti1.BackColor = System.Drawing.Color.Transparent
        Me.ti1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ti1.ForeColor = System.Drawing.Color.Black
        Me.ti1.Location = New System.Drawing.Point(515, -64)
        Me.ti1.Name = "ti1"
        Me.ti1.Size = New System.Drawing.Size(39, 15)
        Me.ti1.TabIndex = 216
        Me.ti1.Text = "Tipo"
        '
        'cmbdpto
        '
        Me.cmbdpto.DisplayMember = "DptoID"
        Me.cmbdpto.FormattingEnabled = True
        Me.cmbdpto.Location = New System.Drawing.Point(134, 274)
        Me.cmbdpto.Name = "cmbdpto"
        Me.cmbdpto.Size = New System.Drawing.Size(272, 21)
        Me.cmbdpto.TabIndex = 215
        Me.cmbdpto.ValueMember = "DptoID"
        '
        'txtdireccion
        '
        Me.txtdireccion.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdireccion.Location = New System.Drawing.Point(133, 167)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(279, 22)
        Me.txtdireccion.TabIndex = 214
        '
        'fecha
        '
        Me.fecha.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Location = New System.Drawing.Point(134, 235)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(279, 22)
        Me.fecha.TabIndex = 213
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(133, 198)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(279, 22)
        Me.txtemail.TabIndex = 212
        '
        'txttelefono
        '
        Me.txttelefono.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelefono.Location = New System.Drawing.Point(133, 139)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(279, 22)
        Me.txttelefono.TabIndex = 211
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(31, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 15)
        Me.Label1.TabIndex = 210
        Me.Label1.Text = "Dirección"
        '
        'cmbestado
        '
        Me.cmbestado.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbestado.ForeColor = System.Drawing.Color.Black
        Me.cmbestado.FormattingEnabled = True
        Me.cmbestado.Items.AddRange(New Object() {"Estudiante", "Egresado", "Graduado", "Estudios no concluidos"})
        Me.cmbestado.Location = New System.Drawing.Point(137, 359)
        Me.cmbestado.Name = "cmbestado"
        Me.cmbestado.Size = New System.Drawing.Size(272, 23)
        Me.cmbestado.TabIndex = 207
        '
        'txtcarrera
        '
        Me.txtcarrera.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcarrera.ForeColor = System.Drawing.Color.Black
        Me.txtcarrera.Location = New System.Drawing.Point(137, 336)
        Me.txtcarrera.Name = "txtcarrera"
        Me.txtcarrera.Size = New System.Drawing.Size(272, 22)
        Me.txtcarrera.TabIndex = 206
        '
        'txtuniversidad
        '
        Me.txtuniversidad.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuniversidad.ForeColor = System.Drawing.Color.Black
        Me.txtuniversidad.Location = New System.Drawing.Point(137, 310)
        Me.txtuniversidad.Name = "txtuniversidad"
        Me.txtuniversidad.Size = New System.Drawing.Size(272, 22)
        Me.txtuniversidad.TabIndex = 205
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.ForeColor = System.Drawing.Color.Black
        Me.txtnombre.Location = New System.Drawing.Point(134, 79)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(278, 22)
        Me.txtnombre.TabIndex = 204
        '
        'est1
        '
        Me.est1.AutoSize = True
        Me.est1.BackColor = System.Drawing.Color.Transparent
        Me.est1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.est1.ForeColor = System.Drawing.Color.White
        Me.est1.Location = New System.Drawing.Point(31, 362)
        Me.est1.Name = "est1"
        Me.est1.Size = New System.Drawing.Size(51, 15)
        Me.est1.TabIndex = 203
        Me.est1.Text = "Estado"
        '
        'car1
        '
        Me.car1.AutoSize = True
        Me.car1.BackColor = System.Drawing.Color.Transparent
        Me.car1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.car1.ForeColor = System.Drawing.Color.White
        Me.car1.Location = New System.Drawing.Point(30, 336)
        Me.car1.Name = "car1"
        Me.car1.Size = New System.Drawing.Size(58, 15)
        Me.car1.TabIndex = 202
        Me.car1.Text = "Carrera"
        '
        'uni1
        '
        Me.uni1.AutoSize = True
        Me.uni1.BackColor = System.Drawing.Color.Transparent
        Me.uni1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uni1.ForeColor = System.Drawing.Color.White
        Me.uni1.Location = New System.Drawing.Point(27, 313)
        Me.uni1.Name = "uni1"
        Me.uni1.Size = New System.Drawing.Size(90, 15)
        Me.uni1.TabIndex = 201
        Me.uni1.Text = "Universidad"
        '
        'dpto1
        '
        Me.dpto1.AutoSize = True
        Me.dpto1.BackColor = System.Drawing.Color.Transparent
        Me.dpto1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpto1.ForeColor = System.Drawing.Color.White
        Me.dpto1.Location = New System.Drawing.Point(27, 274)
        Me.dpto1.Name = "dpto1"
        Me.dpto1.Size = New System.Drawing.Size(103, 15)
        Me.dpto1.TabIndex = 200
        Me.dpto1.Text = "Departamento"
        '
        'fec1
        '
        Me.fec1.AutoSize = True
        Me.fec1.BackColor = System.Drawing.Color.Transparent
        Me.fec1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fec1.ForeColor = System.Drawing.Color.White
        Me.fec1.Location = New System.Drawing.Point(-11, 235)
        Me.fec1.Name = "fec1"
        Me.fec1.Size = New System.Drawing.Size(145, 15)
        Me.fec1.TabIndex = 199
        Me.fec1.Text = "Fecha de nacimiento"
        '
        'mail1
        '
        Me.mail1.AutoSize = True
        Me.mail1.BackColor = System.Drawing.Color.Transparent
        Me.mail1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mail1.ForeColor = System.Drawing.Color.White
        Me.mail1.Location = New System.Drawing.Point(31, 195)
        Me.mail1.Name = "mail1"
        Me.mail1.Size = New System.Drawing.Size(52, 15)
        Me.mail1.TabIndex = 198
        Me.mail1.Text = "E-mail"
        '
        'tel1
        '
        Me.tel1.AutoSize = True
        Me.tel1.BackColor = System.Drawing.Color.Transparent
        Me.tel1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tel1.ForeColor = System.Drawing.Color.White
        Me.tel1.Location = New System.Drawing.Point(31, 139)
        Me.tel1.Name = "tel1"
        Me.tel1.Size = New System.Drawing.Size(67, 15)
        Me.tel1.TabIndex = 197
        Me.tel1.Text = "Teléfono"
        '
        'nom1
        '
        Me.nom1.AutoSize = True
        Me.nom1.BackColor = System.Drawing.Color.Transparent
        Me.nom1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom1.ForeColor = System.Drawing.Color.White
        Me.nom1.Location = New System.Drawing.Point(27, 79)
        Me.nom1.Name = "nom1"
        Me.nom1.Size = New System.Drawing.Size(67, 15)
        Me.nom1.TabIndex = 196
        Me.nom1.Text = "Nombres"
        '
        'Tipo
        '
        Me.Tipo.AutoSize = True
        Me.Tipo.BackColor = System.Drawing.Color.Transparent
        Me.Tipo.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tipo.ForeColor = System.Drawing.Color.White
        Me.Tipo.Location = New System.Drawing.Point(50, 106)
        Me.Tipo.Name = "Tipo"
        Me.Tipo.Size = New System.Drawing.Size(39, 15)
        Me.Tipo.TabIndex = 218
        Me.Tipo.Text = "Tipo"
        '
        'Modificarpersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(719, 481)
        Me.Controls.Add(Me.Tipo)
        Me.Controls.Add(Me.cmbtipo)
        Me.Controls.Add(Me.ti1)
        Me.Controls.Add(Me.cmbdpto)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbestado)
        Me.Controls.Add(Me.txtcarrera)
        Me.Controls.Add(Me.txtuniversidad)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.est1)
        Me.Controls.Add(Me.car1)
        Me.Controls.Add(Me.uni1)
        Me.Controls.Add(Me.dpto1)
        Me.Controls.Add(Me.fec1)
        Me.Controls.Add(Me.mail1)
        Me.Controls.Add(Me.tel1)
        Me.Controls.Add(Me.nom1)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnvolver)
        Me.Name = "Modificarpersonas"
        Me.Text = "Modificar personas"
        CType(Me.UNIDOSBGDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UNIDOSBGDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnvolver As Button
    Friend WithEvents UNIDOSBGDataSetBindingSource As BindingSource
    Friend WithEvents UNIDOSBGDataSet As UNIDOSBGDataSet
    Friend WithEvents cmbtipo As ComboBox
    Friend WithEvents ti1 As Label
    Friend WithEvents cmbdpto As ComboBox
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents fecha As DateTimePicker
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbestado As ComboBox
    Friend WithEvents txtcarrera As TextBox
    Friend WithEvents txtuniversidad As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents est1 As Label
    Friend WithEvents car1 As Label
    Friend WithEvents uni1 As Label
    Friend WithEvents dpto1 As Label
    Friend WithEvents fec1 As Label
    Friend WithEvents mail1 As Label
    Friend WithEvents tel1 As Label
    Friend WithEvents nom1 As Label
    Friend WithEvents Tipo As Label
End Class
