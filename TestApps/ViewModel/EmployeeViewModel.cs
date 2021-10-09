using CodeFirstDB;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestApps.ViewModel
{
    public class EmployeeViewModel
    {



        public int EmpID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public IFormFile ProfileImage { get; set; }
               
        public int Deptid { get; set; }
    }
}
