using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace GRDTemplateField
{
    public partial class GridOperation : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            GridLoadNew();
        }
        public void GridLoadNew()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT studRollno,studName,studGender,studSubject FROM tbl_student_details", conn);
                //DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                cmd.Connection.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                //sda.Fill(ds, "tbl_student_details");
                cmd.Connection.Close();
                //grv_crud.DataSource = ds.Tables["tbl_student_details"];
                sda.Fill(dt);
                grv_crud.DataSource = dt;
                grv_crud.DataBind();

                //grv_crud.DataSource = ds.Tables[0];
                //grv_crud.DataBind();
                grv_details.DataSource = dt;
                grv_details.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}