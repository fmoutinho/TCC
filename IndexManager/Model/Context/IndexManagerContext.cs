using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexManager.Model.Context
{
    public class IndexManagerContext: DbContext
    {
        public DbSet<Case> Cases { get; set; }

        public DbSet<Index> Indexes { get; set; }

        public DbSet<Column> Columns { get; set; }

        public DbSet<Table> Tables { get; set; }
    }
}
