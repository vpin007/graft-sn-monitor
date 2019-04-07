Public Class frmIPAddEdit
    Public addIP As Boolean

    Public editipandport As IPsandports



    Private Sub frmIPAddEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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


        If addIP Then

            Me.Text = "Add Ip"
            NUDPort.Value = 18690

        Else
            Me.Text = "Edit Ip"

            txtIpaddress.Text = editipandport.IPAddress
            txtName.Text = editipandport.Name
            NUDPort.Value = editipandport.Port





        End If



    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If addIP Then
            If txtName.Text <> "" AndAlso txtIpaddress.Text <> "" Then
                Dim tempIP As New IPsandports

                tempIP.Name = txtName.Text
                tempIP.IPAddress = txtIpaddress.Text
                tempIP.Port = NUDPort.Value


                frmSupernode2.mymulti.IPS.Add(tempIP)
                Me.DialogResult = DialogResult.OK

            Else

                MessageBox.Show("Please Enter Name and Ip Address")



            End If




        Else
            If txtName.Text <> "" AndAlso txtIpaddress.Text <> "" Then
                frmSupernode2.mymulti.IPS.Item(frmSupernode2.lstIPs.SelectedIndex).Name = Me.txtName.Text.ToString
                frmSupernode2.mymulti.IPS.Item(frmSupernode2.lstIPs.SelectedIndex).IPAddress = Me.txtIpaddress.Text.ToString
                frmSupernode2.mymulti.IPS.Item(frmSupernode2.lstIPs.SelectedIndex).Port = Me.NUDPort.Value
                Me.DialogResult = DialogResult.OK

            Else
                MessageBox.Show("Please Enter Name and Ip Address")


            End If



        End If






    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class