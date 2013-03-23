using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using SendSMS;

public partial class SMS : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_Click(object sender, EventArgs e)
    {
        string fromEmail = txtFrom.Text;
        string countryCode = txtCntCode.Text;
        string receipent = txtTo.Text;
        string message = txtMessage.Text;
        SendSMSWorldSoapClient msg = new SendSMSWorldSoapClient();
        XmlDocument x = new XmlDocument();


    }
}