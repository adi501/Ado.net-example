using System;
using System.Data;
using System.Data.SqlClient;

namespace ADOdotnet_With_ASPdotnet
{
    public partial class Delete_a_record_using_sqlcommand_class : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=DB_EMP;Integrated Security=True");
            //string s = "Delete emp where empid=1";
            //SqlCommand cmd;
            //cmd = new SqlCommand(s, con);
            //cmd.CommandType = CommandType.Text;
            //con.Open();
            //cmd.ExecuteNonQuery();
            //con.Close();

            //SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=DB_EMP;Integrated Security=True");
            //string s = "Delete emp where empid=1";
            //SqlCommand cmd;
            //cmd = new SqlCommand(s, con);
            //cmd.CommandType = CommandType.Text;
            //con.Open();
            //int i = cmd.ExecuteNonQuery();
            //con.Close();
            //lbl_msg.Text = "Records deleted";

            SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Training;Integrated Security=True");
            string s = "Delete emp where empid=1";
            SqlCommand cmd;
            cmd = new SqlCommand(s, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            lbl_msg.Text = i + "Records deleted";

        }
    }
}