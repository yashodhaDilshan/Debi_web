<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Debi_web.User_Home1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    
    <link href="css/Admin_Home.css" rel="stylesheet" />
    
    <style>
        .main{width:1050px; margin-left:auto; margin-right:auto;}

        .container { position: relative; }
.text-block { width: 600px; height: 300px; position: absolute; bottom: 250px; right: 210px; background-color: rgba(0, 0, 0, 0.53); color: white; padding-left: 20px; padding-right: 20px; }
.text-block h1{font-size: 400px;}
.para{font-size:50px; font-weight:bold; font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif}

.btns {
        margin-top: 20px;
    }

       .btns .button {
            height: 40px;
            width: 140px;
            border-radius: 5px;
            border: none;
            margin: 0 10px;
            border: 2px solid white;
            font-size: 20px;
            font-weight: 500;
            padding: 0 10px;
            cursor: pointer;
            outline: none;
            transition: all 0.3s ease;
        }

            .btns .button:first-child {
                color: #fff;
                background: none;
            }

.btns .button:first-child:hover {
    background: white;
    color: black;
}

.btns .button:last-child {
    background: white;
    color: black;
}


    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>           
            

            <div class="main">
                               
                <center>
                <div class="container">
                    <img src="image/1111.jpg" alt="Norway" style="width:100%;">

                    <div class="text-block">                        
                        <p class="para">Debi Hotel Rooms</p>    
                        <h4>You can after Sea Hotel Rooms</h4>
                        <div class="btns">
                            <asp:Button CssClass="button" ID="Button1" runat="server" Text="Login" OnClick="Button1_Click"></asp:Button>
                            <asp:Button CssClass="button" ID="Button2" runat="server" Text="Register" OnClick="Button2_Click"></asp:Button>
                       </div>
                    </div>
                </div>
                    </center>
            </div>

        </div>
    </form>
</body>
</html>
