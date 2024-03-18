using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;
using ASP_Core.Database.Models;


namespace ASP_Core.Database.ModelContext
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=SaturnDB;user=root;password=");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User> (entity =>
            {
                entity.HasKey(e => e.SaturnCode);
                entity.Property(e => e.Password).IsRequired();
                entity.HasMany(e => e.AccessLevel).WithOne(r => r.OneUser);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.RoleName).IsRequired();
                
            });
        }

    }
}
