using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika.Entityes
{
    public class Position
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Worker> Workers { get; set; }
        public List<Author> Authors { get; set; }
    }
}
