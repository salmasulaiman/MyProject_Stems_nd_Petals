using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyProject
{
    public partial class ACInsert : System.Web.UI.Page
    { Connection_Class obj = new Connection_Class();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["acno"] = TextBox1.Text;
            string s = "select count(user_id) from AccountTable where user_id=" + Session["userid"] + "";
            string count = obj.fun_scaler(s);
            int c1 = Convert.ToInt32(count);
            if (c1 == 0)
            {

                string str = "insert into AccountTable values(" + Session["userid"] + "," + TextBox1.Text + "," + TextBox2.Text + ",'active')";
                obj.fun_nonQuery(str);
                Response.Redirect("checkBal.aspx");
            }
            else
            {
                Response.Redirect("checkBal.aspx");
            }
        }
    }
}