Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports System.Data.SqlClient
Partial Class _Default
    Inherits System.Web.UI.Page
    Dim ModelBarang As New ModelBarang
    Dim ModelDetail As New ModelDetailPembelian
    Dim ModelPesanan As New ModelPesanan
    Dim ModelPembayaran As New ModelPembayaran
    Dim koneksi As New Koneksi
    Dim idPesanan As Integer
    Dim idPembayaran As Integer
    Dim idBarang As Integer
    Dim namaBarang As String
    Dim hargaBarang As Integer
    Dim jumlahBarang As Integer
    Dim uangPembeli As Integer
    Dim totalHarga As Integer
    Dim stokBarang As Integer
    Dim sqlQuery As String
    Dim sqlQuery2 As String
    Public Sub updateTable()
        Dim conn As New MySqlConnection("server=localhost;user id=root;database=dotnet")

        Dim adapter As New MySqlDataAdapter("select * from barang", conn)
        Dim table As New DataTable
        adapter.Fill(table)
        GridView1.DataSource = table
        GridView1.DataBind()


    End Sub
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        updateTable()
    End Sub



    Protected Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        namaBarang = TextBox2.Text
        hargaBarang = TextBox3.Text
        stokBarang = TextBox4.Text

        ModelBarang.addBarang(namaBarang, stokBarang, hargaBarang)


        updateTable()
    End Sub

    Protected Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        idBarang = Integer.Parse(TextBox1.Text)
        ModelDetail.nullBarang(idBarang)
        ModelBarang.deleteBarang(idBarang)

        updateTable()
    End Sub

    Protected Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        Dim Index As Integer
        namaBarang = TextBox2.Text
        Index = ModelBarang.search(namaBarang)
        If Index > 0 Then
            Response.Write("<script type='text/javascript' language='javascript'> alert('Ditemukan')</script>")
        Else
            Response.Write("<script type='text/javascript' language='javascript'> alert('Tidak Ditemukan')</script>")

        End If
    End Sub
End Class
