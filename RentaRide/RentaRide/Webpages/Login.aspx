<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RentaRide.Webpages.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <h1>Login Page </h1>
        <h4>Wala Pang Design at the momint</h4>
        <asp:Label ID="lbl_message" runat="server" Text="" color="red" ></asp:Label>
        <br/>
         <asp:Label ID="lbl_email" runat="server" Text="Email:"></asp:Label><asp:TextBox ID="txtbx_email" runat="server"></asp:TextBox>
        <br/>
         <asp:Label ID="lbl_password" runat="server" Text="Password:"></asp:Label><asp:TextBox ID="txtbx_password" runat="server" TextMode="Password"></asp:TextBox>
        <br/>
         <asp:Button ID="btn_login" runat="server" Text="Login" OnClick="btn_login_Click" />
    </div>
    </form>
</body>
</html>
