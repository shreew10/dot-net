using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ClinicProjectWeb2Jan
{
    public class clsConnection
    {
        public SqlConnection funCon()
        {
            SqlConnection strCon = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            return strCon;
        }
    }
}