using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aramark1
{
    public partial class Register : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LogRed_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void Register1_Click(object sender, EventArgs e)
        {
            if (Pass.Text == Confirmpass.Text)
            {
                Label1.Text = "";
                AramarkDBEntities1 db = new AramarkDBEntities1();
                var user = new Users();
                user.uname = Uname.Text;
                user.pass = Pass.Text;
                user.Admin = "No";
                db.Users.Add(user);
                db.SaveChanges();
                Response.Redirect("Login.aspx");
            }
            else
            {
                Label1.Text = "Your passwords does not match";
            }
        }

    }
}