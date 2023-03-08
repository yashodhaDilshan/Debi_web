<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Register.aspx.cs" Inherits="Debi_web.Admin_Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin_Register</title>
    <style type="text/css">
        
        *{margin:0; padding:0;}
        .Login{width:950px; height: 400px;  margin-left: auto; margin-right: auto; margin-top: 150px; }
        

        .Form{width:900px; height: 400px; background-color:; border-left:1px solid rgb(232, 231, 231); border-right:1px solid rgb(232, 231, 231)}

        .box{width:800px; height: 400px; margin-left: auto; margin-right: auto;}
        .textbox{width:300px; height: 30px; margin-bottom:20px;  margin-left:10px; margin-right:10px;}
        .btnreg{width:300px; height: 30px; margin-bottom:10px;  margin-top: 10px}
        .Login_lable{font-size: 30px; font-weight:bold;}  
        .cancel{color: black; text-decoration:none}
        .message{background-color:forestgreen; color:white}
        .Error{background-color:red; color:white}

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div class="Login">               
                
                <div class="Form">                    
                    <div class="box">
                        <center>
                    <br />
                    <br />
                    <asp:Label CssClass="Login_lable" ID="Label1" runat="server" Text="Addmin Registration Form"></asp:Label>
                    <br />
                    <br/>
                    <br />
                       
                        <asp:TextBox CssClass="textbox" ID="txtuserName" runat="server" placeholder="User Name"></asp:TextBox>
                        <asp:TextBox CssClass="textbox" ID="txtEmail" runat="server" placeholder="Email" MaxLength="100" TextMode="Email"></asp:TextBox><br />                                             

                        <asp:TextBox CssClass="textbox" ID="txtAddress" runat="server" placeholder="Address"></asp:TextBox>
                        <asp:TextBox CssClass="textbox" ID="txtDistrict" runat="server" placeholder="District"></asp:TextBox>

                        <asp:TextBox CssClass="textbox" ID="txtPNo" runat="server" placeholder="PhoneNo" TextMode="Number"></asp:TextBox>
                        <asp:TextBox CssClass="textbox" ID="txtPassword" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                       
                        <asp:Button CssClass="btnreg" ID="btnLogin" runat="server" Text="Register" OnClick="btnLogin_Click" /><br />
                        <a class="cancel" href="Admin_Home.aspx">Cancel</a><br />

                        

                       </center>
                        
                    </div>
                </div>
            </div>

        </div>
    </form>
</body>
</html>
