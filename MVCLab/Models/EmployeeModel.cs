using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBasics.Models
{
    public class EmployeeModel : BaseModel
    {

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
