using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ajaxExample
{
    public partial class timerExam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        


        protected void Timer1_Tick1(object sender, EventArgs e)
        {
            lbl_dt_time.Text = DateTime.Now.ToString();
        }
    }
}