using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class timerPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Fires when timer tick event occurs
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        lblMessage1.Text = "First Update Panel: " + DateTime.Now.ToLongTimeString();
        lblMessage2.Text = "<p>Second Update Panel: " + DateTime.Now.ToLongTimeString() + "</p>";

    }
}
