Public Class frmMain
    ' Tells the program if a scan is running
    Private bln_ScanIsRunning As Boolean = False
    ' Threads
    Private thread_Engine As New Threading.Thread(AddressOf StartScanEngine)
    ' Scanner Engine
    Private WithEvents Engine As New ScanEngine
    ' Delegates
    Private Delegate Sub engineInvoked_OnDeviceScanned(ByVal Printer_Structure As Printers.PrinterStructure)
    Private Delegate Sub engineInvoked_OnComplete()
    Private Delegate Sub engineInvoked_OnError(ByVal message As String)
    Private Delegate Sub engineInvoked_OnMessage(ByVal message As String)

#Region "Tool Strip Buttons"
    Private Sub ts_NewScan_Click(sender As System.Object, e As System.EventArgs) Handles ts_NewScan.Click
        Dim frmNewScan As New frmNewScan

        If frmNewScan.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            ' Clear Results
            lst_Printers.Items.Clear()

            ' Progress Bar
            ts_Progress.Maximum = col_IPAddresses.Count
            ts_Progress.Value = 0

            ' Start Scan
            Engine.bln_AbortScan = False
            bln_ScanIsRunning = True
            ts_StopScan.Enabled = True
            thread_Engine = New Threading.Thread(AddressOf StartScanEngine)
            thread_Engine.Start()
        End If
    End Sub
#End Region

#Region "Menu Items"
    Private Sub mnu_Exit_Click(sender As System.Object, e As System.EventArgs) Handles mnu_Exit.Click
        End
    End Sub
