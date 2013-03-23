using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Configuration;

public partial class class7_sample_data1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string strCon = ConfigurationManager.AppSettings["db_connection"];
        string strSQL = "SELECT * FROM Customers";

        SqlConnection objCon = new SqlConnection(strCon);
        SqlDataAdapter objAd = new SqlDataAdapter(strSQL, objCon);
        SqlCommand objCmd = new SqlCommand(strSQL, objCon);
        //OleDbConnection objCon;
        //OleDbDataAdapter objAd;
        DataSet ds = new DataSet();

        //objCon = new OleDbConnection(strCon);
        //objAd = new OleDbDataAdapter(strSQL, objCon);
        //objAd.Fill(ds, "customers");
        objAd.Fill(ds, "customers");

        GridView1.DataSource = ds.Tables["customers"].DefaultView;
        GridView1.DataBind();

        objCon.Close();
        objCon.Dispose();
    }
}