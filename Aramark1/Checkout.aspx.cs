using System;
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
    public partial class Checkout : System.Web.UI.Page
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AramarkDB.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Order] where CustomerID='" + Session["CustomerID"] + "'AND Date='" + DateTime.Now.Date + "'", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            Decimal TotalPrice = Convert.ToDecimal(dt.Compute("SUM(Price)", string.Empty));
            PriceLabel.Text = "£" + TotalPrice.ToString();
            gvbind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            SqlCommand cmd = new SqlCommand("Select * from [Order]", conn);
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

        protected void Endcheckout_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaymentFinished.aspx");
        }
    }
}