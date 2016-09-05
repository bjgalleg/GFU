<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Nuevoproyecto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nuevoproyecto))
        Me.txtnombreproy = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcomunidad = New System.Windows.Forms.TextBox()
        Me.cmbtipo = New System.Windows.Forms.ComboBox()
        Me.ffinal = New System.Windows.Forms.DateTimePicker()
        Me.finicio = New System.Windows.Forms.DateTimePicker()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tipo = New System.Windows.Forms.Label()
        Me.Departamento = New System.Windows.Forms.Label()
        Me.cmbdpto = New System.Windows.Forms.ComboBox()
        Me.UNIDOSBGDataSet4 = New WindowsApplication1.UNIDOSBGDataSet4()
        Me.DEPARTAMENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DEPARTAMENTOSTableAdapter = New WindowsApplication1.UNIDOSBGDataSet4TableAdapters.DEPARTAMENTOSTableAdapter()
        CType(Me.UNIDOSBGDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEPARTAMENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnombreproy
        '
        Me.txtnombreproy.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombreproy.Location = New System.Drawing.Point(307, 79)
        Me.txtnombreproy.Name = "txtnombreproy"
        Me.txtnombreproy.Size = New System.Drawing.Size(295, 26)
        Me.txtnombreproy.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(46, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(173, 19)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Nombre de Proyecto"
        '
        'txtcomunidad
        '
        Me.txtcomunidad.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcomunidad.Location = New System.Drawing.Point(307, 107)
        Me.txtcomunidad.Name = "txtcomunidad"
        Me.txtcomunidad.Size = New System.Drawing.Size(295, 26)
        Me.txtcomunidad.TabIndex = 39
        '
        'cmbtipo
        '
        Me.cmbtipo.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtipo.FormattingEnabled = True
        Me.cmbtipo.Items.AddRange(New Object() {"Proyecto colaborativo", "Proyecto único", "Misión universitaria", "Misión comunitaria"})
        Me.cmbtipo.Location = New System.Drawing.Point(307, 144)
        Me.cmbtipo.Name = "cmbtipo"
        Me.cmbtipo.Size = New System.Drawing.Size(295, 27)
        Me.cmbtipo.TabIndex = 38
        '
        'ffinal
        '
        Me.ffinal.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ffinal.Location = New System.Drawing.Point(307, 217)
        Me.ffinal.Name = "ffinal"
        Me.ffinal.Size = New System.Drawing.Size(295, 26)
        Me.ffinal.TabIndex = 37
        '
        'finicio
        '
        Me.finicio.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.finicio.Location = New System.Drawing.Point(307, 180)
        Me.finicio.Name = "finicio"
        Me.finicio.Size = New System.Drawing.Size(295, 26)
        Me.finicio.TabIndex = 36
        '
        'btnvolver
        '
        Me.btnvolver.BackColor = System.Drawing.Color.DarkRed
        Me.btnvolver.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvolver.ForeColor = System.Drawing.Color.White
        Me.btnvolver.Location = New System.Drawing.Point(369, 344)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(100, 26)
        Me.btnvolver.TabIndex = 35
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.DarkRed
        Me.btnguardar.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.White
        Me.btnguardar.Location = New System.Drawing.Point(231, 344)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(103, 26)
        Me.btnguardar.TabIndex = 34
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(49, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 19)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Fecha final"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(49, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 19)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Fecha inicio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(49, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 19)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Comunidad"
        '
        'Tipo
        '
        Me.Tipo.AutoSize = True
        Me.Tipo.BackColor = System.Drawing.Color.Transparent
        Me.Tipo.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tipo.ForeColor = System.Drawing.Color.White
        Me.Tipo.Location = New System.Drawing.Point(46, 147)
        Me.Tipo.Name = "Tipo"
        Me.Tipo.Size = New System.Drawing.Size(47, 19)
        Me.Tipo.TabIndex = 43
        Me.Tipo.Text = "Tipo"
        '
        'Departamento
        '
        Me.Departamento.AutoSize = True
        Me.Departamento.BackColor = System.Drawing.Color.Transparent
        Me.Departamento.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Departamento.ForeColor = System.Drawing.Color.White
        Me.Departamento.Location = New System.Drawing.Point(49, 255)
        Me.Departamento.Name = "Departamento"
        Me.Departamento.Size = New System.Drawing.Size(126, 19)
        Me.Departamento.TabIndex = 47
        Me.Departamento.Text = "Departamento"
        '
        'cmbdpto
        '
        Me.cmbdpto.DataSource = Me.DEPARTAMENTOSBindingSource
        Me.cmbdpto.DisplayMember = "DptoID"
        Me.cmbdpto.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdpto.FormattingEnabled = True
        Me.cmbdpto.Location = New System.Drawing.Point(310, 252)
        Me.cmbdpto.Name = "cmbdpto"
        Me.cmbdpto.Size = New System.Drawing.Size(295, 27)
        Me.cmbdpto.TabIndex = 46
        Me.cmbdpto.ValueMember = "DptoID"
        '
        'UNIDOSBGDataSet4
        '
        Me.UNIDOSBGDataSet4.DataSetName = "UNIDOSBGDataSet4"
        Me.UNIDOSBGDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DEPARTAMENTOSBindingSource
        '
        Me.DEPARTAMENTOSBindingSource.DataMember = "DEPARTAMENTOS"
        Me.DEPARTAMENTOSBindingSource.DataSource = Me.UNIDOSBGDataSet4
        '
        'DEPARTAMENTOSTableAdapter
        '
        Me.DEPARTAMENTOSTableAdapter.ClearBeforeFill = True
        '
        'Nuevoproyecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(772, 475)
        Me.Controls.Add(Me.Departamento)
        Me.Controls.Add(Me.cmbdpto)
        Me.Controls.Add(Me.Tipo)
        Me.Controls.Add(Me.txtnombreproy)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtcomunidad)
        Me.Controls.Add(Me.cmbtipo)
        Me.Controls.Add(Me.ffinal)
        Me.Controls.Add(Me.finicio)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Nuevoproyecto"
        Me.Text = "Nuevo proyecto"
        CType(Me.UNIDOSBGDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEPARTAMENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnombreproy As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtcomunidad As TextBox
    Friend WithEvents cmbtipo As ComboBox
    Friend WithEvents ffinal As DateTimePicker
    Friend WithEvents finicio As DateTimePicker
    Friend WithEvents btnvolver As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Tipo As Label
    Friend WithEvents Departamento As Label
    Friend WithEvents cmbdpto As ComboBox
    Friend WithEvents UNIDOSBGDataSet4 As UNIDOSBGDataSet4
    Friend WithEvents DEPARTAMENTOSBindingSource As BindingSource
    Friend WithEvents DEPARTAMENTOSTableAdapter As UNIDOSBGDataSet4TableAdapters.DEPARTAMENTOSTableAdapter
End Class
