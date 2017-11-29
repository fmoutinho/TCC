using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexManager.Model
{
    public class Index
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string SqlCommand { get; set; }

        public HashSet<Column> Columns { get; set; }

        public HashSet<Case> Cases { get; set; }

    }
}
