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
    public partial class User_view : System.Web.UI.Page
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
            string s = "select * from U_Table";
            DataSet ds = obj.fun_dataAdapter(s);
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }





        protected void GridView1_RowEditing1(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            gridbind();
        }

        protected void GridView1_RowCancelingEdit1(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            gridbind();
        }

        protected void GridView1_RowUpdating1(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            TextBox txtsts = (TextBox)GridView1.Rows[i].Cells[8].Controls[0];
            string strup = "update U_Table set Status='" + txtsts.Text + "' where User_Id=" + getid + "";
            obj.fun_nonQuery(strup);
            GridView1.EditIndex = -1;
            gridbind();
        }
    }
}