using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fhc.Models
    {
    public class Employee
        {
            public int Id { get; set; }
            [Required]
            [Display(Name = "First Name")]
            public string FirstName { get; set; }


            public string LastName { get; set; }

            public string Title { get; set; }


            public Department Department { get; set; }
            public int DepartmentId { get; set; }


            public string Supervisor { get; set; }


            public Building Building { get; set; }
            public int BuildingId { get; set; }


            public DateTime? StartDate { get; set; }

           // public FullTimeEmployee FullTimeEmployee{get; set;}
           // public int FullTimeEmployeeId { get; set; }


            public string UserName { get; set; }


            public string Password { get; set; }




            public bool Domain { get; set; }
            public bool Epic { get; set; }
            public bool Dentrix { get; set; }
        public bool Email { get; set; }
        public bool Internet { get; set; }
            public bool Skype { get; set; }
            public bool PhoneExt { get; set; }
            public bool Laptop { get; set; }
    }
    }