using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 登入練習
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void new_Click(object sender, EventArgs e)
        {
            string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["UsersConnectionString3"].ConnectionString;

            SqlConnection connection = new SqlConnection(s_data);
            string sql = $"insert into [account](username,password) values(@username,@password)";
            connection.Open();

            SqlCommand Command = new SqlCommand(sql, connection);

            Command.Parameters.Add("@username", SqlDbType.NVarChar);
            Command.Parameters["@username"].Value = userID.Text;

            Command.Parameters.Add("@password", SqlDbType.NVarChar);
            Command.Parameters["@password"].Value = userPWD.Text;

            Command.ExecuteNonQuery();

            connection.Close();
            Response.Redirect("Main");

        }

        protected void cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main");
        }
    }
}