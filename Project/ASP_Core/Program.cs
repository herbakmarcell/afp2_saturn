
using ASP_Core.Database;
using System.Security.Policy;
using ASP_Core.Database.Models;
using System.Diagnostics.Eventing.Reader;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using ASP_Core.Services.Auth;

namespace ASP_Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            //CreateDB();
            //CreateTemplateUser();
            builder.Services.AddScoped<AuthIService, AuthService>();
            builder.Services.AddControllers();
            builder.Services.AddDbContext<SaturnContext>();

            builder.Services.AddAuthentication()
                .AddJwtBearer()
                .AddJwtBearer("LocalAuthIssuer");
                
            builder.Services.AddAuthorization();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseCors();
            app.UseAuthentication();
            app.UseAuthorization();


            app.MapControllers();
            //app.MapGet("/auth");
            app.Run();

            
        }

        private static void CreateDB()
        {
            using (var context = new SaturnContext())
            {
                context.Database.EnsureCreated();
                //context.Seed();
            }
        }
        private static void CreateTemplateUser()
        {
            using (var context = new SaturnContext())
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

                context.Users.Add(user);
                context.SaveChanges();
            }
        }
    }
}
