using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;


namespace RentaRide.Webpages
{

    public partial class Register : System.Web.UI.Page
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S93I946\SQLEXPRESS;Initial Catalog=RenttoRideDB;User ID=sa;Password=Fv6l7i1#aD%9O1");
       

        protected void Page_Load(object sender, EventArgs e)
        {
            

        }



        protected void btn_register_Click(object sender, EventArgs e)
        {
      
            con.Open();
            SqlCommand scmd = con.CreateCommand();
            scmd.CommandType = System.Data.CommandType.Text;
            //scmd.CommandText = "insert into dbo.customer_acc(customer_user,customer_firstname,customer_middlename,customer_lastname,customer_namesuffix,customer_contact,customer_email,customer_password) values ('"+txtbx_username.Text+"','" + txtbx_fname.Text + "','" + txtbx_mname.Text + "','" + txtbx_lname.Text + "','" + txtbx_nsuffix.Text + "','" + txtbx_contact.Text + "','" + txtbx_email.Text + "','"+txtbx_password.Text+"');";
            scmd.CommandText = "insert into dbo.customer_acc(customer_user,customer_firstname,customer_middlename,customer_lastname,customer_namesuffix,customer_contact,customer_email,customer_password) values ('" + txtbx_username.Text + "','" + txtbx_fname.Text + "','" + txtbx_mname.Text + "','" + txtbx_lname.Text + "','" + txtbx_nsuffix.Text + "','" + txtbx_contact.Text + "','" + txtbx_email.Text + "', HASHBYTES('SHA2_512','" + txtbx_password.Text + "') );";

            scmd.ExecuteNonQuery();
            con.Close();
        }


    }
}