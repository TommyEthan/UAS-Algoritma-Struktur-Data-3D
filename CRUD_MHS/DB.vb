Imports MySql.Data.MySqlClient
Namespace DB
    Module DB
        Public conn As New MySqlConnection
        Public dataTable As New DataTable
        Public dataAdapter As New MySqlDataAdapter
        Public reader As MySqlDataReader
        Public cmd As MySqlCommand
        Public dataSet As New DataSet
        Public query As String

        'CONFIG
        Public server As String = "127.0.0.1"
        Public port As String = "3306"
        Public username As String = "root"
        Public password As String = ""
        Public database As String = "dbmahasiswa"

        Public Sub MyDNS()
            conn.ConnectionString = "server=" & server & ";port=" & port & ";userid=" & username & ";password=" & password & ";database=" & database
        End Sub
        Sub ConnectionChecking()
            Try
                Call MyDNS()
                conn.Open()
                Call QueryData("SELECT * FROM tmahasiswa")
                MsgBox("Connection Success!", MsgBoxStyle.Information, "Status")
            Catch ex As MySQLException
                MsgBox(ex.ToString, MsgBoxStyle.Exclamation, "Fatal Error!")
            Finally
                conn.Close()
                conn.Dispose()
            End Try
        End Sub

        Public Function QueryData(sql)
            dataSet = New DataSet
            query = sql
            dataAdapter = New MySqlDataAdapter(query, conn)
            Return dataAdapter.Fill(dataSet)
        End Function
    End Module
End Namespace
