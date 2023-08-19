using MyCodeFirst.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MyCodeFirst.DAL
{
    public class Class1:DbContext
    {
        public Class1() : base("UniContext")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Unit> Enrollments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}