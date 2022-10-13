using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BrowserCompatibility
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpBrowserCapabilities b;
            b = Request.Browser;
            Response.Write("Browser Name is :"+b.Browser);
            Response.Write("Browser Version is :" + b.Version+"<br>");
            Response.Write("Browser Support JavaScript is :" + b.JavaScript + "<br>");
            Response.Write("Browser S is :" + b.Version + "<br>");
            string url = Request.Url.AbsolutePath;
            Response.Write("Url og curent Page is :"+url+"<br>");
            string os = Environment.OSVersion.ToString();
            Response.Write("Windows Version is --:"+os);
        }
    }
}