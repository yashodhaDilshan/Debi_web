<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Room_Manage.aspx.cs" Inherits="Debi_web.Admin_Room_Manage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Room Update Delete</title>

    <style>
        .box{ width:700px;  margin-left:auto; margin-right:auto; margin-top:20px; margin-bottom:20px;}
        .Form{ width:470px; height:400px; margin-left:300px;  }
        .textbox{ margin-bottom:10px;  width:400px; height:30px;}
        .File{ color:rgb(128, 128, 128); background-color: white; width:200px }
        .button{margin-top:20px; width:200px; height:30px; }
        
        /* ------------------------- Main Image  ------------------------- */
        .container { position: relative; width:1000px; margin-left:auto; margin-right:auto; margin-top:70px}
        .text-block { width: 300px; height:450px; position: absolute; bottom: 50px; right: 100px;  padding-left: 20px; padding-right: 20px; }
        .text-block h1{font-size: 400px;}
        .para{font-size:50px; font-weight:bold; font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif}
        a{color:black; text-decoration:none; margin-left:auto; margin-right:auto;}
        lable{background-color:red; color:white}
        .search{width:80px; height:35px; font-weight:bold; background-color: cornflowerblue; color:white; border:none}
        .search:hover{background-color:dodgerblue}

         .auto-style2 {
             width: 543px;
             height: 633px;
             float:right;
             margin-bottom:100px;
            
         }
         .auto-style4 {
             color: rgb(128, 128, 128);
             background-color: white;
             margin-bottom:30px;
         }
         .auto-style5 {
             margin: 20px auto;
             width: 707px;
             height: 630px;
         }
         auto-style7{
             margin-top:20px;
             background-color:red;
         }
         .auto-style6 {
             margin-left: 0px;
             margin-top:20px;
             background-color:rgba(255, 0, 0, 0.65);
             color:white;
             border:none;
         }
         .auto-style6:hover {             
             background-color:red;
             transform: 0.2s;
             
         }

        </style>

</head>
<body>
    <form id="form1" runat="server">
        <div style="border-top:1px solid black; border-bottom:1px solid black; margin-top:20px" >
            <div class="auto-style5">
                <div class="auto-style2">                    
                
                    <h1 style="margin-left:110px"> Manage Rooms </h1>

                    <asp:TextBox CssClass="textbox" ID="txtRId" runat="server" placeholder="Room Id"></asp:TextBox>
                    <asp:Button CssClass="search" ID="Searchbtn" runat="server" Text="Search" OnClick="Searchbtn_Click"  /><br />
                    <asp:Label ID="Label1" runat="server" Text="Hotel Name : "></asp:Label>
                    <asp:Label ID="Label2" runat="server" Text=""></asp:Label><br />
                    <br />

                    <asp:TextBox CssClass="textbox" ID="txtType" runat="server" placeholder="Room Type"></asp:TextBox>       
                    <asp:TextBox CssClass="textbox" ID="txtCity" runat="server" placeholder="City"></asp:TextBox>
                    <asp:TextBox CssClass="textbox" ID="txtCuntry" runat="server" placeholder="Country"></asp:TextBox>
                    <asp:TextBox CssClass="textbox" ID="txtPrice" runat="server" placeholder="Price"></asp:TextBox>
                    
                    <asp:TextBox CssClass="textbox" ID="txtDescription" runat="server" placeholder="Description" Height="64px" TextMode="MultiLine" Width="397px"></asp:TextBox>
                    <asp:FileUpload CssClass="auto-style4"  ID="imgupload" runat="server" Height="22px" Width="317px" ></asp:FileUpload>
                    
                    <asp:Button CssClass="Clear" ID="btnClear" runat="server" Text="Clear All" OnClick="btnClear_Click" />
                    <asp:Button ID="btnHUpdate" runat="server" Text="Update" Height="34px" Width="402px" OnClick="btnHUpdate_Click" ></asp:Button><br />
                    <asp:Button CssClass="auto-style6" ID="btnDelete" runat="server" Text="Delete" Height="33px" Width="404px" OnClick="btnDelete_Click" ></asp:Button><br />

                    <asp:Label CssClass="lable" ID="lblError" runat="server" Text=""></asp:Label>
                    <a href="Admin_Home.aspx">Cancel</a>   
                    
                </div>                
            </div>
        </div>      
    </form>
</body>
</html>
