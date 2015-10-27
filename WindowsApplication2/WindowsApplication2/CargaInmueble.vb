Imports System.Data
Imports System.Data.SqlClient
Public Class CargaInmueble

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Try
            con.ConnectionString = "Data Source=(local);Initial Catalog=Inquilinos;Integrated Security=True"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "insert into Inmuebles (Direccion,Comision,dniLocador) Values ('" + Me.Direccion.Text + "','" + Me.Comision.Text + "','" + Me.DNILabel.Text + "');"
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Inmueble Cargado")
            Limpiar_Click(sender, e)
        Catch ex As Exception
            MessageBox.Show("Error" & ex.Message, "Insert Records")
        End Try

    End Sub

    Private Sub Volver_Click(sender As Object, e As EventArgs) Handles Volver.Click
        SistemaInmobiliario.Show()
        Me.Close()

    End Sub

    Private Sub CargaInmueble_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'InquilinosDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Try
            Dim sSQL As String
            sSQL = "SELECT * FROM Clientes Order BY Apellido ASC"
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

        End Try


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ApellidoCombo.SelectedIndexChanged
        DNILabel.Text = Nothing
        Try
            With DNILabel
                .Text = ApellidoCombo.SelectedItem(0).ToString
            End With
        Catch ex As Exception

        End Try
        NombreLabel.Text = Nothing
        Try
            With NombreLabel
                .Text = ApellidoCombo.SelectedItem(1).ToString
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        NombreLabel.Text = ""
        DNILabel.Text = ""
        ApellidoCombo.Text = ""
        Direccion.Text = ""
        Comision.Text = ""
    End Sub
End Class
