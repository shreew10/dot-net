using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace intro_mvc_example.Models
{
    public class DeptBL
    {
        public DeptModel deptFun()
        {
            DeptModel dept = new DeptModel();
            dept.DeptID = 1;
            dept.DeptName = "IT";
            dept.DeptContact = 823754316550;
            dept.DeptDate = "01/02/2022";
            return dept;
        }
    }
}