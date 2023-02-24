using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace api_Example.Controllers
{
    public class StudentController : ApiController
    {
        SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);

        [HttpGet]
        [Route("api/Student/get")]

        public string get()
        {
            return "Hello";
        }

        [HttpPost]
        [Route("api/Student/postData")]
        public string postData([FromBody] dynamic para)
        {
            return "hello";
        }

        public class tblStudentDetails
        {
            public int studID { get; set; }
            public string studName { get; set; }
            public string studCity { get; set; }
        }

        [HttpPost]
        [Route("api/Student/GetPara")]
        public IHttpActionResult GetPara([FromBody] dynamic paraData)
        {
            JObject obj = new JObject();

            List<JObject> objLst = new List<JObject>();

            JObject objMessage = new JObject();

            objLst.Add(obj);
            try
            {
                int id = Convert.ToInt32(paraData[0].studID.Value);

                SqlCommand cmd = new SqlCommand("SELECT stud_id,stud_name,stud_city FROM tbl_student", sqlCon);
                sqlCon.Open();
                DataTable dtStud = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dtStud);
                sqlCon.Close();

                List<tblStudentDetails> lst_student = new List<tblStudentDetails>();
                if (dtStud.Rows.Count > 0)
                {
                    for (int i = 0; i < dtStud.Rows.Count; i++)
                    {
                        tblStudentDetails objDetails = new tblStudentDetails();
                        objDetails.studID = Convert.ToInt32(dtStud.Rows[i]["studID"]);
                        objDetails.studName = Convert.ToString(dtStud.Rows[i]["studName"]);
                        objDetails.studCity = Convert.ToString(dtStud.Rows[i]["studCity"]);
                        lst_student.Add(objDetails);

                    }
                    objMessage.Add("Error", false);
                    objMessage.Add("Message", "Data Fetch Successfully");

                    StringBuilder objSB = new StringBuilder();
                    objSB.Append(JsonConvert.SerializeObject(lst_student));
                    objSB.Insert(1, Convert.ToString(objMessage) + ",");

                    return Ok(new JArray(Convert.ToString(objSB)));
                }
                else
                {
                    objMessage.Add("Error", false);
                    objMessage.Add("Message", "Record Not Found");

                    StringBuilder sbObj = new StringBuilder();
                    sbObj.Append(JsonConvert.SerializeObject(objLst));
                    sbObj.Insert(1, Convert.ToString(objMessage) + ",");

                    return Ok(new JArray(Convert.ToString(sbObj)));
                }


            }
            catch (Exception ex)
            {
                objMessage.Add("Error", true);
                objMessage.Add("Message", ex.Message);

                StringBuilder sb = new StringBuilder();
                sb.Append(JsonConvert.SerializeObject(objLst));
                sb.Insert(1, Convert.ToString(objMessage) + ",");

                return Ok(new JArray(Convert.ToString(sb)));
            }
        }

        [HttpPost]
        [Route("api/Student/InsertPara")]

        public IHttpActionResult InsertPara([FromBody] dynamic paraData)
        {
            JObject objInsert = new JObject();

            JObject objMessage = new JObject();

            try
            {
                SqlCommand cmdInsert = new SqlCommand("INSERT INTO tbl_student (stud_id,stud_name,stud_city) VALUES(@stud_id,@stud_name,@stud_city)", sqlCon);
                cmdInsert.Connection.Open();
                //int id = Convert.ToInt32(paraData[0].studID.Value);
                //int a = Convert.ToInt32(paraData[0].studID.Value);
                //string name = Convert.ToString(paraData[0].studName.Value);
                //string city = Convert.ToString(paraData[0].studCity.Value);



                cmdInsert.Parameters.AddWithValue("@stud_id", Convert.ToInt32(paraData[0].studID.Value));
                cmdInsert.Parameters.AddWithValue("@stud_name", Convert.ToString(paraData[0].studName.Value));
                cmdInsert.Parameters.AddWithValue("@stud_city", Convert.ToString(paraData[0].studCity.Value));
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
                sb.Insert(1, Convert.ToString(objMessage) + ",");

                return Ok(new JArray(Convert.ToString(sb)));
            }

        }

        [HttpPost]
        [Route("api/Student/UpdatePara")]

        public IHttpActionResult UpdatePara([FromBody] dynamic paraData)
        {
            JObject objMessage = new JObject();

            try
            {
                SqlCommand cmdUpdate = new SqlCommand("UPDATE tbl_student SET stud_id=@stud_id,stud_name=@stud_name,stud_city=@stud_city WHERE stud_id=@stud_id", sqlCon);
                sqlCon.Open();
                cmdUpdate.Parameters.AddWithValue("@stud_id", Convert.ToInt32(paraData[0].stud_id.Value));
                cmdUpdate.Parameters.AddWithValue("@stud_name", Convert.ToString(paraData[0].stud_name.Value));
                cmdUpdate.Parameters.AddWithValue("@stud_city", Convert.ToString(paraData[0].stud_city.Value));
                cmdUpdate.ExecuteNonQuery();
                sqlCon.Close();

                objMessage.Add("Error", false);
                objMessage.Add("Message", "Data Updated Succesfully");

                StringBuilder objSB = new StringBuilder();
                objSB.Append(Convert.ToString(objMessage));

                return Ok(new JArray(Convert.ToString(objSB)));
            }
            catch (Exception ex)
            {
                objMessage.Add("Error", true);
                objMessage.Add("Message", ex.Message);

                StringBuilder sb = new StringBuilder();
                sb.Insert(1, Convert.ToString(objMessage) + ",");

                return Ok(new JArray(Convert.ToString(sb)));
            }

        }

        [HttpPost]
        [Route("api/Student/DeletePara")]

        public IHttpActionResult DeletePara([FromBody] dynamic paraData)
        {
            JObject objMessage = new JObject();

            try
            {
                SqlCommand cmdDelete = new SqlCommand("DELETE FROM tbl_student WHERE stud_id=@stud_id", sqlCon);
                sqlCon.Open();
                cmdDelete.Parameters.AddWithValue("@stud_id", Convert.ToInt32(paraData[0].EmpID.Value));
                cmdDelete.ExecuteNonQuery();
                sqlCon.Close();

                objMessage.Add("Error", false);
                objMessage.Add("Message", "Data Updated Succesfully");

                StringBuilder objSB = new StringBuilder();
                objSB.Append(Convert.ToString(objMessage));

                return Ok(new JArray(Convert.ToString(objSB)));

            }
            catch(Exception ex)
            {
                objMessage.Add("Error", true);
                objMessage.Add("Message", ex.Message);

                StringBuilder sb = new StringBuilder();
                sb.Insert(1, Convert.ToString(objMessage) + ",");

                return Ok(new JArray(Convert.ToString(sb)));
            }

        }
    }
}
