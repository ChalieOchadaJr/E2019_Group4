<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cars.aspx.cs" Inherits="RentaRide.Webpages.Admin.Cars" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="form-group">
        <asp:Label ID="lbl_plateno" runat="server" Text="Plate Number"></asp:Label>
        <asp:TextBox ID="txtbx_plateno" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Label ID="lbl_brand" runat="server" Text="Car Brand"></asp:Label>
        <asp:TextBox ID="txtbx_brand" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Label ID="lbl_model" runat="server" Text="Model"></asp:Label>
        <asp:TextBox ID="txtbx_model" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Label ID="lbl_color" runat="server" Text="Color"></asp:Label>
        <asp:TextBox ID="txtbx_color" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Label ID="lbl_capacity" runat="server" Text="Capacity"></asp:Label>
        <asp:TextBox ID="txtbx_capacity" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Label ID="lbl_price" runat="server" Text="Price"></asp:Label>
        <asp:TextBox ID="txtbx_price" runat="server"></asp:TextBox>
    </div>
        <div class="from-group">


        </div>

    </form>
    @renderpage();
</body>
</html>
