using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika.Entityes
{
    public class PartToRepair
    {
        public int IdRepair { get; set; }
        public int IdPart { get; set; }
        public int count { get; set; }
        public DevicePart DevicePart { get; set; }
        public Repair Repair { get; set; }
    }
}
