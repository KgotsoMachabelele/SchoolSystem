using DataModels.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.DBModels
{
    public class Enrollment : RecordBase
    {
        public string StudentID { get; set; }
        public string CourseID { get; set; }
        public DateTime EnrollDate { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
    }

    public class EnrollmentDTO : RecordBase
    {
        public string StudentID { get; set; }
        public string CourseID { get; set; }
        public DateTime EnrollDate { get; set; }

    }
}
