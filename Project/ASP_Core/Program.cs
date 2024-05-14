
using ASP_Core.Database;
using System.Security.Policy;
using ASP_Core.Database.Models;
using System.Diagnostics.Eventing.Reader;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using ASP_Core.Services.Auth;
using ASP_Core.Services;
using Microsoft.Net.Http.Headers;
using Microsoft.AspNetCore.Identity;
using ASP_Core.Services.Exam;
using ASP_Core.Services.Course;

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
            //builder.Services.AddIdentityCore<User>().AddRoles<Role>();
            builder.Services.AddDbContext<SaturnContext>();
            builder.Services.AddAuthentication()
                .AddJwtBearer(option =>
                {
                    option.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = "https://localhost:7204/",
                        ValidAudience = "https://localhost:7204/",
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("SaturnSuperSecretKey666XDWEARETHECHAMPIONSMYFRIEND"))
                    };
                });
            builder.Services.AddAuthorization();
            builder.Services.AddAuthorization(x => x.AddPolicy("AdminOnly", policy => policy.RequireRole("Admin")));
            builder.Services.AddScoped<AuthIService, AuthService>();
            builder.Services.AddScoped<ICommonService, CommonService>();
            builder.Services.AddScoped<IMessageService, MessageService>();
            builder.Services.AddScoped<ExamIService, ExamService>();
            builder.Services.AddScoped<CourseIService, CourseService>();

            builder.Services.AddControllers();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Saturn", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
                {
                    Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
                    In = Microsoft.OpenApi.Models.ParameterLocation.Header,
                    Name = HeaderNames.Authorization,
                    Scheme = "Bearer"
                });

                c.OperationFilter<SecureEndpointAuthRequirementFilter>();
            });


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            
            app.UseAuthentication();
            app.UseAuthorization();
            //app.UseCors();


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
            using (var context = new SaturnContext())
            {
                User user = new User();
                user.SaturnCode = "QAGSVA";
                user.Password = BCrypt.Net.BCrypt.HashPassword("GoofyAAH");
                user.LastName = "Marci";
                user.FirstName = "Hallgato";
                user.Email = "marc@student.com";
                user.PhoneNumber = "+36201234567";

                Role role = new Role();
                role.Name = "Student";
                user.Roles = [role];

                context.Users.Add(user);
                context.SaveChanges();
            }
        }
    }
}
