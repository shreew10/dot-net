using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinQExample
{
    public partial class LinQ1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LinQdataBaseDataContext objDc = new LinQdataBaseDataContext();
            GridView1.DataSource = from objTbl in objDc.tbl_Depts
                                       //where objTbl.dept_id == 1
                                   select new { name = objTbl.dept_name };  // to display selected column and give them alias name
            GridView1.DataBind();


            ////lambda Expression
            //var nameList = objDc.tbl_Depts.Select(x => new { Name = x.dept_name }).ToList();
            //GridView1.DataSource = nameList;
            //GridView1.DataBind();

            ////insert operation
            ////tbl_Dept objDept = new tbl_Dept();
            ////objDept.dept_id = 3;
            ////objDept.dept_name = "Accounting";
            ////objDc.tbl_Depts.InsertOnSubmit(objDept);
            ////objDc.SubmitChanges();

            //GridView1.DataSource = from objTbl in objDc.tbl_Depts
            //                           //where objTbl.dept_id == 1
            //                       select new { id = objTbl.dept_id };  // to display selected column and give them alias name
            //GridView1.DataBind();


            // update database
            LinQdataBaseDataContext objDcUpdate = new LinQdataBaseDataContext();
            (from p in objDcUpdate.tbl_Depts
             where p.dept_id == 1
             select p).ToList().ForEach(x => x.dept_name = "kkkk");
            objDcUpdate.SubmitChanges();
            GridView1.DataSource = from objTbl in objDc.tbl_Depts
                                       //where objTbl.dept_id == 1
                                   select new { name = objTbl.dept_name };
            GridView1.DataBind();


            // delete operation
            LinQdataBaseDataContext objDelete = new LinQdataBaseDataContext();
            tbl_Dept objtbl = objDelete.tbl_Depts.Single(obj => obj.dept_id == 3);
            objDelete.tbl_Depts.DeleteOnSubmit(objtbl);
            objDelete.SubmitChanges();
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;

//namespace Linq_demo
//{
//    public partial class WebForm1 : System.Web.UI.Page
//    {
//        protected void Page_Load(object sender, EventArgs e)
//        {
//            ////_____________________________________________________________________________________________________________________
//            ////LINQ with Query

//            DataClasses2DataContext objDC = new DataClasses2DataContext();
//            GridView1.DataSource = from objtbl in objDC.tbl_emps
//                                   select new { userName = objtbl.ENAME, no = objtbl.EMPNO };
//            GridView1.DataBind();

//            DataClasses2DataContext dc = new DataClasses2DataContext();
//            GridView1.DataSource = from objt in dc.tbl_emps
//                                   where objt.ENAME == "Rutwi"
//                                   select objt;
//            GridView1.DataBind();

//            ////1 way of insert Data in data base //insert operation
//            DataClasses2DataContext objDCInsert = new DataClasses2DataContext();
//            tbl_emp objEmp = new tbl_emp();
//            objEmp.EMPNO = 120;
//            objEmp.ENAME = "jj";
//            objEmp.JOB = "HR";
//            objEmp.HIREDATE = System.DateTime.Now.Date;

//            objDCInsert.tbl_emps.InsertOnSubmit(objEmp);
//            objDCInsert.SubmitChanges();

//            ////2 way of insert Data in data base //insert operation
//            using (DataClasses2DataContext objDCAdd = new DataClasses2DataContext())
//            {
//                tbl_emp objEmpAdd = new tbl_emp();
//                objEmpAdd.EMPNO = 100;
//                objEmpAdd.ENAME = "ajay";
//                objEmpAdd.JOB = "no";
//                objEmpAdd.HIREDATE = System.DateTime.Now.Date;
//                objDCInsert.tbl_emps.InsertOnSubmit(objEmpAdd);
//                objDCInsert.SubmitChanges();
//            }

//            ////update data i database //update operation
//            DataClasses2DataContext objDcUpdate = new DataClasses2DataContext();
//            (from p in objDcUpdate.tbl_emps
//             where p.EMPNO == 2
//             select p).ToList().ForEach(x => x.ENAME = "dddddd");
//            objDcUpdate.SubmitChanges();

//            GridView1.DataSource = from objt in dc.tbl_emps
//                                   select objt;
//            GridView1.DataBind();

//            ////delete record from database // delete operation
//            DataClasses2DataContext objDCDelete = new DataClasses2DataContext();
//            ////Get Single emp which need to Delete  
//            tbl_emp objTbl = objDCDelete.tbl_emps.Single(obj => obj.EMPNO == 12);
//            ////Puts an entity from this table into a pending delete state and parameter is the entity which to be deleted.  
//            objDCDelete.tbl_emps.DeleteOnSubmit(objTbl);
//            //// executes the appropriate commands to implement the changes to the database  
//            objDCDelete.SubmitChanges();

//            ////_______________________________________________________________________________________________________________________________________
//            ////LINQ with lambada expression
//            ////To delete single data
//            DataClasses2DataContext objDCDeleteUsingLambadaExpression = new DataClasses2DataContext();
//            var objDeleteLambda = objDCDeleteUsingLambadaExpression.tbl_emps.Where(x => x.ENAME == "Supriya").SingleOrDefault();
//            objDCDelete.tbl_emps.DeleteOnSubmit(objDeleteLambda);

//            ////To delete multiple data
//            var objDeleteMultipleLambda = objDCDeleteUsingLambadaExpression.tbl_emps.Where(x => x.ENAME == "geet").ToList();
//            objDCDelete.tbl_emps.DeleteAllOnSubmit(objDeleteMultipleLambda);
//            objDCDelete.SubmitChanges();

//            var nameList = objDC.tbl_emps.Select(x => new { studName = x.ENAME }).ToList();
//            GridView1.DataSource = nameList;
//            GridView1.DataBind();
//        }
//    }
//}