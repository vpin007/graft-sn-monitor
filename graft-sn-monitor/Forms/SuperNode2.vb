Imports System.IO
Imports System.Net.Http
Imports Newtonsoft.Json

Public Class frmSupernode2

    Public mymulti As New IpsAndIds

    Private configfile As String = "multi.json"



    Private Sub SuperNode2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Readsettings()


    End Sub

    Private Sub Readsettings()


        Dim mystring As String





        If File.Exists(configfile) Then

            mystring = File.ReadAllText("multi.json")
            mymulti = JsonConvert.DeserializeObject(Of IpsAndIds)(mystring)


            lstIPs.DataSource = mymulti.IPS
            lstIPs.DisplayMember = "Name"
            lstIPs.ValueMember = "IPAddress"



            lstIDS.DataSource = mymulti.IDS
            lstIDS.DisplayMember = "Name"
            lstIDS.ValueMember = "ID"

            If lstIDS.Items.Count > 0 Then
                lstIDS.SelectedIndex = 0
            End If

            If lstIPs.Items.Count > 0 Then
                lstIPs.SelectedIndex = 0

            End If


        Else

            MessageBox.Show("Config file not found, default created.")

            mystring = JsonConvert.SerializeObject(mymulti, Formatting.Indented)

            File.WriteAllText(configfile, mystring)



        End If







    End Sub



    Private Sub lstIDS_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstIDS.SelectedValueChanged
        If lstIDS.SelectedIndex <> -1 Then
            txtPubID.Text = lstIDS.SelectedValue.ToString


        End If

    End Sub

    Private Sub lstIPs_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstIPs.SelectedValueChanged
        If lstIPs.SelectedIndex <> -1 Then


            txtIpAddress.Text = lstIPs.SelectedValue.ToString
            NUDPort.Value = CType(lstIPs.SelectedItem, IPsandports).Port


        End If
    End Sub

    Private Sub btnDeleteID_Click(sender As Object, e As EventArgs) Handles btnDeleteID.Click
        If txtPubID.Text = lstIDS.SelectedValue Then
            txtPubID.Text = ""

        End If
        mymulti.IDS.Remove(lstIDS.SelectedItem)

        ReloadIDS()

    End Sub

    Private Sub ReloadIDS()
        lstIDS.DataSource = Nothing


        lstIDS.DataSource = mymulti.IDS
        lstIDS.DisplayMember = "Name"
        lstIDS.ValueMember = "ID"

    End Sub


    Private Sub ReloadIPs()
        lstIPs.DataSource = Nothing

        lstIPs.DataSource = mymulti.IPS
        lstIPs.DisplayMember = "Name"
        lstIPs.ValueMember = "IPAddress"


    End Sub

    Private Sub btnDeleteIP_Click(sender As Object, e As EventArgs) Handles btnDeleteIP.Click
        If txtIpAddress.Text = lstIPs.SelectedValue Then
            txtIpAddress.Text = ""

        End If
        mymulti.IPS.Remove(lstIPs.SelectedItem)

        ReloadIPs()


    End Sub


    Private Sub btnModifyIP_Click(sender As Object, e As EventArgs) Handles btnModifyIP.Click
        If lstIPs.SelectedIndex <> -1 Then

            Dim tempSelectedip As IPsandports

            tempSelectedip = CType(lstIPs.SelectedItem, IPsandports)

            Dim addmodifyip As New frmIPAddEdit

            addmodifyip.addIP = False
            addmodifyip.editipandport = tempSelectedip

            Dim result As DialogResult = addmodifyip.ShowDialog

            If result = DialogResult.OK Then

                ReloadIPs()


            End If

        End If


    End Sub

    Private Sub btnAddIP_Click(sender As Object, e As EventArgs) Handles btnAddIP.Click
        Dim addmodifyip As New frmIPAddEdit

        addmodifyip.addIP = True


        Dim result As DialogResult = addmodifyip.ShowDialog
        If result = Windows.Forms.DialogResult.OK Then

            ReloadIPs()

        End If

    End Sub

    Private Sub btnAddID_Click(sender As Object, e As EventArgs) Handles btnAddID.Click
        Dim addmodifyID As New frmIDAddEdit
        addmodifyID.addID = True


        Dim result As DialogResult = addmodifyID.ShowDialog
        If result = Windows.Forms.DialogResult.OK Then

            ReloadIDS()

        End If


    End Sub

    Private Sub btnModifyID_Click(sender As Object, e As EventArgs) Handles btnModifyID.Click


        If lstIDS.SelectedIndex <> -1 Then
            Dim tempSelectedid As IDandValue


            tempSelectedid = CType(lstIDS.SelectedItem, IDandValue)


            Dim addmodifyid As New frmIDAddEdit

            addmodifyid.addID = False
            addmodifyid.editid = tempSelectedid


            Dim result As DialogResult = addmodifyid.ShowDialog



            If result = DialogResult.OK Then

                ReloadIDS()

            End If
        Else



        End If


    End Sub

    Private Sub Button_Save_Settings_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click
        Dim mystring As String = JsonConvert.SerializeObject(mymulti, Formatting.Indented)

        File.WriteAllText(configfile, mystring)
    End Sub

    Private Async Function CheckStatusAsync() As Task

        Try


            Dim client As New HttpClient

            Dim ipaddress As String = txtIpAddress.Text

            Dim foundID As Boolean = False



            Dim response = Await client.GetStringAsync("http://" & ipaddress & ":" & NUDPort.Value & "/debug/supernode_list/1")

            Dim mysupern As New Sup.SuperN


            mysupern = Sup.SuperN.FromJson(response)




            Dim nodecount As Integer = 0
            Dim inactive As Integer = 0
            Dim Tier4 As Integer = 0
            Dim tier3 As Integer = 0
            Dim tier2 As Integer = 0
            Dim tier1 As Integer = 0
            Dim tier0 As Integer = 0

            Dim currentheight As Long = mysupern.Result.Height

            txtCurrentHeight.Text = currentheight.ToString

            Dim TotalStaked As Long


            For Each a In mysupern.Result.Items




                If a.LastUpdateAge < 3600 Then

                    Select Case (a.StakeAmount / 10000000000)
                        Case 0 To 49999
                            tier0 += 1
                        Case 50000 To 89999
                            tier1 += 1
                        Case 90000 To 149999
                            tier2 += 1
                        Case 150000 To 249999
                            tier3 += 1
                        Case >= 250000
                            Tier4 += 1
                    End Select
                    TotalStaked += a.StakeAmount
                    nodecount += 1
                Else
                    If (a.StakeAmount / 10000000000) >= 50000 Then
                        inactive += 1

                    End If

                End If





                If a.PublicId = txtPubID.Text Then
                    Dim numofblocksleft As Integer = 0

                    txtStake.Text = (a.StakeAmount / 10000000000).ToString("N04")

                    txtLastUpdateAge.Text = a.LastUpdateAge


                    If a.ExpiringBlock = 0 And a.StakeExpiringBlock = 0 Then

                        lblBlocksLeft.Text = 0
                        txtExpirationtime.Text = "Not Staked"

                    Else

                        If a.ExpiringBlock > 0 Then

                            lblBlocksLeft.Text = a.ExpiringBlock - currentheight
                            numofblocksleft = a.ExpiringBlock - currentheight
                            txtExpiringBlock.Text = a.ExpiringBlock.ToString

                        Else
                            lblBlocksLeft.Text = a.StakeExpiringBlock - currentheight
                            numofblocksleft = a.StakeExpiringBlock - currentheight
                            txtExpiringBlock.Text = a.StakeExpiringBlock.ToString
                            txtAuthSample.Text = a.IsAvailableForAuthSample.ToString

                        End If





                        Dim mins As Integer = numofblocksleft * 2

                        Dim mydatetime As New DateTime

                        mydatetime = Now.AddMinutes(mins)

                        txtExpirationtime.Text = mydatetime



                    End If



                    foundID = True



                End If




            Next


            If foundID Then
                lblLostandFound.Text = "Found ID# " & txtPubID.Text.Substring(0, 5)
            Else
                lblLostandFound.Text = "ID was not found"
            End If


            txtTotalStaked.Text = (TotalStaked / 10000000000).ToString("N04")

            txtInactive.Text = inactive.ToString
            txttier1.Text = tier1.ToString
            txttier2.Text = tier2.ToString
            txttier3.Text = tier3.ToString
            txttier4.Text = Tier4.ToString


            Dim intTotalrunning As Integer = tier1 + tier2 + tier3 + Tier4

            txtTotalRunning.Text = intTotalrunning.ToString


            Dim tier1percent = tier1 / intTotalrunning
            Dim tier2percent = tier2 / intTotalrunning
            Dim tier3percent = tier3 / intTotalrunning
            Dim tier4percent = Tier4 / intTotalrunning





            Me.TierChart.Series("Tier").Points.Clear()


            Me.TierChart.Series("Tier").Points.AddXY("Tier 1 " & tier1percent.ToString("P"), tier1)


            Me.TierChart.Series("Tier").Points.AddXY("Tier 2 " & tier2percent.ToString("P"), tier2)

            Me.TierChart.Series("Tier").Points.AddXY("Tier 3 " & tier3percent.ToString("P"), tier3)

            Me.TierChart.Series("Tier").Points.AddXY("Tier 4 " & tier4percent.ToString("P"), Tier4)

            Me.TierChart.Series("Tier").IsValueShownAsLabel = True



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Function

    Private Async Sub btnCheckStatus_Click(sender As Object, e As EventArgs) Handles btnCheckStatus.Click

        lblBlocksLeft.Text = 0
        lblLostandFound.Text = "Status:"
        txtInactive.Text = ""
        txttier1.Text = ""
        txttier2.Text = ""
        txttier3.Text = ""
        txttier4.Text = ""
        txtStake.Text = ""
        txtTotalRunning.Text = ""
        txtExpiringBlock.Text = ""
        txtLastUpdateAge.Text = ""
        txtTotalStaked.Text = ""
        txtExpirationtime.Text = ""
        txtCurrentHeight.Text = ""
        txtAuthSample.Text = ""


        Me.TierChart.Series("Tier").Points.Clear()

        btnCheckStatus.Enabled = False


        Await CheckStatusAsync()
        btnCheckStatus.Enabled = True

    End Sub

    Private Sub StakeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StakeToolStripMenuItem.Click
        Dim myform As New frmStakeInfo


        If mymulti.IPS IsNot Nothing AndAlso mymulti.IPS.Count <> 0 Then

            myform.IPaddresses = mymulti.IPS

        End If



        myform.Show()
    End Sub
End Class