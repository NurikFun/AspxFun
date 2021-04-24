using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspxFun
{
    public partial class ProductList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var context = new DataContext())
            {
                var products = (from d in context.Products
                                select new { d.Name, d.ProductNumber }
                    ).ToList();
                Gridview1.DataSource = products;
                Gridview1.DataBind();
            }
        }
    }
}