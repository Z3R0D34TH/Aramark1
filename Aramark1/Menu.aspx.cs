using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aramark1
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void PizzaChoice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            AramarkDBEntities1 db = new AramarkDBEntities1();
            var pizza = new Order();
            if (PizzaChoice.Items[0].Selected)
            {

                pizza.Pizza = "Margarita";
                pizza.Price = "2.60£";
            }
            else if (PizzaChoice.Items[1].Selected)
            {
                pizza.Pizza = "Pepperoni";
                pizza.Price = "2.80£";
            }
            db.Orders.Add(pizza);
            db.SaveChanges();
            GridView1.DataBind();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

        }

        protected void CheckoutButton_Click(object sender, EventArgs e)
        {

        }
    }
}