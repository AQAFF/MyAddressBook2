<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdbName = New System.Windows.Forms.RadioButton()
        Me.rdbGender = New System.Windows.Forms.RadioButton()
        Me.rdbRace = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKeyword = New System.Windows.Forms.TextBox()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.cboRace = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtRegNum = New System.Windows.Forms.TextBox()
        Me.txtPhoneNum = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.txtRace = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search for:"
        '
        'rdbName
        '
        Me.rdbName.AutoSize = True
        Me.rdbName.Location = New System.Drawing.Point(25, 80)
        Me.rdbName.Name = "rdbName"
        Me.rdbName.Size = New System.Drawing.Size(65, 20)
        Me.rdbName.TabIndex = 1
        Me.rdbName.TabStop = True
        Me.rdbName.Text = "Name"
        Me.rdbName.UseVisualStyleBackColor = True
        '
        'rdbGender
        '
        Me.rdbGender.AutoSize = True
        Me.rdbGender.Location = New System.Drawing.Point(25, 165)
        Me.rdbGender.Name = "rdbGender"
        Me.rdbGender.Size = New System.Drawing.Size(73, 20)
        Me.rdbGender.TabIndex = 2
        Me.rdbGender.TabStop = True
        Me.rdbGender.Text = "Gender"
        Me.rdbGender.UseVisualStyleBackColor = True
        '
        'rdbRace
        '
        Me.rdbRace.AutoSize = True
        Me.rdbRace.Location = New System.Drawing.Point(25, 213)
        Me.rdbRace.Name = "rdbRace"
        Me.rdbRace.Size = New System.Drawing.Size(61, 20)
        Me.rdbRace.TabIndex = 3
        Me.rdbRace.TabStop = True
        Me.rdbRace.Text = "Race"
        Me.rdbRace.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(145, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Type in keyword"
        '
        'txtKeyword
        '
        Me.txtKeyword.Location = New System.Drawing.Point(151, 125)
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.Size = New System.Drawing.Size(218, 22)
        Me.txtKeyword.TabIndex = 5
        '
        'cboGender
        '
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"male", "female"})
        Me.cboGender.Location = New System.Drawing.Point(151, 165)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(123, 24)
        Me.cboGender.TabIndex = 6
        '
        'cboRace
        '
        Me.cboRace.FormattingEnabled = True
        Me.cboRace.Items.AddRange(New Object() {"Malay", "Chinnese", "India ", "Others"})
        Me.cboRace.Location = New System.Drawing.Point(151, 213)
        Me.cboRace.Name = "cboRace"
        Me.cboRace.Size = New System.Drawing.Size(123, 24)
        Me.cboRace.TabIndex = 7
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(698, 26)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(698, 247)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Search Result(s)"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(25, 297)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(748, 150)
        Me.DataGridView1.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 471)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(198, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Highlight the preferred info :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(107, 509)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "ID :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(83, 534)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Name :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(0, 565)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Registration Number:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 594)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Phone Number:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(72, 623)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Address:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(139, 534)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(230, 22)
        Me.txtName.TabIndex = 19
        '
        'txtRegNum
        '
        Me.txtRegNum.Location = New System.Drawing.Point(139, 562)
        Me.txtRegNum.Name = "txtRegNum"
        Me.txtRegNum.Size = New System.Drawing.Size(230, 22)
        Me.txtRegNum.TabIndex = 20
        '
        'txtPhoneNum
        '
        Me.txtPhoneNum.Location = New System.Drawing.Point(139, 588)
        Me.txtPhoneNum.Name = "txtPhoneNum"
        Me.txtPhoneNum.Size = New System.Drawing.Size(230, 22)
        Me.txtPhoneNum.TabIndex = 21
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(139, 623)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(230, 81)
        Me.txtAddress.TabIndex = 22
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(684, 490)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 23
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(684, 531)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 24
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(612, 574)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(147, 22)
        Me.txtGender.TabIndex = 25
        '
        'txtRace
        '
        Me.txtRace.Location = New System.Drawing.Point(612, 623)
        Me.txtRace.Name = "txtRace"
        Me.txtRace.Size = New System.Drawing.Size(147, 22)
        Me.txtRace.TabIndex = 26
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(145, 509)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(55, 16)
        Me.lblID.TabIndex = 27
        Me.lblID.Text = "Label10"
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 729)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.txtRace)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtPhoneNum)
        Me.Controls.Add(Me.txtRegNum)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.cboRace)
        Me.Controls.Add(Me.cboGender)
        Me.Controls.Add(Me.txtKeyword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rdbRace)
        Me.Controls.Add(Me.rdbGender)
        Me.Controls.Add(Me.rdbName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSearch"
        Me.Text = "Search My Address Book"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents rdbName As RadioButton
    Friend WithEvents rdbGender As RadioButton
    Friend WithEvents rdbRace As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents txtKeyword As TextBox
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents cboRace As ComboBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtRegNum As TextBox
    Friend WithEvents txtPhoneNum As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtGender As TextBox
    Friend WithEvents txtRace As TextBox
    Friend WithEvents lblID As Label
End Class
