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

public partial class MultiUserControl : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void UserControl11_ChangeTheContents(object sender, EventArgs e)
    {
        UserControl22.SelectedString = "1st UserControl DropDown Text: <b>" + UserControl11.SelectedText + "</b> & Value: <b>" + UserControl11.SelectedValue + "</b>";
        
        UserControl22.Update();
    }

}
