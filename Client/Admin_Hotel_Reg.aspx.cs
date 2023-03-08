using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Debi_web
{
    public partial class Admin_Hotel_Reg : System.Web.UI.Page
    {
        SqlConnection sqlCon;
        protected void Page_Load(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection("data source = LAPTOP-DOE2NB4H; initial catalog = debi; Integrated Security = true");
            sqlCon.Open();
        }

        protected void btnHRegister_Click(object sender, EventArgs e)
        {
            if (txtTNo.Text == "" && txtHName.Text == "" && txtHEmail.Text == "" && txtDistrict.Text == "" && txtDescription.Text == "" && txtAddress.Text == "" )
            {
                Response.Write("<script>alert('Empty box');</script>");
                Server.Transfer("Admin_Hotel_Reg.aspx");
            }
            else
            {
                string imgName = Path.GetFileName(imgupload.FileName);
                imgupload.SaveAs(Server.MapPath("Image/") + imgName);

                SqlCommand cmd = new SqlCommand("INSERT INTO Hotel_info VALUES('" + txtHName.Text + "', '" + txtHEmail.Text + "', '" + txtTNo.Text + "', '" + txtAddress.Text + "', '" + txtDistrict.Text + "', '" + txtDescription.Text + "' ,'" + "Image/" + imgupload.FileName + "' )", sqlCon);
                int temp = cmd.ExecuteNonQuery();

                if (temp > 0)
                {
                    Response.Write("<script>alert('Add Hotel Successful');</script>");
                    Server.Transfer("Admin_Hotel.aspx");

                }
                else
                {
                    Response.Write("<script>alert('Add Hotel fail');</script>");
                    Server.Transfer("Admin_Hotel_Reg.aspx");
                }
            }
            
        }
    }
}