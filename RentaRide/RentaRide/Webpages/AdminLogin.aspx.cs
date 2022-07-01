using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentaRide.Webpages
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        string constring;
        string name;


        protected void Page_Load(object sender, EventArgs e)
        {

        }






        private bool testConnetion()
        {
            constring = @"Data Source=DESKTOP-S93I946\SQLEXPRESS;Integrated Security=False;User ID=sa;Password=Fv6l7i1#aD%9O1;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            con = new SqlConnection(constring);

            try
            {
                con.Open();
                lbl_message.Text = "Connection Success!";
                return true;

            }
            catch
            {

                lbl_message.Text = "No Connection Bitch";
                return false;

            }


        }



        private void verifyLogin()
        {
            constring = @"Data Source=DESKTOP-S93I946\SQLEXPRESS;Initial Catalog=RenttoRideDB;User ID=sa;Password=Fv6l7i1#aD%9O1";
            string query = "SELECT admin_user,admin_password FROM admin_acc WHERE admin_user = '" + txtbx_username.Text + "' AND admin_password = '" + txtbx_password.Text + "';";
            con = new SqlConnection(constring);
            con.Open();
            cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.HasRows && reader.Read())
            {

                name = reader.GetString(reader.GetOrdinal("admin_user"));

            };
            if (reader.FieldCount == 2)
            {
                Session["ses"] = name;
                Response.BufferOutput = true;
                Response.Write("Sign in successful");
                Response.Redirect("AdminDashBoard.aspx", false);
            }
            else
            {

                lbl_message.Text = "Invalid  Admin Acount";
            }

            reader.Close();
            con.Close();

        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {
            verifyLogin();
        }
    }
}