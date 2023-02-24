using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PageLifeCycleExample
{
    public partial class WF_lifeCycle : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            //Postback,Value,ViewState operation not allowed
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            //Control Value initialize
        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            //Security Example/Hacking
        }

        protected override void OnPreLoad(EventArgs e)
        {
            //Work and It will assign the values to label.  
            //If the page is post back, then label contrl values will be loaded from view state.  
            //You can add/modify any thing before load any control

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //All control,View,Session,State Load
            //after button click IsPostBack property set as true
            if (IsPostBack == true)
            {
                //if IsPostBack property is true then execute the code
            }
            if (!IsPostBack)
            {
                //if IsPostBack property is not true then execute the block of code
                // this block is execute when page is load at first time
            }
        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            //set IsPostBack=true
            //on click on submit button first call page load event and after page load exectue instruction in button click event 
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            //Comman function call
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
        }

        protected override void OnPreRender(EventArgs e)
        {
            //Convert ASP-HTML Code 
        }
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected override void OnPreRenderComplete(EventArgs e)
        {
            //After bound called
        }
        protected override void OnSaveStateComplete(EventArgs e)
        {
            // All state get save on page

        }
        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //distroy all obj
            //unload used ressourcess
            //reset all controls values and properties
            //clear all states
            //reset all vriables values
            //Clear memrory
            //Clear all control
        }
    }
}