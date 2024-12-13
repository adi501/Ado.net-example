using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADOdotnet_With_ASPdotnet
{
    public partial class Delete_a_record_by_using_the_parameterized_query : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=Training;Integrated Security=True");
                string s = "Delete Tbl_Emp where Id=@x";
                SqlCommand cmd = new SqlCommand(s, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@x", txt_emp_id.Text);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                lbl_msg.Text = i + "Records deleted";
                lbl_msg.ForeColor = System.Drawing.Color.Green;

            }
            catch (Exception ex)
            {
                string path = Server.MapPath("~/Error/Error.txt");
                File.AppendAllText(path, DateTime.Now + ":" + ex.ToString());
                lbl_msg.Text = ex.ToString();
                lbl_msg.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}