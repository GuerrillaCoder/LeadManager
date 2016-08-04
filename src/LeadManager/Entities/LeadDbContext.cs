using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeadManager.Entities
{
    public class LeadDbContext : DbContext
    {
        private IConfigurationRoot _config;

        public LeadDbContext(IConfigurationRoot config, DbContextOptions<LeadDbContext> options) : base(options)
        {
            _config = config;
        }
        public DbSet<Lead> Leads { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            
            optionsBuilder.UseSqlServer(_config["ConnectionStrings:Development"]);
        }
    }

    

}
