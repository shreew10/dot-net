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

public partial class UserControl2 : System.Web.UI.UserControl
{
    private string m_SelectedString = string.Empty;
    public string SelectedString
    {
        get { return m_SelectedString; }
        set { m_SelectedString = value; }
    }
    public UpdatePanelUpdateMode UpdateMode
    {
        get { return this.UpdatePanel2.UpdateMode; }
        set { this.UpdatePanel2.UpdateMode = value; }
    }

    public void Update()
    {
        this.UpdatePanel2.Update();
    }

    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);
        ChangeDataOfThisPanel(); // change the data accordingly
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    private void ChangeDataOfThisPanel()
    {
        lblMessage.Text = "UC 2 -> " + m_SelectedString;
    }
}
