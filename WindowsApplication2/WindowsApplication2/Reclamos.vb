Imports System.Data
Imports System.Data.SqlClient
Public Class Reclamos
    Dim con As New SqlConnection
    Private Sub Reclamos_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try

            Dim sSQL As String
            sSQL = "SELECT Clientes.Apellido, Clientes.nombre , Contratos.DNI FROM Clientes Left JOIN Contratos ON Contratos.DNI = Clientes.dni WHERE GETDATE()<Contratos.FF GROUP BY Contratos.DNI, Clientes.Apellido, Clientes.Nombre"
            Dim con As New SqlConnection
            con.ConnectionString = "Data Source=(local);Initial Catalog=Inquilinos;Integrated Security=True"
            Dim dbadp As New SqlDataAdapter(sSQL, con)
            Dim dTable As New DataTable
            dbadp.Fill(dTable)
            dbadp.Dispose()
            Me.ApellidoCombo.DisplayMember = "Apellido"
            Me.ApellidoCombo.ValueMember = "Apellido"
            Me.ApellidoCombo.DataSource = dTable


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub ApellidoCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ApellidoCombo.SelectedIndexChanged
        Dim sSQL2 As String

        sSQL2 = "SELECT Contratos.Direccion From Contratos WHERE Contratos.DNI Like '" + Me.ApellidoCombo.SelectedItem(2) + "' AND Contratos.FF > GETDATE()"
        con.ConnectionString = "Data Source=(local);Initial Catalog=Inquilinos;Integrated Security=True"
        Dim dbadp As New SqlDataAdapter(sSQL2, con)
        Dim dTable2 As New DataTable
        DNILabel.Text = Me.ApellidoCombo.SelectedItem(2)
        dbadp.Fill(dTable2)
        dbadp.Dispose()
        NombreLabel.Text = Me.ApellidoCombo.SelectedItem(1)
        Me.DireccionCombo.DisplayMember = "Direccion"
        Me.DireccionCombo.ValueMember = "Direccion"
        Me.DireccionCombo.DataSource = dTable2
        Me.DireccionCombo.Update()

    End Sub

    Private Sub Volver_Click(sender As Object, e As EventArgs) Handles Volver.Click
        Me.Close()
        SistemaInmobiliario.Show()

    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Dim cmd As New SqlCommand
        Try
            con.ConnectionString = "Data Source=(local);Initial Catalog=Inquilinos;Integrated Security=True"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "insert into Reclamos (DNI,Direccion,Reclamo,Fecha) Values ('" + Me.ApellidoCombo.SelectedItem(2) + "','" + Me.DireccionCombo.Text + " ','" + Me.Reclamo.Text + "','" + DateAndTime.Today + "');"
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Reclamo Cargado")
        Catch ex As Exception
            MessageBox.Show("Error" & ex.Message, "Insert Records")
        End Try

    End Sub
End Class