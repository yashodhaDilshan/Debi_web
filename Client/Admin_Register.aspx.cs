using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Debi_web
{
    public partial class Admin_Register : System.Web.UI.Page
    {
        SqlConnection sqlCon;
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
                Server.Transfer("Admin_Register.aspx");
            }

            else
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO User_info VALUES('" + txtuserName.Text + "', '" + txtEmail.Text + "', '" + txtAddress.Text + "', '" + txtDistrict.Text + "', '" + txtPNo.Text + "', '" + txtPassword.Text + "', 'Admin')", sqlCon);
                int temp = cmd.ExecuteNonQuery();

                if (temp > 0)
                {
                    Response.Write("<script>alert('Admin Registertion Successful');</script>");
                    Server.Transfer("Admin_Home.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Admin Registertion Successful');</script>");
                    Server.Transfer("Admin_Register.aspx");
                }
            }
        }
    }
}