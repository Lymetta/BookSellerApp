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
        public DataContext() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\proch\source\repos\KnyguApp1\KnyguApp1\KnygosDB.mdf;Integrated Security=True")
        {

        }

        public DbSet<Book> Books { get; set; }

    }
}
