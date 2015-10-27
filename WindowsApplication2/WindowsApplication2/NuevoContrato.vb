'TODO: Metodo para clientes q solo tienen 1 o 2 aumentos
Imports System.Data
Imports System.Data.SqlClient
Public Class NuevoContrato
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Try
            con.ConnectionString = "Data Source=(local);Initial Catalog=Inquilinos;Integrated Security=True"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "insert into Contratos (DNI, Direccion, FI,FI1,FI2,FI3,FF,P0,P1,P2,P3,FUP) Values ('" + Me.ApellidoComboBox.SelectedItem(0) + "','" + Me.DireccionComboBox1.Text + " ','" + Me.FI.Value + "','" + Me.FI1.Value + "','" + Me.FI2.Value + "','" + Me.FI3.Value + "','" + Me.FF.Value + "','" + Me.P0.Text + "','" + Me.P1.Text + "','" + Me.P2.Text + "','" + Me.P3.Text + "','" + DateAndTime.Today + "');"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Contrato Creado")
            con.Close()
            Me.Limpiar_Click(sender, e)
        Catch ex As Exception
            MessageBox.Show("Error" & ex.Message, "Insert Records")
        End Try


    End Sub


    Private Sub Volver_Click(sender As Object, e As EventArgs) Handles Volver.Click
        SistemaInmobiliario.Show()
        Me.Close()
    End Sub


    Private Sub NuevoContrato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'InquilinosDataSet.Inmuebles' Puede moverla o quitarla según sea necesario.
        Dim sSQL As String
        Intervalo.Text = 0
        sSQL = "SELECT * FROM Clientes"
        Dim con As New SqlConnection
        con.ConnectionString = "Data Source=(local);Initial Catalog=Inquilinos;Integrated Security=True"
        Dim dbadp As New SqlDataAdapter(sSQL, con)
        Dim dTable As New DataTable
        dbadp.Fill(dTable)
        dbadp.Dispose()
        Me.ApellidoComboBox.DisplayMember = "Apellido"
        Me.ApellidoComboBox.ValueMember = "Apellido"
        Me.ApellidoComboBox.DataSource = dTable
        'TODO: esta línea de código carga datos en la tabla 'InquilinosDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Dim sSQL2 As String
        sSQL2 = "SELECT Direccion FROM Inmuebles"
        con.ConnectionString = "Data Source=(local);Initial Catalog=Inquilinos;Integrated Security=True"
        Dim dbadp2 As New SqlDataAdapter(sSQL2, con)
        Dim dTable2 As New DataTable
        dbadp2.Fill(dTable2)
        dbadp2.Dispose()
        Me.DireccionComboBox1.DisplayMember = "Direccion"
        Me.DireccionComboBox1.ValueMember = "Direccion"
        Me.DireccionComboBox1.DataSource = dTable2


    End Sub

    Private Sub ApellidoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ApellidoComboBox.SelectedIndexChanged
        DNILabel.Text = Nothing
        Try
            With DNILabel
                .Text = ApellidoComboBox.SelectedItem(0).ToString
            End With
            With NombreLabel
                .Text = ApellidoComboBox.SelectedItem(1).ToString
            End With
        Catch ex As Exception

        End Try

    End Sub


    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click

        ApellidoComboBox.Text = ""
        DNILabel.Text = ""
        DireccionComboBox1.Text = ""
        NombreLabel.Text = ""
        FI.Value = DateTime.Now
        FI1.Value = DateTime.Now
        FI2.Value = DateTime.Now
        FI3.Value = DateTime.Now
        FF.Value = DateTime.Now
        P0.Clear()
        P1.Clear()
        P2.Clear()
        P3.Clear()

    End Sub

    Private Sub FI_ValueChanged(sender As Object, e As EventArgs) Handles FI.ValueChanged
        Me.FI1.Value = FI.Value.AddMonths(Me.Intervalo.SelectedItem)
        Me.FI2.Value = FI1.Value.AddMonths(Me.Intervalo.SelectedItem)
        Me.FI3.Value = FI2.Value.AddMonths(Me.Intervalo.SelectedItem)
        Me.FF.Value = FI3.Value.AddMonths(Me.Intervalo.SelectedItem)
    End Sub

    Private Sub Intervalo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Intervalo.SelectedIndexChanged
        FI_ValueChanged(sender, e)
    End Sub
End Class