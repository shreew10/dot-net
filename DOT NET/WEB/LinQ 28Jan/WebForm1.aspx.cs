using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinQ_28Jan
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                DataClasses1DataContext objDc = new DataClasses1DataContext();

                // ---------------SELECT QUERY IN LINQ------------------
                Gv.DataSource = from objTbl in objDc.tbl_student_details
                                where objTbl.studRollno == 37
                                select objTbl;
                Gv.DataBind();


                //-------------- LAMBDA EXPRESSION ---------------
                var namelist = objDc.tbl_student_details.Select(x => new { Student = x.studName }).ToList();
                Gv.DataSource = namelist;
                Gv.DataBind();


                //--------INSERT OPERATION---------------
                DataClasses1DataContext objInsert = new DataClasses1DataContext();
                tbl_student_detail objStud = new tbl_student_detail();
                objStud.studName = "Abhi";
                objStud.studRollno = 40;
                objStud.studSubject = "Maths";
                objStud.studGender = "Female";
                objInsert.tbl_student_details.InsertOnSubmit(objStud);
                objInsert.SubmitChanges();




                //-----------UPDATE OPERATION--------------
                DataClasses1DataContext objUpdate = new DataClasses1DataContext();
                (from tbl_stud in objUpdate.tbl_student_details
                 where tbl_stud.studName == "Jolly"
                 select tbl_stud).ToList().ForEach(x => x.studSubject = "History");
                objUpdate.SubmitChanges();

                Gv.DataSource = from objU in objDc.tbl_student_details select objU;
                Gv.DataBind();


                //===============DELETE OPERATION--------------------===============
                DataClasses1DataContext objDelete = new DataClasses1DataContext();
                tbl_student_detail objStudent = objDelete.tbl_student_details.Single(obj => obj.studRollno == 37);
                objDelete.tbl_student_details.DeleteOnSubmit(objStudent);
                objDelete.SubmitChanges();

                Gv.DataSource = from objU in objDc.tbl_student_details
                                select objU;
                Gv.DataBind();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}