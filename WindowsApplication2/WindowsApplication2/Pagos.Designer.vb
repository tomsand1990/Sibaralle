<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pagos
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
        Dim DireccionLabel1 As System.Windows.Forms.Label
        Dim DNIL As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pagos))
        Me.Volver = New System.Windows.Forms.Button()
        Me.ApellidoCombo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DireccionCombo = New System.Windows.Forms.ComboBox()
        Me.DNILabel = New System.Windows.Forms.Label()
        Me.NombreLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AguaLabel = New System.Windows.Forms.Label()
        Me.LuzLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GasLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DGRLabel = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MuniLabel = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.OtrosLabel = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AlquilerLabel = New System.Windows.Forms.Label()
        Me.DeudaLabel = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PagoTextBox = New System.Windows.Forms.TextBox()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.locaLabel = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Fechalabel = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Mora = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGRCheck = New System.Windows.Forms.CheckBox()
        Me.GasCheck = New System.Windows.Forms.CheckBox()
        Me.MuniCheck = New System.Windows.Forms.CheckBox()
        Me.OtrosCheck = New System.Windows.Forms.CheckBox()
        Me.AguaCheck = New System.Windows.Forms.CheckBox()
        Me.LuzCheck = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.AguaDataGrid = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LuzDataGrid = New System.Windows.Forms.DataGridView()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GasDataGrid = New System.Windows.Forms.DataGridView()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.MuniDataGrid = New System.Windows.Forms.DataGridView()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.DGRDataGrid = New System.Windows.Forms.DataGridView()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.OtrosDataGrid = New System.Windows.Forms.DataGridView()
        Me.lax = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        DireccionLabel1 = New System.Windows.Forms.Label()
        DNIL = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.AguaDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.LuzDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.GasDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.MuniDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.DGRDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        CType(Me.OtrosDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DireccionLabel1
        '
        DireccionLabel1.AutoSize = True
        DireccionLabel1.Location = New System.Drawing.Point(24, 107)
        DireccionLabel1.Name = "DireccionLabel1"
        DireccionLabel1.Size = New System.Drawing.Size(55, 13)
        DireccionLabel1.TabIndex = 72
        DireccionLabel1.Text = "Direccion:"
        '
        'DNIL
        '
        DNIL.AutoSize = True
        DNIL.Location = New System.Drawing.Point(51, 79)
        DNIL.Name = "DNIL"
        DNIL.Size = New System.Drawing.Size(29, 13)
        DNIL.TabIndex = 74
        DNIL.Text = "DNI:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(33, 57)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(47, 13)
        Label1.TabIndex = 76
        Label1.Text = "Nombre:"
        '
        'Volver
        '
        Me.Volver.Location = New System.Drawing.Point(340, 319)
        Me.Volver.Name = "Volver"
        Me.Volver.Size = New System.Drawing.Size(108, 57)
        Me.Volver.TabIndex = 24
        Me.Volver.Text = "Volver"
        Me.Volver.UseVisualStyleBackColor = True
        '
        'ApellidoCombo
        '
        Me.ApellidoCombo.DisplayMember = "Apellido"
        Me.ApellidoCombo.FormattingEnabled = True
        Me.ApellidoCombo.Location = New System.Drawing.Point(80, 27)
        Me.ApellidoCombo.Name = "ApellidoCombo"
        Me.ApellidoCombo.Size = New System.Drawing.Size(121, 21)
        Me.ApellidoCombo.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Apellido:"
        '
        'DireccionCombo
        '
        Me.DireccionCombo.DisplayMember = "Direccion"
        Me.DireccionCombo.FormattingEnabled = True
        Me.DireccionCombo.Location = New System.Drawing.Point(80, 104)
        Me.DireccionCombo.Name = "DireccionCombo"
        Me.DireccionCombo.Size = New System.Drawing.Size(121, 21)
        Me.DireccionCombo.TabIndex = 73
        '
        'DNILabel
        '
        Me.DNILabel.Location = New System.Drawing.Point(77, 81)
        Me.DNILabel.Name = "DNILabel"
        Me.DNILabel.Size = New System.Drawing.Size(100, 23)
        Me.DNILabel.TabIndex = 75
        '
        'NombreLabel
        '
        Me.NombreLabel.Location = New System.Drawing.Point(77, 57)
        Me.NombreLabel.Name = "NombreLabel"
        Me.NombreLabel.Size = New System.Drawing.Size(100, 23)
        Me.NombreLabel.TabIndex = 77
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Agua:"
        '
        'AguaLabel
        '
        Me.AguaLabel.AutoSize = True
        Me.AguaLabel.Location = New System.Drawing.Point(88, 77)
        Me.AguaLabel.Name = "AguaLabel"
        Me.AguaLabel.Size = New System.Drawing.Size(0, 13)
        Me.AguaLabel.TabIndex = 79
        '
        'LuzLabel
        '
        Me.LuzLabel.AutoSize = True
        Me.LuzLabel.Location = New System.Drawing.Point(88, 100)
        Me.LuzLabel.Name = "LuzLabel"
        Me.LuzLabel.Size = New System.Drawing.Size(0, 13)
        Me.LuzLabel.TabIndex = 81
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(58, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Luz:"
        '
        'GasLabel
        '
        Me.GasLabel.AutoSize = True
        Me.GasLabel.Location = New System.Drawing.Point(88, 123)
        Me.GasLabel.Name = "GasLabel"
        Me.GasLabel.Size = New System.Drawing.Size(0, 13)
        Me.GasLabel.TabIndex = 83
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(56, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "Gas:"
        '
        'DGRLabel
        '
        Me.DGRLabel.AutoSize = True
        Me.DGRLabel.Location = New System.Drawing.Point(88, 146)
        Me.DGRLabel.Name = "DGRLabel"
        Me.DGRLabel.Size = New System.Drawing.Size(0, 13)
        Me.DGRLabel.TabIndex = 85
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(52, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 84
        Me.Label8.Text = "DGR:"
        '
        'MuniLabel
        '
        Me.MuniLabel.AutoSize = True
        Me.MuniLabel.Location = New System.Drawing.Point(88, 168)
        Me.MuniLabel.Name = "MuniLabel"
        Me.MuniLabel.Size = New System.Drawing.Size(0, 13)
        Me.MuniLabel.TabIndex = 87
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(52, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 13)
        Me.Label10.TabIndex = 86
        Me.Label10.Text = "Muni:"
        '
        'OtrosLabel
        '
        Me.OtrosLabel.AutoSize = True
        Me.OtrosLabel.Location = New System.Drawing.Point(88, 54)
        Me.OtrosLabel.Name = "OtrosLabel"
        Me.OtrosLabel.Size = New System.Drawing.Size(0, 13)
        Me.OtrosLabel.TabIndex = 89
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(52, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 13)
        Me.Label12.TabIndex = 88
        Me.Label12.Text = "Otros:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "Alquiler:"
        '
        'AlquilerLabel
        '
        Me.AlquilerLabel.AutoSize = True
        Me.AlquilerLabel.Location = New System.Drawing.Point(91, 33)
        Me.AlquilerLabel.Name = "AlquilerLabel"
        Me.AlquilerLabel.Size = New System.Drawing.Size(0, 13)
        Me.AlquilerLabel.TabIndex = 91
        '
        'DeudaLabel
        '
        Me.DeudaLabel.AutoSize = True
        Me.DeudaLabel.Location = New System.Drawing.Point(91, 16)
        Me.DeudaLabel.Name = "DeudaLabel"
        Me.DeudaLabel.Size = New System.Drawing.Size(0, 13)
        Me.DeudaLabel.TabIndex = 93
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 13)
        Me.Label11.TabIndex = 92
        Me.Label11.Text = "Deuda Anterior:"
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLabel.Location = New System.Drawing.Point(87, 214)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(0, 22)
        Me.TotalLabel.TabIndex = 95
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(25, 214)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 22)
        Me.Label9.TabIndex = 94
        Me.Label9.Text = "Total:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(245, 288)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 96
        Me.Label7.Text = "Pago:"
        '
        'PagoTextBox
        '
        Me.PagoTextBox.Location = New System.Drawing.Point(283, 285)
        Me.PagoTextBox.Name = "PagoTextBox"
        Me.PagoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PagoTextBox.TabIndex = 97
        '
        'Guardar
        '
        Me.Guardar.Location = New System.Drawing.Point(180, 319)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(100, 60)
        Me.Guardar.TabIndex = 99
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'Limpiar
        '
        Me.Limpiar.Location = New System.Drawing.Point(15, 319)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(100, 60)
        Me.Limpiar.TabIndex = 98
        Me.Limpiar.Text = "Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'locaLabel
        '
        Me.locaLabel.AutoSize = True
        Me.locaLabel.Location = New System.Drawing.Point(85, 134)
        Me.locaLabel.Name = "locaLabel"
        Me.locaLabel.Size = New System.Drawing.Size(39, 13)
        Me.locaLabel.TabIndex = 101
        Me.locaLabel.Text = "Label9"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(33, 134)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 13)
        Me.Label14.TabIndex = 100
        Me.Label14.Text = "Locador:"
        '
        'Fechalabel
        '
        Me.Fechalabel.AutoSize = True
        Me.Fechalabel.Location = New System.Drawing.Point(74, 279)
        Me.Fechalabel.Name = "Fechalabel"
        Me.Fechalabel.Size = New System.Drawing.Size(39, 13)
        Me.Fechalabel.TabIndex = 103
        Me.Fechalabel.Text = "Label9"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(31, 279)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 13)
        Me.Label15.TabIndex = 102
        Me.Label15.Text = "Fecha:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(51, 186)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 13)
        Me.Label13.TabIndex = 104
        Me.Label13.Text = "Mora:"
        '
        'Mora
        '
        Me.Mora.AutoSize = True
        Me.Mora.Location = New System.Drawing.Point(88, 186)
        Me.Mora.Name = "Mora"
        Me.Mora.Size = New System.Drawing.Size(0, 13)
        Me.Mora.TabIndex = 105
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OtrosLabel)
        Me.GroupBox1.Controls.Add(Me.Mora)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.MuniLabel)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.DGRLabel)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TotalLabel)
        Me.GroupBox1.Controls.Add(Me.GasLabel)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.AlquilerLabel)
        Me.GroupBox1.Controls.Add(Me.LuzLabel)
        Me.GroupBox1.Controls.Add(Me.DeudaLabel)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.AguaLabel)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(248, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(180, 243)
        Me.GroupBox1.TabIndex = 106
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DETALLE"
        '
        'DGRCheck
        '
        Me.DGRCheck.AutoSize = True
        Me.DGRCheck.Location = New System.Drawing.Point(119, 43)
        Me.DGRCheck.Name = "DGRCheck"
        Me.DGRCheck.Size = New System.Drawing.Size(50, 17)
        Me.DGRCheck.TabIndex = 106
        Me.DGRCheck.Text = "DGR"
        Me.DGRCheck.UseVisualStyleBackColor = True
        '
        'GasCheck
        '
        Me.GasCheck.AutoSize = True
        Me.GasCheck.Location = New System.Drawing.Point(13, 43)
        Me.GasCheck.Name = "GasCheck"
        Me.GasCheck.Size = New System.Drawing.Size(45, 17)
        Me.GasCheck.TabIndex = 107
        Me.GasCheck.Text = "Gas"
        Me.GasCheck.UseVisualStyleBackColor = True
        '
        'MuniCheck
        '
        Me.MuniCheck.AutoSize = True
        Me.MuniCheck.Location = New System.Drawing.Point(70, 43)
        Me.MuniCheck.Name = "MuniCheck"
        Me.MuniCheck.Size = New System.Drawing.Size(49, 17)
        Me.MuniCheck.TabIndex = 108
        Me.MuniCheck.Text = "Muni"
        Me.MuniCheck.UseVisualStyleBackColor = True
        '
        'OtrosCheck
        '
        Me.OtrosCheck.AutoSize = True
        Me.OtrosCheck.Location = New System.Drawing.Point(119, 20)
        Me.OtrosCheck.Name = "OtrosCheck"
        Me.OtrosCheck.Size = New System.Drawing.Size(51, 17)
        Me.OtrosCheck.TabIndex = 109
        Me.OtrosCheck.Text = "Otros"
        Me.OtrosCheck.UseVisualStyleBackColor = True
        '
        'AguaCheck
        '
        Me.AguaCheck.AutoSize = True
        Me.AguaCheck.Location = New System.Drawing.Point(13, 20)
        Me.AguaCheck.Name = "AguaCheck"
        Me.AguaCheck.Size = New System.Drawing.Size(51, 17)
        Me.AguaCheck.TabIndex = 110
        Me.AguaCheck.Text = "Agua"
        Me.AguaCheck.UseVisualStyleBackColor = True
        '
        'LuzCheck
        '
        Me.LuzCheck.AutoSize = True
        Me.LuzCheck.Location = New System.Drawing.Point(70, 20)
        Me.LuzCheck.Name = "LuzCheck"
        Me.LuzCheck.Size = New System.Drawing.Size(43, 17)
        Me.LuzCheck.TabIndex = 111
        Me.LuzCheck.Text = "Luz"
        Me.LuzCheck.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.AguaCheck)
        Me.GroupBox2.Controls.Add(Me.LuzCheck)
        Me.GroupBox2.Controls.Add(Me.DGRCheck)
        Me.GroupBox2.Controls.Add(Me.GasCheck)
        Me.GroupBox2.Controls.Add(Me.OtrosCheck)
        Me.GroupBox2.Controls.Add(Me.MuniCheck)
        Me.GroupBox2.Location = New System.Drawing.Point(29, 203)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(172, 67)
        Me.GroupBox2.TabIndex = 112
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SERVICIOS"
        '
        'AguaDataGrid
        '
        Me.AguaDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.AguaDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.AguaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AguaDataGrid.Location = New System.Drawing.Point(6, 19)
        Me.AguaDataGrid.Name = "AguaDataGrid"
        Me.AguaDataGrid.Size = New System.Drawing.Size(165, 83)
        Me.AguaDataGrid.TabIndex = 113
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.AguaDataGrid)
        Me.GroupBox3.Location = New System.Drawing.Point(456, 34)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(177, 113)
        Me.GroupBox3.TabIndex = 114
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DETALLE AGUA"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LuzDataGrid)
        Me.GroupBox4.Location = New System.Drawing.Point(456, 153)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(177, 113)
        Me.GroupBox4.TabIndex = 115
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "DETALLE LUZ"
        '
        'LuzDataGrid
        '
        Me.LuzDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.LuzDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.LuzDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LuzDataGrid.Location = New System.Drawing.Point(6, 19)
        Me.LuzDataGrid.Name = "LuzDataGrid"
        Me.LuzDataGrid.Size = New System.Drawing.Size(165, 83)
        Me.LuzDataGrid.TabIndex = 113
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GasDataGrid)
        Me.GroupBox5.Location = New System.Drawing.Point(639, 34)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(177, 113)
        Me.GroupBox5.TabIndex = 115
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "DETALLE GAS"
        '
        'GasDataGrid
        '
        Me.GasDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.GasDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.GasDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GasDataGrid.Location = New System.Drawing.Point(6, 19)
        Me.GasDataGrid.Name = "GasDataGrid"
        Me.GasDataGrid.Size = New System.Drawing.Size(165, 83)
        Me.GasDataGrid.TabIndex = 113
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.MuniDataGrid)
        Me.GroupBox6.Location = New System.Drawing.Point(639, 153)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(177, 113)
        Me.GroupBox6.TabIndex = 116
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "DETALLE MUNI"
        '
        'MuniDataGrid
        '
        Me.MuniDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.MuniDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MuniDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MuniDataGrid.Location = New System.Drawing.Point(6, 19)
        Me.MuniDataGrid.Name = "MuniDataGrid"
        Me.MuniDataGrid.Size = New System.Drawing.Size(165, 83)
        Me.MuniDataGrid.TabIndex = 113
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.DGRDataGrid)
        Me.GroupBox7.Location = New System.Drawing.Point(822, 34)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(177, 113)
        Me.GroupBox7.TabIndex = 117
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "DETALLE DGR"
        '
        'DGRDataGrid
        '
        Me.DGRDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGRDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DGRDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGRDataGrid.Location = New System.Drawing.Point(6, 19)
        Me.DGRDataGrid.Name = "DGRDataGrid"
        Me.DGRDataGrid.Size = New System.Drawing.Size(165, 83)
        Me.DGRDataGrid.TabIndex = 113
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.OtrosDataGrid)
        Me.GroupBox8.Location = New System.Drawing.Point(456, 272)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(360, 113)
        Me.GroupBox8.TabIndex = 118
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "DETALLE OTROS"
        '
        'OtrosDataGrid
        '
        Me.OtrosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OtrosDataGrid.Location = New System.Drawing.Point(6, 19)
        Me.OtrosDataGrid.Name = "OtrosDataGrid"
        Me.OtrosDataGrid.Size = New System.Drawing.Size(348, 83)
        Me.OtrosDataGrid.TabIndex = 113
        '
        'lax
        '
        Me.lax.AutoSize = True
        Me.lax.ForeColor = System.Drawing.Color.Red
        Me.lax.Location = New System.Drawing.Point(835, 214)
        Me.lax.Name = "lax"
        Me.lax.Size = New System.Drawing.Size(63, 13)
        Me.lax.TabIndex = 108
        Me.lax.Text = "alq no pago"
        Me.lax.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(828, 279)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 106)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 119
        Me.PictureBox1.TabStop = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'Pagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 388)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.lax)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Fechalabel)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.locaLabel)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.PagoTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.NombreLabel)
        Me.Controls.Add(DNIL)
        Me.Controls.Add(Me.DNILabel)
        Me.Controls.Add(DireccionLabel1)
        Me.Controls.Add(Me.DireccionCombo)
        Me.Controls.Add(Me.ApellidoCombo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Volver)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pagos"
        Me.Text = "Pagos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.AguaDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.LuzDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.GasDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.MuniDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.DGRDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.OtrosDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Volver As System.Windows.Forms.Button
    Friend WithEvents ApellidoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DireccionCombo As System.Windows.Forms.ComboBox
    Friend WithEvents DNILabel As System.Windows.Forms.Label
    Friend WithEvents NombreLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AguaLabel As Label
    Friend WithEvents LuzLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GasLabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DGRLabel As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents MuniLabel As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents OtrosLabel As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents AlquilerLabel As Label
    Friend WithEvents DeudaLabel As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TotalLabel As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PagoTextBox As TextBox
    Friend WithEvents Guardar As Button
    Friend WithEvents Limpiar As Button
    Friend WithEvents locaLabel As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Fechalabel As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Mora As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGRCheck As System.Windows.Forms.CheckBox
    Friend WithEvents GasCheck As System.Windows.Forms.CheckBox
    Friend WithEvents MuniCheck As System.Windows.Forms.CheckBox
    Friend WithEvents OtrosCheck As System.Windows.Forms.CheckBox
    Friend WithEvents AguaCheck As System.Windows.Forms.CheckBox
    Friend WithEvents LuzCheck As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents AguaDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents LuzDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GasDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents MuniDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents DGRDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents OtrosDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents lax As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
