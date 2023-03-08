using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Debi_web
{
    public partial class Admin_Room : System.Web.UI.Page
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

        protected void btnAddRoom_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Room_Add.aspx");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Room_Manage.aspx");
        }
    }
}