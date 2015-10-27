<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConCli
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
        Me.Nombres = New System.Windows.Forms.GroupBox()
        Me.nEme = New System.Windows.Forms.Label()
        Me.nTit = New System.Windows.Forms.Label()
        Me.nPar = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tEme = New System.Windows.Forms.Label()
        Me.tPar = New System.Windows.Forms.Label()
        Me.tTit = New System.Windows.Forms.Label()
        Me.Nombres.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Nombres
        '
        Me.Nombres.Controls.Add(Me.nEme)
        Me.Nombres.Controls.Add(Me.nTit)
        Me.Nombres.Controls.Add(Me.nPar)
        Me.Nombres.Controls.Add(Me.Label3)
        Me.Nombres.Controls.Add(Me.Label2)
        Me.Nombres.Controls.Add(Me.Label1)
        Me.Nombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Nombres.Location = New System.Drawing.Point(12, 12)
        Me.Nombres.Name = "Nombres"
        Me.Nombres.Size = New System.Drawing.Size(340, 227)
        Me.Nombres.TabIndex = 0
        Me.Nombres.TabStop = False
        Me.Nombres.Text = "Nombres"
        '
        'nEme
        '
        Me.nEme.AutoSize = True
        Me.nEme.Location = New System.Drawing.Point(125, 182)
        Me.nEme.Name = "nEme"
        Me.nEme.Size = New System.Drawing.Size(66, 24)
        Me.nEme.TabIndex = 5
        Me.nEme.Text = "Label6"
        '
        'nTit
        '
        Me.nTit.AutoSize = True
        Me.nTit.Location = New System.Drawing.Point(125, 44)
        Me.nTit.Name = "nTit"
        Me.nTit.Size = New System.Drawing.Size(66, 24)
        Me.nTit.TabIndex = 4
        Me.nTit.Text = "Label5"
        '
        'nPar
        '
        Me.nPar.AutoSize = True
        Me.nPar.Location = New System.Drawing.Point(125, 112)
        Me.nPar.Name = "nPar"
        Me.nPar.Size = New System.Drawing.Size(66, 24)
        Me.nPar.TabIndex = 3
        Me.nPar.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Emergencia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Pareja"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Titular"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tEme)
        Me.GroupBox1.Controls.Add(Me.tPar)
        Me.GroupBox1.Controls.Add(Me.tTit)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(359, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(340, 227)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Telefonos"
        '
        'tEme
        '
        Me.tEme.AutoSize = True
        Me.tEme.Location = New System.Drawing.Point(6, 182)
        Me.tEme.Name = "tEme"
        Me.tEme.Size = New System.Drawing.Size(76, 24)
        Me.tEme.TabIndex = 2
        Me.tEme.Text = "Label12"
        '
        'tPar
        '
        Me.tPar.AutoSize = True
        Me.tPar.Location = New System.Drawing.Point(6, 112)
        Me.tPar.Name = "tPar"
        Me.tPar.Size = New System.Drawing.Size(76, 24)
        Me.tPar.TabIndex = 1
        Me.tPar.Text = "Label13"
        '
        'tTit
        '
        Me.tTit.AutoSize = True
        Me.tTit.Location = New System.Drawing.Point(6, 44)
        Me.tTit.Name = "tTit"
        Me.tTit.Size = New System.Drawing.Size(76, 24)
        Me.tTit.TabIndex = 0
        Me.tTit.Text = "Label14"
        '
        'ConCli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 343)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Nombres)
        Me.Name = "ConCli"
        Me.Text = "Contacto Clientes"
        Me.Nombres.ResumeLayout(False)
        Me.Nombres.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Nombres As GroupBox
    Friend WithEvents nEme As Label
    Friend WithEvents nTit As Label
    Friend WithEvents nPar As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tEme As Label
    Friend WithEvents tPar As Label
    Friend WithEvents tTit As Label
End Class
