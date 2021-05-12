using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 登入練習
{
    public partial class readdbForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["UsersConnectionString3"].ConnectionString;

            SqlConnection connection = new SqlConnection(s_data);

            string sqlText = "select* from account";
            SqlCommand Command = new SqlCommand(sqlText, connection);


            connection.Open();


            SqlDataReader Reader = Command.ExecuteReader();

            if (Reader.HasRows)
            {

                if (Reader.Read())
                {
                    Label1.Text = Reader[0].ToString();
                }
            }

            connection.Close();
        }
    }
}