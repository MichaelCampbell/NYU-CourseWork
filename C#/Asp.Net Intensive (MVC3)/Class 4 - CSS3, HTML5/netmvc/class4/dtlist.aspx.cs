using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class class4_dtlist : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //string strCon = "Data Source=localhost;Initial Catalog=Northwind;User ID=nyu_sb;Password=nyu_pwd";
	    string strCon = "Data Source=.\\SQLEXPRESS;AttachDbFilename=H:\\.Net Intensive\\Class 4\\netmvc\\class4\\SQL Server 2000 Sample Databases\\NorthWND.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        string strSQL = "SELECT Customerid, CompanyName, ContactName FROM Customers";
        string strResults = "<datalist id='mylist'>";

        SqlConnection objCon = new SqlConnection(strCon);
        try
        {    
            objCon.Open();
            SqlCommand objCmd = new SqlCommand(strSQL, objCon);
            SqlDataReader objReader;

            objReader = objCmd.ExecuteReader();
            while (objReader.Read())
            {
                strResults += "<option label='" + objReader["ContactName"] + " (" + objReader["CompanyName"] + ")' value='" + objReader["CustomerID"] + "' />";
            }
            strResults += "</datalist>";
            dl.InnerHtml= strResults;
            objCmd.Dispose();
        }
        catch (Exception ex)
        {
            strResults = "<b>Error while accessing data </b><br />" + ex.Message.ToString() + "<br />" + ex.Source.ToString();
            err.InnerHtml = strResults;
        }
	finally
	{
            objCon.Close();
            objCon.Dispose();
	}
    }
}