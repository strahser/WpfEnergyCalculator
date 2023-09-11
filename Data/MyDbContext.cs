using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfEnergyCalculator.Models;
namespace WpfEnergyCalculator.Data
{
    public class MyDbContext : DbContext

    {

        public virtual DbSet<RoomData> RoomData { get; set; }
        public virtual DbSet<StructureCategory> StructureCategory { get; set; }
        public virtual DbSet<StructureInstance> StructureInstance { get; set; }

        public MyDbContext() : base("SructureDB")
        { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<MyDbContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);

        }




    }
}
