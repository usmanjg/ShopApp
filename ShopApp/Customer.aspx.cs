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
    public partial class Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            LblError.Text = "";
            string constr = "Data Source=Mani\\Usman;Initial Catalog=ShopAppDataBase;Integrated Security=True";
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            string IdCheckSql = "Select * from Customer where Cust_Id='" + TxtId.Text + "'";
            SqlCommand cmd = new SqlCommand(IdCheckSql, con);
           object IdExist = cmd.ExecuteScalar();
            if (IdExist!=null)
            {
                LblError.Text="Id already exist";
            }
            else
            {
                string CustSql = "insert into Customer (Cust_Id,ForeName,LastName, Address) values ('" + TxtId.Text + "' ,  '" + TxtFName.Text + "','" + TxtLName.Text + "', '" + TxtAddress.Text + "') ";
                SqlCommand cmd1 = new SqlCommand(CustSql, con);
                cmd1.ExecuteNonQuery();
            }
            con.Close();
            
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=Mani\\Usman;Initial Catalog=ShopAppDataBase;Integrated Security=True";
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            string CustSql = "delete from Customer where Cust_Id='"+TxtId.Text +"' And ForeName='"+TxtFName.Text+"'";
            SqlCommand cmd = new SqlCommand(CustSql, con);
            cmd.ExecuteNonQuery();
        }
    }
}