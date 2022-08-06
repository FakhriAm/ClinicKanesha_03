Imports System.Data.Odbc
Module ConnectDB
    Public Conn As OdbcConnection
    Public Da As OdbcDataAdapter
    Public Ds As DataSet
    Public Rd As OdbcDataReader
    Public Cmd As OdbcCommand
    Public MyDB As String
    Public Sub Connect_DB()
        MyDB = "Driver={MySQL ODBC 8.0 ANSI Driver};Database=clinic_kanesha;server=localhost;uid=root;"
        Conn = New OdbcConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub
End Module
