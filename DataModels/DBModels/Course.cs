using DataModels.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.DBModels
{
    public class Course : RecordBase
    {
        public string CourseName { get; set; }
        public string Description { get; set; }
        public string TeacherID { get; set; }
        public Teacher Teacher { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }

    public class CourseDTO : RecordBase
    {
        public string CourseName { get; set; }
        public string Description { get; set; }
        public string TeacherID { get; set; }
        public Teacher Teacher { get; set; }
    }
}
