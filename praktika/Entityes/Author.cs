using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika.Entityes
{
    public class Author
    {
        public int Id { get; set; }
        public Position Position { get; set; }
        public Worker Worker { get; set; }
    }
}
