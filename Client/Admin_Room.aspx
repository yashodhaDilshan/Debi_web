<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Room.aspx.cs" Inherits="Debi_web.Admin_Room" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Rooms Infor</title>
        <link rel="stylesheet" href="css/Admin_Home.css"/> 
        <style>        

            #myTable { //border-collapse: collapse; width: 100%; border: 1px solid #ddd; font-size: 14px; }
            #myTable th, #myTable td { text-align: left; padding: 12px; }
            #myTable tr { border-bottom: 1px solid #ddd; }
            #myTable tr.header, #myTable tr:hover { background-color: #f1f1f1;}
            .textbox{width:300px; height: 30px; margin: 10px 30px 20px 20px; background-color: #04AA6D ; color:white; border:none }
            .textbox:hover{background-color:#06c05e;}

            .grid{ border-collapse:collapse;text-align:center}
            .grid td{padding:10px ;border:1px solid #c1c1c1;color:#444;font-size:1em;}
.           grid th{padding:4px 2px ; color:#707083; text-shadow:1px 1px 0px #ffffff;         
                  background: -weblit-gradient(linear,left bottom, left top,color-stop(0,#e5e5e9),color-stop(1,#fbfbfc));        
                  border:1px solid #c1c1c1;font-size:1em;text-align:center ;}            
            .grid th a{color:White;text-decoration:none  ; }
            .grid th a:hover{color:#444;text-decoration:none  ;}
            .grid .alt{background:linear-gradient(#fff,#e6e6e6);}
           
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="sidebar">
                <a class="active" href="Admin_Home.aspx">Home</a>
                <a href="Admin_Hotel.aspx">Hotels</a>
                <a>Rooms</a>
                <a href="Admin_User_Infor.aspx">Users</a>
                <a href="Home.aspx">Log out</a>
            </div>

            <div class="content">
                
                <div class="topnav">  
                    <a href="#">Room Menu</a>                    
                </div>

                <div style="margin-left:300px">
                    <asp:Button CssClass="textbox" ID="btnAddRoom" runat="server" Text="Add Room" OnClick="btnAddRoom_Click" />
                    <asp:Button CssClass="textbox" ID="btnUpdate" runat="server" Text="Update and Delete Room" OnClick="btnUpdate_Click" />
                    
                </div>
                
                <center><h1>Room Details</h1></center>
                
                <table>
                <tr><div class="datalist_name">
                    <td><div class="H_id"><center> Id </center></div></td>
                    <td><div class="H_Image"><center> Image </center></div></td>
                    <td><div class="H_Name"><center> Hotel Name </center></div></td>
                    <td><div class="H_District"><center> Room Type </center></div></td>
                    <td><div class="H_Email"><center> Price </center></div></td>
                    <td><div class="H_teNo"><center> City </center></div></td>
                    <td><div class="Address"><center> Country </center></div></td>                    
                    <td><div class="H_details"><center> Details</center></div></td>
                </div></tr>
                </table>

                <asp:DataList ID="DataList1" runat="server" RepeatColumns="1" RepeatDirection="Horizontal">
                    <ItemTemplate>
                        <table>
                        <tr><div class="datalist_main">
                         <td><div class="H_id"><center> <%#Eval("Room_Id") %> </center></div></td>
                            <td><div class="H_Image"><center> <img src='<%#Eval("image") %>' /> </center></div></td>
                            <td><div class="H_Name"><center> <%#Eval("Hotel_name") %> </center></div></td>
                            <td><div class="H_District"><center> <%#Eval("Room_Type") %> </center></div></td>
                            <td><div class="H_Email"><center>LKR <%#Eval("Price") %>  </center></div></td>
                            <td><div class="H_teNo"><center> <%#Eval("City") %> </center></div></td>
                            <td><div class="Address"><center> <%#Eval("Country") %> </center></div></td>                            
                            <td><div class="H_details"><center> <%#Eval("Details") %> </center></div></td>
                        </div></tr>
                      </table>
                    </ItemTemplate>
               </asp:DataList>

            </div><!--content-->

        </div>
    </form>
</body>

    <head>
        <style>

            .datalist_name{width:1280px; display:flex;  }

            .datalist_main{width:1280px; display:flex;  }
            .H_id{width:50px; }
            .H_Image{width:250px;  }
            .H_Image img{width:230px;}

            .H_Name{width:100px;  }
            .H_Email{width:150px; }

            .H_teNo{width:130px;  }
            .Address{width:140px;  }

            .H_District{width:130px;  }
            .H_details{width:280px; }

           

            table, th, td {
  border: 1px solid black;
  
}

        </style>
    </head>

</html>
