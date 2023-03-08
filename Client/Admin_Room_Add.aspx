<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Room_Add.aspx.cs" Inherits="Debi_web.Admin_Room_Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Room Add</title>

    <style>
        .box{ width:400px; background-color:antiquewhite; margin-left:auto; margin-right:auto; margin-top:100px}
        .Form{ width:300px; height:400px; margin-left:auto; margin-right:auto}
        .textbox{ margin-bottom:10px;  width:200px; height:23px; border-radius: 3px; background-color: rgba(0, 0, 0, 0.76); color:white}
        .File{ color:rgba(245, 232, 232, 0.59); background-color: rgba(0, 0, 0, 0.76); width:200px }
        .button{margin-top:20px; width:200px; height:30px;  background-color: rgba(0, 0, 0, 0.89); color:rgba(245, 232, 232, 0.89)}
        .auto-style1 { margin-bottom: 10px; margin-bottom:10px;  width:200px; height:23px; border-radius: 3px; background-color: rgba(0, 0, 0, 0.76);  color:white }

        /* ------------------------- Main Image  ------------------------- */
        .container { position: relative; width:1000px; margin-left:auto; margin-right:auto; margin-top:70px}
        .text-block { width: 300px; height:450px; position: absolute; bottom: 50px; right: 100px; background-color: rgba(0, 0, 0, 0.33); color: white; padding-left: 20px; padding-right: 20px; }
        .text-block h1{font-size: 400px;}
        .para{font-size:50px; font-weight:bold; font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif}
        a{color:white; text-decoration:none}
        lable{background-color:red; color:white}        

        .auto-style2 {
           margin-bottom:10px;  width:250px; height:23px; border-radius: 3px; background-color: rgba(0, 0, 0, 0.76); color:white
        }

    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div class="container">
                    <img src="image/Room_reg.jpg" alt="Norway" style="width:100%; height:90%">
                    <div class="text-block">                       
                       
                        <div class="Form"> 
                    <center>
                
                    <h2>Add Room</h2>
                    
                    <asp:DropDownList CssClass="auto-style2" ID="dlHotels" runat="server" Height="23px" Width="205px"></asp:DropDownList>
                    <asp:DropDownList CssClass="auto-style2" ID="dlType" runat="server" Height="25px" Width="208px">
                        <asp:ListItem>Select Room Type</asp:ListItem>
                        <asp:ListItem>Standard</asp:ListItem>
                        <asp:ListItem>Deluxe</asp:ListItem>
                        <asp:ListItem>Suite</asp:ListItem>
                        </asp:DropDownList>
                    
                    <asp:TextBox CssClass="textbox" ID="txtCity" runat="server" placeholder="City"></asp:TextBox>
                    <asp:TextBox CssClass="textbox" ID="txtCountry" runat="server" placeholder="Country"></asp:TextBox>
                    <asp:TextBox CssClass="textbox" ID="txtPrice" runat="server" placeholder="Price"></asp:TextBox>

                    <asp:TextBox CssClass="auto-style1" ID="txtDetails" runat="server" placeholder="Description" Height="37px" TextMode="MultiLine" Width="200px"></asp:TextBox>
                    <asp:FileUpload CssClass="File"  ID="imgupload" runat="server" ></asp:FileUpload>

                    <asp:Button CssClass="button" ID="btnAddRoom" runat="server" Text="Add Room" OnClick="btnAddRoom_Click" ></asp:Button>
                       
                    <asp:Button CssClass="button" ID="Button1" runat="server" Text="Back" ></asp:Button>
                    </center>
                        </div>

                    </div>
             </div>

        </div>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </form>
</body>
     
</html>
