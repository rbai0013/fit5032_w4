using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyCodeFirst.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }

        public virtual ICollection<Unit> Units { get; set; }
    }
}