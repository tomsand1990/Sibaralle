Imports System.Data
Imports System.Data.SqlClient
Public Class BusCli
    Private Sub BusCli_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tDNI.Enabled = False
        tApellido.Enabled = False
        tNombre.Enabled = False

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tApellido.TextChanged
        Dim BusSQL As String
        BusSQL = ""
        If (tNombre.Text = "") Then
            BusSQL = "SELECT TOP (1) DNI,Nombre,Apellido,TelefonoTitular,NombreConyuge,TelefonoConyuge,NombreEmergencia,TelefonoEmergencia FROM Clientes WHERE Apellido like '" + tApellido.Text + "%'"
        ElseIf (tNombre.Text IsNot "")
            BusSQL = "SELECT TOP (1) DNI,Nombre,Apellido,TelefonoTitular,NombreConyuge,TelefonoConyuge,NombreEmergencia,TelefonoEmergencia FROM Clientes WHERE Apellido like '" + tApellido.Text + "' AND Nombre like '" + tNombre.Text + "'"
        End If
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=(local);Initial Catalog=Inquilinos;Integrated Security=True"
        cmd = New SqlCommand(BusSQL, con)

        Try
            con.Open()
            Dim myreader As SqlDataReader = cmd.ExecuteReader()
            If myreader.Read() Then
                nTit.Text = myreader.GetValue(2) + ", " + myreader.GetValue(1)
                tTit.Text = myreader.GetValue(3)
                nPar.Text = myreader.GetValue(4)
                tPar.Text = myreader.GetValue(5)
                nEme.Text = myreader.GetValue(6)
                tEme.Text = myreader.GetValue(7)

            End If
            myreader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles tNombre.TextChanged
        Dim BusSQL As String
        BusSQL = ""
        If (tNombre.Text = "" And tApellido.Text = "") Then
            BusSQL = "SELECT TOP (1) DNI,Nombre,Apellido,TelefonoTitular,NombreConyuge,TelefonoConyuge,NombreEmergencia,TelefonoEmergencia FROM Clientes WHERE Nombre like '" + tNombre.Text + "%'"
        ElseIf (tApellido.Text IsNot "")
            BusSQL = "SELECT TOP (1) DNI,Nombre,Apellido,TelefonoTitular,NombreConyuge,TelefonoConyuge,NombreEmergencia,TelefonoEmergencia FROM Clientes WHERE Nombre like '" + tNombre.Text + "%' AND Apellido like '" + tApellido.Text + "%'"
        End If
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=(local);Initial Catalog=Inquilinos;Integrated Security=True"
        cmd = New SqlCommand(BusSQL, con)

        Try
            con.Open()
            Dim myreader As SqlDataReader = cmd.ExecuteReader()
            If myreader.Read() Then
                nTit.Text = myreader.GetValue(2) + ", " + myreader.GetValue(1)
                tTit.Text = myreader.GetValue(3)
                nPar.Text = myreader.GetValue(4)
                tPar.Text = myreader.GetValue(5)
                nEme.Text = myreader.GetValue(6)
                tEme.Text = myreader.GetValue(7)

            End If
            myreader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub

    Private Sub rApellido_checked(sender As Object, e As EventArgs) Handles rApellido.CheckedChanged
        If (rApellido.Checked = True) Then
            tApellido.Enabled = True
            tNombre.Enabled = True
            tDNI.Enabled = False
        End If
    End Sub
    Private Sub rDNI_checked(sender As Object, e As EventArgs) Handles rDNI.CheckedChanged
        If (rDNI.Checked = True) Then
            tApellido.Enabled = False
            tNombre.Enabled = False
            tDNI.Enabled = True
        End If
    End Sub
    Private Sub tDNI_TextChanged(sender As Object, e As EventArgs) Handles tDNI.TextChanged
        Dim BusSQL As String
        BusSQL = "SELECT TOP (1) DNI,Nombre,Apellido,TelefonoTitular,NombreConyuge,TelefonoConyuge,NombreEmergencia,TelefonoEmergencia FROM Clientes WHERE DNI like '" & tDNI.Text & "%'"
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=(local);Initial Catalog=Inquilinos;Integrated Security=True"
        cmd = New SqlCommand(BusSQL, con)

        Try
            con.Open()
            Dim myreader As SqlDataReader = cmd.ExecuteReader()
            If myreader.Read() Then
                nTit.Text = myreader.GetValue(2) + ", " + myreader.GetValue(1)
                tTit.Text = myreader.GetValue(3)
                nPar.Text = myreader.GetValue(4)
                tPar.Text = myreader.GetValue(5)
                nEme.Text = myreader.GetValue(6)
                tEme.Text = myreader.GetValue(7)

            End If
            myreader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub

End Class