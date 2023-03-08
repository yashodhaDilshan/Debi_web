using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Debi_web
{
    public partial class Admin_Room_Manage : System.Web.UI.Page
    {
        SqlConnection sqlCon;
        protected void Page_Load(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection("data source = LAPTOP-DOE2NB4H; initial catalog = debi; Integrated Security = true");
            sqlCon.Open();
        }

        protected void Searchbtn_Click(object sender, EventArgs e)
        {
            if(txtRId.Text == "")
            {
                Response.Write("<script>alert('Search Box Is Empty');</script>");
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Rooms_info WHERE Room_Id = '" + txtRId.Text + "'", sqlCon);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {

                        Label2.Text = dr[4].ToString();
                        txtType.Text = dr[1].ToString();
                        txtCity.Text = dr[5].ToString();
                        txtCuntry.Text = dr[6].ToString();
                        txtPrice.Text = dr[2].ToString();
                        txtDescription.Text = dr[7].ToString();
                    }
                    else
                    {
                        Response.Write("<script>alert('Wrong Id');</script>");
                    }
                    dr.Close();

                }
                catch (Exception ex)
                {
                    lblError.Text = "Error Searching data" + ex;
                }
            }
        }

        protected void btnHUpdate_Click(object sender, EventArgs e)
        {
            if(txtRId.Text == "" &&  txtType.Text == "" && txtPrice.Text == "" && txtDescription.Text == "" && txtCuntry.Text == "" && txtCity.Text == "")
            {
                Response.Write("<script>alert('Empty boxes');</script>");
            }

            else
            {
                try
                {
                    SqlCommand cmd1 = new SqlCommand("UPDATE Rooms_info SET Room_Type ='" + txtType.Text + "',  Price = '" + txtPrice.Text + "', City ='" + txtCity.Text + "', Country ='" + txtCuntry.Text + "', Details ='" + txtDescription.Text + "'  WHERE Room_Id = '" + txtRId.Text + "'", sqlCon);
                    int nor = cmd1.ExecuteNonQuery();

                    if (nor > 0)
                    {
                        Response.Write("<script>alert('Succsessfull Update');</script>");
                        Server.Transfer("Admin_Room.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('Cant Update');</script>");
                    }

                }
                catch (Exception ex)
                {
                    lblError.Text = "Error inserting data" + ex;
                }
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtRId.Text = "";
            txtType.Text = "";
            txtPrice.Text = "";
            txtDescription.Text = "";
            txtCuntry.Text = "";
            txtCity.Text = "";
            
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtRId.Text == "")
            {
                Response.Write("<script>alert('Insert Room Id');</script>");
            }

            else
            {
                try
                {
                    SqlCommand cmd1 = new SqlCommand("DELETE FROM Rooms_info WHERE Room_Id = '" + txtRId.Text + "'", sqlCon);
                    int nor = cmd1.ExecuteNonQuery();

                    if (nor > 0)
                    {
                        Response.Write("<script>alert('Room Delete Succsessful');</script>");
                        Server.Transfer("Admin_Room.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('Room update Fail');</script>");                       
                    }

                }
                catch (Exception ex)
                {
                    lblError.Text = "Error inserting data" + ex;
                }
            }
        }
    }
}