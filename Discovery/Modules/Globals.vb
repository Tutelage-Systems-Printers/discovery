Public Module Globals
    Public Structure MIB_Definition
        Public Property oid As String
        Public Property value As String
    End Structure

    Public Structure Device_Definition
        Public Property General_Manufacture As String
        Public Property General_Model As String
        Public Property General_Serial_Number As String
        Public Property General_Public_IP_Address As String
        Public Property General_Is_Color As String
        Public Property Counter_Mono_Total As String
        Public Property Counter_Color_Total As String
        Public Property Counter_Total As String
        Public Property Supplies_Black_Level As String
        Public Property Supplies_Black_Cartridge As String
        Public Property Supplies_Magenta_Level As String
        Public Property Supplies_Magenta_Cartridge As String
        Public Property Supplies_Cyan_Level As String
        Public Property Supplies_Cyan_Cartridge As String
        Public Property Supplies_Yellow_Level As String
        Public Property Supplies_Yellow_Cartridge As String
    End Structure

    Public Structure Scan_IpAddress
        Public Property IPAddress As String
        Public Property SnmpPassword As String
        Public Property Timeout As Integer
        Public Property thread_InProgress As Boolean
        Public Property thread_Index As Integer
    End Structure

    ' Holds the results from the scan
    Public col_MibResults As New Collection

    ' Holds the time out from the main page
    Public int_Timeout As Integer

    ' IP Addresses (to Scan)
    Public col_IPAddresses As New Collection
End Module
