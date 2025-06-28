using DataAccess.DBContext;
using DataAccess.Repository.Interface;
using DataModels.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class StudentRepository : BaseRepository<Student>, IStudetRepository
    {
        public StudentRepository(AppDbContext context) : base(context) { }
    }
}
