<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStakeInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStakeInfo))
        Me.NUDPort = New System.Windows.Forms.NumericUpDown()
        Me.txtStakeCommand = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NUDTier = New System.Windows.Forms.NumericUpDown()
        Me.NUDDays = New System.Windows.Forms.NumericUpDown()
        Me.btmCreateStakeCommand = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSignature = New System.Windows.Forms.TextBox()
        Me.txtWallet = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPubID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIpAddress = New System.Windows.Forms.TextBox()
        Me.txtStakeAmount = New System.Windows.Forms.TextBox()
        Me.btnGetStakeInfo = New System.Windows.Forms.Button()
        Me.txtApproxExp = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.NUDBlocks = New System.Windows.Forms.NumericUpDown()
        Me.lstIPs = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.NUDPort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDTier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDBlocks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NUDPort
        '
        Me.NUDPort.Location = New System.Drawing.Point(371, 30)
        Me.NUDPort.Maximum = New Decimal(New Integer() {28700, 0, 0, 0})
        Me.NUDPort.Name = "NUDPort"
        Me.NUDPort.Size = New System.Drawing.Size(57, 20)
        Me.NUDPort.TabIndex = 36
        Me.NUDPort.Value = New Decimal(New Integer() {28690, 0, 0, 0})
        '
        'txtStakeCommand
        '
        Me.txtStakeCommand.Location = New System.Drawing.Point(103, 291)
        Me.txtStakeCommand.Name = "txtStakeCommand"
        Me.txtStakeCommand.Size = New System.Drawing.Size(425, 20)
        Me.txtStakeCommand.TabIndex = 35
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 201)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Stake Tier"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(217, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Num of days to stake"
        '
        'NUDTier
        '
        Me.NUDTier.Location = New System.Drawing.Point(109, 196)
        Me.NUDTier.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.NUDTier.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUDTier.Name = "NUDTier"
        Me.NUDTier.Size = New System.Drawing.Size(37, 20)
        Me.NUDTier.TabIndex = 32
        Me.NUDTier.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NUDDays
        '
        Me.NUDDays.Location = New System.Drawing.Point(330, 194)
        Me.NUDDays.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.NUDDays.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUDDays.Name = "NUDDays"
        Me.NUDDays.Size = New System.Drawing.Size(37, 20)
        Me.NUDDays.TabIndex = 31
        Me.NUDDays.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btmCreateStakeCommand
        '
        Me.btmCreateStakeCommand.Location = New System.Drawing.Point(83, 250)
        Me.btmCreateStakeCommand.Name = "btmCreateStakeCommand"
        Me.btmCreateStakeCommand.Size = New System.Drawing.Size(144, 23)
        Me.btmCreateStakeCommand.TabIndex = 30
        Me.btmCreateStakeCommand.Text = "Create Stake Command"
        Me.btmCreateStakeCommand.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Stake Amount:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Signature"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(336, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Port:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Wallet:"
        '
        'txtSignature
        '
        Me.txtSignature.Location = New System.Drawing.Point(94, 152)
        Me.txtSignature.Name = "txtSignature"
        Me.txtSignature.Size = New System.Drawing.Size(434, 20)
        Me.txtSignature.TabIndex = 22
        '
        'txtWallet
        '
        Me.txtWallet.Location = New System.Drawing.Point(94, 100)
        Me.txtWallet.Name = "txtWallet"
        Me.txtWallet.Size = New System.Drawing.Size(434, 20)
        Me.txtWallet.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(380, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "5000 max"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(373, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "or # of Blocks"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "ID:"
        '
        'txtPubID
        '
        Me.txtPubID.Location = New System.Drawing.Point(94, 125)
        Me.txtPubID.Name = "txtPubID"
        Me.txtPubID.Size = New System.Drawing.Size(434, 20)
        Me.txtPubID.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(147, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Ip Address:"
        '
        'txtIpAddress
        '
        Me.txtIpAddress.Location = New System.Drawing.Point(220, 29)
        Me.txtIpAddress.Name = "txtIpAddress"
        Me.txtIpAddress.Size = New System.Drawing.Size(110, 20)
        Me.txtIpAddress.TabIndex = 18
        Me.txtIpAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtStakeAmount
        '
        Me.txtStakeAmount.Location = New System.Drawing.Point(109, 224)
        Me.txtStakeAmount.Name = "txtStakeAmount"
        Me.txtStakeAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtStakeAmount.TabIndex = 16
        '
        'btnGetStakeInfo
        '
        Me.btnGetStakeInfo.Location = New System.Drawing.Point(220, 55)
        Me.btnGetStakeInfo.Name = "btnGetStakeInfo"
        Me.btnGetStakeInfo.Size = New System.Drawing.Size(84, 23)
        Me.btnGetStakeInfo.TabIndex = 15
        Me.btnGetStakeInfo.Text = "Get Stake Info"
        Me.btnGetStakeInfo.UseVisualStyleBackColor = True
        '
        'txtApproxExp
        '
        Me.txtApproxExp.Location = New System.Drawing.Point(346, 253)
        Me.txtApproxExp.Name = "txtApproxExp"
        Me.txtApproxExp.ReadOnly = True
        Me.txtApproxExp.Size = New System.Drawing.Size(149, 20)
        Me.txtApproxExp.TabIndex = 37
        Me.txtApproxExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(357, 237)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Approx: Expiration Time:"
        '
        'NUDBlocks
        '
        Me.NUDBlocks.Location = New System.Drawing.Point(463, 194)
        Me.NUDBlocks.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.NUDBlocks.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NUDBlocks.Name = "NUDBlocks"
        Me.NUDBlocks.Size = New System.Drawing.Size(50, 20)
        Me.NUDBlocks.TabIndex = 38
        Me.NUDBlocks.Value = New Decimal(New Integer() {720, 0, 0, 0})
        '
        'lstIPs
        '
        Me.lstIPs.FormattingEnabled = True
        Me.lstIPs.Location = New System.Drawing.Point(15, 12)
        Me.lstIPs.Name = "lstIPs"
        Me.lstIPs.Size = New System.Drawing.Size(105, 82)
        Me.lstIPs.TabIndex = 51
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 294)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 13)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "Stake Command:"
        '
        'frmStakeInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 327)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lstIPs)
        Me.Controls.Add(Me.NUDBlocks)
        Me.Controls.Add(Me.txtApproxExp)
        Me.Controls.Add(Me.NUDPort)
        Me.Controls.Add(Me.txtStakeCommand)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.NUDTier)
        Me.Controls.Add(Me.NUDDays)
        Me.Controls.Add(Me.btmCreateStakeCommand)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSignature)
        Me.Controls.Add(Me.txtWallet)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPubID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIpAddress)
        Me.Controls.Add(Me.txtStakeAmount)
        Me.Controls.Add(Me.btnGetStakeInfo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(556, 366)
        Me.MinimumSize = New System.Drawing.Size(556, 366)
        Me.Name = "frmStakeInfo"
        Me.Text = "StakeInfo"
        CType(Me.NUDPort, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDTier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDBlocks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NUDPort As NumericUpDown
    Friend WithEvents txtStakeCommand As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents NUDTier As NumericUpDown
    Friend WithEvents NUDDays As NumericUpDown
    Friend WithEvents btmCreateStakeCommand As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSignature As TextBox
    Friend WithEvents txtWallet As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPubID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIpAddress As TextBox
    Friend WithEvents txtStakeAmount As TextBox
    Friend WithEvents btnGetStakeInfo As Button
    Friend WithEvents txtApproxExp As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents NUDBlocks As NumericUpDown
    Friend WithEvents lstIPs As ListBox
    Friend WithEvents Label12 As Label
End Class
