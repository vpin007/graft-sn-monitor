<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupernode2
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSupernode2))
        Me.lstIDS = New System.Windows.Forms.ListBox()
        Me.NUDPort = New System.Windows.Forms.NumericUpDown()
        Me.txtPubID = New System.Windows.Forms.TextBox()
        Me.btnCheckStatus = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIpAddress = New System.Windows.Forms.TextBox()
        Me.lstIPs = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddIP = New System.Windows.Forms.Button()
        Me.btnModifyIP = New System.Windows.Forms.Button()
        Me.btnDeleteIP = New System.Windows.Forms.Button()
        Me.btnAddID = New System.Windows.Forms.Button()
        Me.btnModifyID = New System.Windows.Forms.Button()
        Me.btnDeleteID = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StakeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtExpirationtime = New System.Windows.Forms.TextBox()
        Me.txtAuthSample = New System.Windows.Forms.TextBox()
        Me.txtCurrentHeight = New System.Windows.Forms.TextBox()
        Me.txtLastUpdateAge = New System.Windows.Forms.TextBox()
        Me.txtExpiringBlock = New System.Windows.Forms.TextBox()
        Me.txtStake = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblBlocksLeft = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TierChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.txtTotalStaked = New System.Windows.Forms.TextBox()
        Me.txtTotalRunning = New System.Windows.Forms.TextBox()
        Me.txttier4 = New System.Windows.Forms.TextBox()
        Me.txttier3 = New System.Windows.Forms.TextBox()
        Me.txttier2 = New System.Windows.Forms.TextBox()
        Me.txttier1 = New System.Windows.Forms.TextBox()
        Me.txtInactive = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblLostandFound = New System.Windows.Forms.Label()
        Me.btnSaveSettings = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.NUDPort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.TierChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstIDS
        '
        Me.lstIDS.FormattingEnabled = True
        Me.lstIDS.Location = New System.Drawing.Point(74, 195)
        Me.lstIDS.Name = "lstIDS"
        Me.lstIDS.Size = New System.Drawing.Size(105, 108)
        Me.lstIDS.TabIndex = 49
        '
        'NUDPort
        '
        Me.NUDPort.Location = New System.Drawing.Point(418, 23)
        Me.NUDPort.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NUDPort.Name = "NUDPort"
        Me.NUDPort.Size = New System.Drawing.Size(57, 20)
        Me.NUDPort.TabIndex = 1
        Me.NUDPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NUDPort.Value = New Decimal(New Integer() {18690, 0, 0, 0})
        '
        'txtPubID
        '
        Me.txtPubID.Location = New System.Drawing.Point(272, 49)
        Me.txtPubID.Name = "txtPubID"
        Me.txtPubID.Size = New System.Drawing.Size(397, 20)
        Me.txtPubID.TabIndex = 2
        '
        'btnCheckStatus
        '
        Me.btnCheckStatus.Location = New System.Drawing.Point(272, 75)
        Me.btnCheckStatus.Name = "btnCheckStatus"
        Me.btnCheckStatus.Size = New System.Drawing.Size(96, 23)
        Me.btnCheckStatus.TabIndex = 3
        Me.btnCheckStatus.Text = "Check Status"
        Me.btnCheckStatus.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(204, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Ip Address:"
        '
        'txtIpAddress
        '
        Me.txtIpAddress.Location = New System.Drawing.Point(272, 23)
        Me.txtIpAddress.Name = "txtIpAddress"
        Me.txtIpAddress.Size = New System.Drawing.Size(90, 20)
        Me.txtIpAddress.TabIndex = 0
        Me.txtIpAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lstIPs
        '
        Me.lstIPs.FormattingEnabled = True
        Me.lstIPs.Location = New System.Drawing.Point(74, 35)
        Me.lstIPs.Name = "lstIPs"
        Me.lstIPs.Size = New System.Drawing.Size(105, 108)
        Me.lstIPs.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(204, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "ID:"
        '
        'btnAddIP
        '
        Me.btnAddIP.Location = New System.Drawing.Point(12, 35)
        Me.btnAddIP.Name = "btnAddIP"
        Me.btnAddIP.Size = New System.Drawing.Size(47, 23)
        Me.btnAddIP.TabIndex = 4
        Me.btnAddIP.Text = "Add"
        Me.btnAddIP.UseVisualStyleBackColor = True
        '
        'btnModifyIP
        '
        Me.btnModifyIP.Location = New System.Drawing.Point(12, 64)
        Me.btnModifyIP.Name = "btnModifyIP"
        Me.btnModifyIP.Size = New System.Drawing.Size(47, 23)
        Me.btnModifyIP.TabIndex = 5
        Me.btnModifyIP.Text = "Modify"
        Me.btnModifyIP.UseVisualStyleBackColor = True
        '
        'btnDeleteIP
        '
        Me.btnDeleteIP.Location = New System.Drawing.Point(12, 93)
        Me.btnDeleteIP.Name = "btnDeleteIP"
        Me.btnDeleteIP.Size = New System.Drawing.Size(47, 23)
        Me.btnDeleteIP.TabIndex = 6
        Me.btnDeleteIP.Text = "Delete"
        Me.btnDeleteIP.UseVisualStyleBackColor = True
        '
        'btnAddID
        '
        Me.btnAddID.Location = New System.Drawing.Point(12, 196)
        Me.btnAddID.Name = "btnAddID"
        Me.btnAddID.Size = New System.Drawing.Size(47, 23)
        Me.btnAddID.TabIndex = 7
        Me.btnAddID.Text = "Add"
        Me.btnAddID.UseVisualStyleBackColor = True
        '
        'btnModifyID
        '
        Me.btnModifyID.Location = New System.Drawing.Point(12, 225)
        Me.btnModifyID.Name = "btnModifyID"
        Me.btnModifyID.Size = New System.Drawing.Size(47, 23)
        Me.btnModifyID.TabIndex = 8
        Me.btnModifyID.Text = "Modify"
        Me.btnModifyID.UseVisualStyleBackColor = True
        '
        'btnDeleteID
        '
        Me.btnDeleteID.Location = New System.Drawing.Point(12, 254)
        Me.btnDeleteID.Name = "btnDeleteID"
        Me.btnDeleteID.Size = New System.Drawing.Size(47, 23)
        Me.btnDeleteID.TabIndex = 9
        Me.btnDeleteID.Text = "Delete"
        Me.btnDeleteID.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(83, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Super Node Ip"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(83, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Super Node ID"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StakeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(729, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StakeToolStripMenuItem
        '
        Me.StakeToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.StakeToolStripMenuItem.Name = "StakeToolStripMenuItem"
        Me.StakeToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.StakeToolStripMenuItem.Text = "Stake"
        '
        'txtExpirationtime
        '
        Me.txtExpirationtime.Location = New System.Drawing.Point(237, 100)
        Me.txtExpirationtime.Name = "txtExpirationtime"
        Me.txtExpirationtime.ReadOnly = True
        Me.txtExpirationtime.Size = New System.Drawing.Size(136, 20)
        Me.txtExpirationtime.TabIndex = 69
        Me.txtExpirationtime.TabStop = False
        Me.txtExpirationtime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAuthSample
        '
        Me.txtAuthSample.Location = New System.Drawing.Point(103, 131)
        Me.txtAuthSample.Name = "txtAuthSample"
        Me.txtAuthSample.ReadOnly = True
        Me.txtAuthSample.Size = New System.Drawing.Size(100, 20)
        Me.txtAuthSample.TabIndex = 64
        Me.txtAuthSample.TabStop = False
        Me.txtAuthSample.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCurrentHeight
        '
        Me.txtCurrentHeight.Location = New System.Drawing.Point(103, 105)
        Me.txtCurrentHeight.Name = "txtCurrentHeight"
        Me.txtCurrentHeight.ReadOnly = True
        Me.txtCurrentHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtCurrentHeight.TabIndex = 65
        Me.txtCurrentHeight.TabStop = False
        Me.txtCurrentHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLastUpdateAge
        '
        Me.txtLastUpdateAge.Location = New System.Drawing.Point(104, 55)
        Me.txtLastUpdateAge.Name = "txtLastUpdateAge"
        Me.txtLastUpdateAge.ReadOnly = True
        Me.txtLastUpdateAge.Size = New System.Drawing.Size(100, 20)
        Me.txtLastUpdateAge.TabIndex = 66
        Me.txtLastUpdateAge.TabStop = False
        Me.txtLastUpdateAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtExpiringBlock
        '
        Me.txtExpiringBlock.Location = New System.Drawing.Point(104, 78)
        Me.txtExpiringBlock.Name = "txtExpiringBlock"
        Me.txtExpiringBlock.ReadOnly = True
        Me.txtExpiringBlock.Size = New System.Drawing.Size(100, 20)
        Me.txtExpiringBlock.TabIndex = 67
        Me.txtExpiringBlock.TabStop = False
        Me.txtExpiringBlock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtStake
        '
        Me.txtStake.Location = New System.Drawing.Point(104, 30)
        Me.txtStake.Name = "txtStake"
        Me.txtStake.ReadOnly = True
        Me.txtStake.Size = New System.Drawing.Size(100, 20)
        Me.txtStake.TabIndex = 68
        Me.txtStake.TabStop = False
        Me.txtStake.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Last Update Age:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(244, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 13)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Blocks Till Expiration:"
        '
        'lblBlocksLeft
        '
        Me.lblBlocksLeft.AutoSize = True
        Me.lblBlocksLeft.Location = New System.Drawing.Point(285, 55)
        Me.lblBlocksLeft.Name = "lblBlocksLeft"
        Me.lblBlocksLeft.Size = New System.Drawing.Size(13, 13)
        Me.lblBlocksLeft.TabIndex = 58
        Me.lblBlocksLeft.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(239, 77)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(121, 13)
        Me.Label16.TabIndex = 59
        Me.Label16.Text = "Approx: Expiration Time:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 134)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "Auth Sample:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Current Height:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 13)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Expiring Block:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Stake Amount:"
        '
        'TierChart
        '
        Me.TierChart.BackColor = System.Drawing.SystemColors.Control
        ChartArea1.Name = "ChartArea1"
        Me.TierChart.ChartAreas.Add(ChartArea1)
        Me.TierChart.Location = New System.Drawing.Point(345, 335)
        Me.TierChart.Name = "TierChart"
        Series1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Series1.ChartArea = "ChartArea1"
        Series1.Color = System.Drawing.Color.Green
        Series1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Series1.LabelBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Series1.LabelBorderColor = System.Drawing.Color.White
        Series1.Name = "Tier"
        Me.TierChart.Series.Add(Series1)
        Me.TierChart.Size = New System.Drawing.Size(324, 224)
        Me.TierChart.TabIndex = 85
        Me.TierChart.Text = "Chart1"
        '
        'txtTotalStaked
        '
        Me.txtTotalStaked.Location = New System.Drawing.Point(127, 539)
        Me.txtTotalStaked.Name = "txtTotalStaked"
        Me.txtTotalStaked.ReadOnly = True
        Me.txtTotalStaked.Size = New System.Drawing.Size(101, 20)
        Me.txtTotalStaked.TabIndex = 84
        Me.txtTotalStaked.TabStop = False
        Me.txtTotalStaked.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalRunning
        '
        Me.txtTotalRunning.Location = New System.Drawing.Point(173, 501)
        Me.txtTotalRunning.Name = "txtTotalRunning"
        Me.txtTotalRunning.ReadOnly = True
        Me.txtTotalRunning.Size = New System.Drawing.Size(55, 20)
        Me.txtTotalRunning.TabIndex = 77
        Me.txtTotalRunning.TabStop = False
        Me.txtTotalRunning.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txttier4
        '
        Me.txttier4.Location = New System.Drawing.Point(173, 477)
        Me.txttier4.Name = "txttier4"
        Me.txttier4.ReadOnly = True
        Me.txttier4.Size = New System.Drawing.Size(55, 20)
        Me.txttier4.TabIndex = 78
        Me.txttier4.TabStop = False
        Me.txttier4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txttier3
        '
        Me.txttier3.Location = New System.Drawing.Point(173, 451)
        Me.txttier3.Name = "txttier3"
        Me.txttier3.ReadOnly = True
        Me.txttier3.Size = New System.Drawing.Size(55, 20)
        Me.txttier3.TabIndex = 79
        Me.txttier3.TabStop = False
        Me.txttier3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txttier2
        '
        Me.txttier2.Location = New System.Drawing.Point(174, 425)
        Me.txttier2.Name = "txttier2"
        Me.txttier2.ReadOnly = True
        Me.txttier2.Size = New System.Drawing.Size(55, 20)
        Me.txttier2.TabIndex = 80
        Me.txttier2.TabStop = False
        Me.txttier2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txttier1
        '
        Me.txttier1.Location = New System.Drawing.Point(174, 399)
        Me.txttier1.Name = "txttier1"
        Me.txttier1.ReadOnly = True
        Me.txttier1.Size = New System.Drawing.Size(55, 20)
        Me.txttier1.TabIndex = 81
        Me.txttier1.TabStop = False
        Me.txttier1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtInactive
        '
        Me.txtInactive.Location = New System.Drawing.Point(174, 355)
        Me.txtInactive.Name = "txtInactive"
        Me.txtInactive.ReadOnly = True
        Me.txtInactive.Size = New System.Drawing.Size(55, 20)
        Me.txtInactive.TabIndex = 82
        Me.txtInactive.TabStop = False
        Me.txtInactive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(86, 505)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(74, 13)
        Me.Label17.TabIndex = 70
        Me.Label17.Text = "Total Running"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(124, 480)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 13)
        Me.Label13.TabIndex = 71
        Me.Label13.Text = "Tier 4"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(124, 458)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 13)
        Me.Label12.TabIndex = 72
        Me.Label12.Text = "Tier 3"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(124, 432)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = "Tier 2"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(124, 402)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 13)
        Me.Label14.TabIndex = 74
        Me.Label14.Text = "Tier 1"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(111, 359)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 75
        Me.Label15.Text = "Inactive"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(40, 542)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 13)
        Me.Label18.TabIndex = 76
        Me.Label18.Text = "Total Staked:"
        '
        'lblLostandFound
        '
        Me.lblLostandFound.AutoSize = True
        Me.lblLostandFound.Location = New System.Drawing.Point(415, 80)
        Me.lblLostandFound.Name = "lblLostandFound"
        Me.lblLostandFound.Size = New System.Drawing.Size(40, 13)
        Me.lblLostandFound.TabIndex = 86
        Me.lblLostandFound.Text = "Status:"
        '
        'btnSaveSettings
        '
        Me.btnSaveSettings.Location = New System.Drawing.Point(12, 309)
        Me.btnSaveSettings.Name = "btnSaveSettings"
        Me.btnSaveSettings.Size = New System.Drawing.Size(99, 23)
        Me.btnSaveSettings.TabIndex = 10
        Me.btnSaveSettings.Text = "Save  Settings"
        Me.btnSaveSettings.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtExpiringBlock)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.lblBlocksLeft)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtStake)
        Me.GroupBox1.Controls.Add(Me.txtLastUpdateAge)
        Me.GroupBox1.Controls.Add(Me.txtCurrentHeight)
        Me.GroupBox1.Controls.Add(Me.txtAuthSample)
        Me.GroupBox1.Controls.Add(Me.txtExpirationtime)
        Me.GroupBox1.Location = New System.Drawing.Point(262, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(407, 175)
        Me.GroupBox1.TabIndex = 89
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Results"
        '
        'frmSupernode2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 595)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSaveSettings)
        Me.Controls.Add(Me.lblLostandFound)
        Me.Controls.Add(Me.TierChart)
        Me.Controls.Add(Me.txtTotalStaked)
        Me.Controls.Add(Me.txtTotalRunning)
        Me.Controls.Add(Me.txttier4)
        Me.Controls.Add(Me.txttier3)
        Me.Controls.Add(Me.txttier2)
        Me.Controls.Add(Me.txttier1)
        Me.Controls.Add(Me.txtInactive)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnDeleteID)
        Me.Controls.Add(Me.btnModifyID)
        Me.Controls.Add(Me.btnDeleteIP)
        Me.Controls.Add(Me.btnAddID)
        Me.Controls.Add(Me.btnModifyIP)
        Me.Controls.Add(Me.btnAddIP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstIPs)
        Me.Controls.Add(Me.lstIDS)
        Me.Controls.Add(Me.NUDPort)
        Me.Controls.Add(Me.txtPubID)
        Me.Controls.Add(Me.btnCheckStatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIpAddress)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSupernode2"
        Me.Text = "Graft Monitor"
        CType(Me.NUDPort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.TierChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstIDS As ListBox
    Friend WithEvents NUDPort As NumericUpDown
    Friend WithEvents txtPubID As TextBox
    Friend WithEvents btnCheckStatus As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIpAddress As TextBox
    Friend WithEvents lstIPs As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAddIP As Button
    Friend WithEvents btnModifyIP As Button
    Friend WithEvents btnDeleteIP As Button
    Friend WithEvents btnAddID As Button
    Friend WithEvents btnModifyID As Button
    Friend WithEvents btnDeleteID As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StakeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtExpirationtime As TextBox
    Friend WithEvents txtAuthSample As TextBox
    Friend WithEvents txtCurrentHeight As TextBox
    Friend WithEvents txtLastUpdateAge As TextBox
    Friend WithEvents txtExpiringBlock As TextBox
    Friend WithEvents txtStake As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblBlocksLeft As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TierChart As DataVisualization.Charting.Chart
    Friend WithEvents txtTotalStaked As TextBox
    Friend WithEvents txtTotalRunning As TextBox
    Friend WithEvents txttier4 As TextBox
    Friend WithEvents txttier3 As TextBox
    Friend WithEvents txttier2 As TextBox
    Friend WithEvents txttier1 As TextBox
    Friend WithEvents txtInactive As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lblLostandFound As Label
    Friend WithEvents btnSaveSettings As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
