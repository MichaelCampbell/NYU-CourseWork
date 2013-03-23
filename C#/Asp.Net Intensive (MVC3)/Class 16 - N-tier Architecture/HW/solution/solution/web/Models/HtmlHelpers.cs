using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactWeb.Models
{
    public static class HtmlHelpers
    {
        public static MvcHtmlString MenuItem(this HtmlHelper helper, MvcHtmlString link, string controller)
        {
            var li = new TagBuilder("li");
            if (helper.ViewContext.Controller.GetType().Name.ToLower() == String.Format("{0}controller", controller).ToLower())
                li.Attributes.Add("class", "selected");
            li.InnerHtml = link.ToHtmlString();
            return new MvcHtmlString(li.ToString());
                

        }
    }
}