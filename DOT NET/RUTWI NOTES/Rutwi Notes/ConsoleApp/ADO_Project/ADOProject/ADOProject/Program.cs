using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace ADOProject
{
    class Program
    {
        static string EMP_ID;
        static string NAME;
        static string GENDER;
        static string CONTACT;
        static string SALARY;
        static string JOB_STATUS;
        static string JOINING_DATE;
        static string EMAIL;
        static string DEPTNO;
        static string DEPARTMENT;

        static DataTable dtDept;
        static DataTable dtEmp;

        static void selectOption()
        {
            Console.WriteLine("Please Select Option");
            Console.WriteLine("Press 1: For Department Table Details");
            Console.WriteLine("Press 2: For Employee Table Details");
            Console.WriteLine("Press 3: For Insert Data In Department Table");
            Console.WriteLine("Press 4: For Insert Data In Employee Table");
            Console.WriteLine("Press 5: For Update Data In Department Details");
            Console.WriteLine("Press 6: For Update Data In Employee Details");
            Console.WriteLine("Press 7: For Delete Data From Department Details");
            Console.WriteLine("Press 8: For Delete Data From Employee Details");
            Console.WriteLine("Press 9: Application LogOut");

            var opt = Console.ReadLine();
            switch (opt)
            {
                case "1":
                    displayDeptDetails();
                    Console.ReadKey();
                    break;
                case "2":
                    displayEmpDetails();
                    break;
                case "3":
                    insertDeptDetails();
                    break;
                case "4":
                    insertEmpDetails();
                    break;
                case "5":
                    updateDeptDetails();
                    break;
                case "6":
                    updateEmpDetails();
                    break;
                case "7":
                    deleteDeptDetails();
                    break;
                case "8":
                    deleteEmpDetails();
                    break;
                case "9":
                    funExit();
                    break;
                default:
                    Console.WriteLine("Please Select Correct Option");
                    break;

            }
            //Console.ReadKey();

        }

        static void funExit()
        {
            Console.WriteLine("Exit");
        }

        static void displayDeptDetails()
        {
            try
            {
                SqlConnection objCon = new SqlConnection(ConfigurationManager.ConnectionStrings["adoPro"].ConnectionString);
                SqlCommand cmd = new SqlCommand("SELECT dept_id  [DEPT NO], dept_name AS DEPARTMENT FROM tbl_dept ", objCon);
                objCon.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                dtDept = new DataTable();
                sda.Fill(dtDept);
                objCon.Close();

                if (dtDept.Rows.Count > 0)
                {
                    Console.WriteLine("---Table for Department Details---");

                    Console.WriteLine(dtDept.Columns[0].ToString() + "     | " + dtDept.Columns[1].ToString());
                    for (int i = 0; i < dtDept.Rows.Count; i++)
                    {
                        Console.WriteLine(dtDept.Rows[i][0].ToString() + "       |  " + dtDept.Rows[i][1].ToString());
                    }
                    selectOption();
                }
                else
                {
                    Console.WriteLine("Department Table is empty");
                    //Call displayOption function

                }
                selectOption();
                //Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static void displayEmpDetails()
        {
            try
            {

                SqlConnection objCon = new SqlConnection(ConfigurationManager.ConnectionStrings["adoPro"].ConnectionString);


                SqlCommand cmd = new SqlCommand("SELECT emp_id [SrNO], emp_name AS NAME, CONVERT(DATE,emp_joining_date,103) AS JOINING_DATE, emp_job_status AS JOB_STATUS FROM tbl_emp ", objCon);
                objCon.Open();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                dtEmp = new DataTable();

                sda.Fill(dtEmp);
                objCon.Close();
                if (dtEmp.Rows.Count > 0)
                {
                    Console.WriteLine("---Table for Employee Details---");

                    Console.WriteLine(dtEmp.Columns[0].ToString() + "     | " + dtEmp.Columns[1].ToString() + "        | " + dtEmp.Columns[2].ToString() + "   | " + dtEmp.Columns[3].ToString());
                    for (int i = 0; i < dtEmp.Rows.Count; i++)
                    {
                        Console.WriteLine(dtEmp.Rows[i][0].ToString() + "       |  " + dtEmp.Rows[i][1].ToString() + "       |  " + dtEmp.Rows[i][2].ToString() + "     |  " + dtEmp.Rows[i][3].ToString());
                    }

                }
                else
                {
                    Console.WriteLine("Employee Table is Empty");
                }
                selectOption();
                //Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        static void insertDeptDetails()
        {
            try
            {
                Console.WriteLine("---Enter Department Details---");

                Console.WriteLine("Enter Department Name");
                var DEPARTMENT = Console.ReadLine();


                SqlConnection objCon = new SqlConnection(ConfigurationManager.ConnectionStrings["adoPro"].ConnectionString);

                SqlCommand cmdEx = new SqlCommand("SELECT MAX(dept_id) FROM tbl_dept", objCon);
                objCon.Open();
                int deptID = 1;
                if (Convert.ToString(cmdEx.ExecuteScalar()) != "")
                {
                    deptID = Convert.ToInt32(cmdEx.ExecuteScalar()) + 1;
                }
                objCon.Close();

                SqlCommand cmdInsert = new SqlCommand("INSERT INTO tbl_dept(dept_id , dept_name)VALUES(@dept_id, @dept_name)", objCon);
                objCon.Open();
                cmdInsert.Parameters.AddWithValue("@dept_id", deptID);
                cmdInsert.Parameters.AddWithValue("@dept_name", DEPARTMENT);

                int rowAffected = cmdInsert.ExecuteNonQuery();
                if (rowAffected == 1)
                {
                    Console.WriteLine("Data Inserted Succesfully");
                    displayDeptDetails();
                }
                objCon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Console.ReadKey();

        }

        static void insertEmpDetails()
        {
            Console.WriteLine("---Enter Employee Details---");

            Console.WriteLine("Enter Employee Name");
            var NAME = Console.ReadLine();
            Console.WriteLine("Enter Employee Gender");
            var GENDER = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter Employee Contact");
            var CONTACT = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Employee Salary");
            var SALARY = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter Employee Job Status");
            var JOB_STATUS = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Joining Date");
            var JOINING_DATE = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter Employee Email");
            var EMAIL = Console.ReadLine();
            Console.WriteLine("Enter Department No");
            var DEPTNO = Convert.ToInt32(Console.ReadLine());

            try
            {
                SqlConnection objCon = new SqlConnection(ConfigurationManager.ConnectionStrings["adoPro"].ConnectionString);

                SqlCommand cmdEx = new SqlCommand("SELECT MAX(emp_id) FROM tbl_emp", objCon);
                objCon.Open();
                int empId = 1;
                if (Convert.ToString(cmdEx.ExecuteScalar()) != "")
                {
                    empId = Convert.ToInt32(cmdEx.ExecuteScalar()) + 1;
                }
                objCon.Close();

                SqlCommand cmdInsert = new SqlCommand("INSERT INTO tbl_emp (emp_id, emp_name, emp_gender, emp_contact,emp_sal,emp_job_status,emp_joining_date ,emp_email, dept_no) VALUES (@emp_id, @emp_name, @emp_gender, @emp_contact, @emp_sal, @emp_job_status, @emp_joining_date, @emp_email, @dept_no)", objCon);
                objCon.Open();
                cmdInsert.Parameters.AddWithValue("@emp_id", empId);
                cmdInsert.Parameters.AddWithValue("@emp_name", NAME);
                cmdInsert.Parameters.AddWithValue("@emp_gender", GENDER);
                cmdInsert.Parameters.AddWithValue("@emp_contact", CONTACT);
                cmdInsert.Parameters.AddWithValue("@emp_sal", SALARY);
                cmdInsert.Parameters.AddWithValue("@emp_job_status", JOB_STATUS);
                cmdInsert.Parameters.AddWithValue("@emp_joining_date", JOINING_DATE);
                cmdInsert.Parameters.AddWithValue("@emp_email", EMAIL);
                cmdInsert.Parameters.AddWithValue("@dept_no", DEPTNO);
                int rowAffected = cmdInsert.ExecuteNonQuery();
                if (rowAffected == 1)
                {
                    Console.WriteLine("Data Inserted Succesfully ");
                    displayEmpDetails();
                }
                objCon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Console.ReadKey();

        }

        static void updateDeptDetails()
        {
            try
            {
                Console.WriteLine("Enter Department no");
                int DEPTNO = Convert.ToInt32(Console.ReadLine());
                SqlConnection objCon = new SqlConnection(ConfigurationManager.ConnectionStrings["adoPro"].ConnectionString);
                SqlCommand cmdUpdate = new SqlCommand(" UPDATE tbl_dept SET dept_id=@dept_id , dept_name=@dept_name WHERE dept_id= '" + DEPTNO + "'", objCon);
                objCon.Open();
                cmdUpdate.Parameters.AddWithValue("@dept_id", DEPTNO);
                cmdUpdate.Parameters.AddWithValue("@dept_name", DEPARTMENT);
                cmdUpdate.ExecuteNonQuery();
                objCon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Console.ReadKey();

        }

        static void updateEmpDetails()
        {
            try
            {
                Console.WriteLine("Enter Employee Id");
                int SrNO = Convert.ToInt32(Console.ReadLine());
                SqlConnection objCon = new SqlConnection(ConfigurationManager.ConnectionStrings["adoPro"].ConnectionString);
                SqlCommand cmdUpdate = new SqlCommand("  UPDATE tbl_emp SET emp_id= @emp_id, emp_name=@emp_name, emp_gender=@emp_gender, emp_contact=@emp_contact,emp_sal=@emp_sal,emp_job_status=@emp_job_status,emp_joining_date=@emp_joining_date,emp_email=@emp_email, dept_no=@dept_no WHERE  EmpId = '" + SrNO + "'", objCon);
                objCon.Open();
                cmdUpdate.Parameters.AddWithValue("@emp_id", EMP_ID);
                cmdUpdate.Parameters.AddWithValue("@emp_name", NAME);
                cmdUpdate.Parameters.AddWithValue("@emp_gender", GENDER);
                cmdUpdate.Parameters.AddWithValue("@emp_contact", CONTACT);
                cmdUpdate.Parameters.AddWithValue("@emp_sal", SALARY);
                cmdUpdate.Parameters.AddWithValue("@emp_job_status", JOB_STATUS);
                cmdUpdate.Parameters.AddWithValue("@emp_joining_date", JOINING_DATE);
                cmdUpdate.Parameters.AddWithValue("@emp_email", EMAIL);
                cmdUpdate.Parameters.AddWithValue("@dept_no", DEPTNO);
                cmdUpdate.ExecuteNonQuery();
                objCon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Console.ReadKey();
        }

        static void deleteDeptDetails()
        {
            try
            {
                Console.WriteLine("Enter Department no");
                int DEPTNO = Convert.ToInt32(Console.ReadLine());
                SqlConnection objCon = new SqlConnection(ConfigurationManager.ConnectionStrings["adoPro"].ConnectionString);
                SqlCommand cmdDelete = new SqlCommand(" DELETE FROM tbl_dept WHERE dept_no= '" + DEPTNO + "'", objCon);
                objCon.Open();
                cmdDelete.ExecuteNonQuery();
                objCon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Console.ReadKey();

        }

        static void deleteEmpDetails()
        {
            try
            {
                Console.WriteLine("Enter Employee Id");
                int SrNO = Convert.ToInt32(Console.ReadLine());
                SqlConnection objCon = new SqlConnection(ConfigurationManager.ConnectionStrings["adoPro"].ConnectionString);
                SqlCommand cmdDelete = new SqlCommand(" DELETE FROM tbl_emp WHERE emp_id= '" + SrNO + "'", objCon);
                objCon.Open();
                cmdDelete.ExecuteNonQuery();
                objCon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Console.ReadKey();
        }





        static void Main(string[] args)
        {
            Console.WriteLine("---! DGX COMPANY !---");

            displayDeptDetails();
            displayEmpDetails();
            selectOption();
            //Console.WriteLine("If you want to continue, then PRESS'Y' Else PRESS 'N' ");
            //string optn = Console.ReadLine();
            //if (optn.ToLower() == "Y".ToLower())
            //{
            //    selectOption();
            //}
            //else
            //{
            //    Console.WriteLine("Exit");
            //}

            //Console.ReadKey();
        }
    }
}
