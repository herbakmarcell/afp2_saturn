﻿using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;
using ASP_Core.Database.Models;
using Microsoft.EntityFrameworkCore.Query.Internal;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Resources;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using NuGet.Protocol.Plugins;
using BCrypt;
using System.Text.RegularExpressions;
using ASP_Core.Models.Auth;


namespace ASP_Core.Database
{
    public class SaturnContext : DbContext
    {
        public SaturnContext()
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<ClassModel> Classes { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Semester> Semesters { get; set; }       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            var connectionString = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build()
                .GetSection("ConnectionString")["SaturnDB"];
            optionsBuilder.UseMySQL(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ClassTableBuilder(modelBuilder);
            CourseTableBuilder(modelBuilder);
            ExamTableBuilder(modelBuilder);
            GradeTableBuilder(modelBuilder);
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
        private void ExamTableBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exam>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasMany(e => e.Grades).WithOne(g => g.Exam);
                entity.HasMany(e => e.Students).WithMany(u => u.Exams);
                entity.HasOne(e => e.Course).WithMany(c => c.Exams);
                entity.HasOne(e => e.Semester).WithMany(s => s.SemesterExams);
            });
        }
        private void GradeTableBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grade>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasOne(e => e.User).WithMany(g => g.Grades);
                entity.HasOne(e => e.Course).WithMany(c => c.Grades);
                entity.HasOne(e => e.Exam).WithMany(e => e.Grades);

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
                entity.HasMany(e => e.SemesterExams).WithOne(c => c.Semester);
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
                entity.HasMany(e => e.Exams).WithMany(e => e.Students);
                //entity.HasMany(e => e.Exams).WithOne(e => e.Prof);
            });
        }

        public User? LoginCheck(string saturnCode, string password)
        {
            User? user = this.Users.FirstOrDefault(u => u.SaturnCode == saturnCode);
            if (user == null)
            {
                return null;
            }

            bool verfified = BCrypt.Net.BCrypt.Verify(password, user.Password);

            if (!verfified)
                return null;

            return user;
        }

        public void Seed()
        {
            User user = new User();
            user.SaturnCode = "ADMIN1";
            user.Password = BCrypt.Net.BCrypt.HashPassword("GoofyAAH");
            user.LastName = "Péter";
            user.FirstName = "Admin";
            user.Email = "admin@admin.com";
            user.PhoneNumber = "+36201234567";

            Role role = new Role();
            role.Name = "Admin";
            user.Roles = [role];

            Users.Add(user);
            SaveChanges();
        }

        public string Register(RegisterModel registerModel)
        {

            User? userExists;
            string generatedSaturnCode;
            do
            {
                generatedSaturnCode = string.Empty;
                
                Random rd = new Random();
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

                for (int i = 0; i < 6; i++)
                {
                    generatedSaturnCode += chars[rd.Next(chars.Length)];
                }

                userExists = Users.FirstOrDefault(u => u.SaturnCode == generatedSaturnCode);
            } while (userExists != null);

            User newUser = new User()
            {
                SaturnCode = generatedSaturnCode,
                Password = BCrypt.Net.BCrypt.HashPassword(registerModel.Password),
                LastName = registerModel.LastName,
                FirstName = registerModel.FirstName,
                Email = registerModel.Email,
                PhoneNumber = registerModel.PhoneNumber,
                Roles = new List<Role>()
            };

            foreach (var item in registerModel.Roles)
            {
                Role newRole = new Role();
                newRole.Name = item;
                newUser.Roles.Add(newRole);
            }

            Users.AddAsync(newUser);
            SaveChangesAsync();

            return generatedSaturnCode;
        }

        public List<Role>? UserRoles(string saturnCode)
        {
            User? searchedUser = Users.FirstOrDefault(u => u.SaturnCode == saturnCode);

            if (searchedUser == null)
            {
                return null;
            }

            return searchedUser.Roles;
        }
    }
}
