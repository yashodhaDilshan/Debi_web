using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Debi_web
{
    public partial class Register : System.Web.UI.Page
    {
        ServiceReferencedebi.WebServicedebiSoapClient obj = new ServiceReferencedebi.WebServicedebiSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

       
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtuserName.Text == "" && txtPNo.Text == "" && txtPassword.Text == "" && txtEmail.Text == "" && txtDistrict.Text == "" && txtAddress.Text == "")
            {
                Response.Write("<script>alert('Boxes are Empty');</script>");
                Server.Transfer("User_Register.aspx");
            }

            else
            {

                string NoRechords = obj.Register(txtuserName.Text, txtEmail.Text, txtAddress.Text, txtDistrict.Text, txtPNo.Text, txtPassword.Text);
                int noofrechords = Int32.Parse(NoRechords);

                if(noofrechords > 0)
                {
                    Response.Write("<script>alert('User Registertion Successful');</script>");
                    Server.Transfer("Login.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Registertion Fail');</script>");                   
                }






            }   
        }
    }
}