using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace MyProject
{
    public partial class Register : System.Web.UI.Page
    {
        Connection_Class obj = new Connection_Class();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {   
            //for getting registration id from login to  increment
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
            //admin table insertion
            string insA = "insert into AdminTable values(" + reg_id + ",'" + TextBox1.Text + "','" + TextBox2.Text + "','"+TextBox3.Text+ "','" + TextBox4.Text + "')";
            int i = obj.fun_nonQuery(insA);
            if (i == 1)
            {
                //login insertion
                string insL = "insert into LoginTable values(" + reg_id + ",'" + TextBox5.Text + "','" + TextBox6.Text + "','admin')";
                int j = obj.fun_nonQuery(insL);
            }
            Response.Redirect("page1.aspx");

        }

    }
}