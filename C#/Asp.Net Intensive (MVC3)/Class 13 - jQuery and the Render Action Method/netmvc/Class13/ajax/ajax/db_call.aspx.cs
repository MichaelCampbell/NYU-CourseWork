using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class ajax_db_call : System.Web.UI.Page
{
        protected void Page_Load(object sender, EventArgs e)
    {
        string strCon = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\netmvc\\Class13\\SQL Server 2000 Sample Databases\\NORTHWND.MDF;Integrated Security=True;Connect Timeout=30;User Instance=True";

        SqlConnection objCon;
        SqlCommand objCmd;
        DataSet ds = new DataSet();
        string strResults = "";

        objCon = new SqlConnection(strCon);
        objCon.Open();
        //SqlDataReader objReader;
        objCmd = new SqlCommand("SELECT * FROM Customers", objCon);

        //Looping manually

        SqlDataReader objReader = objCmd.ExecuteReader();
        Int32 column_count = objReader.FieldCount;
        Int32 iCol;
        strResults += "<table><tr>";
        for (iCol = 0; iCol < column_count; iCol++)
        {
            strResults += "<td><b>" + objReader.GetName(iCol).ToString() + "</b></td>";
        }
        strResults += "</tr>";
        while (objReader.Read())
        {
            strResults += "<tr>";
            for (iCol = 0; iCol < column_count; iCol++)
            {
                if (objReader[iCol] == System.DBNull.Value)
                {
                    strResults += "<td>&nbsp;</td>";
                }
                else
                {
                    strResults += "<td>" + objReader[iCol] + "</td>";
                }
            }
            strResults += "</tr>";
        }
        strResults += "</table>";
        Response.Write(strResults);
        objCmd.Dispose();
        objCon.Close();
        objCon.Dispose();
    }
    
}