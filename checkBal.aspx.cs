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
    public partial class checkBal : System.Web.UI.Page
    {
        Connection_Class obj = new Connection_Class();
        protected void Page_Load(object sender, EventArgs e)
        {
            string acno = Session["acno"].ToString();
            Label4.Text = acno;
            ServiceReference1.ServiceClient ob = new ServiceReference1.ServiceClient();
            string balance = ob.checkBal(acno);
            Label1.Text = balance;
            int bal = Convert.ToInt32(balance);

            string s = "select grand_total from bill where user_id=" + Session["userid"] + "";
            SqlDataReader dr = obj.fun_Datareader(s);

            string gtotal = "";
            while (dr.Read())
            {
                gtotal = dr["grand_total"].ToString();

            }
            Label2.Text = gtotal;
            int grandtotal = Convert.ToInt32(gtotal);
            if (grandtotal < bal)
            {
                //updating account table
                int newBal = bal - grandtotal;
                Label3.Text = newBal.ToString();
                string balUpdate = "update AccountTable set bal_amount=" + newBal + " where user_id=" + Session["userid"] + "";
                obj.fun_nonQuery(balUpdate);
                //setting status paid in order table
                string statUpdate = "update orderTable set status='paid' where user_id=" + Session["userid"] + "";
                obj.fun_nonQuery(statUpdate);
                //stock update in product table

                string se = "select min(Order_Id) from orderTable where user_id=" + Session["userid"] + "";
                string minOrder = obj.fun_scaler(se);
                int min = Convert.ToInt32(minOrder);

                string se1 = "select max(Order_Id) from orderTable where user_id=" + Session["userid"] + "";
                string maxOrder = obj.fun_scaler(se1);
                int max = Convert.ToInt32(maxOrder);
                for (int i = min; i < max; i++)
                {
                    string q = "select product_id,quantity from orderTable where Order_Id=" + i + "";
                    SqlDataReader dr1 = obj.fun_Datareader(q);
                    int quantity = 0;
                    int productId = 0;
                    while (dr1.Read())
                    {
                        quantity = Convert.ToInt32(dr1["quantity"].ToString());
                        productId = Convert.ToInt32(dr1["product_id"].ToString());
                    }


                    string str = "select Product_Stock from Product where Product_Id=" + productId + "";
                    SqlDataReader dr2 = obj.fun_Datareader(str);
                    int stock = 0;
                    while (dr2.Read())
                    {
                        stock = Convert.ToInt32(dr2["Product_Stock"].ToString());
                    }

                    int newStock = stock - quantity;
                    string nStock = Convert.ToString(newStock);
                    string stockUpdt = "update Product set Product_Stock='" + nStock + "' where Product_Id=" + productId + "";
                    obj.fun_nonQuery(stockUpdt);



                }

            }
            else
            {
                Label3.Text = "Insufficent Balance";
            }
        }

    }
}