using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aramark1
{
    public partial class Login : System.Web.UI.Page
    {
        public string Name { get; private set; }
        public string Password { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            Name = Register.Name;
            Password = Register.Password;

        }

        protected void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}