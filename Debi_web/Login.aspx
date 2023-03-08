<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Debi_web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <style type="text/css">
        
        *{margin:0; padding:0;}
        .Login{width:950px; height: 400px;  margin-left: auto; margin-right: auto; margin-top: 150px; }
        .image{width:500px; height: 400px;  float:left;}
        .image img{width:500px; height: 400px;  }

        .Form{width:440px; height: 400px; background-color:; float:right; border-left:1px solid rgb(232, 231, 231); border-right:1px solid rgb(232, 231, 231)}

        .box{width:300px; height: 400px; margin-left: auto; margin-right: auto;}
        .textbox{width:300px; height: 30px; margin-bottom:20px; }
        .Login_lable{font-size: 30px; font-weight:bold;}
        .box p a{color:#eb4d4b}  
        .cancel{color: black; text-decoration:none}
        .Errormesssage{color:white; background-color:red}

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div class="Login">
                
                <div class="image">                    
                    <img src="img\login.jpg" alt="">
                </div>
                <div class="Form">                    
                    <div class="box">
                        <center>
                    <br />
                    <br />
                    <asp:Label CssClass="Login_lable" ID="Label1" runat="server" Text="Login Form"></asp:Label>
                    <br />
                    <br />
                    <asp:Label CssClass="Errormesssage" ID="lblMessage" runat="server" Text=""></asp:Label><br/>
                    <br />
                        </center>
                        
                        <asp:TextBox CssClass="textbox" ID="txtUsername" runat="server" placeholder="Username" TextMode="Email" OnClick="txtUsername_TextChanged"></asp:TextBox><br/>
                        <asp:TextBox CssClass="textbox" ID="txtPassword" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox><br/>
                        <asp:Button CssClass="textbox" ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                        <center><a class="cancel" href="#">Cancel</a> <br /></center>
                        <br/>
                        <br/>                     

                        <p>Don't have an account ?  <a href="User_Register.aspx">Register Now</a></p> 
                        
                        
                    </div>
                </div>
            </div>

        </div>
    </form>
</body>
</html>


