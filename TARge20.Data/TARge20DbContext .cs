
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARge20.Core.Domain;

namespace TARge20.Data
{
    public class TARge20DbContext : DbContext
    {

        public TARge20DbContext(DbContextOptions<TARge20DbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Kindergarden> Kindergarden { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<Educator> Educator { get; set; }
        public DbSet<Senior_Educator> SeniorEducator { get; set; }
        public DbSet<Methodologist> Methodologist { get; set; }
        public DbSet<Child> Child { get; set; }
        public DbSet<GroupQueue> GroupQueue { get; set; }
        public DbSet<Cook> Cook { get; set; }
        public DbSet<Kitchen> Kitchen { get; set; }
        public DbSet<Menu> Menu { get; set; }
    }
}