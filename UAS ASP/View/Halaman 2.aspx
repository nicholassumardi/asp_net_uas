<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Halaman 2.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Halaman Inventaris</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <style type="text/css">
       
    </style>
</head>
<body style="background-color:navajowhite">
    <h1 class="text-center" style="font-family:'Segoe UI';">Halaman Inventaris</h1>
    <form id="form1" runat="server">
        <div class="container justify-content-center">
        <div class="form-group">
            
            <b>  <asp:Label  Text="ID :" runat="server" /></b> 
            <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server"></asp:TextBox> <br />
            
            <b> <asp:Label CssClass="label2" Text="Nama Barang :" runat="server" /></b>
            <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server"></asp:TextBox> <br />

            <b><asp:Label CssClass="label3" Text="harga :" runat="server" /></b>
            <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server"></asp:TextBox> <br />

            <b><asp:Label CssClass="label4" Text="Stok :" runat="server" /> </b> 
            <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server"></asp:TextBox> <br /> <br />
           <div class="container text-center mb-5">
            <asp:Button CssClass="btn btn-outline-success" Text="Search" runat="server" Width="187px" ID="Search" /> 
            <asp:Button CssClass="btn btn-outline-success" Text="Add" runat="server" Width="185px" ID="Add" />
            <asp:Button CssClass="btn btn-outline-danger" Text="Delete" runat="server" Width="185px" ID="Delete" /> 
            <a href="Default.aspx" class="btn btn-outline-danger">Halaman Checkout</a>
            <a href="Halaman 3.aspx" class="btn btn-outline-danger">Halaman Bayar </a>
            </div>
        </div>
        <div class="mb-5">
            <asp:GridView runat="server" ID="GridView1" CellPadding="4" ForeColor="#333333" GridLines="None" Height="582px" Width="1293px">
                <AlternatingRowStyle BackColor="White" />
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                <SortedDescendingHeaderStyle BackColor="#820000" />
            </asp:GridView>
        </div>
      </div>  
    </form>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.2/dist/umd/popper.min.js" integrity="sha384-IQsoLXl5PILFhosVNubq5LC7Qb9DXgDA9i+tQ8Zj3iwWAwPtgFTxbJ8NT4GN1R8p" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.min.js" integrity="sha384-cVKIPhGWiC2Al4u+LWgxfKTRIcfu0JTxR+EQDz/bgldoEyl4H0zUF0QKbrJ0EcQF" crossorigin="anonymous"></script>
</body>
</html>
