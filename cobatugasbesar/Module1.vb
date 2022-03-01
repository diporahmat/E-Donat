Imports System.Data.OleDb
Module Module1
    Public conn As OleDbConnection
    Public cmd As OleDbCommand
    Public RD As OleDbDataReader
    Public DA As OleDbDataAdapter
    Public DS As DataSet
    Public str As String

    Sub koneksi()
        str = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\donat.mdb"
        conn = New OleDbConnection(str)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
