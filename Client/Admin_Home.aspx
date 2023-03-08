<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Home.aspx.cs" Inherits="Debi_web.AdminHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link rel="stylesheet" href="css/Admin_Home.css"/>    

</head>
<body>
    <form id="form1" runat="server">
        <div>           
            <div class="sidebar">
                <a class="active">Home</a>
                <a href="Admin_Hotel.aspx">Hotels</a>
                <a href="Admin_Room.aspx">Rooms</a>
                <a href="Admin_User_Infor.aspx">Users</a>
                <a href="Home.aspx">Log out</a>
            </div>

            <div class="content">
                
                <div class="topnav">  
                    <a href="Admin_Hotel_Reg.aspx">Add Hotel</a>
                    <a href="Admin_Room_Add.aspx">Add Room</a>
                    <a href="Admin_Register.aspx">Add Admin</a>
                </div>

                <div class="container">
                    <img src="image/bed1.jpg" alt="Norway" style="width:100%;">
                    <div class="text-block">                        
                        <p class="para">Welcome Admin</p>                        
                    </div>
                </div>
            </div>

        </div>
    </form>
</body>
</html>
