Imports System.Data
Imports System.Data.SqlClient
Public Class Vencimientos
    Private Sub Vencimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim vencSQL As String
        vencSQL = "SELECT Cl.Apellido,Cl.Nombre, Co.DNI, Co.Direccion, Co.FF FROM Clientes as Cl RIGHT JOIN Contratos as Co On Cl.DNI=Co.DNI Where Co.FF>GETDATE() Order By Co.FF DESC"
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=(local);Initial Catalog=Inquilinos;Integrated Security=True"
        Dim dbadp As New SqlDataAdapter(vencSQL, con)
        Dim dTable2 As New DataTable
        dbadp.Fill(dTable2)
        DataGridView1.DataSource = dTable2

    End Sub

    Private Sub Volver_Click(sender As Object, e As EventArgs) Handles Volver.Click
        SistemaInmobiliario.Show()
        Me.Close()
    End Sub
End Class