<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="RentaRide.Webpages.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../CSS/Register.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <div class="nav-container">

        <div class="nav-wrapper">
            <nav>
                <div class="nav-logo">
                    RENTARIDE
                </div>
                <div class="nav-items">
                    <ul>
                               
                         <li><a href=>Go Back</a></li>
                        
                    </ul>
                </div>


            </nav>
            </div>
    </div>

<div class="header-container">
    <div class="header-wrapper">
        <header>
            <div class="header-message">
                <h1>Sign Up</h1>
                <p>Already have account? <a href="Login.aspx">Login Here</a></p>
            </div>

            <form id="formreg" runat="server">       
                    <asp:Label ID="lbl_username" runat="server" Text="Username"></asp:Label>
                    <asp:TextBox ID="txtbx_username" runat="server"></asp:TextBox>
                    <br/>
                    <br/>
                    <asp:Label ID="lbl_Name" runat="server" Text="Name"></asp:Label>
                    <asp:TextBox ID="txtbx_Name" runat="server"></asp:TextBox>
                    <br/>
                    <br/>
                    <asp:Label ID="lbl_contact" runat="server" Text="Contact"></asp:Label>
                    <asp:TextBox ID="txtbx_contact" runat="server"></asp:TextBox>
                        <br/>
                    <br/>
                    <asp:Label ID="lbl_email" runat="server" Text="Email"></asp:Label>
                    <asp:TextBox ID="txtbx_email" runat="server"></asp:TextBox>
                    <br/>
                    <br/>
                    <asp:Label ID="lbl_password" runat="server" Text="Password"></asp:Label>
                    <asp:TextBox ID="txtbx_password" runat="server"></asp:TextBox>
                    <br/>
                    <br/>
                    <asp:Label ID="lbl_conpass" runat="server" Text="Confirm Password"></asp:Label>
                    <asp:TextBox ID="txtbx_conpass" runat="server"></asp:TextBox>
                    <br/>
                    <br/>
                    <asp:CheckBox ID="chk_agree" runat="server" text="By Signing up you agree to recieve updates and special Offers."/>
                    <br/>
                    <br/>
                    <asp:Button ID="btn_Register" runat="server" Text="Register" OnClick="btn_register_Click" type="input" />
            </form>
        </header>
    </div>
</div>




</body>
</html>
