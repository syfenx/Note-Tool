Public Class Form1
    Dim issues As String()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim lines() As String = IO.File.ReadAllLines("internet.txt")
        lstInternet.Items.AddRange(lines)

        lines = IO.File.ReadAllLines("cable.txt")
        lstCable.Items.AddRange(lines)

        lines = IO.File.ReadAllLines("account.txt")
        lstAccount.Items.AddRange(lines)

        lines = IO.File.ReadAllLines("resolutions.txt")
        lstResolutions.Items.AddRange(lines)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        updatetext()
    End Sub

    Public Sub updatetext()
        Dim issues, resolutions As String
        txtNotes.Text = ""
        issues = ""
        resolutions = ""
        For Each item As String In lstInternet.SelectedItems
            issues += item.ToString() + " "
        Next

        For Each item As String In lstAccount.SelectedItems
            issues += item.ToString() + " "
        Next

        For Each item As String In lstCable.SelectedItems
            issues += item.ToString() + " "
        Next

        For Each item As String In lstResolutions.SelectedItems
            resolutions += item.ToString() + " "
        Next

        txtNotes.Text += "Caller's Name: " + txtName.Text + vbNewLine

        If (txtAccountNumber.TextLength > 0) Then
            txtNotes.Text += "Account #: " + txtAccountNumber.Text + vbNewLine
        End If

        txtNotes.Text += "Callback Number: " + txtNumber.Text + vbNewLine

        If (txtTicket.TextLength > 0) Then
            txtNotes.Text += "Ticket #:" + txtTicket.Text + vbNewLine
        End If
        If (txtExtra.TextLength > 0) Then
            txtNotes.Text += txtExtra.Text + vbNewLine
        End If

        txtNotes.Text += vbNewLine
        txtNotes.Text += "Issues: " + vbNewLine + issues + vbNewLine + vbNewLine
        txtNotes.Text += "Resolution: " + vbNewLine + resolutions + vbNewLine

    End Sub

    Private Sub lstIssues_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstIssues.SelectedIndexChanged
        updatetext()
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        updatetext()
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged
        updatetext()
    End Sub

    Private Sub txtTicket_TextChanged(sender As Object, e As EventArgs) Handles txtTicket.TextChanged
        updatetext()
    End Sub

    Private Sub lstResolutions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstResolutions22.SelectedIndexChanged
        updatetext()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim ans As String
        ans = MsgBox("Reset?", vbYesNo)
        If ans = vbYes Then
            lstIssues.ClearSelected()
            lstResolutions.ClearSelected()

            For Each checkedItemIndex As Integer In lstIssues.CheckedIndices
                lstIssues.SetItemChecked(checkedItemIndex, False)
            Next


            txtName.Clear()
            txtNumber.Clear()
            txtAccountNumber.Clear()
            txtTicket.Clear()
            txtNotes.Clear()
            txtExtra.Clear()

            lstInternet.ClearSelected()
            lstAccount.ClearSelected()
            lstCable.ClearSelected()
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtNotes.Text.Length > 0 Then
            Clipboard.SetText(txtNotes.Text)
        End If
    End Sub

    Private Sub txtNotes_TextChanged(sender As Object, e As EventArgs) Handles txtNotes.TextChanged

    End Sub

    Private Sub txtExtra_TextChanged(sender As Object, e As EventArgs) Handles txtExtra.TextChanged
        updatetext()
    End Sub

    Private Sub lstIssues_DrawItem(sender As Object, e As DrawItemEventArgs) Handles lstIssues.DrawItem

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstInternet.SelectedIndexChanged
        updatetext()

    End Sub

    Private Sub ListBox1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles lstInternet.DrawItem
        e.DrawBackground()

        If lstInternet.Items(e.Index).ToString() = "no issues" Then

            e.Graphics.FillRectangle(Brushes.LightGreen, e.Bounds)
        End If
        e.Graphics.DrawString(lstInternet.Items(e.Index).ToString(), e.Font, Brushes.Black, New System.Drawing.PointF(e.Bounds.X, e.Bounds.Y))
        e.DrawFocusRectangle()
    End Sub

    Private Sub TxtAccountNumber_TextChanged(sender As Object, e As EventArgs) Handles txtAccountNumber.TextChanged
        updatetext()
    End Sub

    Private Sub LstAccount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAccount.SelectedIndexChanged
        updatetext()

    End Sub

    Private Sub LstCable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCable.SelectedIndexChanged
        updatetext()

    End Sub

    Private Sub LstResolutions_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lstResolutions.SelectedIndexChanged
        updatetext()
    End Sub

    Private Sub lstInternet_DoubleClick(sender As Object, e As EventArgs) Handles lstInternet.DoubleClick

    End Sub
End Class
