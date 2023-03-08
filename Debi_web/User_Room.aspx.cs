using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Debi_web
{
    public partial class User_Home : System.Web.UI.Page
    {
        SqlConnection sqlCon;
        protected void Page_Load(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection("data source = LAPTOP-DOE2NB4H; initial catalog = debi; Integrated Security = true");
            sqlCon.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Rooms_info", sqlCon);            
            DataList1.DataSource = cmd.ExecuteReader();
            DataList1.DataBind();
            sqlCon.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                Response.Write("<script>alert('Search bocx is Empty');</script>");
            }

            else
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Rooms_info WHERE City = '" + txtSearch.Text + "' OR Country = '" + txtSearch.Text + "' OR Hotel_name = '" + txtSearch.Text + "'  OR Room_Type = '" + txtSearch.Text + "' ", sqlCon);
                DataList1.DataSource = cmd.ExecuteReader();
                DataList1.DataBind();
                sqlCon.Close();
            }

        }

        protected void Filter_Click(object sender, EventArgs e)
        {
            sqlCon.Open();

            if (CheckBox1.Checked)
            {     
                if(txtSearch.Text == "")
                {
                    SqlCommand cmd2 = new SqlCommand("SELECT * FROM Rooms_info WHERE Room_Type = 'Standard' ", sqlCon);
                    DataList1.DataSource = cmd2.ExecuteReader();
                    DataList1.DataBind();
                }
                else
                {
                    SqlCommand cmd2 = new SqlCommand("SELECT * FROM Rooms_info WHERE Room_Type = 'Standard' AND ( City = '" + txtSearch.Text + "' OR Country = '" + txtSearch.Text + "' OR Hotel_name = '" + txtSearch.Text + "' ) ", sqlCon);
                    DataList1.DataSource = cmd2.ExecuteReader();
                    DataList1.DataBind();
                }                
            }

            if (CheckBox2.Checked)
            {
                if (txtSearch.Text == "")
                {
                    SqlCommand cmd2 = new SqlCommand("SELECT * FROM Rooms_info WHERE Room_Type = 'Deluxe' ", sqlCon);
                    DataList1.DataSource = cmd2.ExecuteReader();
                    DataList1.DataBind();
                }
                else
                {
                    SqlCommand cmd2 = new SqlCommand("SELECT * FROM Rooms_info WHERE Room_Type = 'Deluxe' AND ( City = '" + txtSearch.Text + "' OR Country = '" + txtSearch.Text + "' OR Hotel_name = '" + txtSearch.Text + "' ) ", sqlCon);
                    DataList1.DataSource = cmd2.ExecuteReader();
                    DataList1.DataBind();
                }
            }

            if (CheckBox3.Checked)
            {
                if (txtSearch.Text == "")
                {
                    SqlCommand cmd2 = new SqlCommand("SELECT * FROM Rooms_info WHERE Room_Type = 'Suite' ", sqlCon);
                    DataList1.DataSource = cmd2.ExecuteReader();
                    DataList1.DataBind();
                }
                else
                {
                    SqlCommand cmd2 = new SqlCommand("SELECT * FROM Rooms_info WHERE Room_Type = 'Suite' AND ( City = '" + txtSearch.Text + "' OR Country = '" + txtSearch.Text + "' OR Hotel_name = '" + txtSearch.Text + "' ) ", sqlCon);
                    DataList1.DataSource = cmd2.ExecuteReader();
                    DataList1.DataBind();
                }
            }

        }
    }
}