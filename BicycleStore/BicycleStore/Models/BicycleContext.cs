using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleStore.Models
{
    public class BicycleContext:DbContext
    {
        public DbSet<Bicycle> Bicycles { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        public BicycleContext(DbContextOptions<BicycleContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string superAdminRole = "superAdmin";
            string adminRole = "admin";
            string userRole = "user";

            string superAdminLogin = "admin@gmail.com";
            string superAdminPassword = "Qwerty123";
            
            Role admin = new Role { RoleId = 1, Name = adminRole };
            Role user = new Role { RoleId = 2, Name = userRole };
            Role superAdmin = new Role { RoleId = 3, Name = superAdminRole };
            User superAdminUser = new User { UserId = 100, Email = superAdminLogin, Password = superAdminPassword, RoleId = superAdmin.RoleId };
            modelBuilder.Entity<Role>().HasData(new Role[] { admin, user, superAdmin });
            modelBuilder.Entity<User>().HasData(new User[] { superAdminUser });
            base.OnModelCreating(modelBuilder);
        }
    }
}
