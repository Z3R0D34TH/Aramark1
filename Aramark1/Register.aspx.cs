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
        public static string Name = "";
        public static string Password = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AramarkDBEntities1 db = new AramarkDBEntities1();
            var user = new User();
            Name = NameBox.Text;
            Password = PasswordBox.Text;

            if (PasswordBox.Text == ConfirmBox.Text)
            {
                user.Name = NameBox.Text;
                user.SecondName = SecondNameBox.Text;
                user.Email = EmailBox.Text;
                user.Password = PasswordBox.Text;
                db.Users.Add(user);
                db.SaveChanges();
                ErrorsLabel.Text = "Your profile has been created, try to log in in the login pages.";
            }
            else
            {
                ErrorsLabel.Text = "Password must be confirmed correctly.";
            }

        }

        protected void ConfirmBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}