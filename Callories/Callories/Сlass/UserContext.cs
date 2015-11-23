using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Callories.Сlass
{
    class UserContext : DbContext
    {
        public UserContext()
            : base("DbConnection")
        { }

        public DbSet<DateFor> DateFors { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Exersice> Exercises { get; set; }
        public DbSet<ProdutInfo> ProdutInfos { get; set; }
        public DbSet<ExerciseInfo> ExerciseInfos { get; set; }

    }
}
