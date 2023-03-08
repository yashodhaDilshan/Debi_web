using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Debi_web
{
    public partial class Admin_Hotel_Update : System.Web.UI.Page
    {
        SqlConnection sqlCon;
        protected void Page_Load(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection("data source = LAPTOP-DOE2NB4H; initial catalog = debi; Integrated Security = true");
            sqlCon.Open();
        }

        // ------------------------------------- Start Search Button --------------------------------------------//
        protected void Searchbtn_Click1(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                Response.Write("<script>alert('Search Box Is Empty');</script>");
            }

            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Hotel_info WHERE Hotel_Id = '" + txtId.Text + "'", sqlCon);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        txtHName.Text = dr[1].ToString();
                        txtHEmail.Text = dr[2].ToString();
                        txtTNo.Text = dr[3].ToString();
                        txtAddress.Text = dr[4].ToString();
                        txtDistrict.Text = dr[5].ToString();
                        txtDescription.Text = dr[6].ToString();

                    }
                    else
                    {
                        lblError.Text = "Data not found";
                    }
                    dr.Close();

                }
                catch (Exception ex)
                {
                    lblError.Text = "Error Searching data" + ex;
                }
            }
        }
        // ------------------------------------- End Search Button ----------------------------------------------//

        // ------------------------------------ Start Update Button ----------------------------------------------//
        protected void btnHUpdate_Click(object sender, EventArgs e)
        {
            if (txtTNo.Text == "" && txtHName.Text == "" && txtHEmail.Text == "" && txtDistrict.Text == "" && txtDescription.Text == "" && txtAddress.Text == "")
            {
                Response.Write("<script>alert('Empty boxes');</script>");
            }

            else
            {
                try
                {
                    SqlCommand cmd1 = new SqlCommand("UPDATE Hotel_info SET Hotel_Name ='" + txtHName.Text + "',  Email = '" + txtHEmail.Text + "', Tele_no ='" + txtTNo.Text + "', Address ='" + txtAddress.Text + "', District ='" + txtDistrict.Text + "', Dictionary ='" + txtDescription.Text + "'  WHERE Hotel_Id = '" + txtId.Text + "'", sqlCon);
                    int nor = cmd1.ExecuteNonQuery();

                    if (nor > 0)
                    {
                        Response.Write("<script>alert('Succsessfull Update');</script>");
                        Server.Transfer("Admin_Hotel.aspx");
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
        // -------------------------------------- End Update Button ----------------------------------------------//


        // ------------------------------------- Start Delete Button ---------------------------------------------//
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                Response.Write("<script>alert('Insert Hotel Id');</script>");
            }
            else
            {
                try
                {
                    SqlCommand cmd1 = new SqlCommand("DELETE FROM Hotel_info WHERE Hotel_Id = '" + txtId.Text + "'", sqlCon);
                    int nor = cmd1.ExecuteNonQuery();

                    if (nor > 0)
                    {
                        Response.Write("<script>alert('Hotel Delete Succsessfull');</script>");
                        Server.Transfer("Admin_Hotel.aspx");
                    }
                    else
                    {
                        lblError.Text = "Rechord update Fail";
                    }

                }
                catch (Exception ex)
                {
                    lblError.Text = "Error inserting data" + ex;
                }
            }

        }
        // -------------------------------------- End Delete Button ----------------------------------------------//


        // ----------------------------------- Start clear all Button --------------------------------------------//
        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtHName.Text = "";
            txtHEmail.Text = "";
            txtAddress.Text = "";
            txtDistrict.Text = "";
            txtTNo.Text = "";
            txtDescription.Text = "";                
        }
        // ------------------------------------ End clear all Button --------------------------------------------//

    }
}