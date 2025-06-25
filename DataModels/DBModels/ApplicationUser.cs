using DataModels.Classes;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.DBModels
{
    public class ApplicationUser : IdentityUser
    {
    
        public string Email { get; set; }
        public string Role {  get; set; }
     
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
    }
}
