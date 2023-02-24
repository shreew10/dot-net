using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace GridViewTF
{
    public partial class frmGrdTF : System.Web.UI.Page
    {
        SqlConnection strCon = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                funGridFill();
            }
        }

        void funGridFill()
        {
            SqlCommand cmd = new SqlCommand("SELECT stud_id, stud_name, stud_city FROM tbl_student", strCon);
            strCon.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            strCon.Close();
            GridView1.DataSource = dt;
            GridView1.DataBind();

            grdDetails.DataSource = dt;
            grdDetails.DataBind();
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Button objBtn = (Button)sender;
            int i = Convert.ToInt32(objBtn.CommandArgument);
            //on the spot change data in  gridview 
            GridViewRow gr = objBtn.NamingContainer as GridViewRow;
            grdDetails.EditIndex = gr.RowIndex;//edit index is use to active edit item template
            funGridFill();

            //form
            SqlCommand cmd = new SqlCommand("SELECT stud_id, stud_name, stud_city FROM tbl_student where stud_id='"+i+"'", strCon);
            strCon.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            strCon.Close();
            TextBox1.Text = dt.Rows[0][0].ToString();
            TextBox2.Text = dt.Rows[0][1].ToString();

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            grdDetails.EditIndex = -1;
            funGridFill();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Button objbtn = (Button)sender;
            int id =Convert.ToInt32(objbtn.CommandArgument);

            GridViewRow objGr = objbtn.NamingContainer as GridViewRow;

            TextBox objId = (TextBox)grdDetails.Rows[objGr.RowIndex].FindControl("txt_stud_id");
            TextBox objName = (TextBox)grdDetails.Rows[objGr.RowIndex].FindControl("txt_stud_name");
            RadioButtonList objCity = (RadioButtonList)grdDetails.Rows[objGr.RowIndex].FindControl("rbl_city");

            string studId = objId.Text;
            string studName = objName.Text;
            //update command
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            TextBox objName = (TextBox)grdDetails.FooterRow.FindControl("stud_ft_name");
            RadioButtonList objCity = (RadioButtonList)grdDetails.FooterRow.FindControl("rbl_ft_city");
            string name = objName.Text;
            string city = objCity.Text;
        }
    }
}