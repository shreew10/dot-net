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

public partial class multiup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Inside update panel
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ChangeDateTimeInside(object sender, EventArgs e)
    {
        lblInside.Text = Calendar1.SelectedDate.ToLongDateString();
        lblInside.Text += "<p>Inside Panel TextBox Value: <b>" + txtInside.Text + "</b></p>";
        lblInside.Text += "<p>Outside Panel TextBox Value: <b>" + txtOutside.Text + "</b></p>";
    }

    /// <summary>
    /// Outside update panel
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ChangeDataTimeOutside(object sender, EventArgs e)
    {
        lblOutside.Text = Calendar2.SelectedDate.ToLongDateString();
    }

    

}
