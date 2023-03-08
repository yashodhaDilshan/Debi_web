using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Web_Server
{
    /// <summary>
    /// Summary description for WebServicedebi
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]


    public class WebServicedebi : System.Web.Services.WebService
    {

        SqlConnection sqlCon;

        public SqlConnection getConnection()
        {
            try
            {
                sqlCon = new SqlConnection("data source = LAPTOP-DOE2NB4H; initial catalog = debi; Integrated Security = true");
                sqlCon.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Connection to db" + ex);
            }

            return sqlCon;
        }

        [WebMethod]
        public String Register(String Username, String Email, String Address, String District, String PhoneNo, String Password)
        {
            int NoRechords = 0;

            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO User_info VALUES('" + Username + "', '" + Email + "', '" + Address + "', '" + District + "', '" + PhoneNo + "', '" + Password + "', 'User')", sqlCon);
                NoRechords = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

            return NoRechords.ToString();
        }


        [WebMethod]
        public String Admin_Register(String Username, String Email, String Address, String District, String PhoneNo, String Password)
        {
            int NoRechords = 0;

            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO User_info VALUES('" + Username + "', '" + Email + "', '" + Address + "', '" + District + "', '" + PhoneNo + "', '" + Password + "', 'Admin')", sqlCon);
                NoRechords = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

            return NoRechords.ToString();
        }


        [WebMethod]
        public String Hotel_Register(String Hotelname, String Email, String TelNo, String Address, String District, String Description, String img)
        {
            int NoRechords = 0;

            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO Hotel_info VALUES('" + Hotelname + "', '" + Email + "', '" + TelNo + "', '" + Address + "', '" + District + "', '" + Description + "' ,'" + "Image/" + img + "' )", sqlCon);
                NoRechords = cmd.ExecuteNonQuery();

            }

            catch (Exception ex)
            {
                return ex.ToString();
            }

            return NoRechords.ToString();

        }


        [WebMethod]
        public String Add_Room(String type, String price, String Hid, String Hname, String City, String country, String details, String img)
        {
            int NoRechords = 0;

            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO Rooms_info VALUES('" + type + "', '" + price + "', '" + Hid + "', '" + Hname + "', '" + City + "', '" + country + "' , '" + details + "' , '" + "Image/" + img + "' )", sqlCon);
                NoRechords = cmd.ExecuteNonQuery();

            }

            catch (Exception ex)
            {
                return ex.ToString();
            }

            return NoRechords.ToString();

        }





    }
}
