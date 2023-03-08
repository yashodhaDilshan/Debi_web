using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Debi_web
{
    public partial class Admin_User_Infor : System.Web.UI.Page
    {
        SqlConnection sqlCon;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                sqlCon = new SqlConnection("data source = LAPTOP-DOE2NB4H; initial catalog = debi; Integrated Security = true");
                sqlCon.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM User_info", sqlCon);
                SqlDataReader dr = cmd.ExecuteReader();

                dgUsers.DataSource = dr;
                dgUsers.DataBind();
               


                sqlCon.Close();

                lblmessage.Text = "Succsessfull";
            }
            catch (Exception ex)
            {
                lblmessage.Text = "Error" + ex;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("User_Register.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Register.aspx");
        }
    }
}