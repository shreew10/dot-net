using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace ClinicProjectWeb2Jan
{
    /// <summary>
    /// Summary description for PatientWebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]


    public class PatientWebService1 : System.Web.Services.WebService
    {
        clsConnection con = new clsConnection();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string[] webUserName(string prefixText)
        {
            SqlCommand cmd = new SqlCommand("SELECT patient_name FROM patient WHERE patient_name LIKE  '%" + prefixText + "%'", con.funCon());
            cmd.Connection.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            List<string> lst_name = new List<string>();
            while (sdr.Read())
            {
                lst_name.Add(sdr["patient_name"].ToString());
            }
            cmd.Connection.Close();
            return lst_name.ToArray();
        }
    }
}
