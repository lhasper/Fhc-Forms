using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fhc.Models;


namespace Fhc.ViewModels
    {
    public class NewItAccessViewModel
        {
        public  IEnumerable<Department> Departments { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeNumber { get; set; }
            public IEnumerable<Building> Building { get; set; }


        
        }
    }