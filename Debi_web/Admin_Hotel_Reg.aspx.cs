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
        ServiceReferencedebi.WebServicedebiSoapClient obj = new ServiceReferencedebi.WebServicedebiSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnHRegister_Click(object sender, EventArgs e)
        {
            if (txtTNo.Text == "" && txtHName.Text == "" && txtHEmail.Text == "" && txtDistrict.Text == "" && txtDescription.Text == "" && txtAddress.Text == "" )
            {
                Response.Write("<script>alert('Boxes are Empty');</script>");
                Server.Transfer("Admin_Hotel_Reg.aspx");
            }
            else
            {
                string imgName = Path.GetFileName(imgupload.FileName);
                imgupload.SaveAs(Server.MapPath("Image/") + imgName);

                String filepath = imgupload.FileName;

                string NoRechords = obj.Hotel_Register(txtHName.Text, txtHEmail.Text, txtTNo.Text, txtAddress.Text, txtDistrict.Text, txtDescription.Text, filepath);
                int noofrechords = Int32.Parse(NoRechords);

                if (noofrechords > 0)
                {
                    Response.Write("<script>alert('Hotel Register Successful');</script>");
                    Server.Transfer("Admin_Hotel.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Registertion Fail');</script>");
                }

            }
            
        }
    }
}