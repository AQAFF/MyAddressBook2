Public Class frmSearch
    Dim searchKey, sqlCond As String

    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtKeyword.Enabled = False
        cboGender.Enabled = False
        cboRace.Enabled = False

        btnUpdate.Enabled = False
        btnDelete.Enabled = False

    End Sub

    Public Sub UpdateSub()
        On Error Resume Next
        ds.Clear()

        cmd = con.CreateCommand
        cmd.CommandText = "select * from addressList"

        da.SelectCommand = cmd

        da.Fill(ds, "AddressList")
        lblID.DataBindings.Add("Text", ds.Tables("AddressList"), "ID")
        txtName.DataBindings.Add("Text", ds.Tables("AddressList"), "AddName")
        txtRegNum.DataBindings.Add("Text", ds.Tables("AddressList"), "RegNum")
        txtPhoneNum.DataBindings.Add("Text", ds.Tables("AddressList"), "PhoneNum")
        txtAddress.DataBindings.Add("Text", ds.Tables("AddressList"), "Address")
        txtGender.DataBindings.Add("Text", ds.Tables("AddressList"), "Gender")
        txtRace.DataBindings.Add("Text", ds.Tables("AddressList"), "Race")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub rdbName_CheckedChanged(sender As Object, e As EventArgs) Handles rdbName.CheckedChanged
        txtKeyword.Enabled = True
        cboGender.Enabled = False
        cboRace.Enabled = False
    End Sub

    Private Sub rdbGender_CheckedChanged(sender As Object, e As EventArgs) Handles rdbGender.CheckedChanged
        txtKeyword.Enabled = False
        cboGender.Enabled = True
        cboRace.Enabled = False
    End Sub

    Private Sub rdbRace_CheckedChanged(sender As Object, e As EventArgs) Handles rdbRace.CheckedChanged
        txtKeyword.Enabled = False
        cboGender.Enabled = False
        cboRace.Enabled = True
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmAddList.Show()
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        On Error Resume Next
        ds.Clear()

        cmd = con.CreateCommand
        cmd.CommandText = "select * from AddressList where " & sqlCond & " like " & searchKey & "'"
        da.SelectCommand = cmd

        da.Fill(ds, "AddressList")
        lblID.DataBindings.Add("Text", ds.Tables("AddressList"), "ID")
        txtName.DataBindings.Add("Text", ds.Tables("AddressList"), "AddName")
        txtRegNum.DataBindings.Add("Text", ds.Tables("AddressList"), "RegNum")
        txtPhoneNum.DataBindings.Add("Text", ds.Tables("AddressList"), "PhoneNum")
        txtAddress.DataBindings.Add("Text", ds.Tables("AddressList"), "Address")
        txtGender.DataBindings.Add("Text", ds.Tables("AddressList"), "Gender")
        txtRace.DataBindings.Add("Text", ds.Tables("AddressList"), "Race")
        DataGridView1.DataSource = ds.Tables(0)

        btnDelete.Enabled = True
        btnUpdate.Enabled = True
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        On Error Resume Next
        con.Open()
        cmd.CommandText = "UPDATE AddressList SET AddName = '" & UCase(txtName.Text) & "'," _
            & "RegNum = '" & UCase(txtRegNum.Text) & "'," _
            & "PhoneNum = '" & UCase(txtPhoneNum.Text) & "'," _
            & "Address = '" & UCase(txtAddress.Text) & "'," _
            & "Gender = '" & UCase(txtGender.Text) & "'," _
            & "Race = '" & UCase(txtRace.Text) & "'," _
            & "WHERE ID = " & lblID.Text

        cmd.Connection = con
        cmd.ExecuteNonQuery()
        con.Close()
        UpdateSub()

        MessageBox.Show("Information Update", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (MessageBox.Show("Are you sure you want to delete this record?", "DeleteRecord", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes) Then
            con.Open()
            Dim Del As OleDb.OleDbCommand = New OleDb.OleDbCommand()
            Del.CommandText = "Delete From AddressList Where ID = " & lblID.Text

            Del.Connection = con
            Del.ExecuteNonQuery()

            Me.BindingContext(ds.Tables("AddressList")).RemoveAt _
                (Me.BindingContext(ds.Tables("AddressList")).Position)
            con.Close()
            MessageBox.Show("Data Have Been Deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Me.Refresh()
        End If
    End Sub

    Private Sub SearchSelection()
        If rdbName.Checked = True Then
            searchKey = UCase(txtKeyword.Text)
            sqlCond = "AddName"
        ElseIf rdbGender.Checked = True Then
            searchKey = UCase(cboGender.SelectedItem)
            sqlCond = "Gender"
        Else
            searchKey = UCase(cboRace.SelectedItem)
            sqlCond = "Race"
        End If
    End Sub
End Class