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
    public partial class UserHome : System.Web.UI.Page
    {
        Connection_Class obj = new Connection_Class();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string s = "select * from CategoryTable";
                DataSet ds = obj.fun_dataAdapter(s);
                DataList1.DataSource = ds;
                DataList1.DataBind();
            }
        }

      

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            int getid = Convert.ToInt32(e.CommandArgument);
            Session["catid"] = getid;
            Response.Redirect("product.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string s = "insert into Feedback(User_Id,Feedback_Message,Status) values(" + Session["userid"] + ",'" + TextBox1.Text + "','pending')";
            obj.fun_nonQuery(s);
        }
    }
}