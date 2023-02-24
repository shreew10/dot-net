using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Configuration;

namespace Grid_Button_Ex
{
    public partial class grid_operation_ex : System.Web.UI.Page
    {

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridLoad();
            }
        }
        public void GridLoad()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT studRollno,studName,studGender,studSubject FROM tbl_student_details", conn);
                // DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                cmd.Connection.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                // sda.Fill(ds, "tbl_student_details");
                sda.Fill(dt);
                cmd.Connection.Close();
                // grv_crud.DataSource = ds.Tables["tbl_student_details"];
                grv_crud.DataSource = dt;
                grv_crud.DataBind();

                grv_stud_details.DataSource = dt;
                grv_stud_details.DataBind();
                //  grv_crud.DataSource = ds.Tables[0]; // Use Another grid
                // grv_crud.DataBind();
            }
            catch (Exception)
            {

            }
        }



        protected void btn_edit_Click(object sender, EventArgs e)
        {
            Button objEdit = (Button)sender;
            int i = Convert.ToInt32(objEdit.CommandArgument);

            Button objbtnEdit = (Button)sender;
            GridViewRow gr = objbtnEdit.NamingContainer as GridViewRow;
            int r = gr.RowIndex;
            grv_stud_details.EditIndex = r;
            GridLoad();


            //SqlCommand objCmdEDit = new SqlCommand("SELECT studRollno,studName,studGender,studSubject FROM tbl_student_details where studRollno='" + i + "'", conn);
            //conn.Open();
            //SqlDataAdapter objSda = new SqlDataAdapter(objCmdEDit);
            //DataTable dt = new DataTable();
            //objSda.Fill(dt);
            //conn.Close();

            //TextBox1.Text = dt.Rows[0][1].ToString();
            //TextBox2.Text = dt.Rows[0][2].ToString();
            //TextBox3.Text = dt.Rows[0][3].ToString();

        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            Button objUpdate = (Button)sender;
            int rollNo = Convert.ToInt32(objUpdate.CommandArgument);//pass rollno//update command

            GridViewRow gr = objUpdate.NamingContainer as GridViewRow;//find selected row

            Label objlbl = (Label)grv_stud_details.Rows[gr.RowIndex].FindControl("lbl_edit_StudRollNo");
            TextBox objText = (TextBox)grv_stud_details.Rows[gr.RowIndex].FindControl("txt_edit_name");
            RadioButtonList objrbl = (RadioButtonList)grv_stud_details.Rows[gr.RowIndex].FindControl("rbl_edit_gender");
            DropDownList objddl = (DropDownList)grv_stud_details.Rows[gr.RowIndex].FindControl("ddl_edit_subject");

            int Roll = Convert.ToInt32(objlbl.Text);
            string name = objText.Text;
            string gender = objrbl.SelectedValue;
            string subject = objddl.SelectedValue;

            //update command
            GridLoad();

        }

        protected void btn_cancel_Click(object sender, EventArgs e)
        {
            grv_stud_details.EditIndex = -1;
            GridLoad();
        }
    }

}