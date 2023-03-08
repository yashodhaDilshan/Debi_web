using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Debi_web
{
    public partial class User_Home1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("Login.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("User_Register.aspx");
        }
    }
}