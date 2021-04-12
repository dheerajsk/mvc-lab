using System;
using System.Collections.Generic;
using System.Text;

namespace LINQPrograms
{
    class User
    {
        public string Name { get; set; }
        public string City { get; set; }
        public int ID { get; set; }
        public int Age { get; set; }


        public override string ToString()
        {
            return "ID=" + ID + ". Name: " + Name + ". City=" + City + ". Age=" + Age;
        }
    }
}
