using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace GridViewOps27Dec
{
    public partial class GridOps : System.Web.UI.Page
    {

        //ConnectionClass con = new ConnectionClass();
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        protected void Page_Init(object sender, EventArgs e)
        {
            //int a = 1;
            //con.funCon();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridLoad();
                //Button1.Text = "shri";
            }
        }

        public void GridLoad()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT studRollno,studName,studGender,studSubject FROM tbl_student_details", conn);
                DataSet ds = new DataSet();
                cmd.Connection.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds, "tbl_student_details");
                cmd.Connection.Close();
                grv_crud.DataSource = ds.Tables["tbl_student_details"];
                grv_crud.DataBind();

                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        protected void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                //int id = Convert.ToInt32(btn.CommandArgument);

                GridViewRow gRow = btn.NamingContainer as GridViewRow;
                grv_crud.EditIndex = gRow.RowIndex;
                GridLoad();
                // grv_crud.EditIndex = -1;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        protected void btn_delete_Click(object sender, EventArgs e)
        {
            Button btnDelete = (Button)sender;

            int delId = Convert.ToInt32(btnDelete.CommandArgument);

            SqlCommand cmd = new SqlCommand("DELETE FROM tbl_student_details WHERE studRollno='" + delId + "'", conn);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            grv_crud.EditIndex = -1;
            GridLoad();
        }
        protected void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                Button btnUpdate = (Button)sender;
                int updId = Convert.ToInt32(btnUpdate.CommandArgument);
                GridViewRow GridRow = btnUpdate.NamingContainer as GridViewRow;

                SqlCommand cmd = new SqlCommand("UPDATE tbl_student_details SET studName=@studName,studGender=@studGender,studSubject=@studSubject WHERE studRollno='" + updId + "'", conn);
                cmd.Connection.Open();

                TextBox txt_Name = (TextBox)grv_crud.Rows[GridRow.RowIndex].FindControl("txt_edit_name");
                RadioButtonList rbl_Gender = (RadioButtonList)grv_crud.Rows[GridRow.RowIndex].FindControl("rbl_edit");
                DropDownList dll_subject = (DropDownList)grv_crud.Rows[GridRow.RowIndex].FindControl("ddl_edit");

                cmd.Parameters.AddWithValue("@studRollno", updId);
                cmd.Parameters.AddWithValue("@studName", txt_Name.Text.Trim());
                cmd.Parameters.AddWithValue("@studGender", rbl_Gender.SelectedValue.Trim());
                cmd.Parameters.AddWithValue("@studSubject", dll_subject.SelectedValue.Trim());

                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                grv_crud.EditIndex = -1;
                GridLoad();
            }
            catch (Exception)
            {

                throw;
            }

        }

        protected void btn_cancel_Click(object sender, EventArgs e)
        {
            grv_crud.EditIndex = -1;
            GridLoad();
        }

        protected void btn_add_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("INSERT INTO tbl_student_details(studName,studGender,studSubject)VALUES(@studName,@studGender,@studSubject)", conn);
            cmd.Connection.Open();


            TextBox txt_f_Name = (TextBox)grv_crud.FooterRow.FindControl("txt_f_name");
            RadioButtonList rbl_f_Gender = (RadioButtonList)grv_crud.FooterRow.FindControl("rbl_f");
            DropDownList dll_f_subject = (DropDownList)grv_crud.FooterRow.FindControl("ddl_f");

            cmd.Parameters.AddWithValue("@studName", txt_f_Name.Text.Trim());
            cmd.Parameters.AddWithValue("@studGender", rbl_f_Gender.SelectedValue);
            cmd.Parameters.AddWithValue("@studSubject", dll_f_subject.SelectedValue);

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            GridLoad();
        }

        protected void grv_crud_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}