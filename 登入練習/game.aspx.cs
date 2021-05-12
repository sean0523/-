using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 登入練習
{
    public partial class 遊戲介面 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["logined"] == null)
            {
                Response.Redirect("Main");
            }
                Label2.Text = "目前線上人數:" + Application["count"];
        }

        protected void buttomClick(object sender, ImageClickEventArgs e)
        {
            int user = 0;
            int i = 1;
            string Win;
            if (sender == ImageButton1)
            {
                user = 1;
                userResult.Text = "玩家出剪刀";
            }
            else if (sender == ImageButton2)
            {
                user = 2;
                userResult.Text = "玩家出石頭";
            }
            else if (sender == ImageButton3)
            {
                user = 3;
                userResult.Text = "玩家出布";
            }

            Random rnd = new Random();
            int computer = rnd.Next(1, 4);
            if (computer == 1)
            {
                computerResult.Text = "電腦出剪刀";
                computerImage.ImageUrl = "~/pic/scissors.png";
            }
            else if (computer == 2)
            {
                computerResult.Text = "電腦出石頭";
                computerImage.ImageUrl = "~/pic/stone.png";
            }
            else if (computer == 3)
            {
                computerResult.Text = "電腦出布";
                computerImage.ImageUrl = "~/pic/paper.png";
            }


            if ((user == 1 && computer == 3) ||
                (user == 2 && computer == 1) ||
                (user == 3 && computer == 2))
            {
                final.Text = "玩家贏了";
                Session["Win"] = Convert.ToInt32(Session["Win"]) + i;
            }
            else if ((user == 1 && computer == 2)
                || (user == 2 && computer == 3)
                || (user == 3 && computer == 1))
            {
                final.Text = "玩家輸了";
                Session["Lost"] = Convert.ToInt32(Session["Lost"]) + i;
            }
            else
            {
                final.Text = "平手";
                Session["Nowin"] = Convert.ToInt32(Session["Nowin"]) + i;
            }
            gameResult.Text = "贏:" + Session["Win"] +"次" + "&nbsp;&nbsp;&nbsp "
                                + "輸:" + Session["Lost"] + "次" + "&nbsp;&nbsp;&nbsp"
                                + "平手:" + Session["Nowin"] + "次";
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Application["count"] = Convert.ToInt32(Application["count"]) -1 ;
            Response.Redirect("Main");
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            if (Application["messageResult"] != null)
            {
                chatResult.Text = Application["messageResult"].ToString();
            }
        }
        protected void SendBtn_Click(object sender, EventArgs e)
        {
            string message = inputText.Text;       
            Application["messageResult"] = Application["messageResult"] + Session["name"].ToString() + ":" + message + "</br>";
        }
    }
}