Imports System.Data
Imports System.Data.SqlClient
Imports ThoughtWorks.QRCode.Codec

Public Class Pagos
    Dim Total As Double
    Dim Muni = 0, DGR = 0, Otros = 0, Agua = 0, Gas = 0, Luz = 0, alqpas, DNI As Double
    Private Sub Volver_Click(sender As Object, e As EventArgs) Handles Volver.Click
        SistemaInmobiliario.Show()
        Me.Close()
    End Sub

    Private Sub Pagos_Load(sender As Object, e As EventArgs) Handles Me.Load
        Fechalabel.Text = DateAndTime.Today
        Try

            Dim sSQL As String
            sSQL = "SELECT Clientes.Apellido, Clientes.nombre , Contratos.DNI FROM Inquilinos.dbo.Clientes Left JOIN Inquilinos.dbo.Contratos ON Contratos.DNI = Clientes.dni WHERE GETDATE()<Contratos.FF GROUP BY Contratos.DNI, Clientes.Apellido, Clientes.Nombre Order BY Clientes.Apellido DESC"
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
        Dim con As New SqlConnection
        sSQL2 = "SELECT Contratos.Direccion From Contratos WHERE Contratos.DNI Like '" + Me.ApellidoCombo.SelectedItem(2) + "' AND Contratos.FF > GETDATE()"
        con.ConnectionString = "Data Source=(local);Initial Catalog=Inquilinos;Integrated Security=True"
        Dim dbadp As New SqlDataAdapter(sSQL2, con)
        Dim dTable2 As New DataTable
        DNI = Me.ApellidoCombo.SelectedItem(2)
        DNILabel.Text = DNI
        dbadp.Fill(dTable2)
        dbadp.Dispose()
        NombreLabel.Text = Me.ApellidoCombo.SelectedItem(1)
        Me.DireccionCombo.DisplayMember = "Direccion"
        Me.DireccionCombo.ValueMember = "Direccion"
        Me.DireccionCombo.DataSource = dTable2
    End Sub

    Private Sub DireccionCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DireccionCombo.SelectedIndexChanged

        Dim aSQL, lSQL, gSQL, mSQL, dSQL, oSQL, cSQL, deuSQL, locSQL As String
        Dim con As New SqlConnection
        'Dim Muni = 0, DGR = 0, Otros = 0, Agua = 0, Gas = 0, Luz = 0, alqpas As Double
        Total = 0
        con.ConnectionString = "Data Source=(local);Initial Catalog= Inquilinos;Integrated Security=True"
        aSQL = "SELECT SUM(Agua.Gasto) AS Gasto FROM Inquilinos.dbo.Agua WHERE (Pagado = 0) AND Direccion='" + Me.DireccionCombo.Text + "'"
        Dim cmd As New SqlCommand(aSQL, con)
        con.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader
        If reader.Read() Then

            If Not reader("Gasto") Is DBNull.Value Then
                AguaLabel.Text = reader("Gasto")
                If AguaCheck.Checked = True Then
                    Agua = AguaLabel.Text
                    Total = Total + reader("Gasto")
                End If
            Else
                AguaLabel.Text = 0
            End If
        End If
        reader.Close()
        dSQL = "SELECT SUM(DGR.Gasto) AS Gasto FROM Inquilinos.dbo.DGR WHERE Direccion = '" + Me.DireccionCombo.Text + "' AND (Pagado = 0)"
        Dim cmd1 As New SqlCommand(dSQL, con)
        reader = cmd1.ExecuteReader()
        If reader.Read() Then
            If Not reader("Gasto") Is DBNull.Value Then
                DGRLabel.Text = reader("Gasto")

                If DGRCheck.Checked = True Then
                    DGR = DGRLabel.Text
                    Total = Total + reader("Gasto")
                End If

            Else
                DGRLabel.Text = 0
            End If
        End If
        reader.Close()
        gSQL = "SELECT SUM(Gas.Gasto) AS Gasto FROM Inquilinos.dbo.Gas WHERE Direccion = '" + Me.DireccionCombo.Text + "' AND (Pagado = 0)"
        Dim cmd2 As New SqlCommand(gSQL, con)
        reader = cmd2.ExecuteReader()
        If reader.Read() Then
            If Not reader("Gasto") Is DBNull.Value Then
                GasLabel.Text = reader("Gasto")
                If GasCheck.Checked = True Then
                    Gas = GasLabel.Text
                    Total = Total + reader("Gasto")
                End If
            Else
                GasLabel.Text = 0
            End If
        End If
        reader.Close()
        mSQL = "SELECT SUM(Muni.Gasto) AS Gasto FROM Inquilinos.dbo.Muni WHERE Direccion = '" + Me.DireccionCombo.SelectedValue + "' AND (Pagado = 0)"
        Dim cmd3 As New SqlCommand(mSQL, con)
        reader = cmd3.ExecuteReader
        If reader.Read() Then
            If Not reader("Gasto") Is DBNull.Value Then
                MuniLabel.Text = reader("Gasto")
                If MuniCheck.Checked = True Then
                    Muni = MuniLabel.Text
                    Total = Total + reader("Gasto")
                End If
            Else
                MuniLabel.Text = 0
            End If
        End If
        reader.Close()
        lSQL = "SELECT SUM(Luz.Gasto) AS Gasto FROM Inquilinos.dbo.Luz WHERE Luz.Direccion = '" + Me.DireccionCombo.Text + "' AND (Pagado = 0)"
        Dim cmd4 As New SqlCommand(lSQL, con)
        reader = cmd4.ExecuteReader
        If reader.Read() Then
            If Not reader("Gasto") Is DBNull.Value Then
                LuzLabel.Text = reader("Gasto")

                If LuzCheck.Checked = True Then
                    Luz = LuzLabel.Text
                    Total = Total + reader("Gasto")
                End If
            Else
                LuzLabel.Text = 0
            End If
        End If
        reader.Close()
        oSQL = "SELECT SUM(Otros.Gasto) AS Gasto FROM Inquilinos.dbo.Otros WHERE Otros.Direccion = '" + Me.DireccionCombo.Text + "' AND (Pagado = 0)"
        Dim cmd5 As New SqlCommand(oSQL, con)
        reader = cmd5.ExecuteReader
        If reader.Read() Then
            If Not reader(0) Is DBNull.Value Then
                OtrosLabel.Text = reader(0)
                If OtrosCheck.Checked = True Then
                    Total = Total + reader(0)
                End If
            Else
                OtrosLabel.Text = 0
            End If
        End If
        reader.Close()
        con.Close()
        cSQL = "SELECT FI,FI1,FI2,FI3,P0,P1,P2,P3,FUP FROM Contratos Where Contratos.Direccion= '" + Me.DireccionCombo.Text + "' AND GETDATE()<=Contratos.FF"
        Dim ccmd As New SqlCommand(cSQL, con)
        con.Open()
        reader = ccmd.ExecuteReader


        If (reader.Read()) Then
            If DateDiff(DateInterval.Month, reader(8), DateAndTime.Today) > 0 Then
                If DateDiff(DateInterval.Month, reader(8), DateAndTime.Today) > 1 Then
                    MessageBox.Show("CUIDADO, SEGUNDO MES IMPAGO!!!")
                    lax.Visible = True
                    lax.Text = "SEGUNDO MES IMPAGO!!!"
                    If (reader(0) <= DateAndTime.Today.AddMonths(-1)) And (DateAndTime.Today.AddMonths(-1) < reader(1)) Then
                        alqpas = (reader(4)) + (reader(4) * (DateDiff(DateInterval.Day, DateSerial(Year(Now), 0, 1), DateAndTime.Now) * (0.005)))
                    ElseIf (reader(1) <= DateAndTime.Today.AddMonths(-1)) And (DateAndTime.Today.AddMonths(-1) < reader(2)) Then
                        alqpas = (reader(5)) + (reader(5) * (DateDiff(DateInterval.Day, DateSerial(Year(Now), 0, 1), DateAndTime.Now) * (0.005)))
                    ElseIf (reader(2) <= DateAndTime.Today.AddMonths(-1)) And (DateAndTime.Today.AddMonths(-1) < reader(3)) Then
                        alqpas = (reader(6)) + (reader(6) * (DateDiff(DateInterval.Day, DateSerial(Year(Now), 0, 1), DateAndTime.Now) * (0.005)))
                    ElseIf (reader(3) <= DateAndTime.Today.AddMonths(-1)) Then
                        alqpas = (reader(7)) + (reader(7) * (DateDiff(DateInterval.Day, DateSerial(Year(Now), 0, 1), DateAndTime.Now) * (0.005)))
                    Else
                        alqpas = 0
                    End If

                    Total = Total + alqpas
                End If
                If (reader(0) <= DateAndTime.Today) And (DateAndTime.Today < reader(1)) Then
                    AlquilerLabel.Text = (reader(4))
                    If (DateDiff(DateInterval.Day, DateSerial(Year(Now), Month(Now), 10), DateAndTime.Now) > 0) Then
                        Mora.Text = (reader(4) * (DateDiff(DateInterval.Day, DateSerial(Year(Now), Month(Now), 1), DateAndTime.Now) * (0.005)))
                    Else
                        Mora.Text = 0
                    End If
                ElseIf (reader(1) <= DateAndTime.Today) And (DateAndTime.Today < reader(2)) Then
                    AlquilerLabel.Text = (reader(5))
                    If (DateDiff(DateInterval.Day, DateSerial(Year(Now), Month(Now), 10), DateAndTime.Now) > 0) Then
                        Mora.Text = (reader(5) * (DateDiff(DateInterval.Day, DateSerial(Year(Now), Month(Now), 1), DateAndTime.Now) * (0.005)))
                    Else
                        Mora.Text = 0
                    End If
                ElseIf (reader(2) <= DateAndTime.Today) And (DateAndTime.Today < reader(3)) Then
                    AlquilerLabel.Text = (reader(6))

                    If (DateDiff(DateInterval.Day, DateSerial(Year(Now), Month(Now), 10), DateAndTime.Now) > 0) Then
                        Mora.Text = ((reader(6) * (DateDiff(DateInterval.Day, DateSerial(Year(Now), Month(Now), 1), DateAndTime.Today) * (0.005))))
                    Else
                        Mora.Text = 0
                    End If
                Else

                    AlquilerLabel.Text = (reader(7))
                    If (DateDiff(DateInterval.Day, DateSerial(Year(Now), Month(Now), 10), DateAndTime.Now) > 0) Then
                        Mora.Text = ((reader(7) * (DateDiff(DateInterval.Day, DateSerial(Year(Now), Month(Now), 1), DateAndTime.Now) * (0.005))))
                    Else
                        Mora.Text = 0
                    End If
                End If
                Total = Total + AlquilerLabel.Text + Mora.Text

            Else
                AlquilerLabel.Text = 0
                Mora.Text = 0
            End If
        End If


        reader.Close()
        con.Close()
        deuSQL = "SELECT DeudaAnterior From Pagos Where DNI = '" + Me.DNILabel.Text + "' AND Direccion= '" + Me.DireccionCombo.Text + "'  Order By idPagos DESC; "
        Dim deucmd As New SqlCommand(deuSQL, con)
        con.Open()
        reader = deucmd.ExecuteReader
        If (reader.Read()) Then
            With DeudaLabel
                .Text = reader(0)
            End With
        Else
            DeudaLabel.Text = 0
        End If
        reader.Close()
        con.Close()
        Total = DeudaLabel.Text + Total
        TotalLabel.Text = Total

        locSQL = "SELECT Clientes.Apellido, Clientes.Nombre From Clientes INNER JOIN Inmuebles ON Clientes.DNI=Inmuebles.dniLocador Where Direccion= '" + Me.DireccionCombo.Text + "'; "
        Dim loccmd As New SqlCommand(locSQL, con)
        con.Open()
        reader = loccmd.ExecuteReader
        If (reader.Read()) Then
            With locaLabel
                .Text = String.Concat(reader(0), ", ", reader(1))
            End With
        End If
        reader.Close()
        con.Close()

        Dim AguaData As String
        AguaData = "Select Gasto, FinPeriodo as Mes From Agua Where Direccion = '" + Me.DireccionCombo.Text + "' AND (Pagado=0)"
        con.ConnectionString = "Data Source=(local);Initial Catalog=Inquilinos;Integrated Security=True"
        Dim dbadpA As New SqlDataAdapter(AguaData, con)
        Dim dTable2 As New DataTable
        dbadpA.Fill(dTable2)
        AguaDataGrid.DataSource = dTable2

        Dim LuzData As String
        LuzData = "Select Gasto, FinPeriodo as Mes From Luz Where Direccion = '" + Me.DireccionCombo.Text + "' AND (Pagado=0)"
        con.ConnectionString = "Data Source=(local);Initial Catalog=Inquilinos;Integrated Security=True"
        Dim dbadpL As New SqlDataAdapter(LuzData, con)
        Dim dTable3 As New DataTable
        dbadpL.Fill(dTable3)
        LuzDataGrid.DataSource = dTable3

        Dim GasData As String
        GasData = "Select Gasto, FinPeriodo as Mes From Gas Where Direccion = '" + Me.DireccionCombo.Text + "' AND (Pagado=0)"
        con.ConnectionString = "Data Source=(local);Initial Catalog=Inquilinos;Integrated Security=True"
        Dim dbadpG As New SqlDataAdapter(GasData, con)
        Dim dTable4 As New DataTable
        dbadpG.Fill(dTable4)
        GasDataGrid.DataSource = dTable4

        Dim MuniData As String
        MuniData = "Select Gasto, FinPeriodo as Mes From Muni Where Direccion = '" + Me.DireccionCombo.Text + "' AND (Pagado=0)"
        con.ConnectionString = "Data Source=(local);Initial Catalog=Inquilinos;Integrated Security=True"
        Dim dbadpM As New SqlDataAdapter(MuniData, con)
        Dim dTable5 As New DataTable
        dbadpM.Fill(dTable5)
        MuniDataGrid.DataSource = dTable5

        Dim DGRData As String
        DGRData = "Select Gasto, FinPeriodo as Mes From DGR Where Direccion = '" + Me.DireccionCombo.Text + "' AND (Pagado=0)"
        con.ConnectionString = "Data Source=(local);Initial Catalog=Inquilinos;Integrated Security=True"
        Dim dbadpD As New SqlDataAdapter(DGRData, con)
        Dim dTable6 As New DataTable
        dbadpD.Fill(dTable6)
        DGRDataGrid.DataSource = dTable6

        Dim OtrosData As String
        OtrosData = "Select Detalle, Gasto, FinPeriodo as Mes From Otros Where Direccion = '" + Me.DireccionCombo.Text + "' AND (Pagado=0)"
        con.ConnectionString = "Data Source=(local);Initial Catalog=Inquilinos;Integrated Security=True"
        Dim dbadpO As New SqlDataAdapter(OtrosData, con)
        Dim dTable7 As New DataTable
        dbadpO.Fill(dTable7)
        OtrosDataGrid.DataSource = dTable7
    End Sub

    Private Sub PagoTextBox_TextChanged(sender As Object, e As EventArgs) Handles PagoTextBox.TextChanged
        Dim objQRCode As QRCodeEncoder = New QRCodeEncoder()
        Dim imgImage As Image
        Dim objBitmap As Bitmap

        objQRCode.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE
        objQRCode.QRCodeScale = 2
        objQRCode.QRCodeVersion = 5
        objQRCode.QRCodeErrorCorrect = ThoughtWorks.QRCode.Codec.QRCodeEncoder.ERROR_CORRECTION.L
        imgImage = objQRCode.Encode(ApellidoCombo.SelectedItem(0) + ", " + ApellidoCombo.SelectedItem(1) + "," + DireccionCombo.SelectedItem(0) + "," + PagoTextBox.Text + ",Total" + TotalLabel.Text + ",Fecha" + Fechalabel.Text)
        objBitmap = New Bitmap(imgImage)
        objBitmap.Save("QRCode.jpg")

        PictureBox1.ImageLocation = "QRCode.jpg"

    End Sub


    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim deu, loc As Double
        Dim ISQL, Fecha As String
        Double.TryParse(PagoTextBox.Text, deu)
        Double.TryParse(DNILabel.Text, DNI)
        Double.TryParse(AguaLabel.Text, Agua)
        Double.TryParse(LuzLabel.Text, Luz)
        Double.TryParse(GasLabel.Text, Gas)
        Double.TryParse(DGRLabel.Text, DGR)
        Double.TryParse(OtrosLabel.Text, Otros)
        Double.TryParse(MuniLabel.Text, Muni)
        Double.TryParse(TotalLabel.Text, Total)
        loc = Total - deu
        Fecha = DateAndTime.Year(Now).ToString + "-" + DateAndTime.Month(Now).ToString + "-" + DateAndTime.Day(Now).ToString
        Try
            con.ConnectionString = "Data Source=(local);Initial Catalog=Inquilinos;Integrated Security=True"
            con.Open()
            cmd.Connection = con

            ISQL = "insert into Pagos (DNI, FechaPago, Importe, DeudaAnterior ,Direccion , Pago, Alquiler, Agua, Luz, Gas, DGR, Muni, Otros, Locador, Pagado, Mora)  Values ('" & DNILabel.Text & "','" & DateAndTime.Today & "','" & TotalLabel.Text & "','" & loc & "','" + Me.DireccionCombo.SelectedItem(0) + "','" & Me.PagoTextBox.Text & "','" & Me.AlquilerLabel.Text & "','" & Agua & "','" & Luz & "','" & Gas & "','" & DGR & "','" & Muni & "','" & Otros & "','" + Me.locaLabel.Text + "',1, '" & Mora.Text & "');"
            If AguaLabel.Text > 0 And AguaCheck.Checked = True Then
                ISQL = String.Concat(ISQL, "UPDATE Agua SET Pagado = 1 WHERE Direccion='" + Me.DireccionCombo.Text + "' And Pagado = 0; ")
            End If
            If LuzLabel.Text > 0 And LuzCheck.Checked = True Then
                ISQL = String.Concat(ISQL, "UPDATE Luz SET Pagado = 1 WHERE Direccion='" + Me.DireccionCombo.Text + "' And Pagado = 0; ")
            End If
            If GasLabel.Text > 0 And GasCheck.Checked = True Then
                ISQL = String.Concat(ISQL, "UPDATE Gas SET Pagado = 1 WHERE Direccion='" + Me.DireccionCombo.Text + "' And Pagado = 0; ")
            End If
            If DGRLabel.Text > 0 And DGRCheck.Checked = True Then
                ISQL = String.Concat(ISQL, "UPDATE DGR SET Pagado = 1 WHERE Direccion='" + Me.DireccionCombo.Text + "' And Pagado = 0; ")
            End If
            If MuniLabel.Text > 0 And MuniCheck.Checked = True Then
                ISQL = String.Concat(ISQL, "UPDATE Muni SET Pagado = 1 WHERE Direccion='" + Me.DireccionCombo.Text + "' And Pagado = 0; ")
            End If
            If OtrosLabel.Text > 0 And OtrosCheck.Checked = True Then
                ISQL = String.Concat(ISQL, "UPDATE Otros SET Pagado = 1 WHERE Direccion='" + Me.DireccionCombo.Text + "' And Pagado = 0; ")
            End If
            ISQL = String.Concat(ISQL, "Update Contratos Set FUP='" + Fecha + "' Where DNI='" + Me.DNILabel.Text + "' AND Direccion='" + Me.DireccionCombo.Text + "';")
            cmd.CommandText = ISQL
            cmd.ExecuteNonQuery()
            MessageBox.Show("Pago Cargado")
            Me.Refresh()
        Catch ex As Exception
            MessageBox.Show("Error" & ex.Message, "Insert Records")
        End Try

        Dim height As Integer = Me.Height
        Me.Height = Me.Height

        'Create a Bitmap and draw the DataGridView on it.
        bitmap = New Bitmap(Me.Width, Me.Height)
        Me.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.Width, Me.Height))

        'Resize DataGridView back to original height.
        Me.Height = height

        'Show the Print Preview Dialog.
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.ShowDialog()
        PrintDocument1.PrinterSettings.Copies = 2
    End Sub
    Private bitmap As Bitmap

    Private Sub PrintPage(sender As Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Print the contents.
        e.Graphics.DrawImage(Bitmap, 0, 0)
    End Sub
    Private Sub AguaCheck_CheckedChanged(sender As Object, e As EventArgs) Handles AguaCheck.CheckedChanged
        DireccionCombo_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub LuzCheck_CheckedChanged(sender As Object, e As EventArgs) Handles LuzCheck.CheckedChanged
        DireccionCombo_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub OtrosCheck_CheckedChanged(sender As Object, e As EventArgs) Handles OtrosCheck.CheckedChanged
        DireccionCombo_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub DGRCheck_CheckedChanged(sender As Object, e As EventArgs) Handles DGRCheck.CheckedChanged


        DireccionCombo_SelectedIndexChanged(sender, e)

    End Sub

    Private Sub MuniCheck_CheckedChanged(sender As Object, e As EventArgs) Handles MuniCheck.CheckedChanged
        DireccionCombo_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub GasCheck_CheckedChanged(sender As Object, e As EventArgs) Handles GasCheck.CheckedChanged
        DireccionCombo_SelectedIndexChanged(sender, e)
    End Sub

End Class