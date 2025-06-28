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
    public class TeacherRepostirory : BaseRepository<Teacher>, ITeacherRepositoty
    {
        public TeacherRepostirory(AppDbContext context): base(context)
        {

        }
    }
}
