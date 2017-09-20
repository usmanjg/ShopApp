using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ShopApp
{
    public partial class SellProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constr = "Data Source=Mani\\Usman;Initial Catalog=ShopAppDataBase;Integrated Security=True";
            SqlConnection con = new SqlConnection(constr);
            con.Open();

            string IdSql = "Select Cust_Id from Customer where ForeName='" + DropDownList1.Text + "'";
            SqlCommand cmd = new SqlCommand(IdSql, con);
            object id = cmd.ExecuteScalar();
            int a = Convert.ToInt32( id);
            //string IdCheckSql = "Select * from Customer where Cust_Id=a";
            //SqlDataAdapter da = new SqlDataAdapter(IdCheckSql, con);
            //DataSet ds = new DataSet();
            //da.Fill(ds);

            ////SqlCommand cmd1 = new SqlCommand(IdCheckSql, con);
            //GridView1.DataSource = ds;
            //GridView1.DataBind();
            //cmd1.ExecuteNonQuery();

            con.Close();
        }

        protected void AddToBasket_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GridView1.Rows.Count-1; i++)
            {
                GridViewRow row = GridView1.Rows[i];
                CheckBox cb = (CheckBox)row.FindControl("CheckBox1");
                if(cb.Checked==true)
                {
                    string id = GridView1.Rows[i].Cells[1].Text;
                    string name = GridView1.Rows[i].Cells[2].Text;
                    string qty = GridView1.Rows[i].Cells[3].Text;
                    string value = GridView1.Rows[i].Cells[4].Text;

                    string constr = "Data Source=Mani\\Usman;Initial Catalog=ShopAppDataBase;Integrated Security=True";
                    SqlConnection con = new SqlConnection(constr);
                    con.Open();
                    string IdSql = "Select Cust_Id from Customer where ForeName='" + DropDownList1.Text + "'";
                    SqlCommand cmd = new SqlCommand(IdSql, con);
                    object id1 = cmd.ExecuteScalar();
                    

                    string IdSql1 = "insert into SellProduct (Pro_Name,Value,Qty,Cust_Id) values ('" + name + "' ,  '" + Convert.ToInt32(value) + "','" + Convert.ToInt32(Convert.ToDouble(qty))  + "','"+ Convert.ToInt32(id1)+"')  ";
                    SqlCommand cmd1 = new SqlCommand(IdSql1, con);
                    cmd1.ExecuteNonQuery();
                    con.Close();
                }
            }
        }



        
    }
}