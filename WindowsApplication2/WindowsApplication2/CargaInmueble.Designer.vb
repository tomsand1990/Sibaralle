<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CargaInmueble
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
        Dim NombreL As System.Windows.Forms.Label
        Dim DNIL As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CargaInmueble))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Direccion = New System.Windows.Forms.TextBox()
        Me.Comisionlabel = New System.Windows.Forms.Label()
        Me.Comision = New System.Windows.Forms.TextBox()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.Volver = New System.Windows.Forms.Button()
        Me.NombreLabel = New System.Windows.Forms.Label()
        Me.DNILabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ApellidoCombo = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InquilinosDataSet = New WindowsApplication2.InquilinosDataSet()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New WindowsApplication2.InquilinosDataSetTableAdapters.ClientesTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        NombreL = New System.Windows.Forms.Label()
        DNIL = New System.Windows.Forms.Label()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InquilinosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NombreL
        '
        NombreL.AutoSize = True
        NombreL.Location = New System.Drawing.Point(17, 55)
        NombreL.Name = "NombreL"
        NombreL.Size = New System.Drawing.Size(47, 13)
        NombreL.TabIndex = 25
        NombreL.Text = "Nombre:"
        '
        'DNIL
        '
        DNIL.AutoSize = True
        DNIL.Location = New System.Drawing.Point(226, 22)
        DNIL.Name = "DNIL"
        DNIL.Size = New System.Drawing.Size(29, 13)
        DNIL.TabIndex = 26
        DNIL.Text = "DNI:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Dirección"
        '
        'Direccion
        '
        Me.Direccion.Location = New System.Drawing.Point(99, 43)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(155, 20)
        Me.Direccion.TabIndex = 3
        '
        'Comisionlabel
        '
        Me.Comisionlabel.AutoSize = True
        Me.Comisionlabel.Location = New System.Drawing.Point(41, 69)
        Me.Comisionlabel.Name = "Comisionlabel"
        Me.Comisionlabel.Size = New System.Drawing.Size(49, 13)
        Me.Comisionlabel.TabIndex = 8
        Me.Comisionlabel.Text = "Comisión"
        '
        'Comision
        '
        Me.Comision.Location = New System.Drawing.Point(99, 69)
        Me.Comision.Name = "Comision"
        Me.Comision.Size = New System.Drawing.Size(155, 20)
        Me.Comision.TabIndex = 7
        '
        'Limpiar
        '
        Me.Limpiar.Location = New System.Drawing.Point(86, 118)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(108, 57)
        Me.Limpiar.TabIndex = 21
        Me.Limpiar.Text = "Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'Guardar
        '
        Me.Guardar.Location = New System.Drawing.Point(331, 118)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(108, 57)
        Me.Guardar.TabIndex = 22
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'Volver
        '
        Me.Volver.Location = New System.Drawing.Point(588, 118)
        Me.Volver.Name = "Volver"
        Me.Volver.Size = New System.Drawing.Size(108, 57)
        Me.Volver.TabIndex = 23
        Me.Volver.Text = "Volver"
        Me.Volver.UseVisualStyleBackColor = True
        '
        'NombreLabel
        '
        Me.NombreLabel.Location = New System.Drawing.Point(70, 55)
        Me.NombreLabel.Name = "NombreLabel"
        Me.NombreLabel.Size = New System.Drawing.Size(100, 23)
        Me.NombreLabel.TabIndex = 26
        '
        'DNILabel
        '
        Me.DNILabel.Location = New System.Drawing.Point(261, 22)
        Me.DNILabel.Name = "DNILabel"
        Me.DNILabel.Size = New System.Drawing.Size(100, 23)
        Me.DNILabel.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Apellido"
        '
        'ApellidoCombo
        '
        Me.ApellidoCombo.DataSource = Me.ClientesBindingSource1
        Me.ApellidoCombo.DisplayMember = "Apellido"
        Me.ApellidoCombo.FormattingEnabled = True
        Me.ApellidoCombo.Location = New System.Drawing.Point(73, 22)
        Me.ApellidoCombo.Name = "ApellidoCombo"
        Me.ApellidoCombo.Size = New System.Drawing.Size(121, 21)
        Me.ApellidoCombo.TabIndex = 30
        Me.ApellidoCombo.ValueMember = "Apellido"
        '
        'ClientesBindingSource1
        '
        Me.ClientesBindingSource1.DataMember = "Clientes"
        Me.ClientesBindingSource1.DataSource = Me.InquilinosDataSet
        '
        'InquilinosDataSet
        '
        Me.InquilinosDataSet.DataSetName = "InquilinosDataSet"
        Me.InquilinosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.InquilinosDataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ApellidoCombo)
        Me.GroupBox1.Controls.Add(DNIL)
        Me.GroupBox1.Controls.Add(Me.DNILabel)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(NombreL)
        Me.GroupBox1.Controls.Add(Me.NombreLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(324, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 88)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LOCADOR"
        '
        'CargaInmueble
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 191)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Volver)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.Comisionlabel)
        Me.Controls.Add(Me.Comision)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Direccion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CargaInmueble"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga Inmueble"
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InquilinosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Direccion As System.Windows.Forms.TextBox
    Friend WithEvents Comisionlabel As System.Windows.Forms.Label
    Friend WithEvents Comision As System.Windows.Forms.TextBox
    Friend WithEvents Limpiar As System.Windows.Forms.Button
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents Volver As System.Windows.Forms.Button
    Friend WithEvents NombreLabel As System.Windows.Forms.Label
    Friend WithEvents DNILabel As System.Windows.Forms.Label
    Friend WithEvents ClientesTableAdapter1 As WindowsApplication2.InquilinosDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication2.InquilinosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ApellidoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents InquilinosDataSet As WindowsApplication2.InquilinosDataSet
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As WindowsApplication2.InquilinosDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents ClientesBindingSource1 As BindingSource
    Friend WithEvents GroupBox1 As GroupBox
End Class
