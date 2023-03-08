using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Debi_web
{
    public partial class User_Hotel : System.Web.UI.Page
    {
        SqlConnection sqlCon;
        protected void Page_Load(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection("data source = LAPTOP-DOE2NB4H; initial catalog = debi; Integrated Security = true");
            sqlCon.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Hotel_info", sqlCon);
            DataList1.DataSource = cmd.ExecuteReader();
            DataList1.DataBind();
            sqlCon.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                Response.Write("<script>alert('Search bocx is Empty');</script>");
            }
            else
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Hotel_info WHERE Hotel_Name = '" + txtSearch.Text + "' OR District = '" + txtSearch.Text + "' ", sqlCon);
                DataList1.DataSource = cmd.ExecuteReader();
                DataList1.DataBind();
                sqlCon.Close();
            }
        }
    }
}