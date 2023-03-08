<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User_Room.aspx.cs" Inherits="Debi_web.User_Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/User_Home.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link href="css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <script src="js/bootstrap.min.js" type="text/javascript"></script>
    <script src="js/jquery-1.11.1.min.js" type="text/javascript"></script>
    
    <style type="text/css">
        .auto-style1 {
            margin-top: 13px;
            margin-left: 578px;
            font-size: 17px;
            width: 104px;
        }
        .auto-style2 {
            margin-left: 30px;
            font-size: 25px;
            margin-top: 9px;
            font-family: Sans-serif;
        }    
        .auto-style4 {
            height: 174px;
            width: 740px;
        }

        .auto-style5 {
            position: fixed;
            height: 173px;
            left: 475px;
            top: 70px;
            width: 784px;
        }
       

    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div class="Wrap_div">

            <div class="navbar">                
                <a class="auto-style2" href="#"> DEBI Hotel Room </a>
                <a class="auto-style1" href="Home.aspx"><i class="fa fa-fw fa-user"></i> Log Out</a>
            </div>

            <!-- The sidebar -->
            <div class="sidebar">  
                <a class="active" style="font-weight:bold "> Navigations</a>
                <a href="User_Room.aspx">Rooms</a>
                <a href="User_Hotel.aspx">Hotels</a>
                <a href="#about">Contact</a>
                <a href="#about">About</a>
            </div>

            <!-- Page content -->
            <div class="content">

          <div style="background-color:white; background-color:white; " class="auto-style5">

                <div class="content_top"><center>Rooms</center></div>
                <div class="content_top_2"></div>

                 <!----- Search ------>
                <div class="content_top2">
                    <asp:TextBox class="Search" ID="txtSearch" runat="server" placeholder="Search Room"></asp:TextBox>                    
                    <asp:Button CssClass="btnsearch" ID="Button2" runat="server" Text="Search" OnClick="Button2_Click" /><br />
                    <div class="Checkbox">
                        <ul>
                            <li><asp:CheckBox ID="CheckBox1" Text=" Standard" runat="server" /> </li>
                            <li><asp:CheckBox ID="CheckBox2" Text=" Deluxe" runat="server" /> </li>
                            <li><asp:CheckBox ID="CheckBox3" Text=" Suite" runat="server" /> </li>
                            <li><asp:Button CssClass="filter" ID="Filter" runat="server" Text="Filter" OnClick="Filter_Click" /></li>
                        </ul>
                       
                    </div>
                    
                </div>
                <div class="content_top_3"></div>
           </div>
        <div style="background-color:white; background-color:white; " class="auto-style4">
        </div>
                
                <!----- DataList1 ------>
                <div style="margin-top:20px">
                    <asp:DataList ID="DataList1" runat="server" CssClass="row" RepeatColumns="1" RepeatDirection="Horizontal">
                        <ItemTemplate>
                            <div class="row productList" style="display:flex">
                                <div class="col-4" style="float:left">
                                    <img alt="" width="250" src='<%#Eval("image") %>' />
                                </div>
                                <div class="col-8" style="float:right; width:400px; margin-left:30px">
                                    <ul>
                                        <li><h2><%#Eval("Room_Type") %> Room </h2>(<%#Eval("City") %>City) <div class="price">LKR <%#Eval("Price") %></div></li>    
                                         
                                        <li><h3><%#Eval("Hotel_name") %> Hotel</h3></li>
                                        <li><h4><%#Eval("Country") %> </h4></li>
                                        <li><div><%#Eval("Details") %></div></li>                                       
                                    </ul>                              
                                </div>
                            </div> 
                        </ItemTemplate>
                    </asp:DataList>
                </div>
             </div>
        </div>
    </form>
</body>
</html>
