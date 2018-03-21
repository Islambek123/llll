using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DALl.Entity
{
    public class EFContext : DbContext
    {
        public EFContext() : base("Bara")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
    }
    
}
