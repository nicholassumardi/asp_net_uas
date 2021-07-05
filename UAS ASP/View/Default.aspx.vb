
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

    Protected Sub Checkout_Click(sender As Object, e As EventArgs) Handles Checkout.Click
        idBarang = Integer.Parse(TextBox1.Text)
        hargaBarang = Integer.Parse(TextBox3.Text)
        jumlahBarang = Integer.Parse(TextBox4.Text)

        Dim totalHagraKeseluruhan As Integer
        totalHagraKeseluruhan = jumlahBarang * hargaBarang
        Dim newstok As Integer
        newstok = Integer.Parse(ModelBarang.getStok(idBarang)) - jumlahBarang

        ModelBarang.updateStok(newstok, idBarang)
        ModelPesanan.addPesanan()
        idPesanan = Integer.Parse(ModelPesanan.getID())


        ModelDetail.insertData(idPesanan, idBarang, jumlahBarang, totalHagraKeseluruhan)
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        updateTable()
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged

        Dim selectedrow As GridViewRow = GridView1.SelectedRow
        TextBox1.Text = selectedrow.Cells(0).Text
        TextBox2.Text = selectedrow.Cells(1).Text
        TextBox3.Text = selectedrow.Cells(2).Text
    End Sub
End Class
