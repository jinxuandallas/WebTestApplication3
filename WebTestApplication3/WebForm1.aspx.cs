using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTestApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Response.Write("Hello world!");
            //TestDataSet.TableDataTable td=new TestDataSet.TableDataTable():
            TestDataSetTableAdapters.TableTableAdapter tta = new TestDataSetTableAdapters.TableTableAdapter();
            GridView1.DataSource = tta.GetData();
            GridView1.DataBind();
            
        }
    }
}