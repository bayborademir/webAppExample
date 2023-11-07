using System;
using Microsoft.EntityFrameworkCore;
using ProjectYıgıt.WebApp.Entity;

namespace ProjectYıgıt.WebApp.DataAcces
{
	public class ProjectYıgıtDbContext : DbContext
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=YıgıtDatabase;uid=SA;pwd=reallyStrongPwd123;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);

        }

        public DbSet<Employee> Employees { get; set; }
    }
}

