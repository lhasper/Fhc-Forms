using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fhc.Models
    {
    public class Building
        {
       
        public int Id { get; set; }
            [Required]
            [StringLength(255)]
            public string BuildingName { get; set; }
        }
    }