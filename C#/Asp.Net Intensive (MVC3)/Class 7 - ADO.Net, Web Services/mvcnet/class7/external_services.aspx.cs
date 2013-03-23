using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using zip;

public partial class class7_external_services : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_Click(object sender, EventArgs e)
    {
        //Web Reference: http://www.webservicex.net/uszip.asmx?WSDL 
        string txt = txtZip.Text;
        USZipSoapClient z = new USZipSoapClient("USZipSoap");
        XmlDocument x = new XmlDocument();

        string a = z.GetInfoByZIP(txt).InnerXml;
        x.LoadXml(a);

        XmlNodeList city = x.GetElementsByTagName("CITY");
        XmlNodeList state = x.GetElementsByTagName("STATE");
        XmlNodeList zip = x.GetElementsByTagName("ZIP");
        XmlNodeList area_code = x.GetElementsByTagName("AREA_CODE");

        rt.InnerHtml = "<br />City: " + city.Item(0).InnerText + "<br />State: " + state.Item(0).InnerText + "<br />Zip Code: " + zip.Item(0).InnerText + "<br />Area Code: " + area_code.Item(0).InnerText;
    }
}