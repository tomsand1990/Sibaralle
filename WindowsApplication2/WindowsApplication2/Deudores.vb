Imports System.Data
Imports System.Data.SqlClient
Public Class Deudores
    Private Sub Deudores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DdrSQL As String
        DdrSQL = "SELECT Cl.Apellido,Cl.Nombre, Co.DNI, Co.Direccion FROM Inquilinos.dbo.Clientes as Cl INNER JOIN Inquilinos.dbo.Contratos as Co ON Cl.DNI=Co.DNI WHERE Co.FF > GETDATE() AND Co.FUP is null OR DATEDIFF(MONTH,Co.FUP,GETDATE())>0 GROUP BY Co.DNI,Co.Direccion,Cl.Apellido,Cl.Nombre"
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=(local);Initial Catalog=Inquilinos;Integrated Security=True"
        Dim dbadp As New SqlDataAdapter(DdrSQL, con)
        Dim dTable2 As New DataTable
        dbadp.Fill(dTable2)
        DataGridView1.DataSource = dTable2
    End Sub
    Private Sub Volver_Click(sender As Object, e As EventArgs) Handles Volver.Click
        SistemaInmobiliario.Show()
        Me.Close()
    End Sub

End Class