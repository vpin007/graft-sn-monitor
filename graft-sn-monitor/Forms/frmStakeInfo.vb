Imports System.Net
Imports System.Net.Http

Public Class frmStakeInfo

    Public strIpaddres As String
    Public IPaddresses As List(Of IPsandports)



    Private Sub btmCreateStakeCommand_Click(sender As Object, e As EventArgs) Handles btmCreateStakeCommand.Click
        CreateStakeCommand()
    End Sub



    Private Async Sub btnGetStakeInfo_Click(sender As Object, e As EventArgs) Handles btnGetStakeInfo.Click

        If txtIpAddress.Text <> "" Then
            btnGetStakeInfo.Enabled = False


            Await GetStakeInfo()

            btnGetStakeInfo.Enabled = True


        Else
            MessageBox.Show("Please Enter IP Address")

        End If


    End Sub

    Private Async Function GetStakeInfo() As Task
        txtWallet.Text = ""
        txtPubID.Text = ""
        txtSignature.Text = ""

        NUDTier.Value = 1
        NUDDays.Value = 1


        txtStakeCommand.Text = ""


        Try


            Dim client As New HttpClient


            Dim ipaddress As String = txtIpAddress.Text


            Dim response = Await client.GetStringAsync("http://" & ipaddress & ":" & NUDPort.Value & "/dapi/v2.0/cryptonode/getwalletaddress")

            Dim mystakeinfo As New wallet.Stakeinfo


            mystakeinfo = wallet.Stakeinfo.FromJson(response)


            txtWallet.Text = mystakeinfo.WalletPublicAddress

            txtPubID.Text = mystakeinfo.IdKey

            txtSignature.Text = mystakeinfo.Signature



        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try



    End Function
    Private Sub CreateStakeCommand()



        If txtWallet.Text = "" Or txtPubID.Text = "" Or txtSignature.Text = "" Then

            MessageBox.Show("Wallet, ID, and Signature must be filled in.")

        Else
            txtStakeCommand.Text = "stake_transfer" & " " & txtWallet.Text & " " & txtStakeAmount.Text & " " & NUDBlocks.Value & " " & txtPubID.Text & " " & txtSignature.Text


            My.Computer.Clipboard.SetText(txtStakeCommand.Text)

            MessageBox.Show("The stake command has been copied to the clipboard")


        End If



    End Sub

    Private Sub NUDDays_ValueChanged(sender As Object, e As EventArgs) Handles NUDDays.ValueChanged
        If NUDDays.Value = 7 Then

            NUDBlocks.Value = 5000
        Else

            NUDBlocks.Value = NUDDays.Value * 720
        End If

        SetAproxExperation()


    End Sub

    Private Sub SetAproxExperation()

        Dim numofblocks As Integer = NUDBlocks.Value


        Dim mins As Integer = numofblocks * 2

        Dim mydatetime As New DateTime

        mydatetime = Now.AddMinutes(mins)

        txtApproxExp.Text = mydatetime


    End Sub

    Private Sub NUDTier_ValueChanged(sender As Object, e As EventArgs) Handles NUDTier.ValueChanged
        Select Case NUDTier.Value
            Case 1
                txtStakeAmount.Text = 50000
            Case 2
                txtStakeAmount.Text = 90000
            Case 3
                txtStakeAmount.Text = 150000
            Case 4
                txtStakeAmount.Text = 250000
        End Select


    End Sub

    Private Sub frmStakeInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIpAddress.Text = strIpaddres

        lstIPs.DataSource = IPaddresses
        lstIPs.DisplayMember = "Name"
        lstIPs.ValueMember = "IPAddress"


        If lstIPs.Items.Count > 0 Then
            lstIPs.SelectedIndex = 0

        End If



        Dim current_Screen As Screen = Screen.FromControl(frmSupernode2.MenuStrip1)

        If current_Screen.Primary = False Then


            Dim HCenter = current_Screen.Bounds.Left +
           (((current_Screen.Bounds.Right - current_Screen.Bounds.Left) / 2) - ((Me.Width) / 2))

            Dim VCenter = (current_Screen.Bounds.Bottom / 2) - ((Me.Height) / 2)

            Me.StartPosition = FormStartPosition.Manual
            Me.Location = New Point(HCenter, VCenter)

        Else

            Me.StartPosition = FormStartPosition.CenterScreen


        End If



    End Sub

    Private Sub NUDBlocks_ValueChanged(sender As Object, e As EventArgs) Handles NUDBlocks.ValueChanged
        SetAproxExperation()

    End Sub

    Private Sub lstIPs_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstIPs.SelectedValueChanged
        If lstIPs.SelectedIndex <> -1 Then


            txtIpAddress.Text = lstIPs.SelectedValue.ToString
            NUDPort.Value = CType(lstIPs.SelectedItem, IPsandports).Port


        End If
    End Sub

End Class