<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewScan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txt_Timeout = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_SNMPPassword = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmd_Add = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_StopOctet4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_StopOctet3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_StopOctet2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_StopOctet1 = New System.Windows.Forms.TextBox()
        Me.txt_StartOctet4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_StartOctet3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_StartOctet2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_StartOctet1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lst_ScanRange = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmd_Cancel = New System.Windows.Forms.Button()
        Me.cmd_StartScan = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ts_Status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mainTabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtSingleTimeout = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnAddSingleIp = New System.Windows.Forms.Button()
        Me.txtSinglePassword = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSingleIPAddress = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnAddBulk = New System.Windows.Forms.Button()
        Me.txtBulkTimeout = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtBulkPassword = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtBulkIPAddresses = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.mainTabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_Timeout
        '
        Me.txt_Timeout.Location = New System.Drawing.Point(232, 87)
        Me.txt_Timeout.Name = "txt_Timeout"
        Me.txt_Timeout.Size = New System.Drawing.Size(78, 21)
        Me.txt_Timeout.TabIndex = 19
        Me.txt_Timeout.Text = "25"
        Me.txt_Timeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 15)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Timeout (ms)"
        '
        'txt_SNMPPassword
        '
        Me.txt_SNMPPassword.Location = New System.Drawing.Point(134, 60)
        Me.txt_SNMPPassword.Name = "txt_SNMPPassword"
        Me.txt_SNMPPassword.Size = New System.Drawing.Size(176, 21)
        Me.txt_SNMPPassword.TabIndex = 17
        Me.txt_SNMPPassword.Text = "public"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 15)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "SNMP Password"
        '
        'cmd_Add
        '
        Me.cmd_Add.Location = New System.Drawing.Point(6, 114)
        Me.cmd_Add.Name = "cmd_Add"
        Me.cmd_Add.Size = New System.Drawing.Size(304, 67)
        Me.cmd_Add.TabIndex = 21
        Me.cmd_Add.Text = "&Add IP Range"
        Me.cmd_Add.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Stop IP Address"
        '
        'txt_StopOctet4
        '
        Me.txt_StopOctet4.Location = New System.Drawing.Point(282, 33)
        Me.txt_StopOctet4.MaxLength = 3
        Me.txt_StopOctet4.Name = "txt_StopOctet4"
        Me.txt_StopOctet4.Size = New System.Drawing.Size(28, 21)
        Me.txt_StopOctet4.TabIndex = 15
        Me.txt_StopOctet4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(266, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "-"
        '
        'txt_StopOctet3
        '
        Me.txt_StopOctet3.Enabled = False
        Me.txt_StopOctet3.Location = New System.Drawing.Point(232, 33)
        Me.txt_StopOctet3.MaxLength = 3
        Me.txt_StopOctet3.Name = "txt_StopOctet3"
        Me.txt_StopOctet3.Size = New System.Drawing.Size(28, 21)
        Me.txt_StopOctet3.TabIndex = 13
        Me.txt_StopOctet3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(218, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "-"
        '
        'txt_StopOctet2
        '
        Me.txt_StopOctet2.Enabled = False
        Me.txt_StopOctet2.Location = New System.Drawing.Point(182, 33)
        Me.txt_StopOctet2.MaxLength = 3
        Me.txt_StopOctet2.Name = "txt_StopOctet2"
        Me.txt_StopOctet2.Size = New System.Drawing.Size(28, 21)
        Me.txt_StopOctet2.TabIndex = 11
        Me.txt_StopOctet2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(166, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(11, 15)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "-"
        '
        'txt_StopOctet1
        '
        Me.txt_StopOctet1.Enabled = False
        Me.txt_StopOctet1.Location = New System.Drawing.Point(134, 33)
        Me.txt_StopOctet1.MaxLength = 3
        Me.txt_StopOctet1.Name = "txt_StopOctet1"
        Me.txt_StopOctet1.Size = New System.Drawing.Size(28, 21)
        Me.txt_StopOctet1.TabIndex = 9
        Me.txt_StopOctet1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_StartOctet4
        '
        Me.txt_StartOctet4.Location = New System.Drawing.Point(282, 6)
        Me.txt_StartOctet4.MaxLength = 3
        Me.txt_StartOctet4.Name = "txt_StartOctet4"
        Me.txt_StartOctet4.Size = New System.Drawing.Size(28, 21)
        Me.txt_StartOctet4.TabIndex = 7
        Me.txt_StartOctet4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(266, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "-"
        '
        'txt_StartOctet3
        '
        Me.txt_StartOctet3.Location = New System.Drawing.Point(232, 6)
        Me.txt_StartOctet3.MaxLength = 3
        Me.txt_StartOctet3.Name = "txt_StartOctet3"
        Me.txt_StartOctet3.Size = New System.Drawing.Size(28, 21)
        Me.txt_StartOctet3.TabIndex = 5
        Me.txt_StartOctet3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(216, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "-"
        '
        'txt_StartOctet2
        '
        Me.txt_StartOctet2.Location = New System.Drawing.Point(182, 6)
        Me.txt_StartOctet2.MaxLength = 3
        Me.txt_StartOctet2.Name = "txt_StartOctet2"
        Me.txt_StartOctet2.Size = New System.Drawing.Size(28, 21)
        Me.txt_StartOctet2.TabIndex = 3
        Me.txt_StartOctet2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(166, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Start IP Address"
        '
        'txt_StartOctet1
        '
        Me.txt_StartOctet1.Location = New System.Drawing.Point(134, 6)
        Me.txt_StartOctet1.MaxLength = 3
        Me.txt_StartOctet1.Name = "txt_StartOctet1"
        Me.txt_StartOctet1.Size = New System.Drawing.Size(28, 21)
        Me.txt_StartOctet1.TabIndex = 1
        Me.txt_StartOctet1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnLoad)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.btnClear)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.lst_ScanRange)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(342, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(320, 215)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Scan Range(s)"
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(82, 163)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(72, 42)
        Me.btnLoad.TabIndex = 4
        Me.btnLoad.Text = "L&oad"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(6, 163)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(72, 42)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Sa&ve"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(160, 163)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(72, 42)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(238, 163)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(72, 42)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lst_ScanRange
        '
        Me.lst_ScanRange.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lst_ScanRange.FullRowSelect = True
        Me.lst_ScanRange.GridLines = True
        Me.lst_ScanRange.Location = New System.Drawing.Point(6, 19)
        Me.lst_ScanRange.Name = "lst_ScanRange"
        Me.lst_ScanRange.Size = New System.Drawing.Size(304, 138)
        Me.lst_ScanRange.TabIndex = 0
        Me.lst_ScanRange.UseCompatibleStateImageBehavior = False
        Me.lst_ScanRange.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "IP Address"
        Me.ColumnHeader1.Width = 126
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Password"
        Me.ColumnHeader3.Width = 75
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Timeout"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 80
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_Cancel.Location = New System.Drawing.Point(348, 233)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(314, 87)
        Me.cmd_Cancel.TabIndex = 3
        Me.cmd_Cancel.Text = "&Cancel"
        Me.cmd_Cancel.UseVisualStyleBackColor = True
        '
        'cmd_StartScan
        '
        Me.cmd_StartScan.Location = New System.Drawing.Point(12, 233)
        Me.cmd_StartScan.Name = "cmd_StartScan"
        Me.cmd_StartScan.Size = New System.Drawing.Size(324, 87)
        Me.cmd_StartScan.TabIndex = 2
        Me.cmd_StartScan.Text = "&Start Scan"
        Me.cmd_StartScan.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_Status})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 328)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(676, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ts_Status
        '
        Me.ts_Status.Name = "ts_Status"
        Me.ts_Status.Size = New System.Drawing.Size(661, 17)
        Me.ts_Status.Spring = True
        Me.ts_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mainTabControl
        '
        Me.mainTabControl.Controls.Add(Me.TabPage1)
        Me.mainTabControl.Controls.Add(Me.TabPage2)
        Me.mainTabControl.Controls.Add(Me.TabPage3)
        Me.mainTabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.mainTabControl.Location = New System.Drawing.Point(12, 12)
        Me.mainTabControl.Name = "mainTabControl"
        Me.mainTabControl.SelectedIndex = 0
        Me.mainTabControl.Size = New System.Drawing.Size(324, 215)
        Me.mainTabControl.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtSingleTimeout)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.btnAddSingleIp)
        Me.TabPage1.Controls.Add(Me.txtSinglePassword)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.txtSingleIPAddress)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(316, 187)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Single IP Address"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtSingleTimeout
        '
        Me.txtSingleTimeout.Location = New System.Drawing.Point(247, 60)
        Me.txtSingleTimeout.Name = "txtSingleTimeout"
        Me.txtSingleTimeout.Size = New System.Drawing.Size(63, 21)
        Me.txtSingleTimeout.TabIndex = 5
        Me.txtSingleTimeout.Text = "25"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 63)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 15)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Timeout (ms)"
        '
        'btnAddSingleIp
        '
        Me.btnAddSingleIp.Location = New System.Drawing.Point(9, 87)
        Me.btnAddSingleIp.Name = "btnAddSingleIp"
        Me.btnAddSingleIp.Size = New System.Drawing.Size(301, 94)
        Me.btnAddSingleIp.TabIndex = 6
        Me.btnAddSingleIp.Text = "&Add Single IP Address"
        Me.btnAddSingleIp.UseVisualStyleBackColor = True
        '
        'txtSinglePassword
        '
        Me.txtSinglePassword.Location = New System.Drawing.Point(210, 33)
        Me.txtSinglePassword.Name = "txtSinglePassword"
        Me.txtSinglePassword.Size = New System.Drawing.Size(100, 21)
        Me.txtSinglePassword.TabIndex = 3
        Me.txtSinglePassword.Text = "public"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 36)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 15)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "SNMP Password"
        '
        'txtSingleIPAddress
        '
        Me.txtSingleIPAddress.Location = New System.Drawing.Point(210, 6)
        Me.txtSingleIPAddress.Name = "txtSingleIPAddress"
        Me.txtSingleIPAddress.Size = New System.Drawing.Size(100, 21)
        Me.txtSingleIPAddress.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 15)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "IP Address"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cmd_Add)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.txt_Timeout)
        Me.TabPage2.Controls.Add(Me.txt_StartOctet1)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.txt_SNMPPassword)
        Me.TabPage2.Controls.Add(Me.txt_StartOctet2)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txt_StartOctet3)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txt_StopOctet4)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.txt_StartOctet4)
        Me.TabPage2.Controls.Add(Me.txt_StopOctet3)
        Me.TabPage2.Controls.Add(Me.txt_StopOctet1)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.txt_StopOctet2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(316, 187)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Range IP Address"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnAddBulk)
        Me.TabPage3.Controls.Add(Me.txtBulkTimeout)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.txtBulkPassword)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.txtBulkIPAddresses)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(316, 187)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Bulk Import"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnAddBulk
        '
        Me.btnAddBulk.Location = New System.Drawing.Point(9, 144)
        Me.btnAddBulk.Name = "btnAddBulk"
        Me.btnAddBulk.Size = New System.Drawing.Size(301, 37)
        Me.btnAddBulk.TabIndex = 6
        Me.btnAddBulk.Text = "&Add Bulk IP Addresses"
        Me.btnAddBulk.UseVisualStyleBackColor = True
        '
        'txtBulkTimeout
        '
        Me.txtBulkTimeout.Location = New System.Drawing.Point(247, 117)
        Me.txtBulkTimeout.Name = "txtBulkTimeout"
        Me.txtBulkTimeout.Size = New System.Drawing.Size(63, 21)
        Me.txtBulkTimeout.TabIndex = 5
        Me.txtBulkTimeout.Text = "25"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 120)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 15)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Timeout (ms)"
        '
        'txtBulkPassword
        '
        Me.txtBulkPassword.Location = New System.Drawing.Point(210, 90)
        Me.txtBulkPassword.Name = "txtBulkPassword"
        Me.txtBulkPassword.Size = New System.Drawing.Size(100, 21)
        Me.txtBulkPassword.TabIndex = 3
        Me.txtBulkPassword.Text = "public"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 93)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 15)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "SNMP Password"
        '
        'txtBulkIPAddresses
        '
        Me.txtBulkIPAddresses.AcceptsReturn = True
        Me.txtBulkIPAddresses.Location = New System.Drawing.Point(9, 21)
        Me.txtBulkIPAddresses.Multiline = True
        Me.txtBulkIPAddresses.Name = "txtBulkIPAddresses"
        Me.txtBulkIPAddresses.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBulkIPAddresses.Size = New System.Drawing.Size(301, 63)
        Me.txtBulkIPAddresses.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 3)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(167, 15)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "IP Addresses (one ip per line)"
        '
        'frmNewScan
        '
        Me.AcceptButton = Me.cmd_Add
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmd_Cancel
        Me.ClientSize = New System.Drawing.Size(676, 350)
        Me.Controls.Add(Me.mainTabControl)
        Me.Controls.Add(Me.cmd_Cancel)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.cmd_StartScan)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmNewScan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "New Scan"
        Me.GroupBox2.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.mainTabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_Add As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_StopOctet4 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_StopOctet3 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_StopOctet2 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_StopOctet1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_StartOctet4 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_StartOctet3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_StartOctet2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_StartOctet1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmd_Cancel As System.Windows.Forms.Button
    Friend WithEvents cmd_StartScan As System.Windows.Forms.Button
    Friend WithEvents txt_Timeout As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_SNMPPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ts_Status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lst_ScanRange As ListView
    Friend WithEvents mainTabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtSingleTimeout As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnAddSingleIp As Button
    Friend WithEvents txtSinglePassword As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtSingleIPAddress As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnAddBulk As Button
    Friend WithEvents txtBulkTimeout As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtBulkPassword As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtBulkIPAddresses As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
End Class
