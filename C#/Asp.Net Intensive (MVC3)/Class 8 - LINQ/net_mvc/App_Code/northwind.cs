using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for northwind
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class northwind : System.Web.Services.WebService {

    public northwind () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }

    [WebMethod]
    public int MultiplyInt(int i)
    {
        return i * 5;
    }
    
    public SqlConnection strConNorthwind = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["con"]);

    [WebMethod(Description = "Returns ID and Company Name of all NorthWind Customrers from SQL Server", EnableSession = false)]
    public DataSet getCustomers()
    {
        SqlDataAdapter custDa = new SqlDataAdapter("SELECT CustomerID, CompanyName FROM Customers", strConNorthwind);
        DataSet custDs = new DataSet();
        custDa.Fill(custDs, "Customers");
        return custDs;
    }

    [WebMethod(Description = "Updates a Northwind Customer and Company Name", EnableSession = false)]
    public DataSet UpdateCustomers(DataSet custDs)
    {
        SqlDataAdapter custDa = new SqlDataAdapter();
        custDa.InsertCommand = new SqlCommand("INSERT INTO Customers(CustomerID,CompanyName) VALUES (@customerid,@companyname)", strConNorthwind);
        custDa.InsertCommand.Parameters.Add("@customerid", SqlDbType.NChar, 5, "CustomerID");
        custDa.InsertCommand.Parameters.Add("@companyname", SqlDbType.NChar, 15, "CompanyName");

        custDa.UpdateCommand = new SqlCommand("UPDATE Customers SET CustomerID=@customerid, CompanyName=@companyname WHERE CustomerID=@oldcustomerid", strConNorthwind);
        custDa.UpdateCommand.Parameters.Add("@customerid", SqlDbType.NChar, 5, "CustomerID");
        custDa.UpdateCommand.Parameters.Add("@companyname", SqlDbType.NChar, 15, "CompanyName");
        SqlParameter objPr = custDa.UpdateCommand.Parameters.Add("@oldcustomerid", SqlDbType.NChar, 5, "CustomerID");
        objPr.SourceVersion = DataRowVersion.Original;

        custDa.DeleteCommand = new SqlCommand("DELETE FROM Customers WHERE CustomerID=@customerid", strConNorthwind);
        custDa.DeleteCommand.Parameters.Add("@customerid", SqlDbType.NChar, 5, "CustomerID");
        objPr.SourceVersion = DataRowVersion.Original;

        custDa.Update(custDs, "Customers");
        return custDs;
    }

}
