using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika.Entityes
{
    public class SpecificationsOfPart
    {
        public int IdSPecification { get; set; }
        public int IdPart { get; set; }
        public decimal Value { get; set; }
        public Specification Specification { get; set; }
        public DevicePart DevicePart { get; set; }

    }
}
