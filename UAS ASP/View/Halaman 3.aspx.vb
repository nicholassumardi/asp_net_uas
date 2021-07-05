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
    Public Sub updatetable()
        Dim conn As New MySqlConnection("server=localhost;user id=root;database=dotnet")

        Dim adapter As New MySqlDataAdapter("select a.id_pesanan, c.namabarang, a.qtytotal, a.totalharga
                             from detailpembelian a
                             inner Join pesanan b on a.id_pesanan = b.id_pesanan
                             inner Join barang c on a.id_barang = c.id_barang
                             ORDER BY id_pesanan ASC", conn)
        Dim table As New DataTable
        adapter.Fill(table)
        GridView1.DataSource = table
        GridView1.DataBind()

    End Sub
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        updateTable()
    End Sub


    Protected Sub Bayar_Click(sender As Object, e As EventArgs) Handles Bayar.Click
        uangPembeli = Integer.Parse(TextBox3.Text)
        totalHarga = Integer.Parse(TextBox2.Text)
        idPesanan = Integer.Parse(ModelPesanan.getID())
        idPembayaran = Integer.Parse(ModelPembayaran.getID())
        Dim Kembalian As Integer
        Kembalian = uangPembeli - totalHarga
        ModelPembayaran.addPembayaran(uangPembeli, Kembalian, idPesanan)
        ModelPesanan.insertIdBayar(idPesanan, idPembayaran)
        Response.Write("<script type='text/javascript' language='javascript'> alert('" & Kembalian & "')</script>")
    End Sub
End Class
