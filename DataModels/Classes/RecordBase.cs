using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Classes
{
    public interface IRecordBase
    {
        int Id { get; set; }
    }
    public class RecordBase : IRecordBase
    {
        public int Id { get; set; }
    }
}
