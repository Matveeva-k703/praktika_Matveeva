﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika.Entityes
{
    public class Specification
    {
        public int Id { get; set; }
        public string Title { get; set; }
        

        public List<SpecificationsOfPart> SpecificationsOfParts { get; set; }
    }
}
