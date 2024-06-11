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
    public partial class product : System.Web.UI.Page
    { Connection_Class obj = new Connection_Class();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                string s = "select * from Product where Category_Id=" + Session["catid"] + "";
                DataSet ds = obj.fun_dataAdapter(s);
                DataList1.DataSource = ds;
                DataList1.DataBind();

            }
        }

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            int getid = Convert.ToInt32(e.CommandArgument);
            Session["proid"] = getid;
            Response.Redirect("one_product.aspx");
        
    }
    }
}