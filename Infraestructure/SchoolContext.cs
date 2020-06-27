using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Domain;
using System.Threading.Tasks;

namespace Infraestructure
{
    public class SchoolContext : DbContext
    {

        public SchoolContext() : base("name = MyContextDB")
        {
            
        }

        public DbSet<Student> Students { get; set; }
    }
}
