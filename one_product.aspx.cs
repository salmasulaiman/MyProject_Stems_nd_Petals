using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace MyProject
{
    public partial class one_product : System.Web.UI.Page
    {
        Connection_Class obj = new Connection_Class();
        protected void Page_Load(object sender, EventArgs e)
        { if (!IsPostBack)
            {
                TextBox1.Text = "1";


                string s = "select * from Product where Product_Id=" + Session["proid"] + "";
                SqlDataReader dr = obj.fun_Datareader(s);
                while (dr.Read())
                {
                    Image1.ImageUrl = dr["Product_Image"].ToString();
                    Label1.Text = dr["Product_Name"].ToString();
                    Label2.Text = dr["Product_Price"].ToString();
                    Label3.Text = dr["Product_Description"].ToString();

                }
            }
            

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(TextBox1.Text);
            quantity = quantity + 1;
            TextBox1.Text = quantity.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(TextBox1.Text);
            if (quantity > 1)
            {
                quantity = quantity - 1;
                TextBox1.Text = quantity.ToString();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserHome.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(Cart_Id) from Cart";
            string cartid = obj.fun_scaler(sel);
            int cart_id;
            if(cartid=="")
            {
                cart_id = 1;
            }
            else
            {
                int newid = Convert.ToInt32(cartid);
                cart_id = newid + 1;
            }
            string se = "select Product_Price from Product where Product_Id=" + Session["proid"] + "";
            SqlDataReader dr = obj.fun_Datareader(se);
            string pro_price="";
            while(dr.Read())
            {
                pro_price = dr["Product_Price"].ToString();
            }
            int price = Convert.ToInt32(pro_price);
            int q = Convert.ToInt32(TextBox1.Text);
            int Total_Price = price * q;



            string cins = "insert into Cart values("+cart_id+"," + Session["userid"] + "," + Session["proid"] + "," + TextBox1.Text + "," + Total_Price + ")";
            int i = obj.fun_nonQuery(cins);
            if(i==1)
            {
                Response.Redirect("view_cart.aspx");
            }



    }
    }
}