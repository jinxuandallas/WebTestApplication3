using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Core;

namespace WebTestApplication3.RichTextBox
{
    public partial class SaveDatabase : System.Web.UI.Page
    {
        protected ManageRichtextboxContent mrc;
        protected void Page_Load(object sender, EventArgs e)
        {
            mrc=new ManageRichtextboxContent();
            mrc.SavetoDatabase("xx");
            Response.Write("success");
        }
    }
}