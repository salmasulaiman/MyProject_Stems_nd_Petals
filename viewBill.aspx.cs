using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace MyProject
{
    public partial class viewBill : System.Web.UI.Page
    {
        Connection_Class obj = new Connection_Class();
        protected void Page_Load(object sender, EventArgs e)
        {
            string qry= "select U_Table.Name,bill.bill_id,U_Table.Address,bill.bill_date,bill.grand_total from U_Table join bill on U_Table.User_Id=bill.user_id where U_Table.User_Id="+Session["userid"]+"";
            string qry1 = "select Product.Product_Name,orderTable.price,orderTable.quantity from Product join orderTable on orderTable.product_id=Product.Product_Id where orderTable.user_id="+Session["userid"]+ " AND orderTable.status='ordered'";
            SqlDataReader dr = obj.fun_Datareader(qry);
           
            
            while(dr.Read())
            {
                Label2.Text = dr["Name"].ToString();
                Label1.Text = dr["bill_id"].ToString();
                Label3.Text = dr["Address"].ToString();
                Label4.Text = dr["bill_date"].ToString();
                Label5.Text = dr["grand_total"].ToString();


            }
            
            DataSet ds = obj.fun_dataAdapter(qry1);
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ACInsert.aspx");
        }
    }
}