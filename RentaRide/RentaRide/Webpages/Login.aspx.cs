using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace RentaRide.Webpages
{
    public partial class Login : System.Web.UI.Page
    {

        SqlDataReader reader;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S93I946\SQLEXPRESS;Initial Catalog=RenttoRideDB;User ID=sa;Password=Fv6l7i1#aD%9O1");
        string name;


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand scmd = con.CreateCommand();
            scmd.CommandType = System.Data.CommandType.Text;
            scmd.CommandText = "SELECT * FROM customer_acc WHERE customer_email ='"+txtbx_email.Text+"' AND customer_password ='"+txtbx_password.Text+"';";
            string query = scmd.CommandText;
            name = "";
            reader = scmd.ExecuteReader();
            while (reader.HasRows && reader.Read()) {
                name = reader.GetString(reader.GetOrdinal("customer_firstname"));


            }

            if (reader.HasRows)
            {
                Session["customer_firstname"] = name;
                Response.BufferOutput = true;
                Response.Redirect("DashBoard.aspx", false);

            }
            else {

                lbl_message.Text = "Invalid User or Password";
            }

            reader.Close();
            con.Close();

        }
    }
}