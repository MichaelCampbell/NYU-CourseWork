using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Class8_LINQ : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DisplayData();
    }
    private void DisplayData()
    {
        DataClassesDataContext db = new DataClassesDataContext();
        var products = from p in db.Products
                       where p.Category.CategoryName == "Confections"
                       select p;
        GridView1.DataSource = products;
        GridView1.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DataClassesDataContext db = new DataClassesDataContext();
        Product product = db.Products.SingleOrDefault(p => p.ProductID == 16);
        product.UnitPrice = product.UnitPrice + 2;
        product.UnitsInStock = 70;
        db.SubmitChanges();
        DisplayData();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        DataClassesDataContext db = new DataClassesDataContext();
        //create new category and products
        Category category = new Category();
        category.CategoryName = "Confections";
        Product product1 = new Product();
        product1.ProductName = "Toy 1";

        Product product2 = new Product();
        product2.ProductName = "Toy 2";

        //associate Product with category
        category.Products.Add(product1);
        category.Products.Add(product2);
        //add category to database and save changes
        db.Categories.InsertOnSubmit(category);
        db.SubmitChanges();
        DisplayData();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        DataClassesDataContext dbContext = new DataClassesDataContext();
        var query = from p in dbContext.Products
                    where p.ProductName.Contains("Toy 2")
                    select p;
        dbContext.Products.DeleteAllOnSubmit(query);
        dbContext.SubmitChanges();
        DisplayData();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        DataClassesDataContext db = new DataClassesDataContext();
        var products = northwind. 
        
        db.SubmitChanges();
        DisplayData();
    }
}