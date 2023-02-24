using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TabContainerExample
{
    public partial class tab_container_exam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TabContainer1.ActiveTabIndex = 0;
        }

        protected void TabContainer1_ActiveTabChanged(object sender, EventArgs e)
        {
            if(TabContainer1.ActiveTabIndex==0)
            {
                txt_stud_name.Text = "";
                txt_stud_city.Text = "";
            }
        }
    }
}