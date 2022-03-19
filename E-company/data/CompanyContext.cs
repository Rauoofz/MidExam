using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace E_company.data
{
    public class CompanyContext:DbContext
    {
        IConfiguration configuration;
        public CompanyContext(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Country> countries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Connections"));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
