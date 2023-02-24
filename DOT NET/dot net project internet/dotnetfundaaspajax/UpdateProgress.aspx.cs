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

public partial class UpdateProgress : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Submit form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="?"></param>
    protected void SubmitForm(object sender, EventArgs e)
    {
        System.Threading.Thread.Sleep(2000);

        lblMessage.Text = "<hr />Name: <b>" + txtName.Text + "</b> <p>" +
            "Address: <b>" + txtAddress.Text + "</b></p>";
    }

    /// <summary>
    /// Fires when 2nd update panel button fires
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void WriteTime(object sender, EventArgs e)
    {
        System.Threading.Thread.Sleep(2000);

        lblMessage1.Text = "Current Time: " + DateTime.Now.ToString();
    }


}
