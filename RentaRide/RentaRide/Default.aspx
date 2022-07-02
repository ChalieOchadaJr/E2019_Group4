<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RentaRide.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link href="CSS/Default.css" rel="stylesheet" />
    <title>RentaRide</title>
</head>
<body>
 <div id="nav_con" class="nav_container">
     <div class="nav_wrapper">
    <nav>
        <div class="logo">
            RENTARIDE
        </div>
    <ul class="nav_items">
        <li style="display:inline;" id="list"><a href="Default.aspx">Home</a></li>
        <li style="display:inline;" id="list a"><a href="Webpages/Service.aspx">Service</a></li>
        <li style="display:inline;" id="list b"><a href="Webpages/About.aspx">About Us</a></li>
        <li style="display:inline;" id="list c"><a href="Webpages/Login.aspx">Login</a></li>
         <li style="display:inline;"id="list d"><a href="Webpages/Register.aspx">Register</a></li>
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
<script src="Scripts/Default.js"></script>
</body>
</html>
