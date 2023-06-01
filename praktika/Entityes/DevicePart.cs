using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika.Entityes
{
    public class DevicePart
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int count { get; set; }
        public decimal cost { get; set; }
        public List<SpecificationsOfPart> SpecificationsOfParts { get; set; }
        public List<PartToRepair> PartToRepairs { get; set; }
    }
}
