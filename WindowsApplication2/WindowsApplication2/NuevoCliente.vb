Imports System.Data
Imports System.Data.SqlClient
Public Class NuevoCliente
    Private Sub Volver_Click(sender As Object, e As EventArgs) Handles Volver.Click
        SistemaInmobiliario.Show()
        Me.Close()
    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        If (Me.Apellido.Text = "" Or Me.Nombre.Text = "" Or Me.DNI.Text = "" Or Me.TelTit.Text = "") Then

            Dim falta As String
            Dim cf As Integer
            cf = 0
            falta = ""
            If (Me.Apellido.Text = "") Then
                cf = cf + 1
                falta = String.Concat(falta, "Apellido")
            End If
            If (Me.Nombre.Text = "") Then
                cf = cf + 1
                If (cf > 1) Then
                    falta = String.Concat(falta, ", Nombre")
                Else
                    falta = String.Concat(falta, "Nombre")
                End If

            End If
            If (Me.DNI.Text = "") Then
                cf = cf + 1
                If (cf > 1) Then
                    falta = String.Concat(falta, ", DNI")
                Else
                    falta = String.Concat(falta, "DNI")
                End If
            End If
            If (Me.TelPar.Text = "") Then
                cf = cf + 1
                If (cf > 1) Then
                    falta = String.Concat(falta, ", Telefono Particular")
                Else
                    falta = String.Concat(falta, "Telefono Particular")
                End If
                If (cf > 1) Then
                    MessageBox.Show(String.Concat("Falta llenar los campos ", falta))
                Else
                    MessageBox.Show(String.Concat("Falta llenar el campo ", falta))
                End If

            End If

            Else

                Try
                con.ConnectionString = "Data Source=(local);Initial Catalog=Inquilinos;Integrated Security=True"
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "insert into Clientes (Apellido,Nombre,DNI,TelefonoTitular,TelefonoEmergencia,TelefonoConyuge,NombreEmergencia,NombreConyuge) Values ('" + Me.Apellido.Text + "','" + Me.Nombre.Text + " ','" + Me.DNI.Text + "','" + Me.TelTit.Text + "','" + Me.TelEme.Text + "','" + Me.TelPar.Text + "','" + Me.NomEmer.Text + "','" + Me.NomPar.Text + "');"
                cmd.ExecuteNonQuery()
                MessageBox.Show("Cliente Agregado")
                Limpiar_Click(sender, e)

            Catch ex As Exception
                MessageBox.Show("Error" & ex.Message, "Insert Records")
            End Try
        End If

    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        Me.DNI.Text = ""
        Me.Apellido.Text = ""
        Me.Nombre.Text = ""
        Me.NomEmer.Text = ""
        Me.NomPar.Text = ""
        Me.TelTit.Text = ""
        Me.TelPar.Text = ""
        Me.TelEme.Text = ""
    End Sub

End Class
