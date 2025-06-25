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
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public DateTime EnrollDate { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
