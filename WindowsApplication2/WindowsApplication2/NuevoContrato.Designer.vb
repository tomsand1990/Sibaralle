<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoContrato
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
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim DireccionLabel1 As System.Windows.Forms.Label
        Dim DNIL As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevoContrato))
        Me.P0 = New System.Windows.Forms.TextBox()
        Me.P1 = New System.Windows.Forms.TextBox()
        Me.P2 = New System.Windows.Forms.TextBox()
        Me.P3 = New System.Windows.Forms.TextBox()
        Me.FI = New System.Windows.Forms.DateTimePicker()
        Me.FI1 = New System.Windows.Forms.DateTimePicker()
        Me.FI2 = New System.Windows.Forms.DateTimePicker()
        Me.FI3 = New System.Windows.Forms.DateTimePicker()
        Me.FF = New System.Windows.Forms.DateTimePicker()
        Me.Volver = New System.Windows.Forms.Button()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ApellidoComboBox = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InquilinosDataSet = New WindowsApplication2.InquilinosDataSet()
        Me.DireccionComboBox1 = New System.Windows.Forms.ComboBox()
        Me.InmueblesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New WindowsApplication2.InquilinosDataSetTableAdapters.ClientesTableAdapter()
        Me.InmueblesTableAdapter = New WindowsApplication2.InquilinosDataSetTableAdapters.InmueblesTableAdapter()
        Me.TableAdapterManager = New WindowsApplication2.InquilinosDataSetTableAdapters.TableAdapterManager()
        Me.DNILabel = New System.Windows.Forms.Label()
        Me.FKContratosInmueblesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InmueblesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NombreLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Intervalo = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        DireccionLabel1 = New System.Windows.Forms.Label()
        DNIL = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InquilinosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InmueblesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKContratosInmueblesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InmueblesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(17, 29)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(47, 13)
        ApellidoLabel.TabIndex = 67
        ApellidoLabel.Text = "Apellido:"
        '
        'DireccionLabel1
        '
        DireccionLabel1.AutoSize = True
        DireccionLabel1.Location = New System.Drawing.Point(18, 110)
        DireccionLabel1.Name = "DireccionLabel1"
        DireccionLabel1.Size = New System.Drawing.Size(55, 13)
        DireccionLabel1.TabIndex = 70
        DireccionLabel1.Text = "Direccion:"
        '
        'DNIL
        '
        DNIL.AutoSize = True
        DNIL.Location = New System.Drawing.Point(405, 29)
        DNIL.Name = "DNIL"
        DNIL.Size = New System.Drawing.Size(29, 13)
        DNIL.TabIndex = 71
        DNIL.Text = "DNI:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(215, 29)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(47, 13)
        Label10.TabIndex = 73
        Label10.Text = "Nombre:"
        '
        'P0
        '
        Me.P0.Location = New System.Drawing.Point(454, 170)
        Me.P0.Name = "P0"
        Me.P0.Size = New System.Drawing.Size(97, 20)
        Me.P0.TabIndex = 4
        '
        'P1
        '
        Me.P1.Location = New System.Drawing.Point(454, 196)
        Me.P1.Name = "P1"
        Me.P1.Size = New System.Drawing.Size(97, 20)
        Me.P1.TabIndex = 5
        '
        'P2
        '
        Me.P2.Location = New System.Drawing.Point(454, 222)
        Me.P2.Name = "P2"
        Me.P2.Size = New System.Drawing.Size(97, 20)
        Me.P2.TabIndex = 6
        '
        'P3
        '
        Me.P3.Location = New System.Drawing.Point(454, 248)
        Me.P3.Name = "P3"
        Me.P3.Size = New System.Drawing.Size(97, 20)
        Me.P3.TabIndex = 7
        '
        'FI
        '
        Me.FI.Location = New System.Drawing.Point(104, 170)
        Me.FI.Name = "FI"
        Me.FI.Size = New System.Drawing.Size(200, 20)
        Me.FI.TabIndex = 8
        '
        'FI1
        '
        Me.FI1.Location = New System.Drawing.Point(104, 196)
        Me.FI1.Name = "FI1"
        Me.FI1.Size = New System.Drawing.Size(200, 20)
        Me.FI1.TabIndex = 9
        '
        'FI2
        '
        Me.FI2.Location = New System.Drawing.Point(104, 222)
        Me.FI2.Name = "FI2"
        Me.FI2.Size = New System.Drawing.Size(200, 20)
        Me.FI2.TabIndex = 10
        '
        'FI3
        '
        Me.FI3.Location = New System.Drawing.Point(104, 248)
        Me.FI3.Name = "FI3"
        Me.FI3.Size = New System.Drawing.Size(200, 20)
        Me.FI3.TabIndex = 11
        '
        'FF
        '
        Me.FF.Location = New System.Drawing.Point(104, 274)
        Me.FF.Name = "FF"
        Me.FF.Size = New System.Drawing.Size(200, 20)
        Me.FF.TabIndex = 12
        '
        'Volver
        '
        Me.Volver.Location = New System.Drawing.Point(452, 314)
        Me.Volver.Name = "Volver"
        Me.Volver.Size = New System.Drawing.Size(100, 60)
        Me.Volver.TabIndex = 56
        Me.Volver.Text = "Volver"
        Me.Volver.UseVisualStyleBackColor = True
        '
        'Guardar
        '
        Me.Guardar.Location = New System.Drawing.Point(227, 314)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(100, 60)
        Me.Guardar.TabIndex = 55
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'Limpiar
        '
        Me.Limpiar.Location = New System.Drawing.Point(29, 314)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(100, 60)
        Me.Limpiar.TabIndex = 54
        Me.Limpiar.Text = "Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(375, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Precio Inicio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(375, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Incremento 1:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(375, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Incremento 2:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(375, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Incremento 3:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Fecha Inicio: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Incremento 1:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Incremento 2:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 251)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Incremento 3: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 278)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "Fecha Fin:"
        '
        'ApellidoComboBox
        '
        Me.ApellidoComboBox.DataSource = Me.ClientesBindingSource
        Me.ApellidoComboBox.DisplayMember = "Apellido"
        Me.ApellidoComboBox.FormattingEnabled = True
        Me.ApellidoComboBox.Location = New System.Drawing.Point(70, 26)
        Me.ApellidoComboBox.Name = "ApellidoComboBox"
        Me.ApellidoComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ApellidoComboBox.TabIndex = 70
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.InquilinosDataSet
        '
        'InquilinosDataSet
        '
        Me.InquilinosDataSet.DataSetName = "InquilinosDataSet"
        Me.InquilinosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DireccionComboBox1
        '
        Me.DireccionComboBox1.DataSource = Me.InmueblesBindingSource
        Me.DireccionComboBox1.DisplayMember = "Direccion"
        Me.DireccionComboBox1.FormattingEnabled = True
        Me.DireccionComboBox1.Location = New System.Drawing.Point(79, 107)
        Me.DireccionComboBox1.Name = "DireccionComboBox1"
        Me.DireccionComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.DireccionComboBox1.TabIndex = 71
        '
        'InmueblesBindingSource
        '
        Me.InmueblesBindingSource.DataMember = "Inmuebles"
        Me.InmueblesBindingSource.DataSource = Me.InquilinosDataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'InmueblesTableAdapter
        '
        Me.InmueblesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AguaTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.ContratosTableAdapter = Nothing
        Me.TableAdapterManager.DGRTableAdapter = Nothing
        Me.TableAdapterManager.GasTableAdapter = Nothing
        Me.TableAdapterManager.InmueblesTableAdapter = Me.InmueblesTableAdapter
        Me.TableAdapterManager.LuzTableAdapter = Nothing
        Me.TableAdapterManager.MuniTableAdapter = Nothing
        Me.TableAdapterManager.PagosTableAdapter = Nothing
        Me.TableAdapterManager.ReclamosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication2.InquilinosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DNILabel
        '
        Me.DNILabel.Location = New System.Drawing.Point(440, 29)
        Me.DNILabel.Name = "DNILabel"
        Me.DNILabel.Size = New System.Drawing.Size(100, 23)
        Me.DNILabel.TabIndex = 72
        '
        'FKContratosInmueblesBindingSource
        '
        Me.FKContratosInmueblesBindingSource.DataMember = "FK_Contratos_Inmuebles"
        Me.FKContratosInmueblesBindingSource.DataSource = Me.InmueblesBindingSource
        '
        'InmueblesBindingSource1
        '
        Me.InmueblesBindingSource1.DataMember = "Inmuebles"
        Me.InmueblesBindingSource1.DataSource = Me.InquilinosDataSet
        '
        'NombreLabel
        '
        Me.NombreLabel.Location = New System.Drawing.Point(268, 29)
        Me.NombreLabel.Name = "NombreLabel"
        Me.NombreLabel.Size = New System.Drawing.Size(100, 23)
        Me.NombreLabel.TabIndex = 74
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(DNIL)
        Me.GroupBox1.Controls.Add(Me.DNILabel)
        Me.GroupBox1.Controls.Add(Label10)
        Me.GroupBox1.Controls.Add(Me.NombreLabel)
        Me.GroupBox1.Controls.Add(Me.ApellidoComboBox)
        Me.GroupBox1.Controls.Add(ApellidoLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(542, 72)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LOCATARIO"
        '
        'Intervalo
        '
        Me.Intervalo.DisplayMember = "0"
        Me.Intervalo.FormattingEnabled = True
        Me.Intervalo.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.Intervalo.Location = New System.Drawing.Point(440, 107)
        Me.Intervalo.Name = "Intervalo"
        Me.Intervalo.Size = New System.Drawing.Size(39, 21)
        Me.Intervalo.TabIndex = 76
        Me.Intervalo.Tag = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(300, 110)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 13)
        Me.Label11.TabIndex = 77
        Me.Label11.Text = "Intervalo de Incremento"
        '
        'NuevoContrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 394)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Intervalo)
        Me.Controls.Add(DireccionLabel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DireccionComboBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Volver)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.FF)
        Me.Controls.Add(Me.FI3)
        Me.Controls.Add(Me.FI2)
        Me.Controls.Add(Me.FI1)
        Me.Controls.Add(Me.FI)
        Me.Controls.Add(Me.P3)
        Me.Controls.Add(Me.P2)
        Me.Controls.Add(Me.P1)
        Me.Controls.Add(Me.P0)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NuevoContrato"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NuevoContrato"
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InquilinosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InmueblesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKContratosInmueblesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InmueblesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents P0 As System.Windows.Forms.TextBox
    Friend WithEvents P1 As System.Windows.Forms.TextBox
    Friend WithEvents P2 As System.Windows.Forms.TextBox
    Friend WithEvents P3 As System.Windows.Forms.TextBox
    Friend WithEvents FI As System.Windows.Forms.DateTimePicker
    Friend WithEvents FI1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents FI2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents FI3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents FF As System.Windows.Forms.DateTimePicker
    Friend WithEvents Volver As System.Windows.Forms.Button
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents Limpiar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ApellidoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DireccionComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents InquilinosDataSet As WindowsApplication2.InquilinosDataSet
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As WindowsApplication2.InquilinosDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents InmueblesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InmueblesTableAdapter As WindowsApplication2.InquilinosDataSetTableAdapters.InmueblesTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication2.InquilinosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DNILabel As System.Windows.Forms.Label
    Friend WithEvents FKContratosInmueblesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InmueblesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents NombreLabel As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Intervalo As ComboBox
    Friend WithEvents Label11 As Label
End Class