#End Region

    Private Sub mnu_NewScan_Click(sender As System.Object, e As System.EventArgs) Handles mnu_NewScan.Click
        ts_NewScan_Click(Me, New System.EventArgs)
    End Sub

    Private Sub StartScanEngine()
        Engine.StartEngine()
    End Sub

    Private Sub OnDeviceScanned(ByVal Printer_Structure As Printers.PrinterStructure) Handles Engine.DeviceScanned
        If Me.InvokeRequired Then
            Dim parameter As Object
            parameter = Printer_Structure

            ' Run Delegate
            Dim run_delegate As New engineInvoked_OnDeviceScanned(AddressOf OnDeviceScanned)
            Me.Invoke(run_delegate, parameter)
        Else
            Dim PrinterStructure As New Printers.PrinterStructure
            Dim lst_ListItem As New ListViewItem

            PrinterStructure = Printer_Structure

            If PrinterStructure.information_is_printer Then
                ' General
                lst_ListItem.Text = PrinterStructure.information_ip_address.ToString

                lst_ListItem.SubItems.Add(PrinterStructure.general_manufacture)
                lst_ListItem.SubItems.Add(PrinterStructure.general_model)
                lst_ListItem.SubItems.Add(PrinterStructure.general_serial)
                'chkColor.Checked = PrinterStructure.general_color

                ' Counters
                lst_ListItem.SubItems.Add(PrinterStructure.counter_total)
                lst_ListItem.SubItems.Add(PrinterStructure.counter_mono_total)
                If PrinterStructure.general_color Then
                    lst_ListItem.SubItems.Add(PrinterStructure.counter_color_total)
                Else
                    lst_ListItem.SubItems.Add("")
                End If
                'Supplies

                ' Black
                If PrinterStructure.supplies_black.Percentage <> "" Then
                    lst_ListItem.SubItems.Add(PrinterStructure.supplies_black.Percentage & "%")
                Else
                    lst_ListItem.SubItems.Add("")
                End If
                ' Cyan
                If PrinterStructure.supplies_cyan.Percentage <> "" Then
                    lst_ListItem.SubItems.Add(PrinterStructure.supplies_cyan.Percentage & "%")
                Else
                    lst_ListItem.SubItems.Add("")
                End If
                ' Magenta
                If PrinterStructure.supplies_magenta.Percentage <> "" Then
                    lst_ListItem.SubItems.Add(PrinterStructure.supplies_magenta.Percentage & "%")
                Else
                    lst_ListItem.SubItems.Add("")
                End If
                'Yellow
                If PrinterStructure.supplies_yellow.Percentage <> "" Then
                    lst_ListItem.SubItems.Add(PrinterStructure.supplies_yellow.Percentage & "%")
                Else
                    lst_ListItem.SubItems.Add("")
                End If

                lst_ListItem.SubItems.Add((PrinterStructure.debug_time_start - PrinterStructure.debug_time_stop).Milliseconds)

                ' Add
                lst_Printers.Items.Add(lst_ListItem)
            End If

            ts_Progress.Value = ts_Progress.Value + 1

        End If
    End Sub

    Private Sub OnMessage(ByVal Message As String) Handles Engine.OnMessage

        If Me.InvokeRequired Then
            Dim parameter As New Object
            parameter = Message

            ' Run Delegate
            Dim run_delegate As New engineInvoked_OnMessage(AddressOf OnMessage)
            Me.Invoke(run_delegate, parameter)
        Else
            ts_Status.Text = Message
        End If
    End Sub

    Private Sub OnComplete() Handles Engine.Complete

        If Me.InvokeRequired Then

            ' Run Delegate
            Dim run_delegate As New engineInvoked_OnComplete(AddressOf OnComplete)
            Me.Invoke(run_delegate)
        Else
            ts_Status.Text = "Scan Complete! Found " & lst_Printers.Items.Count & " Device(s)"
            ts_Progress.Value = 0
            bln_ScanIsRunning = False
            ts_StopScan.Enabled = False
        End If
    End Sub

    Private Sub ts_StopScan_Click(sender As System.Object, e As System.EventArgs) Handles ts_StopScan.Click
        ' Ensure we have a scan running
        If bln_ScanIsRunning = False Then
            Exit Sub
        End If

        Engine.bln_AbortScan = True
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If bln_ScanIsRunning Then
            Engine.bln_AbortScan = True
        End If
    End Sub

    Private Sub cmnu_PrinterList_OpenDevicePage_Click(sender As System.Object, e As System.EventArgs) Handles cmnu_PrinterList_OpenDevicePage.Click
        If lst_Printers.SelectedItems.Count >= 1 Then
            Process.Start("http://" & lst_Printers.SelectedItems.Item(0).Text)
        End If
    End Sub

    Private Sub mnu_SaveScan_Click(sender As System.Object, e As System.EventArgs) Handles mnu_SaveScan.Click
        If lst_Printers.Items.Count <= 0 Then
            MessageBox.Show("Cannot save an empty scan", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.AddExtension = True
        saveFileDialog.DefaultExt = ".csv"
        saveFileDialog.Filter = "Comma-separated Values (CSV)|*.csv"
        saveFileDialog.OverwritePrompt = True
        saveFileDialog.Title = "Save Device Scan"

        If saveFileDialog.ShowDialog(Me) = DialogResult.OK Then
            ' Save File
            Dim objWriter As New System.IO.StreamWriter(saveFileDialog.FileName)

            ' CSV Content
            Dim sContent As String = ""

            ' Write headers
            objWriter.WriteLine("IP Address, Manufacture, Model, Serial Number, Counter Mono, Counter Color, Counter Total, Supplies Black, Supplies Cyan, Supplies Magenta, Supplies Yellow" & vbNewLine)

            ' Loop through list to save items
            Dim lItem As ListViewItem
            Dim sItem As ListViewItem.ListViewSubItem

            For Each lItem In lst_Printers.Items
                sContent = ""
                For Each sItem In lItem.SubItems
                    ' Save each column
                    sContent = sContent & sItem.Text & ","
                Next
                objWriter.WriteLine(sContent)
            Next

            objWriter.WriteLine("")
            objWriter.WriteLine("")
            objWriter.WriteLine(Application.ProductName & " - " & Application.ProductVersion.ToString)
            objWriter.Close()

            MessageBox.Show("The device scan has been saved", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmenu_ExportIpList_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSaveResults_Click(sender As Object, e As EventArgs) Handles btnSaveResults.Click
        mnu_SaveScan.PerformClick()
    End Sub

    Private Sub ExportIPListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportIPListToolStripMenuItem.Click
        If lst_Printers.Items.Count <= 0 Then
            MessageBox.Show("Cannot save an empty scan", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.AddExtension = True
        saveFileDialog.DefaultExt = ".txt"
        saveFileDialog.Filter = "Text File|*.txt"
        saveFileDialog.OverwritePrompt = True
        saveFileDialog.Title = "Save IP Report"

        If saveFileDialog.ShowDialog(Me) = DialogResult.OK Then
            ' Save File
            Dim objWriter As New System.IO.StreamWriter(saveFileDialog.FileName)

            ' CSV Content
            Dim sContent As String = ""

            ' Write headers
            objWriter.WriteLine("IP Address" & vbNewLine)

            ' Loop through list to save items
            Dim lItem As ListViewItem

            For Each lItem In lst_Printers.Items
                sContent = lItem.Text
                objWriter.WriteLine(sContent)
            Next

            objWriter.WriteLine("")
            objWriter.WriteLine("")
            objWriter.WriteLine(Application.ProductName & " - " & Application.ProductVersion.ToString)
            objWriter.Close()

            MessageBox.Show("The device scan has been saved", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
