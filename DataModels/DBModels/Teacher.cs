using DataModels.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.DBModels
{
    public class Teacher : RecordBase
    {
        public string UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }

        public ApplicationUser User { get; set; }
        public ICollection<Course> Courses { get; set; }
    }

    public class TeacherDTO: RecordBase
    {
        public string UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
    }
}
