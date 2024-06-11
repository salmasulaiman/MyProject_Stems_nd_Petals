using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace MyProject
{
    public partial class MailSend : System.Web.UI.Page
    { Connection_Class obj = new Connection_Class();
        protected void Page_Load(object sender, EventArgs e)
        {
            string se = "select Feedback_Message,user_id from Feedback ";

            DataSet ds = obj.fun_dataAdapter(se);
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }
     public static void SendEmail2(string yourName, string yourGmailUserName, string yourGmailPassword, string toName, string toEmail, string subject, string body)
        {
            string to = toEmail; //To address    
            string from = yourGmailUserName; //From address    
            MailMessage message = new MailMessage(from, to);

            string mailbody = body;
            message.Subject = subject;
            message.Body = mailbody;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential(yourGmailUserName, yourGmailPassword);
            client.EnableSsl = true;
            client.UseDefaultCredentials = true;
            client.Credentials = basicCredential1;
            try
            {
                client.Send(message);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string up = "update Feedback set Replay_Message='" + TextBox4.Text + "',Status='send' where User_Id=" + Session["uid"] + "";
            obj.fun_nonQuery(up);

            string s = "select Email,Name from U_Table where User_Id=" + Session["uid"] + "";
            SqlDataReader dr = obj.fun_Datareader(s);
            string email = "";
            string name = "";
            while (dr.Read())
            {
                email = dr["Email"].ToString();
                name = dr["Name"].ToString();

            }
            SendEmail2("Admin", "myapplicationdemomailid@gmail.com", "njgn jnic zzvy hucv", name, email, TextBox3.Text, TextBox4.Text);

        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            Panel1.Visible = true;
            int getid = Convert.ToInt32(e.CommandArgument);
            Session["uid"] = getid;
            
            string s = "select Email from U_Table where User_Id=" + getid + "";
            SqlDataReader dr = obj.fun_Datareader(s);
            string email = "";

            while (dr.Read())
            {
                email = dr["Email"].ToString();
             }

            TextBox1.Text = email;
        }

        
    }
}



