﻿Imports System.Data.SqlClient
Module koneksi
    Dim conn As SqlConnection = New SqlConnection("Server=NOX; Database=Laundry; Integrated Security=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dt As DataTable

    Function aksi(ByVal query As String) As Boolean
        conn.Open()
        cmd = New SqlCommand(query, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        Return True
    End Function
    Function read(ByRef query As String) As DataTable
        conn.Open()
        da = New SqlDataAdapter(query, conn)
        dt = New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt


    End Function

End Module
