using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkPractice2
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName2 { get; set; }
        public string LastName2 { get; set; }
        public string Gender2 { get; set; }
        public int Salary2{ get; set; }

        public Department Department { get; set; }
    }


}