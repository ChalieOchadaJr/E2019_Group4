<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="RentaRide.Webpages.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
   <p>Admin Login</p>
        <asp:Label ID="lbl_user" runat="server" Text="Username:"></asp:Label>
        <asp:TextBox ID="txtbx_username" runat="server"></asp:TextBox>
        <br/>
        <asp:Label ID="lbl_pass" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="txtbx_password" runat="server" TextMode="Password"></asp:TextBox>
        <br/>
        <asp:Label ID="lbl_message" runat="server" Text=""></asp:Label>
        <br/>
        <asp:Button ID="btn_Login" runat="server" Text="Button" OnClick="btn_Login_Click" />

    </div>
        </form>

</body>

 

</html>
