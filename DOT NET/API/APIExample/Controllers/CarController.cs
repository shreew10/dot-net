using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace APIExample.Controllers
{
    //http://localhost:58581/api/Car/fun
    public class tblEmployee
    {
        public int empId { get; set; }
        public string empName { get; set; }
        public string empGender { get; set; }
        public string empEmail { get; set; }
    }

    //SELECT QUERY TO RETRIVE DATA USING API AND FIDDLER
    public class CarController : ApiController
    {
        SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);

        [HttpGet]
        public string fun([FromBody] dynamic para)
        {
            int a = Convert.ToInt32(para[0].Id.Value);
            string b = Convert.ToString(para[0].Name.Value);
            return "Hello";
            //JObject obj = (JObject)JsonConvert.DeserializeObject();
        }

        [HttpPost]
        [Route("api/Car/GetPara")]
        public IHttpActionResult GetPara([FromBody] dynamic para)
        {
            //JObject empty_obj = new JObject();
            //List<JObject> empty_lst = new List<JObject>();

            JObject return_messg = new JObject();

            //empty_lst.Add(empty_obj);
            try
            {
                int id = Convert.ToInt32(para[0].id.Value);
                SqlCommand cmd = new SqlCommand("Select emp_id,emp_email,emp_gender,emp_name from tbl_Emp where emp_id ='" + id + "'", sqlCon);
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
                    //sb.Append(JsonConvert.SerializeObject(empty_lst));
                    sb.Append(Convert.ToString(return_messg));

                    return Ok(new JArray(Convert.ToString(sb)));
                }
            }
            catch (Exception ex)
            {

                return_messg.Add("Error", true);
                return_messg.Add("Message", ex.Message);

                StringBuilder sb = new StringBuilder();
                //sb.Append(JsonConvert.SerializeObject(empty_lst));
                sb.Append(Convert.ToString(return_messg) + ",");

                return Ok(new JArray(Convert.ToString(sb)));
            }
        }




        [HttpPost]
        [Route("api/Car/InsertPara")]
        //INSERT QUERY TO INSERT DATA USING API AND FIDDLER
        public IHttpActionResult InsertPara([FromBody] dynamic paraData)
        {
            JObject objMessage = new JObject();
            try
            {
                SqlCommand cmdInsert = new SqlCommand("INSERT INTO tbl_Dept(dept_id ,dept_name)VALUES(@dept_id,@dept_name)", sqlCon);
                cmdInsert.Connection.Open();
                cmdInsert.Parameters.AddWithValue("@dept_id", Convert.ToInt32(paraData[0].id.Value));
                //cmdInsert.Parameters.AddWithValue("@dept_id", Convert.ToInt32(paraData[0].id.Value));
                cmdInsert.Parameters.AddWithValue("@dept_name", Convert.ToString(paraData[0].name.Value));

                cmdInsert.ExecuteNonQuery();
                cmdInsert.Connection.Close();

                objMessage.Add("Error", false);
                objMessage.Add("Message", "Data Inserted Succesfully");

                StringBuilder objSB = new StringBuilder();
                objSB.Append(Convert.ToString(objMessage));

                return Ok(new JArray(Convert.ToString(objSB)));


            }
            catch (Exception ex)
            {
                objMessage.Add("Error", true);
                objMessage.Add("Message", ex.Message);

                StringBuilder sb = new StringBuilder();
                sb.Append(Convert.ToString(objMessage));

                return Ok(new JArray(Convert.ToString(sb)));
            }

        }
        //------------------
        [HttpPost]
        [Route("api/Car/PostUpdatePara")]
        //UPDATE QUERY TO UPDATE DATA USING API AND FIDDLER
        public IHttpActionResult PostUpdatePara([FromBody] dynamic ParaData)
        {
            JObject return_msg = new JObject();

            try
            {
                //int ID= Convert.ToInt32(ParaData.);
                //int id = Convert.ToInt32(ParaData[0].EmpID.Value);
                SqlCommand sqlupdate = new SqlCommand("UPDATE tbl_Dept SET dept_name = @dept_name WHERE dept_id= @dept_id", sqlCon);
                sqlCon.Open();
                sqlupdate.Parameters.AddWithValue("@dept_id", Convert.ToInt32(ParaData[0].id.Value));
                sqlupdate.Parameters.AddWithValue("@dept_name", Convert.ToString(ParaData[0].name.Value));
                //sqlupdate.Parameters.AddWithValue("@emp_salary", Convert.ToString(ParaData[0].EmpSalary.Value));
                sqlupdate.ExecuteNonQuery();
                sqlCon.Close();

                return_msg.Add("Error", false);
                return_msg.Add("Message", "Record Updated Successfully.");

                StringBuilder strbldr = new StringBuilder();
                strbldr.Append(Convert.ToString(return_msg));

                return Ok(new JArray(Convert.ToString(strbldr)));
            }
            catch (Exception ex)
            {
                return_msg.Add("Error", true);
                return_msg.Add("Message", ex.Message);

                StringBuilder strbldr = new StringBuilder();
                strbldr.Append(Convert.ToString(return_msg));

                return Ok(new JArray(Convert.ToString(strbldr)));
            }
        }

        [HttpPost]
        [Route("api/Car/PostDeletePara")]
        //DELETE QUERY TO DELETE DATA USING API AND FIDDLER
        public IHttpActionResult PostDeletePara([FromBody] dynamic ParaData)
        {
            JObject return_msg = new JObject();

            try
            {
                //int ID= Convert.ToInt32(ParaData.);
                //int id = Convert.ToInt32(ParaData[0].EmpID.Value);
                SqlCommand sqlupdate = new SqlCommand("DELETE FROM tbl_Dept WHERE dept_id=@dept_id", sqlCon);
                sqlCon.Open();
                sqlupdate.Parameters.AddWithValue("@dept_id", Convert.ToInt32(ParaData[0].id.Value));
                sqlupdate.ExecuteNonQuery();
                sqlCon.Close();

                return_msg.Add("Error", false);
                return_msg.Add("Message", "Record Deleted Successfully.");

                StringBuilder strbldr = new StringBuilder();
                strbldr.Append(Convert.ToString(return_msg));

                return Ok(new JArray(Convert.ToString(strbldr)));
            }
            catch (Exception ex)
            {
                return_msg.Add("Error", true);
                return_msg.Add("Message", ex.Message);

                StringBuilder strbldr = new StringBuilder();
                strbldr.Append(Convert.ToString(return_msg));

                return Ok(new JArray(Convert.ToString(strbldr)));
            }
        }

    }
}

