
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Configuration;

namespace Web_service_exam
{
    /// <summary>
    /// Summary description for SmartWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class SmartWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string[] webUserName(string prefixText)
        {
            SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT stud_name FROM tbl_stud WHERE stud_name like '%" + prefixText + "%'", sqlCon);
            cmd.Connection.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            List<string> lst_name = new List<string>();
            while (sdr.Read())
            {
                lst_name.Add(sdr["stud_name"].ToString());
            }
            cmd.Connection.Close();
            return lst_name.ToArray();
        }
    }
}
