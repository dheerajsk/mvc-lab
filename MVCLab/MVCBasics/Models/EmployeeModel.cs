using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBasics.Models
{
    public class EmployeeModel
    {
        public string ID { get; set; }

        [StringLength(10)]
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [StringLength(10)]
        public string Mobile { get; set; }

        [StringLength(10)]
        public string City { get; set; }

        [StringLength(10)]
        public string Department { get; set; }
    }
}
