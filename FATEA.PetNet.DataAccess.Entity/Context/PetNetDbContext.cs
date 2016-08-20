using FATEA.PetNet.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FATEA.PetNet.DataAccess.Entity.Context
{
   // [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class PetNetDbContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }
    }
}
