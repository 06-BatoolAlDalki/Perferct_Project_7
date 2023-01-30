using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project7
{
    public partial class rama : System.Web.UI.Page
    {
        project7Entities db = new project7Entities();
        protected void Page_Load(object sender, EventArgs e)
        {

           var data = db.Products.ToList();
            GridView2.DataSource= data;
            GridView2.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //var data = db.Products
            //               .Where(entity => entity.nameProduct.Contains(TextBox1.Text))
            //               .ToList(); ;
            var data = db.Products.Where(s => s.nameProduct.Contains(TextBox1.Text)).ToList();
            GridView1.DataSource= data;
            GridView1.DataBind();


        }
    }
}