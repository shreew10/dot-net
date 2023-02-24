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

public partial class UserControl1 : System.Web.UI.UserControl
{
    public UpdatePanelUpdateMode UpdateMode
    {
        get { return this.UpdatePanel1.UpdateMode; }
        set { this.UpdatePanel1.UpdateMode = value; }
    }

    public void Update()
    {
        this.UpdatePanel1.Update();
    }


    public string SelectedText
    {
        get { return dropDown1.SelectedItem.Text; }
    }
    
    public string SelectedValue
    {
        get { return dropDown1.SelectedItem.Value; }
    }

    public event EventHandler SelectedIndexChanged;

    protected void OnSelectedIndexChanged(EventArgs e)
    {
        if (SelectedIndexChanged != null)
        {
            SelectedIndexChanged(this, e);
        }
    }

   

    protected override void OnInit(EventArgs e)
    {
        base.OnInit(e);
        this.dropDown1.SelectedIndexChanged += this.FireChangeEvent;
    }


    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void FireChangeEvent(object sender, EventArgs e)
    {
        lblDrop.Text = "UC 1 -> Selected Text: <b>" + dropDown1.SelectedItem.Text + "</b> & Value: <b>"+ dropDown1.SelectedItem.Value + "</b>" ;
        if (SelectedIndexChanged != null)
        {
            this.SelectedIndexChanged(this, e);
        }
    }
    
}
