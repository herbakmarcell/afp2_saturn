
using ASP_Core.Database.ModelContext;
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
            using (var context = new UserContext())
            {
                if (context.Database.EnsureCreated())
                {
                    Console.WriteLine("[SaturnDB] Adatbázis létrehozása folyamatban...");
                }
                else
                {
                    Console.WriteLine("[SaturnDB] Adatbázis már létezik, csatlakozás megkezdése...");
                }

                context.SaveChanges();
            }
        }
    }
}
