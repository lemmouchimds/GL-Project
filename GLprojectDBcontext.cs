using MySql.Data.EntityFramework;
using System.Data.Entity;

namespace GLMainProject
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class GLprojectDBcontext : DbContext
    {
        public GLprojectDBcontext()
        {

        }

        public DbSet<Produit> Produit { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<User> User { get; set; }
        
    }
}
