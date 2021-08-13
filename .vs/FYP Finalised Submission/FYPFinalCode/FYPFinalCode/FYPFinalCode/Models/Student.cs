using System;
using System.Collections.Generic;

namespace FYPFinalCode.Models
{
    public partial class Student
    {
        public Student()
        {
            Chapter = new HashSet<Chapter>();
            Journal = new HashSet<Journal>();
        }

        public int StudentId { get; set; }
        public string StudentBc { get; set; }
        public string StudentName { get; set; }
        public int StudentAge { get; set; }

        public virtual ICollection<Chapter> Chapter { get; set; }
        public virtual ICollection<Journal> Journal { get; set; }
    }
}
