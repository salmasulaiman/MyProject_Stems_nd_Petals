using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace MyProject
{
    public partial class LoginPage : System.Web.UI.Page
    {
        Connection_Class obj = new Connection_Class();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "select count(Reg_Id)from LoginTable where Username='" + TextBox1.Text + "' AND Password='" + TextBox2.Text + "'";
            string cid = obj.fun_scaler(str);
            int cid1 = Convert.ToInt32(cid);
            if (cid1 == 1)
            {
               // FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, true);
                string str1 = "select Reg_Id from LoginTable where Username='" + TextBox1.Text + "' AND Password='" + TextBox2.Text + "'";
                string rid = obj.fun_scaler(str1);
                Session["userid"] = rid;
                string str2 = "select Log_Type from LoginTable where Username='" + TextBox1.Text + "' AND Password='" + TextBox2.Text + "'";
                string logtype = obj.fun_scaler(str2);
                if (logtype == "admin")
                {
                    Response.Redirect("AdminHome.aspx");
                }
                else if (logtype == "user")
                {
                    string str3 = "select Status from U_Table where User_Id='" + Session["userid"] + "'";
                    string status = obj.fun_scaler(str3);
                    if (status == "active")
                    {
                        Response.Redirect("UserHome.aspx");
                    }
                    else if (status == "inactive")
                    {
                        Label3.Visible = true;
                        Label3.Text = "Blocked User";
                    }
                    else
                    {
                        Label3.Visible = false;
                    }

                }

            }

        }

    }
}