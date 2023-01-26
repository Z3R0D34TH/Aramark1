using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace Aramark1
{
    public static class arrays
    {
        public static string cusid;
    }
    public partial class Login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        //LOGIN PROCCESS AND COMMANDS
        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (ValidateUser(Login1.UserName, Login1.Password))
            {
                Response.Redirect("Menu.aspx");
            }
            else
            {
                e.Authenticated = false;
            }

            
        }
        private bool ValidateUser(string username, string password)
        {
            bool status;
            String uname;
            String pass;


            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AramarkDB.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");

            SqlCommand cmd = new SqlCommand("SELECT * FROM Users", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            arrays.cusid = ds.Tables[0].Rows[0]["CustomerID"].ToString();
            uname = ds.Tables[0].Rows[0]["uname"].ToString();
            pass = ds.Tables[0].Rows[0]["pass"].ToString();
            
            if (uname == username && pass == password)
            {
                Session["username"] = uname;
                status = true;
            }
            else
            {
                 status = false;
            }
            return status;
        }
    }
}