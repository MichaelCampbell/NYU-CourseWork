using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class class7_adonet_connect_manual : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string strCon = ConfigurationManager.AppSettings["db_connection"];
        string strSQL = "SELECT * FROM Customers";
        string strResults = "<table border='1'>";
        SqlConnection objCon = new SqlConnection(strCon);
        try
        {
            objCon.Open();
            SqlCommand objCmd = new SqlCommand(strSQL, objCon);
            SqlDataReader objReader;

            objReader = objCmd.ExecuteReader();
            Int32 column_count = objReader.FieldCount;
            Int32 iCol;

            strResults += "<tr>";
            for (iCol = 0; iCol < column_count; iCol++)
            { strResults += "<td>" + objReader.GetName(iCol).ToString() + "</td>"; }
            strResults += "</tr>";

            while (objReader.Read())
            {
                strResults += "<tr>";
                for (iCol = 0; iCol < column_count; iCol++)
                {
                    if (objReader[iCol] != System.DBNull.Value)
                    { strResults += "<td>" + objReader[iCol] + "</td>"; }
                    else
                    { strResults += "<td>&nbsp;</td>"; }
                }
                strResults += "</tr>";
            }

            strResults += "</table>";
            //strResults.InnerHtml = strResults;
            //Response.Write(strResults);
            objCmd.Dispose();
        }
        catch (Exception ex)
        {
            strResults = "<b>Error while accessing data </b><br />" + ex.Message.ToString() + "<br />" + ex.Source.ToString();
        }
        finally
        {
            objCon.Close();
            objCon.Dispose();
        }


    }
}