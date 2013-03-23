using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Class8_nwind_consume : System.Web.UI.Page
{
    northwind n = new northwind();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet d = n.getCustomers();
        this.GridView1.DataSource = d;
        this.GridView1.DataBind();
    }
    protected void btnInsert_Click(object sender, EventArgs e)
    {
        DataSet ds = n.getCustomers();
        DataTable dt = new DataTable("ds");
        dt = ds.Tables[0];
        DataRow row;
        row = dt.NewRow();
        row["CustomerID"] = this.txtID.Text;
        row["CompanyName"] = this.txtCompanyName.Text;
        dt.Rows.Add(row);

        ds = n.UpdateCustomers(ds);
        this.GridView1.DataSource = ds;
        this.GridView1.DataBind();
    }
}