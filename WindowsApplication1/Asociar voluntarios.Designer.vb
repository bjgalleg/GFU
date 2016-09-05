<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbproyecto = New System.Windows.Forms.ComboBox()
        Me.cmbvoluntario = New System.Windows.Forms.ComboBox()
        Me.datagridvoluntario = New System.Windows.Forms.DataGridView()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btnquitar = New System.Windows.Forms.Button()
        Me.UNIDOSBGDataSet5 = New WindowsApplication1.UNIDOSBGDataSet5()
        Me.PROYECTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROYECTOSTableAdapter = New WindowsApplication1.UNIDOSBGDataSet5TableAdapters.PROYECTOSTableAdapter()
        Me.PERSONASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PERSONASTableAdapter = New WindowsApplication1.UNIDOSBGDataSet5TableAdapters.PERSONASTableAdapter()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnquitarpro = New System.Windows.Forms.Button()
        Me.btnagregarpro = New System.Windows.Forms.Button()
        Me.datagridproyecto = New System.Windows.Forms.DataGridView()
        Me.cmbproyecto1 = New System.Windows.Forms.ComboBox()
        Me.cmbvoluntario1 = New System.Windows.Forms.ComboBox()
        Me.btnbuscarpro = New System.Windows.Forms.Button()
        Me.gboxvoluntarios = New System.Windows.Forms.GroupBox()
        Me.btnbuscarvol = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PERSONASBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UNIDOSBGDataSet5BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROYECTOSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.datagridvoluntario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UNIDOSBGDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROYECTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERSONASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.datagridproyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxvoluntarios.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PERSONASBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UNIDOSBGDataSet5BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROYECTOSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione Proyecto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Seleccione voluntario"
        '
        'cmbproyecto
        '
        Me.cmbproyecto.DataSource = Me.PROYECTOSBindingSource
        Me.cmbproyecto.DisplayMember = "Nombre"
        Me.cmbproyecto.FormattingEnabled = True
        Me.cmbproyecto.Location = New System.Drawing.Point(218, 22)
        Me.cmbproyecto.Name = "cmbproyecto"
        Me.cmbproyecto.Size = New System.Drawing.Size(262, 21)
        Me.cmbproyecto.TabIndex = 2
        Me.cmbproyecto.ValueMember = "ProyectoID"
        '
        'cmbvoluntario
        '
        Me.cmbvoluntario.DataSource = Me.PERSONASBindingSource
        Me.cmbvoluntario.DisplayMember = "NombreCompleto"
        Me.cmbvoluntario.FormattingEnabled = True
        Me.cmbvoluntario.Location = New System.Drawing.Point(176, 23)
        Me.cmbvoluntario.Name = "cmbvoluntario"
        Me.cmbvoluntario.Size = New System.Drawing.Size(262, 21)
        Me.cmbvoluntario.TabIndex = 3
        '
        'datagridvoluntario
        '
        Me.datagridvoluntario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridvoluntario.Location = New System.Drawing.Point(84, 269)
        Me.datagridvoluntario.Name = "datagridvoluntario"
        Me.datagridvoluntario.Size = New System.Drawing.Size(572, 150)
        Me.datagridvoluntario.TabIndex = 4
        '
        'btnagregar
        '
        Me.btnagregar.Location = New System.Drawing.Point(229, 29)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(75, 23)
        Me.btnagregar.TabIndex = 5
        Me.btnagregar.Text = "Añadir"
        Me.btnagregar.UseVisualStyleBackColor = True
        '
        'btnquitar
        '
        Me.btnquitar.Location = New System.Drawing.Point(229, 76)
        Me.btnquitar.Name = "btnquitar"
        Me.btnquitar.Size = New System.Drawing.Size(75, 23)
        Me.btnquitar.TabIndex = 6
        Me.btnquitar.Text = "Quitar"
        Me.btnquitar.UseVisualStyleBackColor = True
        '
        'UNIDOSBGDataSet5
        '
        Me.UNIDOSBGDataSet5.DataSetName = "UNIDOSBGDataSet5"
        Me.UNIDOSBGDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PROYECTOSBindingSource
        '
        Me.PROYECTOSBindingSource.DataMember = "PROYECTOS"
        Me.PROYECTOSBindingSource.DataSource = Me.UNIDOSBGDataSet5
        '
        'PROYECTOSTableAdapter
        '
        Me.PROYECTOSTableAdapter.ClearBeforeFill = True
        '
        'PERSONASBindingSource
        '
        Me.PERSONASBindingSource.DataMember = "PERSONAS"
        Me.PERSONASBindingSource.DataSource = Me.UNIDOSBGDataSet5
        '
        'PERSONASTableAdapter
        '
        Me.PERSONASTableAdapter.ClearBeforeFill = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(41, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(780, 451)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.btnbuscarvol)
        Me.TabPage1.Controls.Add(Me.cmbproyecto)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.datagridvoluntario)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(772, 425)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Voluntario"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.gboxvoluntarios)
        Me.TabPage2.Controls.Add(Me.btnbuscarpro)
        Me.TabPage2.Controls.Add(Me.datagridproyecto)
        Me.TabPage2.Controls.Add(Me.cmbvoluntario)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(772, 425)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Proyecto"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnquitarpro
        '
        Me.btnquitarpro.Location = New System.Drawing.Point(200, 66)
        Me.btnquitarpro.Name = "btnquitarpro"
        Me.btnquitarpro.Size = New System.Drawing.Size(75, 23)
        Me.btnquitarpro.TabIndex = 11
        Me.btnquitarpro.Text = "Quitar"
        Me.btnquitarpro.UseVisualStyleBackColor = True
        '
        'btnagregarpro
        '
        Me.btnagregarpro.Location = New System.Drawing.Point(200, 19)
        Me.btnagregarpro.Name = "btnagregarpro"
        Me.btnagregarpro.Size = New System.Drawing.Size(75, 23)
        Me.btnagregarpro.TabIndex = 10
        Me.btnagregarpro.Text = "Añadir"
        Me.btnagregarpro.UseVisualStyleBackColor = True
        '
        'datagridproyecto
        '
        Me.datagridproyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridproyecto.Location = New System.Drawing.Point(102, 257)
        Me.datagridproyecto.Name = "datagridproyecto"
        Me.datagridproyecto.Size = New System.Drawing.Size(572, 150)
        Me.datagridproyecto.TabIndex = 9
        '
        'cmbproyecto1
        '
        Me.cmbproyecto1.DataSource = Me.PROYECTOSBindingSource1
        Me.cmbproyecto1.DisplayMember = "Nombre"
        Me.cmbproyecto1.FormattingEnabled = True
        Me.cmbproyecto1.Location = New System.Drawing.Point(30, 35)
        Me.cmbproyecto1.Name = "cmbproyecto1"
        Me.cmbproyecto1.Size = New System.Drawing.Size(146, 21)
        Me.cmbproyecto1.TabIndex = 12
        Me.cmbproyecto1.ValueMember = "ProyectoID"
        '
        'cmbvoluntario1
        '
        Me.cmbvoluntario1.DataSource = Me.PERSONASBindingSource1
        Me.cmbvoluntario1.DisplayMember = "NombreCompleto"
        Me.cmbvoluntario1.FormattingEnabled = True
        Me.cmbvoluntario1.Location = New System.Drawing.Point(39, 48)
        Me.cmbvoluntario1.Name = "cmbvoluntario1"
        Me.cmbvoluntario1.Size = New System.Drawing.Size(149, 21)
        Me.cmbvoluntario1.TabIndex = 8
        Me.cmbvoluntario1.ValueMember = "Cedula"
        '
        'btnbuscarpro
        '
        Me.btnbuscarpro.Location = New System.Drawing.Point(505, 21)
        Me.btnbuscarpro.Name = "btnbuscarpro"
        Me.btnbuscarpro.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscarpro.TabIndex = 13
        Me.btnbuscarpro.Text = "buscar"
        Me.btnbuscarpro.UseVisualStyleBackColor = True
        '
        'gboxvoluntarios
        '
        Me.gboxvoluntarios.Controls.Add(Me.btnagregarpro)
        Me.gboxvoluntarios.Controls.Add(Me.btnquitarpro)
        Me.gboxvoluntarios.Controls.Add(Me.cmbproyecto1)
        Me.gboxvoluntarios.Location = New System.Drawing.Point(216, 108)
        Me.gboxvoluntarios.Name = "gboxvoluntarios"
        Me.gboxvoluntarios.Size = New System.Drawing.Size(304, 100)
        Me.gboxvoluntarios.TabIndex = 14
        Me.gboxvoluntarios.TabStop = False
        Me.gboxvoluntarios.Text = "Proyectos"
        '
        'btnbuscarvol
        '
        Me.btnbuscarvol.Location = New System.Drawing.Point(564, 22)
        Me.btnbuscarvol.Name = "btnbuscarvol"
        Me.btnbuscarvol.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscarvol.TabIndex = 14
        Me.btnbuscarvol.Text = "buscar"
        Me.btnbuscarvol.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnagregar)
        Me.GroupBox1.Controls.Add(Me.btnquitar)
        Me.GroupBox1.Controls.Add(Me.cmbvoluntario1)
        Me.GroupBox1.Location = New System.Drawing.Point(179, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(349, 122)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Voluntarios"
        '
        'PERSONASBindingSource1
        '
        Me.PERSONASBindingSource1.DataMember = "PERSONAS"
        Me.PERSONASBindingSource1.DataSource = Me.UNIDOSBGDataSet5
        '
        'UNIDOSBGDataSet5BindingSource
        '
        Me.UNIDOSBGDataSet5BindingSource.DataSource = Me.UNIDOSBGDataSet5
        Me.UNIDOSBGDataSet5BindingSource.Position = 0
        '
        'PROYECTOSBindingSource1
        '
        Me.PROYECTOSBindingSource1.DataMember = "PROYECTOS"
        Me.PROYECTOSBindingSource1.DataSource = Me.UNIDOSBGDataSet5BindingSource
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 475)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form6"
        Me.Text = "Asociar voluntarios"
        CType(Me.datagridvoluntario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UNIDOSBGDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROYECTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERSONASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.datagridproyecto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxvoluntarios.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PERSONASBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UNIDOSBGDataSet5BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROYECTOSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbproyecto As ComboBox
    Friend WithEvents cmbvoluntario As ComboBox
    Friend WithEvents datagridvoluntario As DataGridView
    Friend WithEvents btnagregar As Button
    Friend WithEvents btnquitar As Button
    Friend WithEvents UNIDOSBGDataSet5 As UNIDOSBGDataSet5
    Friend WithEvents PROYECTOSBindingSource As BindingSource
    Friend WithEvents PROYECTOSTableAdapter As UNIDOSBGDataSet5TableAdapters.PROYECTOSTableAdapter
    Friend WithEvents PERSONASBindingSource As BindingSource
    Friend WithEvents PERSONASTableAdapter As UNIDOSBGDataSet5TableAdapters.PERSONASTableAdapter
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnquitarpro As Button
    Friend WithEvents btnagregarpro As Button
    Friend WithEvents datagridproyecto As DataGridView
    Friend WithEvents cmbvoluntario1 As ComboBox
    Friend WithEvents cmbproyecto1 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PERSONASBindingSource1 As BindingSource
    Friend WithEvents btnbuscarvol As Button
    Friend WithEvents gboxvoluntarios As GroupBox
    Friend WithEvents btnbuscarpro As Button
    Friend WithEvents PROYECTOSBindingSource1 As BindingSource
    Friend WithEvents UNIDOSBGDataSet5BindingSource As BindingSource
End Class
