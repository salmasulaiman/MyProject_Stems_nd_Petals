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
    public partial class add_edit_product : System.Web.UI.Page
    { Connection_Class obj = new Connection_Class();
        protected void Page_Load(object sender, EventArgs e)
        {if (!IsPostBack)
            {
                string s = "select Category_Id,Category_Name from CategoryTable";
                DataSet ds = obj.fun_dataAdapter(s);
                DropDownList1.DataSource = ds;
                DropDownList1.DataTextField = "Category_Name";
                DropDownList1.DataValueField = "Category_Id";
                DropDownList1.DataBind();

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/phsProduct/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            string s = "insert into Product values('"+DropDownList1.SelectedItem.Value+"','" + TextBox1.Text + "','" + TextBox2.Text + "','" + p + "','" + TextBox3.Text + "','" + TextBox4.Text + "','"+TextBox5.Text+"')";
            int i = obj.fun_nonQuery(s);
            if (i == 1)
            {
                Label8.Text = "inserted";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            gridbind();

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            gridbind();

        }
        public void  gridbind()
        {
            string s = "select * from Product";
            DataSet ds = obj.fun_dataAdapter(s);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex =-1;
            gridbind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            TextBox txtstatus = (TextBox)GridView1.Rows[i].Cells[8].Controls[0];
            TextBox txtdescription = (TextBox)GridView1.Rows[i].Cells[6].Controls[0];
            TextBox txtstock = (TextBox)GridView1.Rows[i].Cells[7].Controls[0];
            string strup = "update Product set Product_Description='" + txtdescription.Text + "',Product_Stock='" + txtstock.Text + "',Product_Status='" + txtstatus.Text + "' where Product_Id=" + getid + "";
            obj.fun_nonQuery(strup);
            GridView1.EditIndex = -1;
            gridbind();
        }
    }
}