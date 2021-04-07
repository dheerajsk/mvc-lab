using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVCBasics.Models
{
    public class TeacherModel : BaseModel
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfJoining { get; set; }

        public string Department { get; set; }

    }
}
