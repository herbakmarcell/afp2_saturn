
using ASP_Core.Database;
using System.Security.Policy;
using ASP_Core.Database.Models;
using System.Diagnostics.Eventing.Reader;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace ASP_Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            //CreateTemplateUser();
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
        //private static void CreateTemplateUser()
        //{
        //    using (var context = new SaturnContext())
        //    {
        //        User user = new User();
        //        user.SaturnCode = "SATURN";
        //        user.Password = " ";
        //        user.LastName = "VEZETEKNEV";
        //        user.FirstName = "KERESZTNEV";
        //        user.Email = "example@example.com";
        //        user.PhoneNumber = "+36701234567";

        //        Role role = new Role();
        //        role.Name = "Oktató";
        //        user.Roles = new List<Role>();
        //        user.Roles.Add(role);

        //        context.Users.Add(user);
        //        context.SaveChanges();
        //    }
        //}
    }
}
