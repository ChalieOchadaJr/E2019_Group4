using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Security;
using System.Data;

namespace RentaRide.Webpages
{
    public partial class Login : System.Web.UI.Page
    {
        SqlCommand cmd;
        string constring;
        string name;
        SqlConnection con;



        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //LOGIN BUTTON 
        protected void btn_login_Click(object sender, EventArgs e)
        {

            verifyLogin();
       
        }



        // ***************************** METHODS *****************************

        private bool testConnetion() {
            constring = @"Data Source=DESKTOP-S93I946\SQLEXPRESS;Integrated Security=False;User ID=sa;Password=Fv6l7i1#aD%9O1;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            con = new SqlConnection(constring);

            try
            {
                con.Open();
                lbl_uemessage.Text = "Connection Success!";
                return true;

            }
            catch {

                lbl_uemessage.Text = "No Connection Bitch";
                return false;

            }


        }
        


        private void verifyLogin() {
            constring = @"Data Source=DESKTOP-S93I946\SQLEXPRESS;Initial Catalog=RenttoRideDB;User ID=sa;Password=Fv6l7i1#aD%9O1";
            string query = "SELECT customer_user,customer_password FROM customer_acc WHERE customer_user = '" + txtbx_email.Text + "' AND customer_password = '" + txtbx_password.Text + "';";
            con = new SqlConnection(constring);
            con.Open();
            cmd = new SqlCommand(query,con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.HasRows && reader.Read()) {

                name = reader.GetString(reader.GetOrdinal("customer_user"));

            } ;
            if (reader.FieldCount == 2)
            {
                Session["ses"] = name;
                Response.BufferOutput = true;
                Response.Write("Sign in successful");
                Response.Redirect("DashBoard.aspx",false);
            }
            else {

                lbl_uemessage.Text = "Invalid username or Password!";
            }

            reader.Close();
            con.Close();

        }


  /*      private void verifyLogin()
        {
            constring = @"Data Source=DESKTOP-S93I946\SQLEXPRESS;Integrated Security=False;User ID=sa;Password=Fv6l7i1#aD%9O1;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string query = "SELECT * FROM customer_acc WHERE customer_user = '" + txtbx_email.Text + "' AND customer_password = '" + txtbx_password.Text + "';";
            con = new SqlConnection(constring);
            cmd = new SqlCommand(query, con);
            SqlDataAdapter objda = new SqlDataAdapter(cmd);
            DataSet objDs = new DataSet();



            objda.Fill(objDs);
            if (objDs.Tables[0].Rows.Count > 0)
            {
                Response.Write("Sign in successful");
                Response.Redirect("DashBoard.aspx");
            }



        }

*/


        /*
                private bool loginVerification(string user , string pass) {

                    if ((null == user) || (0 == user.Length)) {

                        lbl_uemessage.Text = "Invalid username / email  ";
                        return false;


                    }

                    if ((null == pass) || (0 == pass.Length)){

                        lbl_pwdmessage.Text = "Invalid password!";

                        return false;
                    }

                    try
                    {
                        string constring = @"Data Source=DESKTOP-S93I946\SQLEXPRESS;Integrated Security=False;User ID=sa;Password=Fv6l7i1#aD%9O1;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        SqlConnection con = new SqlConnection(constring);

                        cmd = new SqlCommand("SELECT customer_password FROM customer_acc WHERE customer_user = '" + user + "'", con);
                        cmd.Parameters.Add("customer_user", user);
                        cmd.Parameters["Admin"].Value = user;

                        lockpass = (string)cmd.ExecuteScalar();

                        cmd.Dispose();
                        con.Dispose();     


                    }catch (Exception E){



                    }

                    if (null == lockpass) {
                        return false;

                    }


                    return (0 == string.Compare(lockpass, pass, false));


                }

            */










    }
}