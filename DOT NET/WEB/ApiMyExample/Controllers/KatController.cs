using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ApiMyExample.Controllers
{
    public class KatController : ApiController
    {
        SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);



        [HttpGet]
        public IHttpActionResult GetPara()
        {
            JObject empty_obj = new JObject();
            List<JObject> empty_lst = new List<JObject>();

            JObject return_messg = new JObject();

            empty_lst.Add(empty_obj);
            try
            {
                SqlCommand cmd = new SqlCommand("Select emp_id,emp_email,emp_gender,emp_name from tbl_Emp");
                sqlCon.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                sqlCon.Close();

                List<tblEmployee> EmployeesList = new List<tblEmployee>();
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        tblEmployee obj = new tblEmployee();
                        obj.empId = Convert.ToInt32(dt.Rows[i]["emp_id"]);
                        obj.empEmail = Convert.ToString(dt.Rows[i]["emp_email"]);
                        obj.empName = Convert.ToString(dt.Rows[i]["emp_name"]);
                        obj.empGender = Convert.ToString(dt.Rows[i]["emp_gender"]);
                        EmployeesList.Add(obj);
                    }
                    return_messg.Add("error", false);
                    return_messg.Add("message", "record fetch successfully");

                    StringBuilder sb = new StringBuilder();
                    sb.Append(JsonConvert.SerializeObject(EmployeesList));
                    sb.Insert(1, Convert.ToString(return_messg) + ",");

                    return Ok(new JArray(Convert.ToString(sb)));
                }
                else
                {
                    return_messg.Add("error", false);
                    return_messg.Add("message", "record not found");

                    StringBuilder sb = new StringBuilder();
                    sb.Append(JsonConvert.SerializeObject(empty_lst));
                    sb.Insert(1, Convert.ToString(return_messg));

                    return Ok(new JArray(Convert.ToString(sb)));
                }

            }
            catch (Exception ex)
            {

                return_messg.Add("Error", true);
                return_messg.Add("Message", ex.Message);

                StringBuilder sb = new StringBuilder();
                sb.Append(JsonConvert.SerializeObject(empty_lst));
                sb.Insert(1, Convert.ToString(return_messg) + ",");

                return Ok(new JArray(Convert.ToString(sb)));
            }
        }

        [HttpGet]
        public string fun()
        {
            return "chiku";
        }

        public void func1([FromBody] dynamic para)
        {
            //int id = Convert.ToInt32(para[0].ID.Value);
            //string name = Convert.ToString(para[0].Name.Value);

            string car = Convert.ToString(para[0].Car.Value);
            string name = Convert.ToString(para[0].Name.Value);

            //ado

            //select

            //can write code`
        }


        public class tblEmployee
        {
            public int empId { get; set; }
            public string empName { get; set; }
            public string empGender { get; set; }
            public string empEmail { get; set; }
        }


        //[Route("/api/Kat/GetPara")]


    }
}
