using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Threading;

namespace final_WebApplication.view
{
    public partial class WebForm_example : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
            {
                Path = "~/scripts/jquery-1.4.1.min.js",
                DebugPath = "~/scripts/jquery-1.4.1.js",
                CdnPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.1.min.js",
                CdnDebugPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.4.1.js"
            });
            date.Text = DateTime.Now.ToString(@"dd-MM-yy");

        }

       


        protected void button_mang_Click(object sender, EventArgs e)
        {
            if(!Request.IsAuthenticated)
                Response.Redirect("EnterYourId.aspx?manager=1");
            else
            {
                Response.Redirect("manager.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!Request.IsAuthenticated)
                Response.Redirect("EnterYourId.aspx?manager=0");
            else
            {
                Response.Redirect("employee.aspx");
            }
        }

      

       
       

       
       
        
    }
}