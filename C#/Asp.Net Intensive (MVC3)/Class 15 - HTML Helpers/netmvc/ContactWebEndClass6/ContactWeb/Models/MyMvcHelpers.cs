using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages.Html;
using System.Web.Mvc;

namespace ContactWeb.Models
{
    public static class MyMvcHelpers
    {
        public static string Exclamation(this System.Web.WebPages.Html.HtmlHelper helper, string data)
        {
            return String.Format("{0}!", data.ToUpper());
        }
    }
}