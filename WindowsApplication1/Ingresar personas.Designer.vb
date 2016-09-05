<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingresarpersonas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingresarpersonas))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ced = New System.Windows.Forms.Label()
        Me.txtcedula = New System.Windows.Forms.TextBox()
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
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.cmbdpto = New System.Windows.Forms.ComboBox()
        Me.DEPARTAMENTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UNIDOSDataSet = New WindowsApplication1.UNIDOSDataSet()
        Me.DEPARTAMENTOTableAdapter = New WindowsApplication1.UNIDOSDataSetTableAdapters.DEPARTAMENTOTableAdapter()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.cmbtipo = New System.Windows.Forms.ComboBox()
        Me.ti1 = New System.Windows.Forms.Label()
        CType(Me.DEPARTAMENTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UNIDOSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(76, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 15)
        Me.Label3.TabIndex = 184
        Me.Label3.Text = "Dirección"
        '
        'ced
        '
        Me.ced.AutoSize = True
        Me.ced.BackColor = System.Drawing.Color.Transparent
        Me.ced.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ced.ForeColor = System.Drawing.Color.Black
        Me.ced.Location = New System.Drawing.Point(75, 18)
        Me.ced.Name = "ced"
        Me.ced.Size = New System.Drawing.Size(53, 15)
        Me.ced.TabIndex = 181
        Me.ced.Text = "Cédula"
        '
        'txtcedula
        '
        Me.txtcedula.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcedula.ForeColor = System.Drawing.Color.Black
        Me.txtcedula.Location = New System.Drawing.Point(179, 18)
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.Size = New System.Drawing.Size(278, 22)
        Me.txtcedula.TabIndex = 180
        '
        'cmbestado
        '
        Me.cmbestado.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbestado.ForeColor = System.Drawing.Color.Black
        Me.cmbestado.FormattingEnabled = True
        Me.cmbestado.Items.AddRange(New Object() {"Estudiante", "Egresado", "Graduado", "Estudios no concluidos"})
        Me.cmbestado.Location = New System.Drawing.Point(182, 324)
        Me.cmbestado.Name = "cmbestado"
        Me.cmbestado.Size = New System.Drawing.Size(272, 23)
        Me.cmbestado.TabIndex = 179
        '
        'txtcarrera
        '
        Me.txtcarrera.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcarrera.ForeColor = System.Drawing.Color.Black
        Me.txtcarrera.Location = New System.Drawing.Point(182, 301)
        Me.txtcarrera.Name = "txtcarrera"
        Me.txtcarrera.Size = New System.Drawing.Size(272, 22)
        Me.txtcarrera.TabIndex = 178
        '
        'txtuniversidad
        '
        Me.txtuniversidad.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuniversidad.ForeColor = System.Drawing.Color.Black
        Me.txtuniversidad.Location = New System.Drawing.Point(182, 275)
        Me.txtuniversidad.Name = "txtuniversidad"
        Me.txtuniversidad.Size = New System.Drawing.Size(272, 22)
        Me.txtuniversidad.TabIndex = 177
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.ForeColor = System.Drawing.Color.Black
        Me.txtnombre.Location = New System.Drawing.Point(179, 44)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(278, 22)
        Me.txtnombre.TabIndex = 174
        '
        'est1
        '
        Me.est1.AutoSize = True
        Me.est1.BackColor = System.Drawing.Color.Transparent
        Me.est1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.est1.ForeColor = System.Drawing.Color.Black
        Me.est1.Location = New System.Drawing.Point(76, 327)
        Me.est1.Name = "est1"
        Me.est1.Size = New System.Drawing.Size(51, 15)
        Me.est1.TabIndex = 173
        Me.est1.Text = "Estado"
        '
        'car1
        '
        Me.car1.AutoSize = True
        Me.car1.BackColor = System.Drawing.Color.Transparent
        Me.car1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.car1.ForeColor = System.Drawing.Color.Black
        Me.car1.Location = New System.Drawing.Point(75, 301)
        Me.car1.Name = "car1"
        Me.car1.Size = New System.Drawing.Size(58, 15)
        Me.car1.TabIndex = 172
        Me.car1.Text = "Carrera"
        '
        'uni1
        '
        Me.uni1.AutoSize = True
        Me.uni1.BackColor = System.Drawing.Color.Transparent
        Me.uni1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uni1.ForeColor = System.Drawing.Color.Black
        Me.uni1.Location = New System.Drawing.Point(72, 278)
        Me.uni1.Name = "uni1"
        Me.uni1.Size = New System.Drawing.Size(90, 15)
        Me.uni1.TabIndex = 171
        Me.uni1.Text = "Universidad"
        '
        'dpto1
        '
        Me.dpto1.AutoSize = True
        Me.dpto1.BackColor = System.Drawing.Color.Transparent
        Me.dpto1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpto1.ForeColor = System.Drawing.Color.Black
        Me.dpto1.Location = New System.Drawing.Point(72, 239)
        Me.dpto1.Name = "dpto1"
        Me.dpto1.Size = New System.Drawing.Size(103, 15)
        Me.dpto1.TabIndex = 170
        Me.dpto1.Text = "Departamento"
        '
        'fec1
        '
        Me.fec1.AutoSize = True
        Me.fec1.BackColor = System.Drawing.Color.Transparent
        Me.fec1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fec1.ForeColor = System.Drawing.Color.Black
        Me.fec1.Location = New System.Drawing.Point(34, 200)
        Me.fec1.Name = "fec1"
        Me.fec1.Size = New System.Drawing.Size(145, 15)
        Me.fec1.TabIndex = 169
        Me.fec1.Text = "Fecha de nacimiento"
        '
        'mail1
        '
        Me.mail1.AutoSize = True
        Me.mail1.BackColor = System.Drawing.Color.Transparent
        Me.mail1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mail1.ForeColor = System.Drawing.Color.Black
        Me.mail1.Location = New System.Drawing.Point(76, 160)
        Me.mail1.Name = "mail1"
        Me.mail1.Size = New System.Drawing.Size(52, 15)
        Me.mail1.TabIndex = 168
        Me.mail1.Text = "E-mail"
        '
        'tel1
        '
        Me.tel1.AutoSize = True
        Me.tel1.BackColor = System.Drawing.Color.Transparent
        Me.tel1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tel1.ForeColor = System.Drawing.Color.Black
        Me.tel1.Location = New System.Drawing.Point(76, 104)
        Me.tel1.Name = "tel1"
        Me.tel1.Size = New System.Drawing.Size(67, 15)
        Me.tel1.TabIndex = 167
        Me.tel1.Text = "Teléfono"
        '
        'nom1
        '
        Me.nom1.AutoSize = True
        Me.nom1.BackColor = System.Drawing.Color.Transparent
        Me.nom1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom1.ForeColor = System.Drawing.Color.Black
        Me.nom1.Location = New System.Drawing.Point(72, 44)
        Me.nom1.Name = "nom1"
        Me.nom1.Size = New System.Drawing.Size(67, 15)
        Me.nom1.TabIndex = 164
        Me.nom1.Text = "Nombres"
        '
        'txtdireccion
        '
        Me.txtdireccion.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdireccion.Location = New System.Drawing.Point(178, 132)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(279, 22)
        Me.txtdireccion.TabIndex = 188
        '
        'fecha
        '
        Me.fecha.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Location = New System.Drawing.Point(179, 200)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(279, 22)
        Me.fecha.TabIndex = 187
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(178, 163)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(279, 22)
        Me.txtemail.TabIndex = 186
        '
        'txttelefono
        '
        Me.txttelefono.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelefono.Location = New System.Drawing.Point(178, 104)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(279, 22)
        Me.txttelefono.TabIndex = 185
        '
        'cmbdpto
        '
        Me.cmbdpto.DataSource = Me.DEPARTAMENTOBindingSource
        Me.cmbdpto.DisplayMember = "DptoID"
        Me.cmbdpto.FormattingEnabled = True
        Me.cmbdpto.Location = New System.Drawing.Point(179, 239)
        Me.cmbdpto.Name = "cmbdpto"
        Me.cmbdpto.Size = New System.Drawing.Size(272, 21)
        Me.cmbdpto.TabIndex = 189
        Me.cmbdpto.ValueMember = "DptoID"
        '
        'DEPARTAMENTOBindingSource
        '
        Me.DEPARTAMENTOBindingSource.DataMember = "DEPARTAMENTO"
        Me.DEPARTAMENTOBindingSource.DataSource = Me.UNIDOSDataSet
        '
        'UNIDOSDataSet
        '
        Me.UNIDOSDataSet.DataSetName = "UNIDOSDataSet"
        Me.UNIDOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DEPARTAMENTOTableAdapter
        '
        Me.DEPARTAMENTOTableAdapter.ClearBeforeFill = True
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.BlueViolet
        Me.btnguardar.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.Location = New System.Drawing.Point(524, 94)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(91, 38)
        Me.btnguardar.TabIndex = 191
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btnvolver
        '
        Me.btnvolver.BackColor = System.Drawing.Color.BlueViolet
        Me.btnvolver.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvolver.Location = New System.Drawing.Point(531, 205)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(84, 38)
        Me.btnvolver.TabIndex = 190
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = False
        '
        'cmbtipo
        '
        Me.cmbtipo.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtipo.ForeColor = System.Drawing.Color.Black
        Me.cmbtipo.FormattingEnabled = True
        Me.cmbtipo.Items.AddRange(New Object() {"Voluntario", "Donante", "Cliente"})
        Me.cmbtipo.Location = New System.Drawing.Point(179, 71)
        Me.cmbtipo.Name = "cmbtipo"
        Me.cmbtipo.Size = New System.Drawing.Size(272, 23)
        Me.cmbtipo.TabIndex = 193
        '
        'ti1
        '
        Me.ti1.AutoSize = True
        Me.ti1.BackColor = System.Drawing.Color.Transparent
        Me.ti1.Font = New System.Drawing.Font("Cooper Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ti1.ForeColor = System.Drawing.Color.Black
        Me.ti1.Location = New System.Drawing.Point(72, 74)
        Me.ti1.Name = "ti1"
        Me.ti1.Size = New System.Drawing.Size(39, 15)
        Me.ti1.TabIndex = 192
        Me.ti1.Text = "Tipo"
        '
        'Ingresarpersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(792, 448)
        Me.Controls.Add(Me.cmbtipo)
        Me.Controls.Add(Me.ti1)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.cmbdpto)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ced)
        Me.Controls.Add(Me.txtcedula)
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
        Me.Name = "Ingresarpersonas"
        Me.Text = "Ingresar personas"
        CType(Me.DEPARTAMENTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UNIDOSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents ced As Label
    Friend WithEvents txtcedula As TextBox
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
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents fecha As DateTimePicker
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents cmbdpto As ComboBox
    Friend WithEvents UNIDOSDataSet As UNIDOSDataSet
    Friend WithEvents DEPARTAMENTOBindingSource As BindingSource
    Friend WithEvents DEPARTAMENTOTableAdapter As UNIDOSDataSetTableAdapters.DEPARTAMENTOTableAdapter
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnvolver As Button
    Friend WithEvents cmbtipo As ComboBox
    Friend WithEvents ti1 As Label
End Class
