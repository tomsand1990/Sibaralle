Imports System.Data
Imports System.Data.SqlClient
Public Class CargaCuentas
    Dim con As New SqlConnection


    Private Sub DireccionCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DireccionCombo.SelectedIndexChanged
        Agua_CheckedChanged(DireccionCombo.SelectedItem, e)
        Luz_CheckedChanged(DireccionCombo.SelectedItem, e)
        Gas_CheckedChanged(DireccionCombo.SelectedItem, e)
        Muni_CheckedChanged(DireccionCombo.SelectedItem, e)
        DGR_CheckedChanged(DireccionCombo.SelectedItem, e)
        Otros_CheckedChanged(DireccionCombo.SelectedItem, e)
    End Sub

    Private Sub CargaCuentas_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim sSQL As String

        sSQL = "SELECT Inmuebles.Direccion,Agua.Contrato,Luz.Contrato, Gas.Contrato, Muni.Contrato,DGR.Contrato From Inmuebles LEFT JOIN Agua ON Inmuebles.Direccion = Agua.Direccion LEFT JOIN Luz ON Inmuebles.Direccion = Luz.Direccion LEFT JOIN Gas ON Inmuebles.Direccion = Gas.Direccion LEFT JOIN Muni ON Inmuebles.Direccion = Muni.Direccion LEFT JOIN DGR ON Inmuebles.Direccion = DGR.Direccion GROUP BY Inmuebles.Direccion,Agua.Contrato,Luz.Contrato, Gas.Contrato, Muni.Contrato,DGR.Contrato"
        con.ConnectionString = "Data Source=(local);Initial Catalog=Inquilinos;Integrated Security=True"
        Dim dbadp As New SqlDataAdapter(sSQL, con)
        Dim dTable2 As New DataTable
        dbadp.Fill(dTable2)
        dbadp.Dispose()
        Me.DireccionCombo.DisplayMember = "Direccion"
        Me.DireccionCombo.ValueMember = "Direccion"
        Me.DireccionCombo.DataSource = dTable2
    End Sub

    Private Sub Agua_CheckedChanged(sender As Object, e As EventArgs) Handles Agua.CheckedChanged
        If Agua.Checked = True Then
            If IsDBNull(DireccionCombo.SelectedItem(1)) Then
                Me.AqTextBox.Visible = True
            Else
                Me.AqTextBox.Visible = False
                Me.Label7.Text = Me.DireccionCombo.SelectedItem(1)
            End If
        Else
            Me.Label7.Text = ""
            AqTextBox.Visible = False
        End If

    End Sub
    Private Sub Luz_CheckedChanged(sender As Object, e As EventArgs) Handles Luz.CheckedChanged
        If Luz.Checked = True Then
            If IsDBNull(DireccionCombo.SelectedItem(2)) Then
                LuzTextBox.Visible = True
            Else
                LuzTextBox.Visible = False
                Me.Label8.Text = Me.DireccionCombo.SelectedItem(2)
            End If
        Else
            Me.Label8.Text = ""
            LuzTextBox.Visible = False
        End If

    End Sub
    Private Sub Gas_CheckedChanged(sender As Object, e As EventArgs) Handles Gas.CheckedChanged
        If Gas.Checked = True Then
            If IsDBNull(DireccionCombo.SelectedItem(3)) Then
                GasTextBox.Visible = True
            Else
                GasTextBox.Visible = False
                Me.Label10.Text = Me.DireccionCombo.SelectedItem(3)
            End If
        Else
            Me.Label10.Text = ""
            GasTextBox.Visible = False
        End If

    End Sub
    Private Sub Muni_CheckedChanged(sender As Object, e As EventArgs) Handles Muni.CheckedChanged
        If Muni.Checked = True Then
            If IsDBNull(DireccionCombo.SelectedItem(4)) Then
                MuniTextBox.Visible = True
            Else
                MuniTextBox.Visible = False
                Me.Label9.Text = Me.DireccionCombo.SelectedItem(4)
            End If
        Else
            Me.Label9.Text = ""
            MuniTextBox.Visible = False
        End If

    End Sub
    Private Sub DGR_CheckedChanged(sender As Object, e As EventArgs) Handles DGR.CheckedChanged
        If DGR.Checked = True Then
            If IsDBNull(DireccionCombo.SelectedItem(5)) Then
                DGRTextBox.Visible = True
            Else
                DGRTextBox.Visible = False
                Me.Label11.Text = Me.DireccionCombo.SelectedItem(5)
            End If
        Else
            Me.Label11.Text = ""
            DGRTextBox.Visible = False
        End If

    End Sub
    Private Sub Otros_CheckedChanged(sender As Object, e As EventArgs) Handles Otros.CheckedChanged
        If Otros.Checked = True Then
            OtrosTextBox.Visible = True
        Else
            OtrosTextBox.Visible = False
        End If

    End Sub
    Private Sub Volver_Click(sender As Object, e As EventArgs) Handles Volver.Click
        Me.Close()
        SistemaInmobiliario.Show()
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click

    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Dim GSQL As String
        Dim Aguas As String
        Dim Luzs As String
        Dim Gass As String
        Dim Munis As String
        Dim DGRs As String
        Dim Otross As String
        Dim cmd As New SqlCommand
        con.ConnectionString = "Data Source=(local);Initial Catalog=Inquilinos;Integrated Security=True"
        GSQL = ""
        If Agua.Checked = True Then

            If AqTextBox.Text = "" Then
                Aguas = Me.Label7.Text
            Else
                Aguas = AqTextBox.Text
            End If
            GSQL = String.Concat(GSQL, "INSERT INTO Agua (Contrato, Gasto, FinPeriodo, Direccion, Pagado) Values ('" + Aguas + "','" + Me.GastoAgua.Text + "', '" + Me.VencAgua.Value + "','" + Me.DireccionCombo.SelectedItem(0).ToString + "',0); ")
        End If
        If Luz.Checked = True Then

            If LuzTextBox.Text = "" Then
                Luzs = Me.Label8.Text
            Else
                Luzs = LuzTextBox.Text
            End If
            GSQL = String.Concat(GSQL, "INSERT INTO Luz (Contrato, Gasto, FinPeriodo, Direccion, Pagado) Values ('" + Luzs + "','" + Me.GastoLuz.Text + "', '" + Me.VencLuz.Value + "','" + Me.DireccionCombo.SelectedItem(0).ToString + "',0); ")
        End If
        If Gas.Checked = True Then

            If GasTextBox.Text = "" Then
                Gass = Me.Label10.Text
            Else
                Gass = GasTextBox.Text
            End If
            GSQL = String.Concat(GSQL, "INSERT INTO Gas (Contrato, Gasto, FinPeriodo, Direccion, Pagado) Values ('" + Gass + "','" + Me.GastoGas.Text + "', '" + Me.VencGas.Value + "','" + Me.DireccionCombo.SelectedItem(0).ToString + "',0); ")
        End If
        If Muni.Checked = True Then

            If MuniTextBox.Text = "" Then
                Munis = Me.Label9.Text
            Else
                Munis = MuniTextBox.Text
            End If
            GSQL = String.Concat(GSQL, "INSERT INTO Muni (Contrato, Gasto, FinPeriodo, Direccion, Pagado) Values ('" + Munis + "','" + Me.GastoMuni.Text + "', '" + Me.VencMuni.Value + "','" + Me.DireccionCombo.SelectedItem(0).ToString + "',0); ")
        End If
        If DGR.Checked = True Then

            If DGRTextBox.Text = "" Then
                DGRs = Me.Label11.Text
            Else
                DGRs = DGRTextBox.Text
            End If
            GSQL = String.Concat(GSQL, "INSERT INTO DGR (Contrato, Gasto, FinPeriodo, Direccion, Pagado) Values ('" + DGRs + "','" + Me.GastoDGR.Text + "', '" + Me.VencDGR.Value + "','" + Me.DireccionCombo.SelectedItem(0).ToString + "',0); ")
        End If

        If Otros.Checked = True Then

            If OtrosTextBox.Text = "" Then
                Otross = Me.Label11.Text
            Else
                Otross = OtrosTextBox.Text
            End If
            GSQL = String.Concat(GSQL, "INSERT INTO Otros (Detalle, FinPeriodo, Gasto, Direccion, Pagado) Values ('" + Otross + "', '" + Me.VencOtros.Value + "','" + Me.GastoOtros.Text + "','" + Me.DireccionCombo.SelectedItem(0).ToString + "',0); ")

        End If

        con.Open()
        cmd.Connection = con
        cmd.CommandText = GSQL
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Registros Agregados")
        Me.Update()
    End Sub
End Class