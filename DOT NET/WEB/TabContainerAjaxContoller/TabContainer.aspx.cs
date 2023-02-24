using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TabContainerAjaxContoller
{
    public partial class TabContainer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tabcontainer1.ActiveTabIndex = 1;
        }

        protected void tabcontainer1_ActiveTabChanged(object sender, EventArgs e)
        {
            if (tabcontainer1.ActiveTabIndex == 0)
            {
                TextBox1.Text = "";
            }
        }
    }
}