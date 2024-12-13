using System;
using System.Data.SqlClient;

namespace ADOdotnet_With_ASPdotnet
{
    public partial class Connect_to_sqlserver_using_sqlclient_provider : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_connect_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            con = new SqlConnection("Data Source=(local);Initial Catalog=Training;Integrated Security=True");
            con.Open();
           lbl_message.Text="connected succefully";

        }
    }
}