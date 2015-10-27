<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SistemaInmobiliario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SistemaInmobiliario))
        Me.NuevoInmueble = New System.Windows.Forms.Button()
        Me.NewContract = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Reclamosbtn = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Pago = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.VerRec = New System.Windows.Forms.Button()
        Me.Deudor = New System.Windows.Forms.Button()
        Me.VencCont = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'NuevoInmueble
        '
        Me.NuevoInmueble.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.NuevoInmueble.Location = New System.Drawing.Point(224, 39)
        Me.NuevoInmueble.Name = "NuevoInmueble"
        Me.NuevoInmueble.Size = New System.Drawing.Size(138, 60)
        Me.NuevoInmueble.TabIndex = 0
        Me.NuevoInmueble.Text = "Inmueble"
        Me.NuevoInmueble.UseVisualStyleBackColor = True
        '
        'NewContract
        '
        Me.NewContract.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.NewContract.Location = New System.Drawing.Point(6, 120)
        Me.NewContract.Name = "NewContract"
        Me.NewContract.Size = New System.Drawing.Size(139, 60)
        Me.NewContract.TabIndex = 1
        Me.NewContract.Text = "Contrato"
        Me.NewContract.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Button2.Location = New System.Drawing.Point(7, 39)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 60)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Cliente"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Reclamosbtn)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Pago)
        Me.GroupBox1.Controls.Add(Me.NuevoInmueble)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.NewContract)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(583, 197)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Carga"
        '
        'Reclamosbtn
        '
        Me.Reclamosbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Reclamosbtn.Location = New System.Drawing.Point(439, 39)
        Me.Reclamosbtn.Name = "Reclamosbtn"
        Me.Reclamosbtn.Size = New System.Drawing.Size(138, 60)
        Me.Reclamosbtn.TabIndex = 6
        Me.Reclamosbtn.Text = "Reclamos"
        Me.Reclamosbtn.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Button3.Location = New System.Drawing.Point(224, 120)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(138, 60)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Cuentas"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Pago
        '
        Me.Pago.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Pago.Location = New System.Drawing.Point(439, 120)
        Me.Pago.Name = "Pago"
        Me.Pago.Size = New System.Drawing.Size(138, 60)
        Me.Pago.TabIndex = 4
        Me.Pago.Text = "Pago"
        Me.Pago.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.VerRec)
        Me.GroupBox2.Controls.Add(Me.Deudor)
        Me.GroupBox2.Controls.Add(Me.VencCont)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 215)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(583, 214)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seguimiento"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Button1.Location = New System.Drawing.Point(438, 44)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 65)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Contacto Clientes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Button4.Location = New System.Drawing.Point(224, 129)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(138, 65)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Deudas"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'VerRec
        '
        Me.VerRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.VerRec.Location = New System.Drawing.Point(224, 44)
        Me.VerRec.Name = "VerRec"
        Me.VerRec.Size = New System.Drawing.Size(138, 65)
        Me.VerRec.TabIndex = 9
        Me.VerRec.Text = "Verificacion de Reclamos"
        Me.VerRec.UseVisualStyleBackColor = True
        '
        'Deudor
        '
        Me.Deudor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Deudor.Location = New System.Drawing.Point(7, 129)
        Me.Deudor.Name = "Deudor"
        Me.Deudor.Size = New System.Drawing.Size(138, 60)
        Me.Deudor.TabIndex = 8
        Me.Deudor.Text = "Deben Mes"
        Me.Deudor.UseVisualStyleBackColor = True
        '
        'VencCont
        '
        Me.VencCont.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.VencCont.Location = New System.Drawing.Point(6, 44)
        Me.VencCont.Name = "VencCont"
        Me.VencCont.Size = New System.Drawing.Size(139, 65)
        Me.VencCont.TabIndex = 7
        Me.VencCont.Text = "Vencimiento de Contratos"
        Me.VencCont.UseVisualStyleBackColor = True
        '
        'SistemaInmobiliario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(607, 441)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SistemaInmobiliario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema Inmobiliario v0.5"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NuevoInmueble As System.Windows.Forms.Button
    Friend WithEvents NewContract As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Pago As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Reclamosbtn As Button
    Friend WithEvents VerRec As Button
    Friend WithEvents Deudor As Button
    Friend WithEvents VencCont As Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As Button
End Class
