<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Hotel_Reg.aspx.cs" Inherits="Debi_web.Admin_Hotel_Reg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hotel Register</title>
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
        

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container">
                    <img src="image/Hoteq.jpg" alt="Norway" style="width:100%;">
                    <div class="text-block">                       
                       
                        <div class="Form">
                    <center>
                
                    <h2>Hotel Registration</h2>
                    <asp:TextBox CssClass="textbox" ID="txtHName" runat="server" placeholder="Hotel Name"></asp:TextBox>
                    <asp:TextBox CssClass="textbox" ID="txtHEmail" runat="server" placeholder="Email"></asp:TextBox>
                    <asp:TextBox CssClass="textbox" ID="txtTNo" runat="server" placeholder="Telephone No."></asp:TextBox>
                    <asp:TextBox CssClass="textbox" ID="txtAddress" runat="server" placeholder="Address"></asp:TextBox>
                    <asp:TextBox CssClass="textbox" ID="txtDistrict" runat="server" placeholder="District"></asp:TextBox>
                    <asp:TextBox CssClass="auto-style1" ID="txtDescription" runat="server" placeholder="Description" Height="37px" TextMode="MultiLine" Width="200px"></asp:TextBox>
                    <asp:FileUpload CssClass="File"  ID="imgupload" runat="server" ></asp:FileUpload>

                    <asp:Button CssClass="button" ID="btnHRegister" runat="server" Text="Register" OnClick="btnHRegister_Click"></asp:Button><br />
                        <asp:Label CssClass="lable" ID="lblError" runat="server" Text=""></asp:Label>
                    <a href="Admin_Home.aspx">Cancel</a>
                    </center>
                        </div>

                    </div>
             </div>
         </div>
    </form>
</body>
</html>


