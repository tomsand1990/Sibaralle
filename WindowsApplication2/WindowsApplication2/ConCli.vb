Imports System.Data
Imports System.Data.SqlClient
Public Class ConCli
    Public Sub New(ByVal DNI As Int32)
        InitializeComponent()
        Dim BusSQL As String
        BusSQL = "SELECT DNI,Nombre,Apellido,TelefonoTitular,NombreConyuge,TelefonoConyuge,NombreEmergencia,TelefonoEmergencia FROM Clientes WHERE DNI= '" & DNI & "'"
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