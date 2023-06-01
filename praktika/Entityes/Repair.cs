using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika.Entityes
{
    public class Repair
    {
        public int Id { get; set; }
        public int device { get; set; }
        public string comment { get; set; }
        public string status { get; set; }
        public decimal cost { get; set; }
        public List<PartToRepair> PartToRepairs { get; set; }
        public Status Status { get; set; }
        public Device Device { get; set; }
    }
}
