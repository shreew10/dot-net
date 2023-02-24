using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ajaxExample
{
    public partial class Calender_WF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txt_dt_time.Attributes.Add("ReadOnly", "true");
        }
    }
}