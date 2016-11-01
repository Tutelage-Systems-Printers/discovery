<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_NewScan = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnu_SaveScan = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportIPListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnu_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ts_NewScan = New System.Windows.Forms.ToolStripButton()
        Me.ts_StopScan = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSaveResults = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ts_Status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ts_Progress = New System.Windows.Forms.ToolStripProgressBar()
        Me.lst_Printers = New System.Windows.Forms.ListView()
        Me.col_IPAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Manufacture = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Model = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_SerialNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_CounterTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_CounterMono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_CounterColor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_SuppliesBlack = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_SuppliesCyan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_SuppliesMagenta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_SuppliesYellow = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_ScanTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmnu_PrinterList = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmnu_PrinterList_OpenDevicePage = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.cmnu_PrinterList.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1263, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_NewScan, Me.ToolStripMenuItem1, Me.mnu_SaveScan, Me.ExportIPListToolStripMenuItem, Me.ToolStripMenuItem3, Me.mnu_Exit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'mnu_NewScan
        '
        Me.mnu_NewScan.Name = "mnu_NewScan"
        Me.mnu_NewScan.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnu_NewScan.Size = New System.Drawing.Size(169, 22)
        Me.mnu_NewScan.Text = "&New Scan"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(166, 6)
        '
        'mnu_SaveScan
        '
        Me.mnu_SaveScan.Name = "mnu_SaveScan"
        Me.mnu_SaveScan.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnu_SaveScan.Size = New System.Drawing.Size(169, 22)
        Me.mnu_SaveScan.Text = "&Save Scan"
        '
        'ExportIPListToolStripMenuItem
        '
        Me.ExportIPListToolStripMenuItem.Name = "ExportIPListToolStripMenuItem"
        Me.ExportIPListToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ExportIPListToolStripMenuItem.Text = "Export IP List"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(166, 6)
        '
        'mnu_Exit
        '
        Me.mnu_Exit.Image = Global.Discovery.My.Resources.Resources._exit
        Me.mnu_Exit.Name = "mnu_Exit"
        Me.mnu_Exit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.mnu_Exit.Size = New System.Drawing.Size(169, 22)
        Me.mnu_Exit.Text = "E&xit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ts_NewScan, Me.ts_StopScan, Me.ToolStripSeparator2, Me.btnSaveResults})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1263, 67)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 67)
        '
        'ts_NewScan
        '
        Me.ts_NewScan.AutoSize = False
        Me.ts_NewScan.Image = Global.Discovery.My.Resources.Resources.plus
        Me.ts_NewScan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ts_NewScan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_NewScan.Name = "ts_NewScan"
        Me.ts_NewScan.Size = New System.Drawing.Size(72, 64)
        Me.ts_NewScan.Text = "New Scan"
        Me.ts_NewScan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ts_NewScan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ts_StopScan
        '
        Me.ts_StopScan.AutoSize = False
        Me.ts_StopScan.Enabled = False
        Me.ts_StopScan.Image = Global.Discovery.My.Resources.Resources.cross
        Me.ts_StopScan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ts_StopScan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ts_StopScan.Name = "ts_StopScan"
        Me.ts_StopScan.Size = New System.Drawing.Size(72, 64)
        Me.ts_StopScan.Text = "Stop Scan"
        Me.ts_StopScan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ts_StopScan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 67)
        '
        'btnSaveResults
        '
        Me.btnSaveResults.AutoSize = False
        Me.btnSaveResults.Image = Global.Discovery.My.Resources.Resources.save_32
        Me.btnSaveResults.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSaveResults.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSaveResults.Name = "btnSaveResults"
        Me.btnSaveResults.Size = New System.Drawing.Size(72, 64)
        Me.btnSaveResults.Text = "Save Results"
        Me.btnSaveResults.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSaveResults.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_Status, Me.ts_Progress})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 467)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1263, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ts_Status
        '
        Me.ts_Status.Name = "ts_Status"
        Me.ts_Status.Size = New System.Drawing.Size(1146, 17)
        Me.ts_Status.Spring = True
        Me.ts_Status.Text = "Application Ready ..."
        Me.ts_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ts_Progress
        '
        Me.ts_Progress.Name = "ts_Progress"
        Me.ts_Progress.Size = New System.Drawing.Size(100, 16)
        '
        'lst_Printers
        '
        Me.lst_Printers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_IPAddress, Me.col_Manufacture, Me.col_Model, Me.col_SerialNumber, Me.col_CounterTotal, Me.col_CounterMono, Me.col_CounterColor, Me.col_SuppliesBlack, Me.col_SuppliesCyan, Me.col_SuppliesMagenta, Me.col_SuppliesYellow, Me.col_ScanTime})
        Me.lst_Printers.ContextMenuStrip = Me.cmnu_PrinterList
        Me.lst_Printers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst_Printers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lst_Printers.FullRowSelect = True
        Me.lst_Printers.GridLines = True
        Me.lst_Printers.Location = New System.Drawing.Point(0, 91)
        Me.lst_Printers.MultiSelect = False
        Me.lst_Printers.Name = "lst_Printers"
        Me.lst_Printers.Size = New System.Drawing.Size(1263, 376)
        Me.lst_Printers.TabIndex = 3
        Me.lst_Printers.UseCompatibleStateImageBehavior = False
        Me.lst_Printers.View = System.Windows.Forms.View.Details
        '
        'col_IPAddress
        '
        Me.col_IPAddress.Text = "IP Address"
        Me.col_IPAddress.Width = 104
        '
        'col_Manufacture
        '
        Me.col_Manufacture.Text = "Manufacture"
        Me.col_Manufacture.Width = 123
        '
        'col_Model
        '
        Me.col_Model.Text = "Model"
        Me.col_Model.Width = 123
        '
        'col_SerialNumber
        '
        Me.col_SerialNumber.Text = "Serial Number"
        Me.col_SerialNumber.Width = 113
        '
        'col_CounterTotal
        '
        Me.col_CounterTotal.Text = "Counter Total"
        Me.col_CounterTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.col_CounterTotal.Width = 110
        '
        'col_CounterMono
        '
        Me.col_CounterMono.Text = "Counter Mono"
        Me.col_CounterMono.Width = 108
        '
        'col_CounterColor
        '
        Me.col_CounterColor.Text = "Counter Color"
        Me.col_CounterColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.col_CounterColor.Width = 115
        '
        'col_SuppliesBlack
        '
        Me.col_SuppliesBlack.Text = "Supplies Black"
        Me.col_SuppliesBlack.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.col_SuppliesBlack.Width = 90
        '
        'col_SuppliesCyan
        '
        Me.col_SuppliesCyan.Text = "Supplies Cyan"
        Me.col_SuppliesCyan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.col_SuppliesCyan.Width = 90
        '
        'col_SuppliesMagenta
        '
        Me.col_SuppliesMagenta.Text = "Supplies Magenta"
        Me.col_SuppliesMagenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.col_SuppliesMagenta.Width = 100
        '
        'col_SuppliesYellow
        '
        Me.col_SuppliesYellow.Text = "Supplies Yellow"
        Me.col_SuppliesYellow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.col_SuppliesYellow.Width = 100
        '
        'col_ScanTime
        '
        Me.col_ScanTime.Text = "Scan Time"
        Me.col_ScanTime.Width = 78
        '
        'cmnu_PrinterList
        '
        Me.cmnu_PrinterList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnu_PrinterList_OpenDevicePage})
        Me.cmnu_PrinterList.Name = "cmnu_PrinterList"
        Me.cmnu_PrinterList.Size = New System.Drawing.Size(171, 26)
        '
        'cmnu_PrinterList_OpenDevicePage
        '
        Me.cmnu_PrinterList_OpenDevicePage.Name = "cmnu_PrinterList_OpenDevicePage"
        Me.cmnu_PrinterList_OpenDevicePage.Size = New System.Drawing.Size(170, 22)
        Me.cmnu_PrinterList_OpenDevicePage.Text = "Open Device Page"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1263, 489)
        Me.Controls.Add(Me.lst_Printers)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Discovery"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.cmnu_PrinterList.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_Exit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ts_NewScan As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ts_StopScan As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnu_NewScan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lst_Printers As System.Windows.Forms.ListView
    Friend WithEvents col_IPAddress As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Manufacture As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_Model As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_SerialNumber As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_CounterMono As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_CounterColor As System.Windows.Forms.ColumnHeader
    Friend WithEvents ts_Status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents col_CounterTotal As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_SuppliesBlack As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_SuppliesCyan As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_SuppliesMagenta As System.Windows.Forms.ColumnHeader
    Friend WithEvents col_SuppliesYellow As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmnu_PrinterList As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmnu_PrinterList_OpenDevicePage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_SaveScan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ts_Progress As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnSaveResults As ToolStripButton
    Friend WithEvents col_ScanTime As ColumnHeader
    Friend WithEvents ExportIPListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
End Class
