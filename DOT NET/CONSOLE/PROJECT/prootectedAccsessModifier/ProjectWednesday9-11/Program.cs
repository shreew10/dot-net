using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWednesday9_11
{
    //applicable to the current application
    public class company
    {
        protected int companyId = 123;
        protected string companyName = "shreeCompany";

        protected void companyDetails()
        {
            Console.WriteLine(companyId);
            Console.WriteLine(companyName);
        }
    }
    class EmployeeContact : company
    {
        protected string contactNo = "1234567890";
        protected int id = 155;
        static void Main(string[] args)
        {
            // for current class
            EmployeeContact objp = new EmployeeContact();
            Console.WriteLine(objp.contactNo);
            Console.WriteLine(objp.id);
            objp.companyDetails();
            objp.companyName;
            Console.WriteLine(objp.companyName);
            objp.companyId;

            // applicable to the current application/namespace
            // can accsess outside class data members and member functions
            company c = new company();

            Console.ReadKey();

        }
    }
}
