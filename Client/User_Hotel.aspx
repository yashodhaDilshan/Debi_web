<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User_Hotel.aspx.cs" Inherits="Debi_web.User_Hotel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="css/User_Home.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>
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
            height: 133px;
            width: 763px;
        }

        .auto-style5 {
            position: fixed;
            height: 134px;
            left: 475px;
            top: 70px;
            width: 769px;
        }
       .price{background-color: #04AA6D; color: white; width:120px; height:30px;  margin-left:286px; margin-top:-40px; padding-left:10px; padding-top:10px; font-weight:bold}

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

                <div class="content_top"><center>Hotels</center></div>
                <div class="content_top_2"></div>

                 <!----- Search ------>
                <div class="content_top2">
                    <asp:TextBox class="Search" ID="txtSearch" runat="server" placeholder="Search Room"></asp:TextBox>                    
                    <asp:Button CssClass="btnsearch" ID="Button2" runat="server" Text="Search" OnClick="Button2_Click" /><br />
                    
                    
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
                                        <li><h2><%#Eval("Hotel_Name") %> Hotel </h2>(<%#Eval("District") %>District) <div class="price"><i class="fa fa-phone" aria-hidden="true"></i> <%#Eval("Tele_no") %></div></li>    
                                         
                                        <li> <i class="fa fa-envelope" aria-hidden="true"></i> <%#Eval("Email") %> </li>
                                        
                                        <li><i class="fa fa-map-marker" aria-hidden="true"></i> <%#Eval("Address") %> </li>
                                        <li><div><%#Eval("Dictionary") %></div></li>                                       
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
