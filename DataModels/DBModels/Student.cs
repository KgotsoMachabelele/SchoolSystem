using DataModels.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.DBModels
{
    public class Student : RecordBase
    {
        public int UserID {  get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime DOB { get; set; }
        public string GradeName { get; set;} = string.Empty;

        public ApplicationUser User { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }


    }
}
