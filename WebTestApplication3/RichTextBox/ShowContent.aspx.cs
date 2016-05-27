using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Core;

namespace WebTestApplication3.RichTextBox
{
    public partial class ShowContent : System.Web.UI.Page
    {
        public GetContent gc;
        public string content;
        protected void Page_Load(object sender, EventArgs e)
        {
            gc = new GetContent();
            content = gc.getContent();
            contentDiv.InnerHtml = content;
            Literal1.Text = content;
        }

       
    }
}