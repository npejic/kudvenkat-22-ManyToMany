using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kuvdenkat_22
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public IList<Student> Students { get; set; }
    }
}