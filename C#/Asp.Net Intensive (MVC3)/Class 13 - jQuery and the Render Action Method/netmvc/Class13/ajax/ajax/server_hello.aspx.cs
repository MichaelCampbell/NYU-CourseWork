using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ajax_server_hello : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string passedValue = this.Request.Form["msg"];
        string returnMessage = "You passed me the following value " + passedValue;
        Response.Write(returnMessage);
    }
}