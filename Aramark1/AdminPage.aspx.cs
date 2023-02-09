using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aramark1
{
    public partial class AdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null && Session["Admin"].ToString() == "Yes       ")
            {
                Label1.Text = "We are glad to see you again, " + Session["username"].ToString();
            }
            else
            {
                Response.Redirect("Register.aspx");
            }
        }

        protected void GoAsCustomer_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }

        protected void CheckOrders_Click(object sender, EventArgs e)
        {
            Response.Redirect("AllOrders.aspx");
        }

        protected void CheckUsers_Click(object sender, EventArgs e)
        {
            Response.Redirect("AllUsers.aspx");
        }
    }
}