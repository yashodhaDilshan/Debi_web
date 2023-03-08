using System;
using System.Data;
using System.Data.SqlClient;

namespace Debi_web
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection sqlCon;
        protected void Page_Load(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection("data source = LAPTOP-DOE2NB4H; initial catalog = debi; Integrated Security = true");
            sqlCon.Open();
            //lblMessage.Text = "Database Succsessf";
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "" || txtPassword.Text == "")
            {
                Response.Write("<script>alert('Boxes are Empty ');</script>");
                Server.Transfer("Login.aspx");
            }

            else
            {
                SqlCommand cmd = new SqlCommand("select * from User_info where Email='" + txtUsername.Text + "' and Password='" + txtPassword.Text + "'", sqlCon);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                int i = cmd.ExecuteNonQuery();

                if (dt.Rows.Count > 0)
                {
                    SqlCommand cmd1 = new SqlCommand("SELECT * FROM User_info WHERE Email = '" + txtUsername.Text + "'", sqlCon);
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    String type = dr[7].ToString();

                    if (type == "Admin")
                    {
                        Response.Write("<script>alert('Admin Login Successful');</script>");
                        Server.Transfer("Admin_Home.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('User Login Successful');</script>");
                        Server.Transfer("User_Room.aspx");
                    }

                }
                else
                {
                    Response.Write("<script>alert('Email and Password Wrong');</script>");
                    Server.Transfer("Login.aspx");

                }
            }            
        }
    }
}



