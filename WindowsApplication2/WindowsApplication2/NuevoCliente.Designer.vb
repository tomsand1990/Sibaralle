<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevoCliente))
        Me.DatosTitular = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DNI = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Apellido = New System.Windows.Forms.TextBox()
        Me.TelTit = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.NomEmer = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.NomPar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TelPar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TelEme = New System.Windows.Forms.TextBox()
        Me.Volver = New System.Windows.Forms.Button()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.DatosTitular.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DatosTitular
        '
        Me.DatosTitular.Controls.Add(Me.Label3)
        Me.DatosTitular.Controls.Add(Me.DNI)
        Me.DatosTitular.Controls.Add(Me.Label2)
        Me.DatosTitular.Controls.Add(Me.Nombre)
        Me.DatosTitular.Controls.Add(Me.Label1)
        Me.DatosTitular.Controls.Add(Me.Label6)
        Me.DatosTitular.Controls.Add(Me.Apellido)
        Me.DatosTitular.Controls.Add(Me.TelTit)
        Me.DatosTitular.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatosTitular.Location = New System.Drawing.Point(12, 12)
        Me.DatosTitular.Name = "DatosTitular"
        Me.DatosTitular.Size = New System.Drawing.Size(661, 105)
        Me.DatosTitular.TabIndex = 49
        Me.DatosTitular.TabStop = False
        Me.DatosTitular.Text = "Datos del Titular"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(434, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 24)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "DNI"
        '
        'DNI
        '
        Me.DNI.Location = New System.Drawing.Point(481, 30)
        Me.DNI.Name = "DNI"
        Me.DNI.Size = New System.Drawing.Size(155, 29)
        Me.DNI.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(90, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 24)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Nombre"
        '
        'Nombre
        '
        Me.Nombre.Location = New System.Drawing.Point(175, 64)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(155, 29)
        Me.Nombre.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 24)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Apellido"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(382, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 24)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Tel Titular"
        '
        'Apellido
        '
        Me.Apellido.Location = New System.Drawing.Point(175, 28)
        Me.Apellido.Name = "Apellido"
        Me.Apellido.Size = New System.Drawing.Size(155, 29)
        Me.Apellido.TabIndex = 37
        '
        'TelTit
        '
        Me.TelTit.Location = New System.Drawing.Point(481, 64)
        Me.TelTit.Name = "TelTit"
        Me.TelTit.Size = New System.Drawing.Size(155, 29)
        Me.TelTit.TabIndex = 53
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.NomEmer)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.NomPar)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TelPar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TelEme)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(661, 133)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Contacto"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(396, 79)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 24)
        Me.Label15.TabIndex = 60
        Me.Label15.Text = "Nombre"
        '
        'NomEmer
        '
        Me.NomEmer.Location = New System.Drawing.Point(480, 79)
        Me.NomEmer.Name = "NomEmer"
        Me.NomEmer.Size = New System.Drawing.Size(155, 29)
        Me.NomEmer.TabIndex = 59
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(396, 46)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 24)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "Nombre"
        '
        'NomPar
        '
        Me.NomPar.Location = New System.Drawing.Point(480, 43)
        Me.NomPar.Name = "NomPar"
        Me.NomPar.Size = New System.Drawing.Size(155, 29)
        Me.NomPar.TabIndex = 57
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(74, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 24)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Tel Pareja"
        '
        'TelPar
        '
        Me.TelPar.Location = New System.Drawing.Point(175, 41)
        Me.TelPar.Name = "TelPar"
        Me.TelPar.Size = New System.Drawing.Size(155, 29)
        Me.TelPar.TabIndex = 51
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 24)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Tel Emergencia"
        '
        'TelEme
        '
        Me.TelEme.Location = New System.Drawing.Point(175, 79)
        Me.TelEme.Name = "TelEme"
        Me.TelEme.Size = New System.Drawing.Size(155, 29)
        Me.TelEme.TabIndex = 49
        '
        'Volver
        '
        Me.Volver.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Volver.Location = New System.Drawing.Point(492, 265)
        Me.Volver.Name = "Volver"
        Me.Volver.Size = New System.Drawing.Size(100, 60)
        Me.Volver.TabIndex = 53
        Me.Volver.Text = "Volver"
        Me.Volver.UseVisualStyleBackColor = True
        '
        'Guardar
        '
        Me.Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guardar.Location = New System.Drawing.Point(267, 265)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(100, 60)
        Me.Guardar.TabIndex = 52
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'Limpiar
        '
        Me.Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Limpiar.Location = New System.Drawing.Point(69, 265)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(100, 60)
        Me.Limpiar.TabIndex = 51
        Me.Limpiar.Text = "Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'NuevoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 352)
        Me.Controls.Add(Me.Volver)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DatosTitular)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NuevoCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NuevoCliente"
        Me.DatosTitular.ResumeLayout(False)
        Me.DatosTitular.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DatosTitular As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DNI As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Apellido As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents NomEmer As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents NomPar As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TelTit As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TelPar As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TelEme As System.Windows.Forms.TextBox
    Friend WithEvents Volver As System.Windows.Forms.Button
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents Limpiar As System.Windows.Forms.Button

End Class
