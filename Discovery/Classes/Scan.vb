Public Class Scan
    Public printer As Printers.PrinterStructure

    Private Scanner As Printers.Scan

    Public Event DeviceScannedSuccess()
    Public Event DeviceScannedError()


    Public Sub ScanPrinter(ByVal IP_Address As Net.IPAddress, ByVal SnmpPassword As String, ByVal SnmpTimeout As Integer, ByVal UsePing As Boolean)

        Scanner = New Printers.Scan(IP_Address, SnmpPassword, SnmpTimeout)

        ' Scan
        printer = Scanner.collect()

        If printer.information_is_printer Then
            ' Raise Event
            RaiseEvent DeviceScannedSuccess()
        Else
            RaiseEvent DeviceScannedError()
        End If

    End Sub
End Class
