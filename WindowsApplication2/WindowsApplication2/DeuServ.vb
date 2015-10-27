Imports System.Data
Imports System.Data.SqlClient
Public Class DeuServ

    Private Sub DeuServ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DdrSQL As String
        DdrSQL = "Select Cl.DNI,Cl.Apellido,Cl.Nombre,Co.Direccion,
(ISNULL((SELECT SUM(Agua.Gasto) From Inquilinos.dbo.Agua WHERE Agua.Pagado=0 and Agua.Direccion=Co.Direccion),0)+
ISNULL((SELECT SUM(Luz.Gasto) From Inquilinos.dbo.Luz WHERE Luz.Pagado=0 and Luz.Direccion=Co.Direccion),0)+
ISNULL((SELECT SUM(Gas.Gasto) From Inquilinos.dbo.Gas WHERE Gas.Pagado=0 and Gas.Direccion=Co.Direccion),0)+
ISNULL((SELECT SUM(DGR.Gasto) From Inquilinos.dbo.DGR WHERE DGR.Pagado=0 and DGR.Direccion=Co.Direccion),0)+
ISNULL((SELECT SUM(Muni.Gasto) From Inquilinos.dbo.Muni WHERE Muni.Pagado=0 and Muni.Direccion=Co.Direccion),0)+
ISNULL((SELECT SUM(Otros.Gasto) From Inquilinos.dbo.Otros WHERE Otros.Pagado=0 and Otros.Direccion=Co.Direccion),0)+
ISNULL((SELECT TOP (1) Pagos.DeudaAnterior FROM Inquilinos.dbo.Pagos WHERE Pagos.Direccion = co.Direccion Order by Pagos.FechaPago Desc ),0)) as Total,
ISNULL((SELECT SUM(Agua.Gasto) From Inquilinos.dbo.Agua WHERE Agua.Pagado=0 and Agua.Direccion=Co.Direccion),0) as Agua,
ISNULL((SELECT SUM(Luz.Gasto) From Inquilinos.dbo.Luz WHERE Luz.Pagado=0 and Luz.Direccion=Co.Direccion),0) as Luz,
ISNULL((SELECT SUM(Gas.Gasto) From Inquilinos.dbo.Gas WHERE Gas.Pagado=0 and Gas.Direccion=Co.Direccion),0) as Gas,
ISNULL((SELECT SUM(DGR.Gasto) From Inquilinos.dbo.DGR WHERE DGR.Pagado=0 and DGR.Direccion=Co.Direccion),0) as DGR,
ISNULL((SELECT SUM(Muni.Gasto) From Inquilinos.dbo.Muni WHERE Muni.Pagado=0 and Muni.Direccion=Co.Direccion),0) as Muni,
ISNULL((SELECT SUM(Otros.Gasto) From Inquilinos.dbo.Otros WHERE Otros.Pagado=0 and Otros.Direccion=Co.Direccion),0) As Otros,
ISNULL((SELECT TOP (1) Pagos.DeudaAnterior FROM Inquilinos.dbo.Pagos WHERE Pagos.Direccion = co.Direccion Order by Pagos.FechaPago Desc ),0) as DeudaAnterior
From Inquilinos.dbo.Clientes as Cl Inner Join Inquilinos.dbo.Contratos as Co ON cl.DNI=Co.DNI Inner Join Inquilinos.dbo.Pagos on Pagos.DNI =Co.DNI
GROUP BY cl.DNI,cl.Apellido, Cl.Nombre,Co.Direccion Order by Total Desc"
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=(local);Initial Catalog=Inquilinos;Integrated Security=True"
        Dim dbadp As New SqlDataAdapter(DdrSQL, con)
        Dim dTable2 As New DataTable
        dbadp.Fill(dTable2)
        DataGridView1.DataSource = dTable2
        DataGridView1.Columns(0).Visible = False
    End Sub
    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        Dim DNI As Int32
        DNI = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        Dim frm As New ConCli(DNI)
        frm.Show()
    End Sub

    Private bitmap As Bitmap
    Private Sub Imprimir_Click(sender As Object, e As EventArgs) Handles Imprimir.Click
        Dim height As Integer = DataGridView1.Height
        DataGridView1.Height = DataGridView1.RowCount * DataGridView1.RowTemplate.Height

        'Create a Bitmap and draw the DataGridView on it.
        bitmap = New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))

        'Resize DataGridView back to original height.
        DataGridView1.Height = height

        'Show the Print Preview Dialog.
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintPage(sender As Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Print the contents.
        e.Graphics.DrawImage(bitmap, 0, 0)
    End Sub
End Class