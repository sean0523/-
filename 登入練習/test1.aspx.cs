﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 登入練習
{
    public partial class test1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
            {

            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Click_Click(object sender, EventArgs e)
        {
            if(FileUpload1.PostedFile != null)
            {
                HttpPostedFile myFile = FileUpload1.PostedFile;
                Session["myfile"] = myFile;
                Image1.ImageUrl = "Handler1.ashx";
            }
            string fileName;
            if(FileUpload1.HasFile)
            {
                if(FileUpload1.PostedFile.ContentType.IndexOf("image") == -1)
                {
                    Message.Text = "檔案型態錯誤";
                    return;
                }
                string Extension = FileUpload1.FileName.Split('.')[FileUpload1.FileName.Split('.').Length - 1];
                fileName = string.Format("{0:yyyyMMddhhmmsss}.{1}", DateTime.Now, Extension);
                FileUpload1.SaveAs(Server.MapPath(string.Format("~/image/{0}", fileName)));
            }
            else
            {
                Message.Text = "沒有上傳";
                return;
            }
        }
    }
}