using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 登入練習
{
    public partial class 登入畫面 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PWDText.Text = "";
            UserText.Text = "";
            if (Session["logined"] != null && Session["logined"].ToString() == "1")
            {
                Response.Redirect("game");
            }
        }

        protected void login_Click(object sender, EventArgs e)
        {
            if (user.Text == "user")
            {
                if (PWD.Text == "123")
                {
                    Application["count"] = Convert.ToInt32(Application["count"]) + 1;
                    Session["logined"] = "1";
                    string Name = name.Text;
                    Session["name"] = Name;
                    Response.Redirect("game");
                }
                else
                {
                    PWDText.Text = "使用者密碼錯誤";
                }
            }
            else
            {
                UserText.Text = "使用者帳號錯誤";
            }
        }

        protected void login1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["UsersConnectionString3"].ConnectionString;

            SqlConnection connection = new SqlConnection(s_data);
            string sqlText = "select * from account where username ='" + user.Text + "'";

            SqlCommand Command = new SqlCommand(sqlText, connection);

            
            connection.Open();

            SqlDataReader Reader = Command.ExecuteReader();


            if (Reader.HasRows)
            {
                if (Reader.Read())
                {

                    if (Reader[2].ToString() == PWD.Text)
                    {
                        
                        Application["count"] = Convert.ToInt32(Application["count"]) + 1;
                        Session["logined"] = "1";
                        string Name = name.Text;
                        Session["name"] = Name;
                        Response.Redirect("game");
                    }
                    else
                    {
                        PWDText.Text = "密碼錯誤";
                    }
                }
            }
            else
            {
                UserText.Text = "無此帳號";
            }
            connection.Close();
        }

        protected void register_Click(object sender, EventArgs e)
        {
            Response.Redirect("register");
        }
    }
}
