using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MySql.Data.Entity;

namespace Personal_Calendar.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    class ApplicationContext : DbContext
    {
        public DbSet<DbEvent> Events { get; set; }

        public ApplicationContext() : base("DefaultConnection")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties<String>().Configure(c => c.HasColumnType("longtext"));
            base.OnModelCreating(modelBuilder);
        }
    }
}
