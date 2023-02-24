using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for impFunction
/// </summary>
public class impFunction
{
	public impFunction()
	{
		
	}

    /// <summary>
    /// Handle the depth of the treeview
    /// </summary>
    /// <param name="expandDepth"></param>
    public static void HandleTreeVIewDepth(Page th, int expandDepth)
    {
        TreeView t = (TreeView)th.Master.FindControl("TreeView1");
        t.ExpandDepth = expandDepth;
        t.Dispose();
    }
}
