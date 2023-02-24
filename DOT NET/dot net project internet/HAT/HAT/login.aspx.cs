using System;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Fires when Login button is clicked
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        string connStr = ConfigurationManager.ConnectionStrings["ConnString"].ToString();

        OleDbConnection conn = new OleDbConnection(connStr);
        conn.Open();
        try
        {
            OleDbCommand dCmd = new OleDbCommand("SELECT count(users) from Users WHERE name = '" + Login1.UserName + "' AND pass = '" + Login1.Password + "'", conn);
            int count = 0;
            Int32.TryParse(dCmd.ExecuteScalar().ToString(), out count);
            if (count.Equals(1))
            {
                e.Authenticated = true;
                FormsAuthentication.RedirectFromLoginPage(Login1.UserName, Login1.RememberMeSet);
            }
            else
            {
                e.Authenticated = false;
            }
        }
        catch (Exception ee)
        {
            lblMessage.Text = "Error occured. <br> " + ee.ToString();
        }
        finally
        {
            conn.Close();
            conn.Dispose();
        }
    }

    /// <summary>
    /// Fires after failure of login attempt
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Login1_LoginError(object sender, EventArgs e)
    {
        lblMessage.Text = "Please try agian!.";
    }
    
}
