using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika.Entityes
{
    public class FirstDiagnostic
    {
        public int Id { get; set; }
        public int device { get; set; }
        public string description { get; set; }
        public Device Device { get; set; }
    }
}
