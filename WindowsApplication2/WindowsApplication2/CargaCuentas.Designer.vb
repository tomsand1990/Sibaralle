<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CargaCuentas
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
        Me.Cuentas = New System.Windows.Forms.GroupBox()
        Me.Muni = New System.Windows.Forms.CheckBox()
        Me.DGR = New System.Windows.Forms.CheckBox()
        Me.Gas = New System.Windows.Forms.CheckBox()
        Me.Luz = New System.Windows.Forms.CheckBox()
        Me.Agua = New System.Windows.Forms.CheckBox()
        Me.DireccionCombo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GastoAgua = New System.Windows.Forms.TextBox()
        Me.VencAgua = New System.Windows.Forms.DateTimePicker()
        Me.AqTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GastoLuz = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LuzTextBox = New System.Windows.Forms.TextBox()
        Me.VencLuz = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GastoGas = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GasTextBox = New System.Windows.Forms.TextBox()
        Me.VencGas = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GastoDGR = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.DGRTextBox = New System.Windows.Forms.TextBox()
        Me.VencDGR = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GastoMuni = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.MuniTextBox = New System.Windows.Forms.TextBox()
        Me.VencMuni = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Volver = New System.Windows.Forms.Button()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GastoOtros = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.OtrosTextBox = New System.Windows.Forms.TextBox()
        Me.VencOtros = New System.Windows.Forms.DateTimePicker()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Otros = New System.Windows.Forms.CheckBox()
        Me.Cuentas.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cuentas
        '
        Me.Cuentas.Controls.Add(Me.Otros)
        Me.Cuentas.Controls.Add(Me.Muni)
        Me.Cuentas.Controls.Add(Me.DGR)
        Me.Cuentas.Controls.Add(Me.Gas)
        Me.Cuentas.Controls.Add(Me.Luz)
        Me.Cuentas.Controls.Add(Me.Agua)
        Me.Cuentas.Location = New System.Drawing.Point(52, 27)
        Me.Cuentas.Name = "Cuentas"
        Me.Cuentas.Size = New System.Drawing.Size(200, 100)
        Me.Cuentas.TabIndex = 0
        Me.Cuentas.TabStop = False
        Me.Cuentas.Text = "Cuentas"
        '
        'Muni
        '
        Me.Muni.AutoSize = True
        Me.Muni.Location = New System.Drawing.Point(101, 43)
        Me.Muni.Name = "Muni"
        Me.Muni.Size = New System.Drawing.Size(91, 17)
        Me.Muni.TabIndex = 1
        Me.Muni.Text = "Municipalidad"
        Me.Muni.UseVisualStyleBackColor = True
        '
        'DGR
        '
        Me.DGR.AutoSize = True
        Me.DGR.Location = New System.Drawing.Point(101, 20)
        Me.DGR.Name = "DGR"
        Me.DGR.Size = New System.Drawing.Size(50, 17)
        Me.DGR.TabIndex = 1
        Me.DGR.Text = "DGR"
        Me.DGR.UseVisualStyleBackColor = True
        '
        'Gas
        '
        Me.Gas.AutoSize = True
        Me.Gas.Location = New System.Drawing.Point(7, 66)
        Me.Gas.Name = "Gas"
        Me.Gas.Size = New System.Drawing.Size(45, 17)
        Me.Gas.TabIndex = 1
        Me.Gas.Text = "Gas"
        Me.Gas.UseVisualStyleBackColor = True
        '
        'Luz
        '
        Me.Luz.AutoSize = True
        Me.Luz.Location = New System.Drawing.Point(7, 43)
        Me.Luz.Name = "Luz"
        Me.Luz.Size = New System.Drawing.Size(43, 17)
        Me.Luz.TabIndex = 1
        Me.Luz.Text = "Luz"
        Me.Luz.UseVisualStyleBackColor = True
        '
        'Agua
        '
        Me.Agua.AutoSize = True
        Me.Agua.Location = New System.Drawing.Point(7, 20)
        Me.Agua.Name = "Agua"
        Me.Agua.Size = New System.Drawing.Size(51, 17)
        Me.Agua.TabIndex = 0
        Me.Agua.Text = "Agua"
        Me.Agua.UseVisualStyleBackColor = True
        '
        'DireccionCombo
        '
        Me.DireccionCombo.FormattingEnabled = True
        Me.DireccionCombo.Location = New System.Drawing.Point(333, 43)
        Me.DireccionCombo.Name = "DireccionCombo"
        Me.DireccionCombo.Size = New System.Drawing.Size(121, 21)
        Me.DireccionCombo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(275, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Dirección"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.GastoAgua)
        Me.GroupBox1.Controls.Add(Me.VencAgua)
        Me.GroupBox1.Controls.Add(Me.AqTextBox)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(52, 171)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 72)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agua"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(320, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Gasto"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(110, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Vencimiento"
        '
        'GastoAgua
        '
        Me.GastoAgua.Location = New System.Drawing.Point(320, 37)
        Me.GastoAgua.Name = "GastoAgua"
        Me.GastoAgua.Size = New System.Drawing.Size(74, 20)
        Me.GastoAgua.TabIndex = 12
        '
        'VencAgua
        '
        Me.VencAgua.Location = New System.Drawing.Point(113, 37)
        Me.VencAgua.Name = "VencAgua"
        Me.VencAgua.Size = New System.Drawing.Size(200, 20)
        Me.VencAgua.TabIndex = 11
        '
        'AqTextBox
        '
        Me.AqTextBox.Location = New System.Drawing.Point(7, 37)
        Me.AqTextBox.Name = "AqTextBox"
        Me.AqTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AqTextBox.TabIndex = 10
        Me.AqTextBox.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Label7"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Contrato"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.GastoLuz)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.LuzTextBox)
        Me.GroupBox2.Controls.Add(Me.VencLuz)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(52, 249)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 72)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Luz"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(320, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Gasto"
        '
        'GastoLuz
        '
        Me.GastoLuz.Location = New System.Drawing.Point(320, 36)
        Me.GastoLuz.Name = "GastoLuz"
        Me.GastoLuz.Size = New System.Drawing.Size(74, 20)
        Me.GastoLuz.TabIndex = 14
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(110, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 13)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Vencimiento"
        '
        'LuzTextBox
        '
        Me.LuzTextBox.Location = New System.Drawing.Point(7, 36)
        Me.LuzTextBox.Name = "LuzTextBox"
        Me.LuzTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LuzTextBox.TabIndex = 11
        Me.LuzTextBox.Visible = False
        '
        'VencLuz
        '
        Me.VencLuz.Location = New System.Drawing.Point(113, 36)
        Me.VencLuz.Name = "VencLuz"
        Me.VencLuz.Size = New System.Drawing.Size(200, 20)
        Me.VencLuz.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Label8"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Contrato"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.GastoGas)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.GasTextBox)
        Me.GroupBox3.Controls.Add(Me.VencGas)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(522, 171)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(400, 72)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Gas"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(322, 14)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(35, 13)
        Me.Label20.TabIndex = 22
        Me.Label20.Text = "Gasto"
        '
        'GastoGas
        '
        Me.GastoGas.Location = New System.Drawing.Point(322, 37)
        Me.GastoGas.Name = "GastoGas"
        Me.GastoGas.Size = New System.Drawing.Size(74, 20)
        Me.GastoGas.TabIndex = 18
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(112, 15)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(65, 13)
        Me.Label21.TabIndex = 21
        Me.Label21.Text = "Vencimiento"
        '
        'GasTextBox
        '
        Me.GasTextBox.Location = New System.Drawing.Point(9, 37)
        Me.GasTextBox.Name = "GasTextBox"
        Me.GasTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GasTextBox.TabIndex = 14
        Me.GasTextBox.Visible = False
        '
        'VencGas
        '
        Me.VencGas.Location = New System.Drawing.Point(115, 37)
        Me.VencGas.Name = "VencGas"
        Me.VencGas.Size = New System.Drawing.Size(200, 20)
        Me.VencGas.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Label10"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Contrato"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.GastoDGR)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.DGRTextBox)
        Me.GroupBox4.Controls.Add(Me.VencDGR)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(522, 249)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(400, 72)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "DGR"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(322, 14)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(35, 13)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Gasto"
        '
        'GastoDGR
        '
        Me.GastoDGR.Location = New System.Drawing.Point(322, 36)
        Me.GastoDGR.Name = "GastoDGR"
        Me.GastoDGR.Size = New System.Drawing.Size(74, 20)
        Me.GastoDGR.TabIndex = 20
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(112, 15)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(65, 13)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "Vencimiento"
        '
        'DGRTextBox
        '
        Me.DGRTextBox.Location = New System.Drawing.Point(9, 36)
        Me.DGRTextBox.Name = "DGRTextBox"
        Me.DGRTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DGRTextBox.TabIndex = 13
        Me.DGRTextBox.Visible = False
        '
        'VencDGR
        '
        Me.VencDGR.Location = New System.Drawing.Point(115, 36)
        Me.VencDGR.Name = "VencDGR"
        Me.VencDGR.Size = New System.Drawing.Size(200, 20)
        Me.VencDGR.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Label11"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Contrato"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.GastoMuni)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.MuniTextBox)
        Me.GroupBox5.Controls.Add(Me.VencMuni)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Location = New System.Drawing.Point(52, 327)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(400, 72)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Municipalidad"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(320, 15)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(35, 13)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Gasto"
        '
        'GastoMuni
        '
        Me.GastoMuni.Location = New System.Drawing.Point(320, 35)
        Me.GastoMuni.Name = "GastoMuni"
        Me.GastoMuni.Size = New System.Drawing.Size(74, 20)
        Me.GastoMuni.TabIndex = 16
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(110, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 13)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "Vencimiento"
        '
        'MuniTextBox
        '
        Me.MuniTextBox.Location = New System.Drawing.Point(7, 35)
        Me.MuniTextBox.Name = "MuniTextBox"
        Me.MuniTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MuniTextBox.TabIndex = 12
        Me.MuniTextBox.Visible = False
        '
        'VencMuni
        '
        Me.VencMuni.Location = New System.Drawing.Point(113, 35)
        Me.VencMuni.Name = "VencMuni"
        Me.VencMuni.Size = New System.Drawing.Size(200, 20)
        Me.VencMuni.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Label9"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Contrato"
        '
        'Volver
        '
        Me.Volver.Location = New System.Drawing.Point(590, 427)
        Me.Volver.Name = "Volver"
        Me.Volver.Size = New System.Drawing.Size(108, 57)
        Me.Volver.TabIndex = 26
        Me.Volver.Text = "Volver"
        Me.Volver.UseVisualStyleBackColor = True
        '
        'Guardar
        '
        Me.Guardar.Location = New System.Drawing.Point(333, 427)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(108, 57)
        Me.Guardar.TabIndex = 25
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'Limpiar
        '
        Me.Limpiar.Location = New System.Drawing.Point(88, 427)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(108, 57)
        Me.Limpiar.TabIndex = 24
        Me.Limpiar.Text = "Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Controls.Add(Me.GastoOtros)
        Me.GroupBox6.Controls.Add(Me.Label23)
        Me.GroupBox6.Controls.Add(Me.OtrosTextBox)
        Me.GroupBox6.Controls.Add(Me.VencOtros)
        Me.GroupBox6.Controls.Add(Me.Label25)
        Me.GroupBox6.Location = New System.Drawing.Point(522, 327)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(400, 72)
        Me.GroupBox6.TabIndex = 17
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Otros"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(320, 15)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(35, 13)
        Me.Label22.TabIndex = 16
        Me.Label22.Text = "Gasto"
        '
        'GastoOtros
        '
        Me.GastoOtros.Location = New System.Drawing.Point(320, 36)
        Me.GastoOtros.Name = "GastoOtros"
        Me.GastoOtros.Size = New System.Drawing.Size(74, 20)
        Me.GastoOtros.TabIndex = 14
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(110, 16)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(65, 13)
        Me.Label23.TabIndex = 15
        Me.Label23.Text = "Vencimiento"
        '
        'OtrosTextBox
        '
        Me.OtrosTextBox.Location = New System.Drawing.Point(6, 36)
        Me.OtrosTextBox.Name = "OtrosTextBox"
        Me.OtrosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OtrosTextBox.TabIndex = 11
        Me.OtrosTextBox.Visible = False
        '
        'VencOtros
        '
        Me.VencOtros.Location = New System.Drawing.Point(113, 36)
        Me.VencOtros.Name = "VencOtros"
        Me.VencOtros.Size = New System.Drawing.Size(200, 20)
        Me.VencOtros.TabIndex = 13
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(4, 16)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(94, 13)
        Me.Label25.TabIndex = 9
        Me.Label25.Text = "Detalle (1 Palabra)"
        '
        'Otros
        '
        Me.Otros.AutoSize = True
        Me.Otros.Location = New System.Drawing.Point(101, 66)
        Me.Otros.Name = "Otros"
        Me.Otros.Size = New System.Drawing.Size(51, 17)
        Me.Otros.TabIndex = 2
        Me.Otros.Text = "Otros"
        Me.Otros.UseVisualStyleBackColor = True
        '
        'CargaCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 509)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Volver)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DireccionCombo)
        Me.Controls.Add(Me.Cuentas)
        Me.Name = "CargaCuentas"
        Me.Text = "Carga Cuentas"
        Me.Cuentas.ResumeLayout(False)
        Me.Cuentas.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cuentas As System.Windows.Forms.GroupBox
    Friend WithEvents Muni As System.Windows.Forms.CheckBox
    Friend WithEvents DGR As System.Windows.Forms.CheckBox
    Friend WithEvents Gas As System.Windows.Forms.CheckBox
    Friend WithEvents Luz As System.Windows.Forms.CheckBox
    Friend WithEvents Agua As System.Windows.Forms.CheckBox
    Friend WithEvents DireccionCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents AqTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LuzTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DGRTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MuniTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Volver As System.Windows.Forms.Button
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents Limpiar As System.Windows.Forms.Button
    Friend WithEvents VencAgua As System.Windows.Forms.DateTimePicker
    Friend WithEvents GastoAgua As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GastoLuz As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents VencLuz As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents GastoGas As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents VencGas As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GastoDGR As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents VencDGR As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GastoMuni As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents VencMuni As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label22 As Label
    Friend WithEvents GastoOtros As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents OtrosTextBox As TextBox
    Friend WithEvents VencOtros As DateTimePicker
    Friend WithEvents Label25 As Label
    Friend WithEvents Otros As CheckBox
End Class
