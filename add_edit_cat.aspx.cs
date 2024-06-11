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
    public partial class add_edit_cat : System.Web.UI.Page
    {
        Connection_Class obj = new Connection_Class();
        protected void Page_Load(object sender, EventArgs e)
        {
           if(!IsPostBack)
            {
                Panel1.Visible = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/phs/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            string s = "insert into CategoryTable values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + p + "','" + TextBox4.Text + "')";
            int i = obj.fun_nonQuery(s);
            if(i==1)
            {
                Label5.Text = "inserted";
            }

        }

       

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            gridbind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            gridbind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            TextBox txtstatus = (TextBox)GridView1.Rows[i].Cells[5].Controls[0];
            TextBox txtdescription = (TextBox)GridView1.Rows[i].Cells[3].Controls[0];

            string strup = "update CategoryTable set Category_Description='" + txtdescription.Text + "',Category_Status='" + txtstatus.Text + "' where Product_Id=" + getid + "";
            obj.fun_nonQuery(strup);
            GridView1.EditIndex = -1;
            gridbind();
        }
        public void gridbind()
        {
            string s = "select * from CategoryTable";
            DataSet ds = obj.fun_dataAdapter(s);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            string s = "select * from CategoryTable";
            DataSet ds = obj.fun_dataAdapter(s);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}