Imports System.Data.SqlClient
Module GlobalAB
    Public conn As SqlConnection
    Public connstr As String
    Public da As SqlDataAdapter
    Public cmd As SqlCommand
    Public query As String
    Public ds As DataSet
    Public datareader As SqlDataReader
    Public dc_1pk(0) As DataColumn
    Public dc_2pk(1) As DataColumn
    Public dr As DataRow
    Public cb As SqlCommandBuilder
    Public dt As New DataTable


    Sub koneksi()
        connstr = "Data Source = WIN7-PC\SQLEXPRESS; Initial Catalog = dbtry; Integrated Security = True"
        conn = New SqlConnection(connstr)
        conn.Open()
    End Sub

    Sub load_data_1pk(tabel As String)
        ds = New DataSet
        query = "Select * From " & tabel
        cmd = New SqlCommand(query, conn)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds, tabel)
        dc_1pk(0) = ds.Tables(tabel).Columns(0)
        ds.Tables(tabel).PrimaryKey = dc_1pk
    End Sub

    Sub load_data_2pk(tabel As String)
        ds = New DataSet
        query = "Select * From " & tabel
        cmd = New SqlCommand(query, conn)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds, tabel)
        dc_2pk(0) = ds.Tables(tabel).Columns(0)
        dc_2pk(1) = ds.Tables(tabel).Columns(1)
        ds.Tables(tabel).PrimaryKey = dc_2pk
    End Sub

    Sub update_data(tabel As String)
        cb = New SqlCommandBuilder(da)
        da = cb.DataAdapter
        da.Update(ds.Tables(tabel))
    End Sub
End Module
