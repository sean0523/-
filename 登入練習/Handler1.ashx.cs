using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace 登入練習
{
    /// <summary>
    /// Handler1 的摘要描述
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            if (context.Session["myfile"] !=null)
            {
                HttpPostedFile myFile = (HttpPostedFile)context.Session["myfile"];
                int myFile_Length = myFile.ContentLength;
                byte[] myData = new byte[myFile_Length];

            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}