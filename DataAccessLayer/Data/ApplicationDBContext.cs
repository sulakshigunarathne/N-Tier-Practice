using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Entities;
using Microsoft.Extensions.Configuration;

namespace DataAccessLayer.Data
{
    public class ApplicationDBContext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=127.0.0.1;Port=5432;Database=Employees;Username=postgres;Password=pass12;");
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Email> Emails { get; set; }
        
    }
}
