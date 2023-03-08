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
        UserServiceReference.debiWebService obj = new UserServiceReference.debiWebService();
        protected void Page_Load(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection("data source = LAPTOP-DOE2NB4H; initial catalog = debi; Integrated Security = true");
            sqlCon.Open();
        }

       
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtuserName.Text == "" && txtPNo.Text == "" && txtPassword.Text == "" && txtEmail.Text == "" && txtDistrict.Text == "" && txtAddress.Text == "")
            {
                Response.Write("<script>alert('Empty boxes');</script>");
                Server.Transfer("User_Register.aspx");
            }

            else
            {
                String Name = txtuserName.Text;

                SqlCommand cmd = new SqlCommand("INSERT INTO User_info VALUES('" + txtuserName.Text + "', '" + txtEmail.Text + "', '" + txtAddress.Text + "', '" + txtDistrict.Text + "', '" + txtPNo.Text + "', '" + txtPassword.Text + "', 'User')", sqlCon);
                int temp = cmd.ExecuteNonQuery();

                if (temp > 0)
                {
                    Response.Write("<script>alert('Registertion Successful');</script>");
                    Server.Transfer("Login.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Registertion Fail');</script>");
                    Server.Transfer("User_Register.aspx");
                }

            }   
        }
    }
}