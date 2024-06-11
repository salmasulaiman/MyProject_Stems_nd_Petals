using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyProject
{
    public partial class U_register : System.Web.UI.Page
    {
        Connection_Class obj = new Connection_Class();
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string sel = "select max(Reg_Id) from LoginTable";
            string regId = obj.fun_scaler(sel);
            int reg_id = 0;
            if (regId == "")
            {
                reg_id = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(regId);
                reg_id = newregid + 1;
            }
            string insA = "insert into U_Table values(" + reg_id + ",'" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','active')";
            int i = obj.fun_nonQuery(insA);
            if (i == 1)
            {
                string insL = "insert into LoginTable values(" + reg_id + ",'" + TextBox6.Text + "','" + TextBox7.Text + "','user')";
                int j = obj.fun_nonQuery(insL);
            }
            Response.Redirect("page1.aspx");
        }
    }
}