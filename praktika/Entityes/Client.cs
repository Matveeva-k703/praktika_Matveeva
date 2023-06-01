using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika.Entityes
{
    public class Client
    {
        public int Num { get; set; }
        public string name { get; set; }
        public int serialPass { get; set; }
        public int numberPas { get; set; }
        public int phone { get; set; }
        public List<Device> Devices { get; set; }
    }
}
