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

public partial class receipt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    
    /// <summary>
    /// Fires when record inserted successfully
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void FormView1_ItemInserted(object sender, FormViewInsertedEventArgs e)
    {
        lblError.Text = "Record Inserted Successfully.";
        lblError.ForeColor = System.Drawing.Color.Blue;
    }

    /// <summary>
    /// Fires when Cancel button is clicked
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void FormView1_ItemCommand(object sender, FormViewCommandEventArgs e)
    {
        if (e.CommandName == "Cancel")
        {
            Response.Redirect("depositList.aspx", true);
        }
    }
}
