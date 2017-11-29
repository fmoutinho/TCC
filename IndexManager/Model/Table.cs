using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexManager.Model
{
    public class Table
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public HashSet<Column> Columns { get; set; }
    }
}
