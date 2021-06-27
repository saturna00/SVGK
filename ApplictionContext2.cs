using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WpfApp30
{
    class ApplictionContext2 : DbContext
    {
        public DbSet<Lud> Luds { get; set; }
        public ApplictionContext2() : base("DefaultConnection2") { }
    }
}
