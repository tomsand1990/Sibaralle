Imports System.Data
Imports System.Data.SqlClient
Public Class VerReclamos
    Private Sub VerReclamos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Apellido_TextChanged(sender, e)
    End Sub
    Private Sub Volver_Click(sender As Object, e As EventArgs) Handles Volver.Click
        SistemaInmobiliario.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Reclamo.Text = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value
        ApellidoL.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value + ", " + DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
        DirecciónL.Text = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
        If Not IsDBNull(DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value) Then
            Respuesta.Text = DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value
            Respuesta.ReadOnly = True
        Else
            Respuesta.Text = ""
        End If
    End Sub
    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        Dim DNI As Int32
        DNI = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        Dim frm As New ConCli(DNI)
        frm.Show()
    End Sub

    Private Sub Resolucion_Click(sender As Object, e As EventArgs) Handles Resolucion.Click
        Dim ResSQL As String
        ResSQL = "UPDATE Reclamos SET Resuelto = GETDATE(), Respuesta = '" + Me.Respuesta.Text + "' WHERE Fecha='" + DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value + "' AND DNI ='" + DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value + "' AND Direccion ='" + DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value + "' AND Reclamo like '" + Reclamo.Text + "'"
        Dim result As Integer = MessageBox.Show("¿Esta Resuelto?", "caption", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            MessageBox.Show("No Resuelto")
        ElseIf result = DialogResult.Yes Then
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            If Respuesta.Text IsNot "" Then
                Try
                    con.ConnectionString = "Data Source=(local);Initial Catalog=Inquilinos;Integrated Security=True"
                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = ResSQL
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MessageBox.Show("Reclamo Resuelto")
                Catch ex As Exception
                    MessageBox.Show("Error" & ex.Message, "Insert Records")
                End Try
            Else
                MessageBox.Show("Falta Completar la Respuesta")
            End If
            VerReclamos_Load(sender, e)
        End If
    End Sub

    Private Sub Apellido_TextChanged(sender As Object, e As EventArgs) Handles Apellido.TextChanged, Nombre.TextChanged

        Dim BusSQL As String
        If (Apellido.Text IsNot "" Or Nombre.Text IsNot "") Then
            BusSQL = "SELECT Cl.DNI,Cl.Apellido,Cl.Nombre, Re.Direccion,Re.Fecha,Re.Reclamo,Re.Resuelto, Re.Respuesta FROM Clientes as Cl Right JOIN Reclamos as Re ON Cl.DNI=Re.DNI Where Cl.DNI = (Select DNI FROM Clientes Where Apellido like '" + Me.Apellido.Text + "' AND Nombre like '" + Me.Nombre.Text + "' )"
        Else
            BusSQL = "SELECT Cl.DNI,Cl.Apellido,Cl.Nombre, Re.Direccion,Re.Fecha,Re.Reclamo,Re.Resuelto, Re.Respuesta FROM Clientes as Cl Right JOIN Reclamos as Re ON Cl.DNI=Re.DNI Where  Re.Resuelto IS NULL"
        End If
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=(local);Initial Catalog=Inquilinos;Integrated Security=True"
        Dim dbadp2 As New SqlDataAdapter(BusSQL, con)
        Dim dTable3 As New DataTable
        dbadp2.Fill(dTable3)
        DataGridView1.DataSource = dTable3
        Me.DataGridView1.Columns(0).Visible = False

    End Sub
    Private bitmap As Bitmap
    Private Sub Imprimir_Click(sender As Object, e As EventArgs) Handles Imprimir.Click
        Dim height As Integer = DataGridView1.Height
        DataGridView1.Height = DataGridView1.RowCount * 50

        'Create a Bitmap and draw the DataGridView on it.
        bitmap = New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(Bitmap, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))

        'Resize DataGridView back to original height.
        DataGridView1.Height = height

        'Show the Print Preview Dialog.
        printPreviewDialog1.Document = PrintDocument1
        printPreviewDialog1.PrintPreviewControl.Zoom = 1
        printPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintPage(sender As Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Print the contents.
        e.Graphics.DrawImage(bitmap, 0, 0)
    End Sub
End Class