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
    public partial class viewPaidCustmr : System.Web.UI.Page
    {
        Connection_Class obj = new Connection_Class();
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = "select product_id,price,Order_Id,date from orderTable where status='paid'";
            DataSet ds = obj.fun_dataAdapter(s);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            
        }

      

        protected void LinkButton2_Command(object sender, CommandEventArgs e)
        {
            int getid = Convert.ToInt32(e.CommandArgument);
            string updt = "update orderTable set status='Delivered' where status='paid' AND Order_Id=" + getid + "";
            obj.fun_nonQuery(updt);
            Label1.Visible = true;
            Label1.Text = "updated";
        }
    }
}