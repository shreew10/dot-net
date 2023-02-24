using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Company
{
    class Program
    {
        DataTable dtDept;
        DataTable dt;


        void DisplayEmp()
        {
            try
            {

                DeptCheck();
                //display  table
                if (dtDept.Rows.Count > 0)
                {
                    SqlConnection SqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
                    SqlCommand SqlCom = new SqlCommand("SELECT * FROM tbl_Emp", SqlCon);
                    SqlCon.Open();
                    SqlDataAdapter SdA = new SqlDataAdapter(SqlCom);
                    dt = new DataTable();
                    SdA.Fill(dt);
                    SqlCon.Close();

                    if (dt.Rows.Count > 0)
                    {
                        Console.WriteLine(dt.Columns[0] + "|" + dt.Columns[1] + "|" + dt.Columns[2] + "|" + dt.Columns[3] + "|" + dt.Columns[4] + "|" + dt.Columns[5] + "|" + dt.Columns[6] + "|" + dt.Columns[7] + "|" + dt.Columns[8]);
                        Console.WriteLine();
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            Console.WriteLine(dt.Rows[i][0] + "|" + dt.Rows[i][1] + "|" + dt.Rows[i][2] + "|" + dt.Rows[i][3] + "|" + dt.Rows[i][4] + "|" + dt.Rows[i][5] + "|" + dt.Rows[i][6] + "|" + dt.Rows[i][7] + "|" + dt.Rows[i][8]);
                        }
                        Console.WriteLine();
                        SelectionOption();
                    }
                    else
                    {
                        Console.WriteLine("------EMPLOYEE DETAILS NOT AVAILABLE----");
                        Console.WriteLine("------INSERT EMPLOYEE DETAILS----");
                        InsertEmp();
                        Console.WriteLine();
                        SelectionOption();

                    }
                }
                else
                {
                    InsertDept();
                    SelectionOption();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
        void DisplayDept()
        {
            try
            {
                //display  table
                SqlConnection SqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
                SqlCommand SqlCom = new SqlCommand("SELECT * FROM tbl_Dept", SqlCon);
                SqlCon.Open();
                SqlDataAdapter SdA = new SqlDataAdapter(SqlCom);
                dtDept = new DataTable();
                SdA.Fill(dtDept);
                SqlCon.Close();

                if (dtDept.Rows.Count > 0)
                {
                    Console.WriteLine(dtDept.Columns[0] + "|" + dtDept.Columns[1]);
                    Console.WriteLine();
                    for (int i = 0; i < dtDept.Rows.Count; i++)
                    {
                        Console.WriteLine(dtDept.Rows[i][0] + "|" + dtDept.Rows[i][1]);
                    }
                    Console.WriteLine();
                    SelectionOption();
                }
                else
                {
                    Console.WriteLine("------DEPARTMENT DETAILS NOT AVAILABLE----");
                    Console.WriteLine("PLEASE ENTER DEPARTMENT DETAILS");
                    InsertDept();
                    Console.WriteLine();
                    SelectionOption();
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
        void InsertEmp()
        {
            try
            {
                DeptCheck();
                if (dtDept.Rows.Count > 0)
                {



                    Console.WriteLine("ENTER NAME");
                    var name = Console.ReadLine();
                    Console.WriteLine("ENTER GENDER");
                    var gender = Console.ReadLine();
                    Console.WriteLine("ENTER PHONE NUMBER");
                    var phone = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("ENTER SALARY");
                    var salary = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("ENTER JOB STATUS");
                    var status = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ENTER JOINING DATE");
                    var date = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("ENTER YOUR EMAIL");
                    var email = Console.ReadLine();
                    Console.WriteLine("ENTER DEPARTMENT ID");
                    var id = Convert.ToInt32(Console.ReadLine());


                    // Execute Scalar
                    SqlConnection SqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
                    SqlCommand sqlEX = new SqlCommand("SELECT MAX(emp_id) FROM tbl_Emp", SqlCon);
                    SqlCon.Open();
                    int count;
                    if (sqlEX.ExecuteScalar().ToString() == "")
                    {
                        count = 0;
                    }
                    else
                    {
                        count = Convert.ToInt32(sqlEX.ExecuteScalar());
                    }
                    SqlCon.Close();

                    SqlCommand sc = new SqlCommand("INSERT INTO tbl_Emp (emp_id, emp_name, emp_gender, emp_contact_no, emp_sal, emp_job_status, emp_joining_date, emp_email, dept_id) VALUES (@emp_id, @emp_name, @emp_gender, @emp_contact_no, @emp_sal, @emp_job_status, @emp_joining_date, @emp_email, @dept_id) ", SqlCon);
                    SqlCon.Open();

                    sc.Parameters.AddWithValue("@emp_id", Convert.ToInt32(count + 1));
                    sc.Parameters.AddWithValue("@emp_name", name);
                    sc.Parameters.AddWithValue("@emp_gender", gender);
                    sc.Parameters.AddWithValue("@emp_contact_no", phone);
                    sc.Parameters.AddWithValue("@emp_sal", salary);
                    sc.Parameters.AddWithValue("@emp_job_status", status);
                    sc.Parameters.AddWithValue("@emp_joining_date", date);//convert joining date in cmd Convert(Date,date,103)
                    sc.Parameters.AddWithValue("@emp_email", email);
                    sc.Parameters.AddWithValue("@dept_id", id);
                    int i = sc.ExecuteNonQuery();
                    if (i != 0)
                    {
                        Console.WriteLine("Data inserted");
                        Console.WriteLine("------ EMPLOYEE DETAILS INSERTED SUCCESSFULLY----");
                    }
                    SqlCon.Close();

                    DisplayEmp();
                    Console.WriteLine();
                    SelectionOption();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
        void InsertDept()
        {
            try
            {
                // Execute Scalar
                SqlConnection SqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
                SqlCommand sqlEX = new SqlCommand("SELECT MAX(dept_id) FROM tbl_Dept", SqlCon);
                SqlCon.Open();
                int deptIdCount;
                if (Convert.ToString(sqlEX.ExecuteScalar()) == "")
                {
                    deptIdCount = 0;
                }
                else
                {
                    deptIdCount = Convert.ToInt32(sqlEX.ExecuteScalar());
                }
                SqlCon.Close();

                Console.WriteLine("ENTER DEPARTMENT NAME");
                var deptName = Console.ReadLine();

                SqlCommand sc = new SqlCommand("INSERT INTO tbl_Dept (dept_id, dept_name) VALUES (@dept_id, @dept_name) ", SqlCon);
                SqlCon.Open();
                sc.Parameters.AddWithValue("@dept_id", Convert.ToInt32(deptIdCount + 1));
                sc.Parameters.AddWithValue("@dept_name", deptName);
                int i = sc.ExecuteNonQuery();
                if (i != 0)
                {
                    Console.WriteLine("Data inserted");
                }
                SqlCon.Close();

                DisplayDept();
                Console.WriteLine();
                SelectionOption();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
        void UpdateEmp()
        {
            try
            {
                DisplayEmp();
                if (dt.Rows.Count > 0)
                {
                    Console.WriteLine("ENTER EMPLOYEE ID WHICH YOU WANT TO UPDATE");
                    var empId = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ENTER NAME");
                    var name = Console.ReadLine();
                    Console.WriteLine("ENTER GENDER");
                    var gender = Console.ReadLine();
                    Console.WriteLine("ENTER PHONE NUMBER");
                    var phone = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("ENTER SALARY");
                    var salary = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("ENTER JOB STATUS");
                    var status = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ENTER JOINING DATE");
                    var date = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("ENTER YOUR EMAIL");
                    var email = Console.ReadLine();
                    Console.WriteLine("ENTER DEPARTMENT ID");
                    var id = Convert.ToInt32(Console.ReadLine());

                    SqlConnection SqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
                    SqlCommand sc = new SqlCommand("UPDATE tbl_Emp SET  emp_name = @emp_name, emp_gender = @emp_gender , emp_contact_no = @emp_contact_no, emp_job_status = @emp_job_status, emp_joining_date = @emp_joining_date , emp_email = @emp_email, dept_id = @dept_id WHERE emp_id='" + empId + "' ", SqlCon);
                    SqlCon.Open();

                    sc.Parameters.AddWithValue("@emp_name", name);
                    sc.Parameters.AddWithValue("@emp_gender", gender);
                    sc.Parameters.AddWithValue("@emp_contact_no", phone);
                    sc.Parameters.AddWithValue("@emp_sal", salary);
                    sc.Parameters.AddWithValue("@emp_job_status", true);
                    sc.Parameters.AddWithValue("@emp_joining_date", date);
                    sc.Parameters.AddWithValue("@emp_email", email);
                    sc.Parameters.AddWithValue("dept_id", id);

                    sc.ExecuteNonQuery();
                    int i = sc.ExecuteNonQuery();
                    if (i != 0)
                    {
                        Console.WriteLine("Data updated");
                        Console.WriteLine();
                        SelectionOption();
                    }
                    SqlCon.Close();

                    //// Execute Scalar
                    //SqlCommand sqlEX = new SqlCommand("  SELECT MAX(emp_id) FROM tbl_Emp", SqlCon);
                    //SqlCon.Open();
                    //int count = Convert.ToInt32(sqlEX.ExecuteScalar());
                    //sc.Parameters.AddWithValue("@emp_id", Convert.ToInt32(count + 1));
                    //SqlCon.Close();

                }
                else
                {
                    Console.WriteLine("-----EMPLOYEE TABLE IS EMPTY-----ENTER DATA");
                    InsertEmp();
                    Console.WriteLine();
                    SelectionOption();
                }
            }

            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
        void UpdateDept()
        {
            try
            {
                DeptCheck();
                if (dtDept.Rows.Count > 0)
                {


                    Console.WriteLine("ENTER DEPARTMENT ID WHICH YOU WANT TO UPDATE");
                    var deptId = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ENTER DEPARTMENT NAME");
                    var deptName = Console.ReadLine();


                    SqlConnection SqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
                    SqlCommand sc = new SqlCommand(" UPDATE tbl_Dept SET dept_name = @dept_name WHERE dept_id = '" + deptId + "' ", SqlCon);
                    SqlCon.Open();
                    sc.Parameters.AddWithValue("@dept_name", deptName);
                    sc.ExecuteNonQuery();

                    int i = sc.ExecuteNonQuery();
                    if (i != 0)
                    {
                        Console.WriteLine("Data updated");
                        Console.WriteLine();
                        SelectionOption();
                    }
                    SqlCon.Close();

                    //// Execute Scalar
                    //SqlCommand sqlEX = new SqlCommand("SELECT MAX(dept_id) FROM tbl_Dept", SqlCon);
                    //SqlCon.Open();
                    //int deptIdCount = Convert.ToInt32(sqlEX.ExecuteScalar());
                    //sc.Parameters.AddWithValue("@dept_id", Convert.ToInt32(deptIdCount + 1));
                    //SqlCon.Close();
                }
                else
                {
                    Console.WriteLine("---------DEPARTMENT TABLE IS EMPTY-----INSERT DATA ");
                    InsertDept();
                    Console.WriteLine();
                    SelectionOption();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        void DeleteEmp()
        {
            try
            {
                Console.WriteLine("ENTER EMPLOYEE ID WHICH YOU WANT TO DELETE");
                var empId = Convert.ToInt32(Console.ReadLine());

                SqlConnection SqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
                SqlCommand sc = new SqlCommand(" DELETE FROM tbl_Emp WHERE emp_id ='" + empId + "' ", SqlCon);
                SqlCon.Open();
                sc.ExecuteNonQuery();
                SqlCon.Close();
                Console.WriteLine("Successfully Deleted!");
                Console.WriteLine();
                SelectionOption();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        void DeleteDept()
        {
            try
            {

                Console.WriteLine("ENTER DEPARTMENT ID WHICH YOU WANT TO DELETE");
                var deptId = Convert.ToInt32(Console.ReadLine());

                SqlConnection SqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
                SqlCommand sc = new SqlCommand(" DELETE FROM tbl_Dept WHERE dept_id='" + deptId + "' ", SqlCon);
                SqlCon.Open();

                sc.ExecuteNonQuery();
                Console.WriteLine("Successfully Deleted!");
                Console.WriteLine();
                SelectionOption();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        void DeptCheck()
        {
            try
            {
                //display  table
                SqlConnection SqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
                SqlCommand SqlCom = new SqlCommand("SELECT * FROM tbl_Dept", SqlCon);
                SqlCon.Open();
                SqlDataAdapter SdA = new SqlDataAdapter(SqlCom);
                dtDept = new DataTable();
                SdA.Fill(dtDept);
                SqlCon.Close();

                if (dtDept.Rows.Count > 0)
                {

                }
                else
                {
                    Console.WriteLine("------DEPARTMENT DETAILS NOT AVAILABLE----");
                    Console.WriteLine("PLEASE ENTER DEPARTMENT DETAILS");
                    InsertDept();
                    Console.WriteLine(" DATA INSERTED SUCCSESFULLY   ");

                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        static void SelectionOption()
        {
            Program obj = new Program();

            Console.WriteLine("PLEASE SELECT ANY ONE OPTION ");
            Console.WriteLine("1.Display Employee Table        ");
            Console.WriteLine("2.Display Department Table");
            Console.WriteLine("3.INSERT INTO EMPLOYEE TABLE");
            Console.WriteLine("4.INSERT INTO DEPARTMENT TABLE");
            Console.WriteLine("5.UPDATE EMPLOYEE TABLE");
            Console.WriteLine("6.UPDATE DEPARTMENT TABLE");
            Console.WriteLine("7.DELETE FROM EMPLOYEE  TABLE");
            Console.WriteLine("8.DELETE FROM DEPARTMENT TABLE");

            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    obj.DisplayEmp();
                    break;
                case 2:
                    obj.DisplayDept();
                    break;
                case 3:
                    obj.InsertEmp();
                    break;
                case 4:
                    obj.InsertDept();
                    break;
                case 5:
                    obj.UpdateEmp();
                    break;
                case 6:
                    obj.UpdateDept();
                    break;
                case 7:
                    obj.DeleteEmp();
                    break;
                case 8:
                    obj.DeleteDept();
                    break;
            }
        }

        static void Main(string[] args)
        {
            // Program obj = new Program();
            SelectionOption();             //selection
            Console.ReadKey();

        }



    }
}

