﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexManager.Model
{
    public class Column
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Table Table { get; set; }

        public HashSet<Index> Indexes { get; set; }
    }
}
