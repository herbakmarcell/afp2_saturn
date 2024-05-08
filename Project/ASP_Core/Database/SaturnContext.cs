using Microsoft.EntityFrameworkCore;
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
using ASP_Core.Models.Responses;
using Humanizer.DateTimeHumanizeStrategy;
using ASP_Core.Models.Message;
using ASP_Core.Models.Exam;
using ASP_Core.Services.Exam;


namespace ASP_Core.Database
{
    public class SaturnContext : DbContext
    {
        public SaturnContext()
        {
            this.Database.EnsureCreated();
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<ClassModel> Classes { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<MessageModel> MessageModel { get; set; }

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
            MessageTableBuilder(modelBuilder);
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
                entity.HasMany(e => e.SentMessages).WithOne(e => e.Sender);
                entity.HasMany(e => e.ReceivedMessages).WithMany(e => e.Receivers);
            });
        }
        private void MessageTableBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MessageModel>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Subject).IsRequired();
                entity.Property(e => e.Content).IsRequired();
                entity.HasOne(e => e.Sender).WithMany(u => u.SentMessages);
                entity.HasMany(e => e.Receivers).WithMany(u => u.ReceivedMessages);
            });
        }

        public User? LoginCheck(string saturnCode, string password)
        {
            User? user = this.Users.Include(u => u.Roles).FirstOrDefault(u => u.SaturnCode == saturnCode);
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

            Users.Add(newUser);
            SaveChanges();

            return generatedSaturnCode;
        }

        public ChangeResponse? Change(ChangeModel changeModel)
        {
            ChangeResponse changeResponse = new ChangeResponse();
            User? user = this.Users.Include(u => u.Roles).FirstOrDefault(u => u.SaturnCode == changeModel.SaturnCode);

            if (user == null)
            {
                return null;
            }
            changeResponse.SaturnCode = user.SaturnCode;
            if (changeModel.NewPassword != null && !BCrypt.Net.BCrypt.Verify(changeModel.NewPassword, user.Password)) 
            { 
                user.Password = BCrypt.Net.BCrypt.HashPassword(changeModel.NewPassword);
                changeResponse.NewPassword = "Password has changed";
            }

            if (changeModel.NewLastName != null && user.LastName != changeModel.NewLastName)
            {
                user.LastName = changeModel.NewLastName;
                changeResponse.NewLastName = changeModel.NewLastName;
            }
            if (changeModel.NewFirstName != null && user.FirstName != changeModel.NewFirstName) 
            {
                user.FirstName = changeModel.NewFirstName;
                changeResponse.NewFirstName = changeModel.NewFirstName;
            }
            if (changeModel.NewEmail != null && user.Email != changeModel.NewEmail)
            {
                user.Email = changeModel.NewEmail;
                changeResponse.NewEmail = changeModel.NewEmail;
            }
            if (changeModel.NewPhoneNumber != null && user.PhoneNumber != changeModel.NewPhoneNumber)
            {
                user.PhoneNumber = changeModel.NewPhoneNumber;
                changeResponse.NewPhone = changeModel.NewPhoneNumber;
            }
                
            if (changeModel.NewRoles != null)
            {
                string[] validRoles = { "Student", "Teacher", "Admin" };
                string[] roles = user.ReturnRoles.Split(',');
                changeResponse.NewRoles = new List<string>();

                foreach (var newUserRole in changeModel.NewRoles)
                {
                    if (!validRoles.Contains(newUserRole)) return null;
                    if (!roles.Contains(newUserRole))
                    {
                        Role newRole = new Role();
                        newRole.Name = newUserRole;
                        user.Roles.Add(newRole);
                        changeResponse.NewRoles.Add("+"+newUserRole);
                    }
                }
                foreach (var oldUserRole in roles)
                {
                    if (!changeModel.NewRoles.Contains(oldUserRole))
                    {
                        Role oldRole = this.Roles.Include(r => r.User).FirstOrDefault(r => r.Name == oldUserRole && r.User.SaturnCode == changeModel.SaturnCode);
                        user.Roles.Remove(oldRole);
                        changeResponse.NewRoles.Add("-"+oldUserRole);
                    }
                }
            }
            SaveChanges();
            return changeResponse;
        }

        public User? UserWithSaturnCode(string saturnCode)
        {
            return this.Users.FirstOrDefault(u => u.SaturnCode == saturnCode);
        }

        public List<MessageModel> GetReceivedMessages(string saturnCode, string? sender)
        {
            User? receiverUser = UserWithSaturnCode(saturnCode);
            if (receiverUser == null) return null;
            List<MessageModel> receivedMessages;
            if (string.IsNullOrEmpty(sender)) return MessageModel.Include(u=> u.Sender).Include(u => u.Receivers).Where(mm => mm.Receivers.Contains(receiverUser)).ToList();
            else return MessageModel.Include(u => u.Sender).Include(u => u.Receivers).Where(mm => mm.Receivers.Contains(receiverUser) && mm.Sender == UserWithSaturnCode(sender)).ToList();

        }

        public List<MessageModel> GetSentMessages(string sender)
        {
            User? receiverUser = UserWithSaturnCode(sender);
            if (receiverUser == null) return null;
            return MessageModel.Include(u=> u.Sender).Include(u=> u.Receivers).Where(mm => mm.Sender.SaturnCode == sender).ToList();
        }


        //make a sendMessage method that returns with a messageresponse and adds the message to the database
        public SendMessageResponse SendMessage(MessageModel messageModel)
        {
            // get the receivers saturncode from the messageModel
            List<string> receivers = new List<string>();
            foreach (var receiver in messageModel.Receivers)
            {
                User? user = UserWithSaturnCode(receiver.SaturnCode);
                if (user != null) receivers.Add(user.SaturnCode);
            }
            MessageModel newMessage = new MessageModel
            {
                Subject = messageModel.Subject,
                Content = messageModel.Content,
                Sender = messageModel.Sender,
                Receivers = messageModel.Receivers
            };
            this.Users.Include(u => u.SentMessages).FirstOrDefault(u => u.SaturnCode == messageModel.Sender.SaturnCode).SentMessages.Add(newMessage);
            foreach (var receiver in messageModel.Receivers)
            {
                this.Users.Include(u => u.ReceivedMessages).FirstOrDefault(u => u.SaturnCode == receiver.SaturnCode).ReceivedMessages.Add(newMessage);
            }
            SaveChanges();
            return new SendMessageResponse { Subject = messageModel.Subject, Content = messageModel.Content, Sender = messageModel.Sender.SaturnCode, Receivers = receivers };
        }

        public DeleteMessageResponse? DeleteMessage(DeleteMessageModelRequest deleteMessageModel)
        {
            User? user = UserWithSaturnCode(deleteMessageModel.SaturnCode);
            if (user == null) return null;
            MessageModel? message = MessageModel.Include(m => m.Sender).Include(m => m.Receivers).FirstOrDefault(m => m.Id == deleteMessageModel.MessageId);
            if (message == null) return null;
            // ideiglenesen kiszedve, hogy bármilyen üzenetet lehessen törölni
            //if (message.Sender.SaturnCode != deleteMessageModel.SaturnCode) return null;
            MessageModel.Remove(message);
            SaveChanges();
            return new DeleteMessageResponse { MessageId = deleteMessageModel.MessageId };
        }

        public AddExamToUserResponse? AddExamToUser(ExamUserModel examuser)
        {
            if (Exams.FirstOrDefault(e => e.Id == examuser.ExamId) == null)
            {
                return new AddExamToUserResponse
                {
                    StudentSaturnCode = examuser.SaturnCode,
                    Message = "Nem található ilyen exam",
                    ExamsId = examuser.ExamId,
                    Success = false
                };
            }
            if (Users.First(e => e.SaturnCode == examuser.SaturnCode) == null)
            {
                return new AddExamToUserResponse
                {
                    StudentSaturnCode = examuser.SaturnCode,
                    Message = "Nem található ilyen user",
                    ExamsId = examuser.ExamId,
                    Success = false
                };
            }
            if (Exams.First(e => e.Id == examuser.ExamId) != null && Users.First(u => u.SaturnCode == examuser.SaturnCode) != null)
            {
                Users.First(u => u.SaturnCode == examuser.SaturnCode).Exams.Add(Exams.First(e => e.Id == examuser.ExamId));
                Exams.First(e => e.Id == examuser.ExamId).Students.Add(Users.First(u => u.SaturnCode == examuser.SaturnCode));
                return new AddExamToUserResponse
                {
                    StudentSaturnCode = examuser.SaturnCode,
                    Message = "siker",
                    ExamsId = examuser.ExamId,
                    Success = true
                };
            }
            return new AddExamToUserResponse
            {
                StudentSaturnCode = examuser.SaturnCode,
                Message = "váratlan hiba",
                ExamsId = examuser.ExamId,
                Success = false
            };
        }
        public ListExamsResponse? ListExams()
        {
            if (Exams.Count()==0)
            {
                return new ListExamsResponse
                {
                    Message = "Nem létezik még vizsga",
                    Success = false
                };
            }
            List<ExamModel> examModels = new List<ExamModel>();
            foreach (Exam exam in Exams)
            {
                examModels.Add(this.Exams.Include(e => e.Grades).Include(e => e.Id).Include(e => e.Course).Include(e => e.Course) as ExamModel);
            }
            return new ListExamsResponse
            {
                Exams = examModels,
                Message = "Sikeres kilistázás",
                Success = true
            };
        }

        public StandardExamResponse? AddNewExams(ExamModel examModel)
        {
            if (examModel==null)
            {
                return new StandardExamResponse
                {
                    Message = "nincs átadva az exam",
                    Success = false
                };
            }
            if (Courses.FirstOrDefault(e => e.Code == examModel.CourseCode)==null)
            {
                return new StandardExamResponse
                {
                    Message = "nincs megadott kurzuskóddal rendelkező kurzus",
                    Success = false
                };
            }
            if (Semesters.FirstOrDefault(s => s.Id == examModel.Id) == null)
            {
                return new StandardExamResponse
                {
                    Message = "nincs megadott semesteridvel rendelkező semester",
                    Success = false
                };
            }
            Exam newexam = new Exam 
            {
                Course=Courses.FirstOrDefault(e=>e.Code ==examModel.CourseCode),
                Grades= new List<Grade>(),
                Semester=Semesters.FirstOrDefault(s=>s.Id==examModel.Id),
                Students=new List<User>(),
                MaxSize= examModel.MaxSize,
                Id= examModel.Id,
                Prof = examModel.Prof
            };
            this.Exams.Add(newexam);
            SaveChanges();
            return new StandardExamResponse
            {
                Message = "Sikeres hozzáadás",
                Success = true
            };
        }
        public StandardExamResponse? DeleteExam(int examId)
        {
            if (examId == null)
            {
                return new StandardExamResponse
                {
                    Message = "nincs átadva az exam",
                    Success = false
                };
            }
            if (Exams.FirstOrDefault(e=>e.Id==examId)==null)
            {
                return new StandardExamResponse
                {
                    Message = "nem létezik ilyen exam",
                    Success = false
                };
            }
            
            foreach (User user in Users)
            {
                if (user.Exams.Contains(Exams.FirstOrDefault(e => e.Id == examId)))
                {
                    user.Exams.Remove(Exams.FirstOrDefault(e => e.Id == examId));
                }
            }

            this.Exams.Remove(Exams.FirstOrDefault(e => e.Id == examId));
            SaveChanges();
            return new StandardExamResponse
            {
                Message = "Sikeresen törölte az examot",
                Success = true
            };
        }

        public StandardExamResponse? EditExam(ExamModel examModel)
        {
            if (examModel == null)
            {
                return new StandardExamResponse
                {
                    Message = "nincs átadva a módosított exam",
                    Success = false
                };
            }
            if (Exams.FirstOrDefault(e => e.Id == examModel.Id) == null)
            {
                return new StandardExamResponse
                {
                    Message = "nem létezik ilyen módosítandó exam",
                    Success = false
                };
            }
            Exam modifiableExam = Exams.FirstOrDefault(e => e.Id == examModel.Id);
            Exam newExam = new Exam
            {
                Course = modifiableExam.Course,
                Id = examModel.Id,
                Grades = modifiableExam.Grades,
                MaxSize = examModel.MaxSize,
                Prof = examModel.Prof,
                Semester = modifiableExam.Semester,
                Students = modifiableExam.Students
            };
            foreach (User user in Users)
            {
                if (user.Exams.Contains(Exams.FirstOrDefault(e => e.Id == examModel.Id)))
                {
                    user.Exams.Remove(Exams.FirstOrDefault(e => e.Id == examModel.Id));
                    user.Exams.Add(newExam);
                }
            }

            this.Exams.Remove(Exams.FirstOrDefault(e => e.Id == modifiableExam.Id));
            this.Exams.Add(newExam);
            SaveChanges();
            return new StandardExamResponse
            {
                Message = "Sikeresen megváltoztatta az examot",
                Success = true
            };
        }


        public ListExamsResponse? SearchExamByProf(string profname)
        {
            if (Exams.Count() == 0)
            {
                return new ListExamsResponse
                {
                    Message = "Nem létezik még vizsga",
                    Success = false
                };
            }
            List<Exam> specexams= new List<Exam>();
            List<ExamModel> specexamsModel= new List<ExamModel>();
            foreach (Exam exam in Exams)
            {
                if (exam.Prof==profname)
                {
                    specexams.Add(exam);
                }
            }
            if (specexams.Count()==0)
            {
                return new ListExamsResponse
                {
                    Message = "nincs a keresésnek megfelelő vizsga",
                    Success = false
                };
            }
            foreach (Exam sexam in specexams)
            {
                specexamsModel.Add(new ExamModel
                {
                    CourseCode = sexam.Course.Code,
                    Id = sexam.Id,
                    MaxSize = sexam.MaxSize,
                    Prof = sexam.Prof,
                    SemesterId = sexam.Semester.Id
                });
            }

            return new ListExamsResponse
            {
                Exams = specexamsModel,
                Message = "Sikeres kilistázás",
                Success = true
            };
        }

        public ListExamsResponse? SearchExamById(int id)
        {
            if (Exams.Count() == 0)
            {
                return new ListExamsResponse
                {
                    Message = "Nem létezik még vizsga",
                    Success = false
                };
            }
            List<Exam> specexams = new List<Exam>();
            List<ExamModel> specexamsModel = new List<ExamModel>();
            foreach (Exam exam in Exams)
            {
                if (exam.Id == id)
                {
                    specexams.Add(exam);
                }
            }
            if (specexams.Count() == 0)
            {
                return new ListExamsResponse
                {
                    Message = "nincs a keresésnek megfelelő vizsga",
                    Success = false
                };
            }
            foreach (Exam sexam in specexams)
            {
                specexamsModel.Add(new ExamModel
                {
                    CourseCode = sexam.Course.Code,
                    Id = sexam.Id,
                    MaxSize = sexam.MaxSize,
                    Prof = sexam.Prof,
                    SemesterId = sexam.Semester.Id
                });
            }

            return new ListExamsResponse
            {
                Exams = specexamsModel,
                Message = "Sikeres kilistázás",
                Success = true
            };
        }
        public ListExamsResponse? SearchExamBySizeMin(int size)
        {
            if (Exams.Count() == 0)
            {
                return new ListExamsResponse
                {
                    Message = "Nem létezik még vizsga",
                    Success = false
                };
            }
            List<Exam> specexams = new List<Exam>();
            List<ExamModel> specexamsModel = new List<ExamModel>();
            foreach (Exam exam in Exams)
            {
                if (exam.MaxSize >= size)
                {
                    specexams.Add(exam);
                }
            }
            if (specexams.Count() == 0)
            {
                return new ListExamsResponse
                {
                    Message = "nincs a keresésnek megfelelő vizsga",
                    Success = false
                };
            }
            foreach (Exam sexam in specexams)
            {
                specexamsModel.Add(new ExamModel
                {
                    CourseCode = sexam.Course.Code,
                    Id = sexam.Id,
                    MaxSize = sexam.MaxSize,
                    Prof = sexam.Prof,
                    SemesterId = sexam.Semester.Id
                });
            }

            return new ListExamsResponse
            {
                Exams = specexamsModel,
                Message = "Sikeres kilistázás",
                Success = true
            };
        }



        public ListExamsResponse? SearchExamBySizeMax(int size)
        {
            if (Exams.Count() == 0)
            {
                return new ListExamsResponse
                {
                    Message = "Nem létezik még vizsga",
                    Success = false
                };
            }
            List<Exam> specexams = new List<Exam>();
            List<ExamModel> specexamsModel = new List<ExamModel>();
            foreach (Exam exam in Exams)
            {
                if (exam.MaxSize <= size)
                {
                    specexams.Add(exam);
                }
            }
            if (specexams.Count() == 0)
            {
                return new ListExamsResponse
                {
                    Message = "nincs a keresésnek megfelelő vizsga",
                    Success = false
                };
            }
            foreach (Exam sexam in specexams)
            {
                specexamsModel.Add(new ExamModel
                {
                    CourseCode = sexam.Course.Code,
                    Id = sexam.Id,
                    MaxSize = sexam.MaxSize,
                    Prof = sexam.Prof,
                    SemesterId = sexam.Semester.Id
                });
            }

            return new ListExamsResponse
            {
                Exams = specexamsModel,
                Message = "Sikeres kilistázás",
                Success = true
            };
        }


        public ListExamsResponse? SearchExamByCourse(string courdeCode)
        {
            if (Exams.Count() == 0)
            {
                return new ListExamsResponse
                {
                    Message = "Nem létezik még vizsga",
                    Success = false
                };
            }
            List<Exam> specexams = new List<Exam>();
            List<ExamModel> specexamsModel = new List<ExamModel>();
            foreach (Exam exam in Exams)
            {
                if (exam.Course.Code == courdeCode)
                {
                    specexams.Add(exam);
                }
            }
            if (specexams.Count() == 0)
            {
                return new ListExamsResponse
                {
                    Message = "nincs a keresésnek megfelelő vizsga",
                    Success = false
                };
            }
            foreach (Exam sexam in specexams)
            {
                specexamsModel.Add(new ExamModel
                {
                    CourseCode = sexam.Course.Code,
                    Id = sexam.Id,
                    MaxSize = sexam.MaxSize,
                    Prof = sexam.Prof,
                    SemesterId = sexam.Semester.Id
                });
            }

            return new ListExamsResponse
            {
                Exams = specexamsModel,
                Message = "Sikeres kilistázás",
                Success = true
            };
        }




        public ListExamsResponse? SearchExamBySemester(int semesterId)
        {
            if (Exams.Count() == 0)
            {
                return new ListExamsResponse
                {
                    Message = "Nem létezik még vizsga",
                    Success = false
                };
            }
            List<Exam> specexams = new List<Exam>();
            List<ExamModel> specexamsModel = new List<ExamModel>();
            foreach (Exam exam in Exams)
            {
                if (exam.Semester.Id==semesterId)
                {
                    specexams.Add(exam);
                }
            }
            if (specexams.Count() == 0)
            {
                return new ListExamsResponse
                {
                    Message = "nincs a keresésnek megfelelő vizsga",
                    Success = false
                };
            }
            foreach (Exam sexam in specexams)
            {
                specexamsModel.Add(new ExamModel
                {
                    CourseCode = sexam.Course.Code,
                    Id = sexam.Id,
                    MaxSize = sexam.MaxSize,
                    Prof = sexam.Prof,
                    SemesterId = sexam.Semester.Id
                });
            }

            return new ListExamsResponse
            {
                Exams = specexamsModel,
                Message = "Sikeres kilistázás",
                Success = true
            };
        }


        public ExamUserCountResponse? ExamUserCount(int examId)
        {
            int usercount = 0;
            if (Exams.Count() == 0)
            {
                return new ExamUserCountResponse
                {
                    Message = "Nem létezik még vizsga",
                    Success = false,
                    usercount=0
                };
            }
            foreach (User user in Users)
            {
                foreach (Exam exam in user.Exams)
                {
                    if (exam.Id==examId)
                    {
                        usercount++;
                    }
                }
            }
            return new ExamUserCountResponse
            {
                usercount = usercount,
                Message = "Sikeres megszámolás",
                Success = true
            };
        }
    }
}
