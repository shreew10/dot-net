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

public partial class dropdown : System.Web.UI.Page
{
    string connStr = ConfigurationManager.ConnectionStrings["ConnStr"].ToString();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindParentCategories();
        }
    }
    
    /// <summary>
    /// Bind dropdowns
    /// </summary>
    private void BindParentCategories()
    {

        OleDbConnection conn = new OleDbConnection(connStr);
        conn.Open();
        
        DataSet dSet = new DataSet();
        try
        {

            OleDbDataAdapter dAd = new OleDbDataAdapter("select * from ParentCategory", conn);
            dAd.Fill(dSet, "ThisTable");

            dropParentCategory.DataSource = dSet.Tables[0].DefaultView;
            dropParentCategory.DataBind();            
        }
        catch (Exception ee)
        {
            lblError.Text = ee.ToString();
        }
        finally
        {
            dSet.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }

    /// <summary>
    /// Populate child dropdown
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void PopulateChildDropDown(object sender, EventArgs e)
    {
        int intParentCategoryID = Int32.Parse(dropParentCategory.SelectedValue);
        OleDbConnection conn = new OleDbConnection(connStr);
        conn.Open();
        DataSet dSet = new DataSet();
        try
        {
            OleDbDataAdapter dAd = new OleDbDataAdapter("select * from Category where ParentCategoryID = " + intParentCategoryID.ToString(), conn);
            dAd.Fill(dSet, "ThisTable");

            dropChildCategory.DataSource = dSet.Tables[0].DefaultView;
            dropChildCategory.DataBind();
        }
        catch (Exception ee)
        {
            lblError.Text = ee.ToString();
        }
        finally
        {
            dSet.Dispose();
            conn.Close();
            conn.Dispose();
        }
    }


    /// <summary>
    /// Submit the form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void SubmitForm(object sender, EventArgs e)
    {
        lblMessage.Text = "<hr />Parent Category -> Text: <b>" + dropParentCategory.SelectedItem.Text + "</b> & Value: <b>" + dropParentCategory.SelectedItem.Value + "</b>" +
            "<br>Child Category - > Text: <b>" + dropChildCategory.SelectedItem.Text + "</b> & Value: <b>" + dropChildCategory.SelectedItem.Value + "</b>";

    }

}
