using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika.Entityes
{
    public class Device
    {
        public int Id { get; set; }
        public int type { get; set; }
        public string model { get; set; }
        public string damage { get; set; }
        public string complaint { get; set; }
        public Type Type { get; set; }
        public Worker Worker { get; set; }
        public Client Client { get; set; }
        public List<FirstDiagnostic> FirstDiagnostics { get; set; }
        public List<Repair> Repairs { get; set; }
    }
}
