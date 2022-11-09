using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkPractice2
{
    public class Department
    {   
        public int Id { get; set; }
        public string Name2 { get; set; }
        public string Location2 { get; set; }
        public List<Employee> Employees { get; set; }
    }
}