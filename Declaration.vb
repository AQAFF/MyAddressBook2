Module Declaration
    Public ds As New DataSet
    Public cmd As New OleDb.OleDbCommand
    Public da As New OleDb.OleDbDataAdapter
    Public con As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\TUF\Desktop\dbAddressList.mdb")
    Public gender As String
    Public race As String
End Module
