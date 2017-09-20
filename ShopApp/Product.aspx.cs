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
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            LblError.Text = "";
            string constr = "Data Source=Mani\\Usman;Initial Catalog=ShopAppDataBase;Integrated Security=True";
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            string IdCheckSql = "Select * from product where Pro_Id='" + TxtProId.Text + "'";
            SqlCommand cmd = new SqlCommand(IdCheckSql, con);
            object IdExist = cmd.ExecuteScalar();
            if (IdExist != null)
            {
                LblError.Text = "Product Id already exist";
            }
            else
            {
                string CustSql = "insert into Product (Pro_Id,Pro_Name,Value, Qty) values ('" +TxtProId.Text + "' ,  '" + TxtProName.Text + "','" +TxtProValue.Text + "', '" + TxtQty.Text + "') ";
                SqlCommand cmd1 = new SqlCommand(CustSql, con);
               // SqlDataReader dr = cmd1.ExecuteReader(); //
                cmd1.ExecuteNonQuery();
              //  GridView1.DataSource = dr;
                //GridView1.DataBind();
                //GridView1.DataBind();
            }
            con.Close();


            
        }



        
    }
}