using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for Handler1
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            var img = context.Request.Form["File1"] ?? context.Request.QueryString["File1"];

            context.Response.ContentType = "text/html";
            context.Response.Redirect(@"view.html?File1=" + img.Split(new Char[] { '\\' }).Last());
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