<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Hotel.aspx.cs" Inherits="Debi_web.Admin_Hotel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hotel Infor</title>
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
                <a>Hotels</a>
                <a href="Admin_Room.aspx">Rooms</a>
                <a href="Admin_User_Infor.aspx">Users</a>
                <a href="Home.aspx">Log out</a>
            </div>

            <div class="content">
                
                <div class="topnav">  
                    <a href="#">Hotel Menu</a>
                    
                </div>

                <div style="margin-left:300px" class="auto-style1">
                    <asp:Button CssClass="textbox" ID="btnAddHotel" runat="server" Text="Add Hotel" OnClick="btnAddHotel_Click" />
                    <asp:Button CssClass="textbox" ID="btnUpdate" runat="server" Text="Update and Delete Hotel" OnClick="btnUpdate_Click" />                  
                    
                </div>

                <center><h1>Hotel Details</h1></center>
                
                <table>
                <tr><div class="datalist_name">
                    <td><div class="H_id"><center> Id </center></div></td>
                    <td><div class="H_Image"><center> Image </center></div></td>
                    <td><div class="H_Name"><center> Hotel Name </center></div></td>
                    <td><div class="H_Email"><center> Email </center></div></td>
                    <td><div class="H_teNo"><center> Telephone No </center></div></td>
                    <td><div class="Address"><center> Address </center></div></td>
                    <td><div class="H_District"><center> District </center></div></td>
                    <td><div class="H_details"><center> Details</center></div></td>
                </div></tr>
                </table>

                <asp:DataList ID="DataList1" runat="server" RepeatColumns="1" RepeatDirection="Horizontal">
                    <ItemTemplate>
                        <table>
                        <tr><div class="datalist_main">
                         <td><div class="H_id"><center> <%#Eval("Hotel_Id") %> </center></div></td>
                            <td><div class="H_Image"><center> <img src='<%#Eval("image") %>' /> </center></div></td>
                            <td><div class="H_Name"><center> <%#Eval("Hotel_Name") %> </center></div></td>
                            <td><div class="H_Email"><center> <%#Eval("Email") %>  </center></div></td>
                            <td><div class="H_teNo"><center> <%#Eval("Tele_no") %> </center></div></td>
                            <td><div class="Address"><center> <%#Eval("Address") %> </center></div></td>
                            <td><div class="H_District"><center> <%#Eval("District") %> </center></div></td>
                            <td><div class="H_details"><center> <%#Eval("Dictionary") %> </center></div></td>
                        </div></tr>
                      </table>
                    </ItemTemplate>
               </asp:DataList>


            

            
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
            .H_Email{width:200px; }

            .H_teNo{width:130px;  }
            .Address{width:140px;  }

            .H_District{width:130px;  }
            .H_details{width:230px; }

           

            table, th, td {
  border: 1px solid black;
  
}

        </style>
    </head>
</html>

