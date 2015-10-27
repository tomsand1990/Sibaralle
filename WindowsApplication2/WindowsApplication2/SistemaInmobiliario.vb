Imports System.Data
Imports System.Data.SqlClient
Public Class SistemaInmobiliario

    Private Sub NuevoInmueble_MouseClick(sender As Object, e As MouseEventArgs) Handles NuevoInmueble.MouseClick
        Me.Hide()
        CargaInmueble.Show()


    End Sub

    Private Sub NuevoContrato_Click(sender As Object, e As EventArgs) Handles NewContract.Click
        NuevoContrato.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NuevoCliente.Show()
        Me.Hide()
    End Sub

    Private Sub Pago_Click(sender As Object, e As EventArgs) Handles Pago.Click
        Pagos.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CargaCuentas.Show()
        Me.Hide()
    End Sub

    Private Sub Reclamos_Click(sender As Object, e As EventArgs) Handles Reclamosbtn.Click
        Reclamos.Show()
        Me.Hide()
    End Sub

    Private Sub Deudores_Click(sender As Object, e As EventArgs) Handles Deudor.Click
        Deudores.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles VencCont.Click
        Vencimientos.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles VerRec.Click
        VerReclamos.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DeuServ.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        BusCli.Show()

    End Sub
End Class