<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eliminar_proyecto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Eliminar_proyecto))
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.ced = New System.Windows.Forms.Label()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.cmbeliminarproyecto = New System.Windows.Forms.ComboBox()
        Me.UNIDOSBGDataSet1 = New WindowsApplication1.UNIDOSBGDataSet1()
        Me.PROYECTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROYECTOSTableAdapter = New WindowsApplication1.UNIDOSBGDataSet1TableAdapters.PROYECTOSTableAdapter()
        CType(Me.UNIDOSBGDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROYECTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btneliminar
        '
        Me.btneliminar.BackColor = System.Drawing.Color.DarkRed
        Me.btneliminar.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar.ForeColor = System.Drawing.Color.White
        Me.btneliminar.Location = New System.Drawing.Point(187, 224)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 16
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = False
        '
        'ced
        '
        Me.ced.AutoSize = True
        Me.ced.BackColor = System.Drawing.Color.Transparent
        Me.ced.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ced.ForeColor = System.Drawing.Color.White
        Me.ced.Location = New System.Drawing.Point(184, 134)
        Me.ced.Name = "ced"
        Me.ced.Size = New System.Drawing.Size(190, 17)
        Me.ced.TabIndex = 18
        Me.ced.Text = "Ingrese codigo proyecto"
        '
        'btnvolver
        '
        Me.btnvolver.BackColor = System.Drawing.Color.DarkRed
        Me.btnvolver.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvolver.ForeColor = System.Drawing.Color.White
        Me.btnvolver.Location = New System.Drawing.Point(304, 224)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(75, 23)
        Me.btnvolver.TabIndex = 17
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = False
        '
        'cmbeliminarproyecto
        '
        Me.cmbeliminarproyecto.DataSource = Me.PROYECTOSBindingSource
        Me.cmbeliminarproyecto.DisplayMember = "Nombre"
        Me.cmbeliminarproyecto.FormattingEnabled = True
        Me.cmbeliminarproyecto.Location = New System.Drawing.Point(187, 173)
        Me.cmbeliminarproyecto.Name = "cmbeliminarproyecto"
        Me.cmbeliminarproyecto.Size = New System.Drawing.Size(192, 21)
        Me.cmbeliminarproyecto.TabIndex = 19
        Me.cmbeliminarproyecto.ValueMember = "Nombre"
        '
        'UNIDOSBGDataSet1
        '
        Me.UNIDOSBGDataSet1.DataSetName = "UNIDOSBGDataSet1"
        Me.UNIDOSBGDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PROYECTOSBindingSource
        '
        Me.PROYECTOSBindingSource.DataMember = "PROYECTOS"
        Me.PROYECTOSBindingSource.DataSource = Me.UNIDOSBGDataSet1
        '
        'PROYECTOSTableAdapter
        '
        Me.PROYECTOSTableAdapter.ClearBeforeFill = True
        '
        'Eliminar_proyecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(566, 388)
        Me.Controls.Add(Me.cmbeliminarproyecto)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.ced)
        Me.Controls.Add(Me.btnvolver)
        Me.Name = "Eliminar_proyecto"
        Me.Text = "Eliminar_proyecto"
        CType(Me.UNIDOSBGDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROYECTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btneliminar As Button
    Friend WithEvents ced As Label
    Friend WithEvents btnvolver As Button
    Friend WithEvents cmbeliminarproyecto As ComboBox
    Friend WithEvents UNIDOSBGDataSet1 As UNIDOSBGDataSet1
    Friend WithEvents PROYECTOSBindingSource As BindingSource
    Friend WithEvents PROYECTOSTableAdapter As UNIDOSBGDataSet1TableAdapters.PROYECTOSTableAdapter
End Class
