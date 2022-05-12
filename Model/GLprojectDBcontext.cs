using MySql.Data.EntityFramework;
using System.Data.Entity;

namespace GLMainProject
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class GLprojectDBcontext : DbContext
    {
        public GLprojectDBcontext(): base("GLprojectDBcontext")
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentDetail> DocumentDetails { get; set; }
        public DbSet<Inventory> Inventory { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
