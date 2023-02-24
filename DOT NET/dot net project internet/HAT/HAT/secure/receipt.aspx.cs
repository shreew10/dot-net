using System;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class receipt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //BindDefaultData();
        }
    }

    /// <summary>
    /// Bind Default Data
    /// </summary>
    private void BindDefaultData()
    {
        if (FormView1.DefaultMode == FormViewMode.Insert)
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConnString"].ToString();
            OleDbConnection conn = new OleDbConnection(connStr);
            conn.Open();

            try
            {
                OleDbCommand dCmd = new OleDbCommand("Select * from heads where type = 'Receipts' and id <> 12 order by head", conn);
                OleDbDataReader dReader = dCmd.ExecuteReader();
                DropDownList dropRec = (DropDownList)FormView1.Row.FindControl("dropReceipt");
                dropRec.DataSource = dReader;
                dropRec.DataBind();
            }
            catch (Exception ee)
            {
                lblError.Text = ee.ToString();
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
    } // BindDefaultData
    
    /// <summary>
    /// Fires when record inserted successfully
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void FormView1_ItemInserted(object sender, FormViewInsertedEventArgs e)
    {
        lblError.Text = "Record Inserted Successfully.";
        lblError.ForeColor = System.Drawing.Color.Blue;
    }

    /// <summary>
    /// Fires when Cancel button is clicked
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void FormView1_ItemCommand(object sender, FormViewCommandEventArgs e)
    {
        if (e.CommandName == "Cancel")
        {
            Response.Redirect("receiptList.aspx", true);
        }
    }
}
