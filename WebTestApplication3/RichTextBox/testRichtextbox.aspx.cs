using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Core;

namespace WebTestApplication3.RichTextBox
{
    public partial class testRichtextbox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "<b>Test</b>";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //xheditor控件似乎包含防脚本攻击
            Label1.Text = elm1.InnerText;
            divBox.InnerHtml = elm1.InnerText;
            ManageRichtextboxContent mrc = new ManageRichtextboxContent();
            mrc.SavetoDatabase(elm1.InnerText);
            Response.Write("success");
           // divBox.InnerHtml = HttpUtility.HtmlDecode(HttpUtility.HtmlEncode(elm1.InnerHtml));
        }
       /* protected string zy(string a)
        {
            HttpUtility.HtmlEncode(a);

        }*/
    }
}