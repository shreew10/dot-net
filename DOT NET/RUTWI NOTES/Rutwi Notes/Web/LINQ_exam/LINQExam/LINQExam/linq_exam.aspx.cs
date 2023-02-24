using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQExam
{
    public partial class linq_exam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext objDc = new DataClasses1DataContext();

            GridView1.DataSource = from objtbl in objDc.tbl_students
                                   select objtbl.stud_name;

            GridView1.DataBind();

            var nameList = objDc.tbl_students.Select(x => new { studName = x.stud_name }).ToList();
            GridView1.DataSource = nameList;
            GridView1.DataBind();

            ////Insert Operation
            //DataClasses1DataContext objDCInsert = new DataClasses1DataContext();
            //tbl_student objStud = new tbl_student();
            //objStud.stud_name = "Pranav";
            //objStud.stud_city = "Pune";
            //objDCInsert.tbl_students.InsertOnSubmit(objStud);
            //objDCInsert.SubmitChanges();

            ////Update Operation
            //DataClasses1DataContext objDCUpdate = new DataClasses1DataContext();
            //(from tbl_stud in objDCUpdate.tbl_students
            // where tbl_stud.stud_name == "Rutwi"
            // select tbl_stud).ToList().ForEach(x => x.stud_city = "Pune");
            //objDCUpdate.SubmitChanges();

            //GridView1.DataSource = from objU in objDc.tbl_students
            //                       select objU;
            //GridView1.DataBind();

            //Delete operation
            DataClasses1DataContext objDCDelete = new DataClasses1DataContext();
            tbl_student objStudent = objDCDelete.tbl_students.Single(obj => obj.stud_id == 3);
            objDCDelete.tbl_students.DeleteOnSubmit(objStudent);
            objDCDelete.SubmitChanges();

            GridView1.DataSource = from objU in objDc.tbl_students
                                   select objU;
            GridView1.DataBind();
        }
    }
}