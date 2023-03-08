<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_User_Infor.aspx.cs" Inherits="Debi_web.Admin_User_Infor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

     <link rel="stylesheet" href="css/Admin_Home.css"/> 
     <style>        

        #myTable { //border-collapse: collapse; width: 100%; border: 1px solid #ddd; font-size: 14px; }
        #myTable th, #myTable td { text-align: left; padding: 12px; }
        #myTable tr { border-bottom: 1px solid #ddd; }
        #myTable tr.header, #myTable tr:hover { background-color: #f1f1f1;}
        .textbox{width:300px; height: 30px; margin: 10px 30px 20px 20px; background-color: #04AA6D ; color:white; border:none}
        .textbox:hover{background-color:#06c05e;}

        .grid{ border-collapse:collapse;text-align:center}
        .grid td{padding:10px ;border:1px solid #c1c1c1;color:#444;font-size:1em;}
.       grid th{padding:4px 2px ; color:#707083; text-shadow:1px 1px 0px #ffffff;         
                  background: -weblit-gradient(linear,left bottom, left top,color-stop(0,#e5e5e9),color-stop(1,#fbfbfc));        
                  border:1px solid #c1c1c1;font-size:1em;text-align:center ;}            
        .grid th a{color:White;text-decoration:none  ; }
        .grid th a:hover{color:#444;text-decoration:none  ;}
        .grid .alt{background:linear-gradient(#fff,#e6e6e6);}

        .auto-style1 {
            width: 711px;
            height: 58px;
        }
     </style>

</head>
<body>
    <form id="form1" runat="server">
        <div>

             <div class="sidebar">
                <a class="active" href="Admin_Home.aspx">Home</a>
                <a href="Admin_Hotel.aspx">Hotels</a>
                <a href="Admin_Room.aspx">Rooms</a>
                <a>Users</a>
                 <a href="Home.aspx">Log out</a>
            </div>

            <div class="content">
                
                <div class="topnav">  
                    <a href="#">Users Menu</a>                    
                </div>

                <div style="margin-left:300px" class="auto-style1">
                    <asp:Button CssClass="textbox" ID="Button1" runat="server" Text="Add User" OnClick="Button1_Click" />
                    <asp:Button CssClass="textbox" ID="Button2" runat="server" Text="Add Admin" OnClick="Button2_Click" />
                </div>
                
                <center><h1>Users Details</h1></center>

                <div>
                    <asp:GridView CssClass="grid" ID="dgUsers" runat="server" Height="322px" Width="1265px"></asp:GridView>
                    <asp:Label ID="lblmessage" runat="server" Text=""></asp:Label>
                </div>

            </div><!--content-->


        </div>
    </form>
</body>
</html>
