
using ASP_Core.Database;
using System.Security.Policy;
using ASP_Core.Database.Models;
using System.Diagnostics.Eventing.Reader;

namespace ASP_Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            CreateDatabase();
            AddRole();
            builder.Services.AddControllers();
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

            app.UseAuthorization();


            app.MapControllers();

            app.Run();

            
        }
        private static void CreateDatabase()
        {
            using (var context = new SaturnContext())
            {
                if (context.Database.EnsureCreated())
                {
                    Console.WriteLine("[SaturnDB] Adatb�zis l�trehoz�sa folyamatban...");
                }
                else
                {
                    Console.WriteLine("[SaturnDB] Adatb�zis m�r l�tezik, csatlakoz�s megkezd�se...");
                }

                User user = new User();
                user.SaturnCode = "QAGSVA";
                user.Password = "Sapk�sKacsa18";
                user.LastName = "Marcell";
                user.FirstName = "Herb�k";
                user.Email = "herbakmarcell@gmail.com";
                user.PhoneNumber = "+36701234567";

                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        private static void AddRole()
        {
            using (var context = new SaturnContext())
            {
                User user = context.Users.First();
                Role role = new Role();
                role.Name = "Oktat�";

                user.Roles = new List<Role>();
                user.Roles.Add(role);
                context.SaveChanges();
            }
        }
    }
}
