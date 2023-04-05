Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clear()
    End Sub
    Private Sub clear()
        cbKaraoke.Text = "Select Service"
        txtHours.Text = ""
        lbCost.Text = ""
        lbHour.Visible = False
        lbCost.Visible = False
        txtHours.Visible = False
        btnClear.Visible = False
        btnTotal.Visible = False
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private song As Decimal = 2.99D
    Private hourly As Decimal = 8.99D
    Private Function ValidateInput() As Boolean
        Dim intNumber As Integer
        Dim blnValid As Boolean = False
        Try
            intNumber = Convert.ToInt32(txtHours.Text)
            If intNumber > 0D Then
                blnValid = True
                Return blnValid
            Else
                MsgBox("Please enter a number greater than 0", , "Error")
            End If
        Catch Exception As FormatException
            MsgBox("Please enter a valid amount", , "Error")
        Catch Exception As OverflowException
            MsgBox("Please enter a reasonable amount", , "Error")
        Catch Exception As SystemException
            MsgBox("Entry invalid. Please enter a valid number representing the number in your party", , "Error")
        End Try

        txtHours.Focus()
        txtHours.Clear()
        Return blnValid
    End Function

    Private Function SongCost(ByVal intPass As Integer) As Decimal
        Dim passCost As Decimal
        passCost = intPass * song
        Return passCost
    End Function

    Private Function RoomCost(ByVal intPass As Integer) As Decimal
        Dim ticketCost As Decimal
        ticketCost = intPass * hourly
        Return ticketCost
    End Function

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Dim isValid As Boolean = False
        Dim intValue As Integer
        Dim total As Decimal

        isValid = ValidateInput()
        If isValid = True Then
            intValue = Convert.ToInt32(txtHours.Text)
            If cbKaraoke.SelectedIndex = 0 Then
                total = SongCost(intValue)
            Else
                total = RoomCost(intValue)
            End If
            lbCost.Visible = True
            lbCost.Text = "Total Cost of Karaoke Night - " & total.ToString("C")
        End If
    End Sub

    Private Sub cbKaraoke_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbKaraoke.SelectedIndexChanged
        If cbKaraoke.SelectedIndex = 0 Then
            lbHour.Text = "Number of Karaoke Songs"
            lbHour.Visible = True
            txtHours.Visible = True
            btnClear.Visible = True
            btnTotal.Visible = True
            txtHours.Focus()
        End If
        If cbKaraoke.SelectedIndex = 1 Then
            lbHour.Text = "Hourly Rental of Karaoke Room:"
            lbHour.Visible = True
            txtHours.Visible = True
            btnClear.Visible = True
            btnTotal.Visible = True
            txtHours.Focus()
        End If
    End Sub
End Class
