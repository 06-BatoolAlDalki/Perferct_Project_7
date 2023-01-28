using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project7
{
    public partial class AdminUsers : System.Web.UI.Page
    {
        project7Entities db = new project7Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            var data = db.AspNetUsers.ToList();
            GridView1.DataSource= data;
            GridView1.DataBind();
        }
    }
}