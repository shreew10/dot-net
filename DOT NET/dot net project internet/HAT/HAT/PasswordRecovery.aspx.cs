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

public partial class PasswordRecovery : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Fires when Submit button clicked at first step
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void PasswordRecovery1_VerifyingUser(object sender, LoginCancelEventArgs e)
    {
        e.Cancel = false;
    }

    /// <summary>
    /// Fires when Submit button is clicked at second step
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void PasswordRecovery1_VerifyingAnswer(object sender, LoginCancelEventArgs e)
    {

    }


    /// <summary>
    /// Fires when Submit button is clicked at the last step
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void PasswordRecovery1_SendingMail(object sender, MailMessageEventArgs e)
    {

    }
}
