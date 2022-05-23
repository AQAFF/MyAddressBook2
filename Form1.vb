Public Class frmAddList
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtName.Text = ""
        txtRegNum.Text = ""
        txtPhoneNum.Text = ""
        txtAddress.Text = ""
        rdbMale.Checked = False
        lstRace.SelectedIndex = 0

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Selection()

        On Error Resume Next
        cmd.Connection = con
        cmd.Connection.Open()
        cmd.CommandText = "INSERT INTO AddressList (AddName, RegNum, PhoneNum, Address, Gender, Race)" _
            & " Values(" _
            & "'" & UCase(txtName.Text) & "'," _
            & "'" & UCase(txtRegNum.Text) & "'," _
            & "'" & txtPhoneNum.Text & "'," _
            & "'" & UCase(txtAddress.Text) & "'," _
            & "'" & UCase(gender) & "'," _
            & "'" & UCase(race) & "')"
        MessageBox.Show("Data Have Been Save", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MsgBox(cmd.CommandText)
        cmd.ExecuteNonQuery()
        UpdateSub()
        con.Close()

        txtName.Text = ""
        txtRegNum.Text = ""
        txtPhoneNum.Text = ""
        txtAddress.Text = ""
        rdbMale.Checked = True

        lstRace.SelectedIndex = 0
        txtName.Focus()

    End Sub

    Public Sub UpdateSub()
        On Error Resume Next
        ds.Clear()

        cmd = con.CreateCommand
        cmd.CommandText = "select * from addressList"

        da.SelectCommand = cmd

        da.Fill(ds, "AddressList")
        DataGridView1.DataSource = ds.Tables(0)

    End Sub

    Public Sub Selection()
        If rdbMale.Checked = True Then
            gender = "Male"
        Else
            gender = "Female"

        End If

        race = lstRace.SelectedItem

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        frmSearch.Show()
        Me.Hide()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmAddList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateSub()
    End Sub

    Private Sub lstRace_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRace.SelectedIndexChanged

    End Sub
End Class
