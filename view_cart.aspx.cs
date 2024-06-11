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
    public partial class view_cart : System.Web.UI.Page
    {
        Connection_Class obj = new Connection_Class();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                gridbind();
            }

        }
        public void gridbind()
        {
            string s = "select * from Cart";
            DataSet ds = obj.fun_dataAdapter(s);
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            gridbind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            gridbind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            TextBox txtquantity = (TextBox)GridView1.Rows[i].Cells[5].Controls[0];
            TextBox txtpro_id = (TextBox)GridView1.Rows[i].Cells[4].Controls[0];
            string tp = "select Product_Price from Product where Product_Id=" + txtpro_id.Text+ "";
            SqlDataReader dr = obj.fun_Datareader(tp);
            string newTotal="";
            while(dr.Read())
            {
                newTotal = dr["Product_Price"].ToString();
            }
            int total = (Convert.ToInt32(newTotal)) * (Convert.ToInt32(txtquantity.Text));

            string str = "update Cart set Quantity=" + txtquantity.Text + ",Total_Price="+total+" where Cart_Id=" + getid + "";
            obj.fun_nonQuery(str);
            GridView1.EditIndex = -1;
            gridbind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int i = e.RowIndex;
            int getid= Convert.ToInt32(GridView1.DataKeys[i].Value);
            string del = "delete from Cart where Cart_Id=" + getid + "";
            obj.fun_nonQuery(del);
            gridbind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string maxcart = "select max(Cart_Id) from Cart where User_Id=" + Session["userid"] + "";
            string j = obj.fun_scaler(maxcart);
            int maxvalue = Convert.ToInt32(j);
            string dt = Convert.ToDateTime(DateTime.Now.ToShortDateString()).ToString("yyyy-MM-dd");
            for (int i=1;i<=maxvalue;i++)
            {
                string selCart = "select * from Cart where Cart_Id=" + i + "";
                SqlDataReader dr = obj.fun_Datareader(selCart);
                string proid = "";
                string qnty = "";
                string price = "";
                
                while(dr.Read())
                {
                    qnty = dr["Quantity"].ToString(); ;
                   proid= dr["Product_Id"].ToString();
                   price= dr["Total_Price"].ToString();
                   
                }
                int q, pid, p;
                pid = Convert.ToInt32(proid);
                q = Convert.ToInt32(qnty);
                p = Convert.ToInt32(price);
                string ins1 = "insert into OrderTable values("+Session["userid"]+","+pid+","+ q+","+p+",'"+dt+"','ordered')";
                obj.fun_nonQuery(ins1);
                string del = "delete from Cart where Cart_Id=" + i + "";
                obj.fun_nonQuery(del);
            }
            string sumTotal = "select sum(price) from orderTable where user_id=" + Session["userid"] + "";
            string a= obj.fun_scaler(sumTotal);
            int grandtotal = Convert.ToInt32(a);
            string ins2 = "insert into bill values('"+dt+"'," + Session["userid"] + "," + grandtotal + ")";
            obj.fun_nonQuery(ins2);
            Response.Redirect("viewBill.aspx");

        }
    }
}

