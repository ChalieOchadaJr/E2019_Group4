<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="RentaRide.Webpages.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <h1>Register Page </h1>
        <h4>Wala Pang Design at the momint</h4>
        <br/>

        <asp:Label ID="lbl_name" runat="server" Text="Name"></asp:Label>

        <asp:TextBox ID="txtbx_fname" runat="server" ></asp:TextBox>
        <asp:TextBox ID="txtbx_mname" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtbx_lname" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtbx_nsuffix" runat="server"></asp:TextBox>
        <br/>
         <asp:Label ID="lbl_contact" runat="server" Text="Contacts:"></asp:Label><asp:TextBox ID="txtbx_contact" runat="server"></asp:TextBox>
        <br/>
         <asp:Label ID="lbl_email" runat="server" Text="Email:"></asp:Label><asp:TextBox ID="txtbx_email" runat="server"></asp:TextBox>
        <br/>
         <asp:Label ID="lbl_password" runat="server" Text="Password:"></asp:Label>&nbsp;
        <asp:TextBox ID="txtbx_password" runat="server" TextMode="Password"></asp:TextBox>
        <br/>
         <asp:Label ID="lbl_confirmPassword" runat="server" Text="Confirm Password:"/><asp:TextBox ID="txtbx_confirmPassword" runat="server" TextMode="Password"></asp:TextBox>

        <br/>
        <asp:Button ID="btn_register" runat="server" Text="Register" OnClick="btn_register_Click" />
    </div>
    </form>
</body>
</html>
