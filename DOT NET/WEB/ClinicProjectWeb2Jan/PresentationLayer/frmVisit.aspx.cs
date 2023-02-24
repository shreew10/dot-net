using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClinicProjectWeb2Jan.PresentationLayer
{
    public partial class frmVisit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Abc");
            dt.Rows.Add("shree", "bnv");
            dt.Rows.Add("shree", "bnv");
            dt.Rows.Add("shree", "bnv");
            dt.Rows.Add("shree", "bnv");
            dt.Rows.Add("shree", "bnv");
            dt.Rows.Add("shree", "bnv");
            dt.Rows.Add("shree", "bnv");
            dt.Rows.Add("shree", "bnv");
            dt.Rows.Add("shree", "bnv");
            dt.Rows.Add("shree", "bnv");
            grv_medication.DataSource = dt;
            grv_medication.DataBind();
            //grv_medication.Rows[0].Visible = false;

            DataTable dt1 = new DataTable();
            dt1.Rows.Add();
            grv_visitDetails.DataSource = dt;
            grv_visitDetails.DataBind();
            grv_investigation.DataSource = dt;
            grv_investigation.DataBind();

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void tc_visit_ActiveTabChanged(object sender, EventArgs e)
        {

        }

        protected void tc_inside_ActiveTabChanged(object sender, EventArgs e)
        {

        }
    }
}