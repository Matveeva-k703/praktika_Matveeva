﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika.Entityes
{
    public class Type
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Device> Devices { get; set; }
    }
}
