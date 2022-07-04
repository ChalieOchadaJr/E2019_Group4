<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDashBoard.aspx.cs" Inherits="RentaRide.Webpages.AdminDashBoard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <div id="nav_con" class="nav_container">
     <div class="nav_wrapper">
    <nav>
        <div class="logo">
            RENTARIDE
        </div>
    <ul class="nav_items">
        <li ><a href="AdminDashBoard.aspx">DashBoard</a></li>
        <li ><a href="#">Cars</a></li>
        <li ><a href="#">Registed User</a></li>
        <li ><a href="#">Rents</a></li>
         <li ><a href="#">Return</a></li>
        <li><a href="#">Logout</a></li>
        </ul> 
        </nav>
      </div>
</div>   

    <div class ="header-container">
        <div class="head-wrap" >
    <header>
        <div class="header-message">
            <h1>Welcome To RESERVE Car Rentals!</h1>
            <p>We are based in Metro Manila.
                 We can assist you with all your car 
                rentals needs here in the Philippines.
            </p>
            <div class="header_btn">
            <a href="Webpages/Register.aspx">Reserve Now!</a>
                </div>
        </div>

        <div class="header-image">
            <img src="src/images/Default_Redcar.png" />
            <div class="header-image-bg">

            </div>
        </div>
    </header>
        </div>
</div>




    <h1>This is Admin Dashboard</h1>

    <p>Greetings Master </p>
    <asp:Label ID="lbl_admin" runat="server" Text=""></asp:Label>
</body>
</html>
