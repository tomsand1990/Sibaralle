<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerReclamos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VerReclamos))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Volver = New System.Windows.Forms.Button()
        Me.Reclamo = New System.Windows.Forms.TextBox()
        Me.Resolucion = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ApellidoL = New System.Windows.Forms.Label()
        Me.DirecciónL = New System.Windows.Forms.Label()
        Me.Apellido = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Nombre = New System.Windows.Forms.TextBox()
        Me.Imprimir = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Respuesta = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.NullValue = "NO"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(13, 74)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.Size = New System.Drawing.Size(987, 94)
        Me.DataGridView1.TabIndex = 2
        '
        'Volver
        '
        Me.Volver.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Volver.Location = New System.Drawing.Point(892, 459)
        Me.Volver.Name = "Volver"
        Me.Volver.Size = New System.Drawing.Size(108, 57)
        Me.Volver.TabIndex = 25
        Me.Volver.Text = "Volver"
        Me.Volver.UseVisualStyleBackColor = True
        '
        'Reclamo
        '
        Me.Reclamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Reclamo.Location = New System.Drawing.Point(18, 50)
        Me.Reclamo.Multiline = True
        Me.Reclamo.Name = "Reclamo"
        Me.Reclamo.Size = New System.Drawing.Size(582, 131)
        Me.Reclamo.TabIndex = 26
        '
        'Resolucion
        '
        Me.Resolucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resolucion.Location = New System.Drawing.Point(12, 459)
        Me.Resolucion.Name = "Resolucion"
        Me.Resolucion.Size = New System.Drawing.Size(108, 57)
        Me.Resolucion.TabIndex = 27
        Me.Resolucion.Text = "Resolver"
        Me.Resolucion.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(13, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 24)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(538, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 24)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Dirección:"
        '
        'ApellidoL
        '
        Me.ApellidoL.AutoSize = True
        Me.ApellidoL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.ApellidoL.Location = New System.Drawing.Point(103, 180)
        Me.ApellidoL.Name = "ApellidoL"
        Me.ApellidoL.Size = New System.Drawing.Size(0, 24)
        Me.ApellidoL.TabIndex = 30
        '
        'DirecciónL
        '
        Me.DirecciónL.AutoSize = True
        Me.DirecciónL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.DirecciónL.Location = New System.Drawing.Point(639, 180)
        Me.DirecciónL.Name = "DirecciónL"
        Me.DirecciónL.Size = New System.Drawing.Size(0, 24)
        Me.DirecciónL.TabIndex = 31
        '
        'Apellido
        '
        Me.Apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Apellido.Location = New System.Drawing.Point(103, 26)
        Me.Apellido.Name = "Apellido"
        Me.Apellido.Size = New System.Drawing.Size(206, 29)
        Me.Apellido.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(13, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 24)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Apellido:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(315, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 24)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Nombre:"
        '
        'Nombre
        '
        Me.Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre.Location = New System.Drawing.Point(405, 26)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(206, 29)
        Me.Nombre.TabIndex = 34
        '
        'Imprimir
        '
        Me.Imprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Imprimir.Location = New System.Drawing.Point(417, 459)
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.Size = New System.Drawing.Size(108, 57)
        Me.Imprimir.TabIndex = 36
        Me.Imprimir.Text = "Imprimir"
        Me.Imprimir.UseVisualStyleBackColor = True
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
        'Respuesta
        '
        Me.Respuesta.Location = New System.Drawing.Point(26, 50)
        Me.Respuesta.Multiline = True
        Me.Respuesta.Name = "Respuesta"
        Me.Respuesta.Size = New System.Drawing.Size(284, 131)
        Me.Respuesta.TabIndex = 37
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Reclamo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 234)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(620, 199)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reclamo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Respuesta)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(669, 234)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(330, 198)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Respuesta"
        '
        'VerReclamos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 528)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Imprimir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Apellido)
        Me.Controls.Add(Me.DirecciónL)
        Me.Controls.Add(Me.ApellidoL)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Resolucion)
        Me.Controls.Add(Me.Volver)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "VerReclamos"
        Me.Text = "VerReclamos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Volver As Button
    Friend WithEvents Reclamo As System.Windows.Forms.TextBox
    Friend WithEvents Resolucion As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ApellidoL As Label
    Friend WithEvents DirecciónL As Label
    Friend WithEvents Apellido As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Nombre As TextBox
    Friend WithEvents Imprimir As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Respuesta As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
