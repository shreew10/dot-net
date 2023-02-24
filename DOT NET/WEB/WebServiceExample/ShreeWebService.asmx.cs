using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace WebServiceExample
{
    /// <summary>
    /// Summary description for ShreeWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class ShreeWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        public string[] WebUserName(string prefixText)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            List<string> listobj = new List<string>();
            while (sdr.Read())
            {
                listobj.Add(sdr[""].ToString());
            }
            cmd.Connection.Close();
            return
        }
    }
}
