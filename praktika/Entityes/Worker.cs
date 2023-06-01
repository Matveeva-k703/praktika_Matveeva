using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika.Entityes
{
    public class Worker
    {
        public int tabNum { get; set; }
        public string FIO { get; set; }
        public decimal oklad { get; set; }
        public double percentToRepair { get; set; }
        public Position Position { get; set; }
        public List<Author> Authors { get; set; }
        public List<Device> Devices { get; set; }
    }
}
