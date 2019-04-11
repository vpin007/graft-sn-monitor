Public Class frmIDAddEdit

    Public addID As Boolean
    Public editid As IDandValue
    Private Sub frmIDAddEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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



        If addID Then

            Me.Text = "Add ID"


        Else


            Me.Text = "Edit ID"

            txtName.Text = editid.Name
            txtPubid.Text = editid.ID






        End If


    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If addID Then
            Dim tempID As New IDandValue

            tempID.Name = txtName.Text
            tempID.ID = txtPubid.Text



            frmSupernode2.mymulti.IDS.Add(tempID)
            Me.DialogResult = DialogResult.OK

        Else
            frmSupernode2.mymulti.IDS.Item(frmSupernode2.lstIDS.SelectedIndex).Name = Me.txtName.Text
            frmSupernode2.mymulti.IDS.Item(frmSupernode2.lstIDS.SelectedIndex).ID = Me.txtPubid.Text

            Me.DialogResult = DialogResult.OK



        End If



    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class