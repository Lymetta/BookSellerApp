using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnyguApp1
{
    internal class DataContext :DbContext
    {
    // true connecion string has been removed
        public DataContext() : base(@"Connection string")
        {

        }

        public DbSet<Book> Books { get; set; }

    }
}
