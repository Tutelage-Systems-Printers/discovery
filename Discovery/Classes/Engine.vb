Public Class ScanEngine

    ' Threading
    Private thread_Lock As New Object

    ' Printer Structure
    Private printer As New Printers.PrinterStructure

    ' Events
    Public Event DeviceScanned(ByVal Printer_Structure As Printers.PrinterStructure)
    Public Event Complete()
    Public Event OnError(ByVal Message As String)
    Public Event OnMessage(ByVal Message As String)

    ' Variables
    Public Device_IP_Address As String
    Public Device_SNMP_Password As String
    Public bln_AbortScan As Boolean = False

    ' Real Scan Engine
    Dim Scanner As Printers.Scan


    Public Sub StartEngine()
        RaiseEvent OnMessage("Starting Scan ...")

        Try
            For Each ip_address As Scan_IpAddress In col_IPAddresses
                Dim w As Threading.WaitCallback = New Threading.WaitCallback(AddressOf CreateEngine)

                ' Thread Information
                Threading.ThreadPool.QueueUserWorkItem(w, ip_address)
            Next

        Catch ex As Exception
            RaiseEvent OnError(ex.ToString)
        End Try

        ' Show Message that we are scanning
        RaiseEvent OnMessage("Scanning for Printers ...")
    End Sub

    Private Sub CreateEngine(ByVal ip_address As Scan_IpAddress)

        If bln_AbortScan = True Then
            ' End the scan
            RaiseEvent Complete()

            Exit Sub
        End If

        ' Lock Thread
        Threading.Monitor.Enter(thread_Lock)

        ' Scan Engine
        Scanner = New Printers.Scan(Net.IPAddress.Parse(ip_address.IPAddress), ip_address.SnmpPassword, ip_address.Timeout)

        RaiseEvent OnMessage("Scanning IP: " & ip_address.IPAddress)

        ' Scan
        printer = Scanner.collect()

        ' Raise the Scanned Event no matter what
        RaiseEvent DeviceScanned(printer)

        If col_IPAddresses.Contains(ip_address.IPAddress) Then
            col_IPAddresses.Remove(ip_address.IPAddress)
        End If

        If col_IPAddresses.Count = 0 Then
            RaiseEvent Complete()
        End If

        ' Release Thread
        Threading.Monitor.Exit(thread_Lock)
    End Sub

End Class
