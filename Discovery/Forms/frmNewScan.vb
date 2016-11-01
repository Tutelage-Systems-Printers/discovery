Public Class frmNewScan

#Region "Form Buttons"
    Private Sub cmd_Cancel_Click(sender As System.Object, e As System.EventArgs) Handles cmd_Cancel.Click
        Me.Close()
    End Sub
#End Region

#Region "Buttons"
    Private Sub cmd_Add_Click(sender As System.Object, e As System.EventArgs) Handles cmd_Add.Click

        ' Check to see if last octet is empty, if so add from the start
        If txt_StopOctet4.Text.Length <= 0 Then
            txt_StopOctet4.Text = txt_StartOctet4.Text
        End If

        ' Generate the IP Addresses
        Try
            ' 192.168.1.
            Dim startIPAddress As String = txt_StartOctet1.Text & "." & txt_StartOctet2.Text & "." & txt_StartOctet3.Text & "."
            Dim startIPOctet = 0
            Dim stopIPOctet = 0

            ' Assign Start IP Octet
            Integer.TryParse(txt_StartOctet4.Text, startIPOctet)
            ' Assign Stop IP Octet
            Integer.TryParse(txt_StopOctet4.Text, stopIPOctet)

            For idx As Integer = startIPOctet To stopIPOctet
                ' Add to Range List
                Dim lst_Item As New ListViewItem
                lst_Item.Text = startIPAddress & idx
                lst_Item.SubItems.Add(txt_SNMPPassword.Text)
                lst_Item.SubItems.Add(Integer.Parse(txt_Timeout.Text))

                ' Add Item
                lst_ScanRange.Items.Add(lst_Item)
            Next
        Catch ex As Exception
        End Try

        ' Reset
        ResetRange()

        ts_Status.Text = "IP Addresses to scan: " & lst_ScanRange.Items.Count()
    End Sub

    Private Sub ResetRange()
        txt_StartOctet1.Text = ""
        txt_StartOctet2.Text = ""
        txt_StartOctet3.Text = ""
        txt_StartOctet4.Text = ""
        txt_StopOctet1.Text = ""
        txt_StopOctet2.Text = ""
        txt_StopOctet3.Text = ""
        txt_StopOctet4.Text = ""

        txt_SNMPPassword.Text = "public"
        txt_Timeout.Text = "25"

        ' Focus
        txt_StartOctet1.Focus()
    End Sub
#End Region


    Private Sub cmd_StartScan_Click(sender As System.Object, e As System.EventArgs) Handles cmd_StartScan.Click
        If lst_ScanRange.Items.Count <= 0 Then
            MessageBox.Show("No IP Ranges were found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Me.Update()

        col_IPAddresses = New Collection

        For Each lst_Item As ListViewItem In lst_ScanRange.Items
            Dim IpAddress As New Scan_IpAddress

            ' Add IP Address
            IpAddress.IPAddress = lst_Item.Text
            IpAddress.SnmpPassword = lst_Item.SubItems.Item(1).Text
            IpAddress.Timeout = lst_Item.SubItems.Item(2).Text

            ' Add into Listing
            If col_IPAddresses.Contains(IpAddress.IPAddress) = False Then
                col_IPAddresses.Add(IpAddress, IpAddress.IPAddress)
            End If
        Next

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnAddSingleIp_Click(sender As Object, e As EventArgs) Handles btnAddSingleIp.Click
        ' Add to Range List
        Dim lst_Item As New ListViewItem
        lst_Item.Text = txtSingleIPAddress.Text
        lst_Item.SubItems.Add(txtSinglePassword.Text)
        lst_Item.SubItems.Add(Integer.Parse(txtSingleTimeout.Text))

        ' Add Item
        lst_ScanRange.Items.Add(lst_Item)

        ts_Status.Text = "IP Addresses to scan: " & lst_ScanRange.Items.Count()
    End Sub

    Private Sub btnAddBulk_Click(sender As Object, e As EventArgs) Handles btnAddBulk.Click
        Dim lines = txtBulkIPAddresses.Text
        Dim lineList As New List(Of String)

        lineList.AddRange(lines.Split(vbNewLine))

        For idx As Integer = 0 To lineList.Count - 1
            Try
                ' Add to Range List
                Dim ipAddress = Net.IPAddress.Parse(lineList.Item(idx).Trim()).ToString()
                Dim lst_Item As New ListViewItem

                lst_Item.Text = ipAddress
                lst_Item.SubItems.Add(txtBulkPassword.Text)
                lst_Item.SubItems.Add(Integer.Parse(txtBulkTimeout.Text))

                ' Add Item
                lst_ScanRange.Items.Add(lst_Item)
            Catch
            End Try
        Next

        ts_Status.Text = "IP Addresses to scan: " & lst_ScanRange.Items.Count()
    End Sub

    Private Sub mainTabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mainTabControl.SelectedIndexChanged
        Select Case mainTabControl.SelectedIndex
            Case 0
                txtSingleIPAddress.Focus()
            Case 1
                txt_StartOctet1.Focus()
            Case 2
                txtBulkIPAddresses.Focus()
        End Select
    End Sub

#Region "List Buttons"

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If lst_ScanRange.Items.Count <= 0 Then
            MessageBox.Show("Cannot save an empty list", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.AddExtension = True
        saveFileDialog.DefaultExt = ".iplist.txt"
        saveFileDialog.Filter = "IP Lists|*.iplist.txt"
        saveFileDialog.OverwritePrompt = True
        saveFileDialog.Title = "Save IP List"

        If saveFileDialog.ShowDialog(Me) = DialogResult.OK Then
            ' Save File
            Dim objWriter As New System.IO.StreamWriter(saveFileDialog.FileName)

            ' Loop through list to save items
            Dim lItem As ListViewItem
            For Each lItem In lst_ScanRange.Items
                objWriter.WriteLine(lItem.Text & ";" & lItem.SubItems.Item(1).Text & ";" & lItem.SubItems.Item(2).Text & ";" & lItem.SubItems.Item(3).Text)
            Next

            objWriter.Close()

            MessageBox.Show("The list has been saved", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.AddExtension = True
        openFileDialog.DefaultExt = ".iplist.txt"
        openFileDialog.Filter = "IP Lists|*.iplist.txt"
        openFileDialog.Title = "Open IP List"

        If openFileDialog.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            lst_ScanRange.Items.Clear()

            Dim objReader As New System.IO.StreamReader(openFileDialog.FileName)

            Dim s_lines As String = "x"
            Dim split_lines As String()

            While s_lines <> Nothing
                s_lines = objReader.ReadLine
                If s_lines <> Nothing Then
                    split_lines = s_lines.Split(";")
                    Dim lItem As New ListViewItem(split_lines(0))
                    lItem.SubItems.Add(split_lines(1))
                    lItem.SubItems.Add(split_lines(2))
                    lItem.SubItems.Add(split_lines(3))

                    lst_ScanRange.Items.Add(lItem)
                End If
            End While

            objReader.Close()
        End If

        ts_Status.Text = "IP Addresses to scan: " & lst_ScanRange.Items.Count()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lst_ScanRange.Items.Clear()

        ts_Status.Text = "IP Addresses to scan: " & lst_ScanRange.Items.Count()
    End Sub

    Private Sub cmd_Delete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        For Each lvItem As ListViewItem In lst_ScanRange.SelectedItems
            lvItem.Remove()
        Next

        ts_Status.Text = "IP Addresses to scan: " & lst_ScanRange.Items.Count()
    End Sub

#End Region

End Class