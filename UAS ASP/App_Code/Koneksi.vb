Imports Microsoft.VisualBasic
Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports System.Data.SqlClient
Public Class Koneksi
    Public sqlKoneksi As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Public sqlRead As MySqlDataReader
    Dim sqlAdapter As New MySqlDataAdapter
    Public sqlresult As String

    Public Function koneksi() As Boolean

        Dim result As Boolean
        sqlKoneksi.ConnectionString = "server=localhost;user id=root;database=dotnet"
        Try
            Console.WriteLine("Connecting to MySQL...")
            sqlKoneksi.Open()
            result = True
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            result = False
        End Try
        Return result
    End Function


    Public Function getData(sqlQuery As String) As MySqlDataReader
        sqlCmd.Connection = sqlKoneksi
        sqlCmd.CommandText = sqlQuery

        sqlRead = sqlCmd.ExecuteReader
        Return sqlRead


    End Function

    Public Function getSingle(sqlQuery As String) As Integer

        sqlCmd.Connection = sqlKoneksi
        sqlCmd.CommandText = sqlQuery

        sqlresult = sqlCmd.ExecuteScalar
        Dim data As Integer
        data = Integer.Parse(sqlresult)
        Return data


    End Function


    Public Function getSingleString(sqlQuery As String) As String
        sqlCmd.Connection = sqlKoneksi
        sqlCmd.CommandText = sqlQuery

        sqlresult = sqlCmd.ExecuteScalar
        Dim data As String
        data = ToString(sqlresult)
        Return data


    End Function

End Class
