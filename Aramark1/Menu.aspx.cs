using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;

namespace Aramark1
{

    public partial class Menu : System.Web.UI.Page
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AramarkDB.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
        //LOGIN VERIFICATION
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                Label1.Text = "We are glad to see you again, " + Session["username"].ToString();
            }
            else
            {
                Response.Redirect("Register.aspx");
            }
            lol();
            gvbind();
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        protected void AddToOrder_Click1(object sender, EventArgs e)
        {
            AramarkDBEntities1 db = new AramarkDBEntities1();
            var pizza = new Order();
            if (Margarita.Checked)
            {
                pizza.CustomerID = int.Parse(Session["CustomerID"].ToString());
                pizza.Pizza = "Margarita";
                pizza.Price = 2.60;
                pizza.Date = DateTime.Today;
                pizza.Placed = "No";

            }
            else if (Pepperoni.Checked)
            {
                pizza.CustomerID = int.Parse(Session["CustomerID"].ToString());
                pizza.Pizza = "Pepperoni";
                pizza.Price = 2.80;
                pizza.Date = DateTime.Today;
                pizza.Placed = "No";
            }
            db.Order.Add(pizza);
            db.SaveChanges();
            gvbind();
        }

        protected void Calculate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AramarkDB.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");

            SqlCommand cmd = new SqlCommand("SELECT * FROM [Order] where CustomerID='" + Session["CustomerID"] + "'AND Placed='No'", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            Decimal TotalPrice = Convert.ToDecimal(dt.Compute("SUM(Price)", string.Empty));
            PriceLabel.Text = "£" + TotalPrice.ToString();
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            if (GridView1.SelectedRow == null)
            {
                Label2.Text = "Please select a row before you delete it";
            }
            else
            {
                Label2.Text = "";
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM [Order] where OrderID='" + GridView1.DataKeys[GridView1.SelectedIndex]["OrderID"].ToString() + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                gvbind();
            }
        }
        
        protected void gvbind()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Order] where CustomerID='" + Session["CustomerID"] + "'AND Placed='No'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            if (ds.Tables[0].Rows.Count > 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            else
            {
                ds.Tables[0].Rows.Add(ds.Tables[0].NewRow());
                GridView1.DataSource = ds;
                GridView1.DataBind();
                int columncount = GridView1.Rows[0].Cells.Count;
                GridView1.Rows[0].Cells.Clear();
                GridView1.Rows[0].Cells.Add(new TableCell());
                GridView1.Rows[0].Cells[0].ColumnSpan = columncount;
                GridView1.Rows[0].Cells[0].Text = "You have not added anything to the list today";
            }
        }
        public void Delete()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM [Order] where CustomerID='" + Session["CustomerID"] + "' AND Placed='No'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            gvbind();
        }

        protected void Checkout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Checkout.aspx");
        }
        protected void lol()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Order] where CustomerID='" + Session["CustomerID"] + "'AND Placed='No'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            String date = null;
            try
            {
                date = dt.Rows[dt.Rows.Count]["Date"].ToString();
            }
            catch
            {

            }
            if (date != null)
            {
                int result = DateTime.Compare(DateTime.Now, DateTime.Parse(date));
                if (result > 0)
                {
                    Delete();
                }
            }
        }

    }
}