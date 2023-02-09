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

    public partial class Login : System.Web.UI.Page
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AramarkDB.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //LOGIN PROCCESS AND COMMANDS
        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (logear(Login1.UserName, Login1.Password))
            {
                if (Session["Admin"].ToString() == "Yes       ")
                {
                    Response.Redirect("AdminPage.aspx");
                }
                else if (Session["Admin"].ToString() == "No       ")
                {
                    Response.Redirect("Menu.aspx");
                }
            }
            else
            {
                e.Authenticated = false;
            }


        }
        private bool logear(string username, string password)
        {
            bool status;
            String CustID;
            String uname;
            String pass;
            String admin;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE uname='" + username + "'AND pass='" + password + "'", conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    CustID = ds.Tables[0].Rows[0]["CustomerID"].ToString();
                    uname = ds.Tables[0].Rows[0]["uname"].ToString();
                    pass = ds.Tables[0].Rows[0]["pass"].ToString();
                    admin = ds.Tables[0].Rows[0]["Admin"].ToString();
                    status = true;
                    Session["CustomerID"] = CustID;
                    Session["username"] = uname;
                    Session["Admin"] = admin;
                }
                else
                {
                    status = false; 
                }

                return status;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}