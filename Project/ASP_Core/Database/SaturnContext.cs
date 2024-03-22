using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;
using ASP_Core.Database.Models;
using Microsoft.EntityFrameworkCore.Query.Internal;


namespace ASP_Core.Database
{
    public class SaturnContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<ClassModel> Classes { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Semester> Semesters { get; set; }       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=SaturnDB;user=root;password=");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ClassTableBuilder(modelBuilder);
            CourseTableBuilder(modelBuilder);
            RoleTableBuilder(modelBuilder);
            RoomTableBuilder(modelBuilder);
            SemesterTableBuilder(modelBuilder);
            SubjectTableBuilder(modelBuilder);
            UserTableBuilder(modelBuilder);
        }

        private void ClassTableBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClassModel>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasOne(e => e.Course).WithMany(c => c.Classes);
            });
        }
        private void CourseTableBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(e => e.Code);
                entity.HasMany(e => e.Classes).WithOne(c => c.Course);
                entity.HasOne(e => e.CurrentSemester).WithMany(s => s.SemesterCourses);
                entity.HasMany(e => e.Students).WithMany(u => u.Courses);
                entity.HasMany(e => e.Grades).WithOne(g => g.Course);
                entity.Property(e => e.Credit).IsRequired();
            });
        }
        private void RoleTableBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();

            });
        }
        private void RoomTableBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>(entity => 
            {
                entity.HasKey(e => e.Code);
                entity.HasMany(e => e.Classes).WithOne(c => c.Room);
            });
        }
        private void SemesterTableBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Semester>(entity => 
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Year).IsRequired();
                entity.HasMany(e => e.SemesterCourses).WithOne(c => c.CurrentSemester);
            });
        }
        private void SubjectTableBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subject>(entity =>
            {
                entity.HasKey(e => e.Code);
                entity.Property(e => e.Name).IsRequired();
                entity.HasMany(e => e.Courses).WithOne(c => c.Subject);
            });
        }
        private void UserTableBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.SaturnCode);
                entity.Property(e => e.Password).IsRequired();
                entity.Property(e => e.LastName).IsRequired();
                entity.Property(e => e.FirstName).IsRequired();
                entity.Property(e => e.Email).IsRequired();
                entity.HasMany(e => e.Roles).WithOne(r => r.User);
                entity.HasMany(e => e.Courses).WithMany(c => c.Students);
                entity.HasMany(e => e.Grades).WithOne(g => g.User);
            });
        }
    }
}
