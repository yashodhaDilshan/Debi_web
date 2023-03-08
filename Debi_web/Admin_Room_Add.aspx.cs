using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Debi_web
{
    public partial class Admin_Room_Add : System.Web.UI.Page
    {
        SqlConnection sqlCon;
        ServiceReferencedebi.WebServicedebiSoapClient obj = new ServiceReferencedebi.WebServicedebiSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                sqlCon = new SqlConnection("data source = LAPTOP-DOE2NB4H; initial catalog = debi; Integrated Security = true");
                sqlCon.Open();
                
            }
            catch (Exception ex)
            {
                Label1.Text = "Error connection db " + ex;
            }

            if (!IsPostBack)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT Hotel_Name  FROM Hotel_info", sqlCon);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    da.Fill(ds, "Hotel_info");

                    dlHotels.DataSource = ds;
                    dlHotels.DataBind();

                    dlHotels.DataValueField = "Hotel_Name";
                    dlHotels.DataBind();

                }
                catch (Exception ex)
                {
                    Label1.Text = "Error drop down" + ex;
                }
            }
        }

        String getHotelId()
        {
            String HotelId = "";

            try
            {
                SqlCommand cmd1 = new SqlCommand("SELECT Hotel_Id  FROM Hotel_info WHERE Hotel_Name = '" + dlHotels.Text + "'", sqlCon);
                SqlDataReader dr = cmd1.ExecuteReader();

                Boolean rechords = dr.HasRows;
                if (rechords)
                {
                    while (dr.Read())
                    {
                        HotelId = dr[0].ToString();
                    }
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                Label1.Text = "Error1 " + ex;
            }

            return HotelId;
        }
                     

        protected void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (txtCity.Text == "" && txtCountry.Text == "" && txtDetails.Text == "" && txtPrice.Text == "" )
            {
                Response.Write("<script>alert('Boxes are Empty');</script>");
                Server.Transfer("Admin_Room_Add.aspx");
            }
            else
            {
                try
                {
                    string imgName = Path.GetFileName(imgupload.FileName);
                    imgupload.SaveAs(Server.MapPath("Image/") + imgName);

                    String filepath = imgupload.FileName;

                    string NoRechords = obj.Add_Room(dlType.Text, txtPrice.Text, getHotelId(), dlHotels.Text, txtCity.Text, txtCountry.Text, txtDetails.Text, filepath);
                    int noofrechords = Int32.Parse(NoRechords);

                    if (noofrechords > 0)
                    {
                        Response.Write("<script>alert('Room Add Succsessful');</script>");
                        Server.Transfer("Admin_Room.aspx");

                    }
                    else
                    {
                        Label1.Text = "CAnt insert Data ";
                    }

                }
                catch (Exception ex)
                {
                    Label1.Text = "Error  aaa " + ex;
                }
            }


           
        }
    }
}