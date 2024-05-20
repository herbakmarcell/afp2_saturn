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
using ASP_Core.Models.Class;
using ASP_Core.Models.Course;
using ASP_Core.Models.Subject;
using ASP_Core.Services.Auth;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System.Reflection.Metadata.Ecma335;
using System.Linq;
using ASP_Core.Models.Responses.POST;
using ASP_Core.Models.Responses.PUT;
using ASP_Core.Models.Responses.GET;
using ASP_Core.Models.Responses.DELETE;

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

        public ChangeResponse? UserChange(ChangeModel changeModel)
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
                        changeResponse.NewRoles.Add("+" + newUserRole);
                    }
                }
                foreach (var oldUserRole in roles)
                {
                    if (!changeModel.NewRoles.Contains(oldUserRole))
                    {
                        Role oldRole = this.Roles.Include(r => r.User).FirstOrDefault(r => r.Name == oldUserRole && r.User.SaturnCode == changeModel.SaturnCode);
                        user.Roles.Remove(oldRole);
                        changeResponse.NewRoles.Add("-" + oldUserRole);
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
            if (string.IsNullOrEmpty(sender)) return MessageModel.Include(u => u.Sender).Include(u => u.Receivers).Where(mm => mm.Receivers.Contains(receiverUser)).ToList();
            else return MessageModel.Include(u => u.Sender).Include(u => u.Receivers).Where(mm => mm.Receivers.Contains(receiverUser) && mm.Sender == UserWithSaturnCode(sender)).ToList();

        }

        public List<MessageModel> GetSentMessages(string sender)
        {
            User? receiverUser = UserWithSaturnCode(sender);
            if (receiverUser == null) return null;
            return MessageModel.Include(u => u.Sender).Include(u => u.Receivers).Where(mm => mm.Sender.SaturnCode == sender).ToList();
        }

        public SendMessageResponse SendMessage(MessageModel messageModel)
        {
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
            MessageModel.Remove(message);
            SaveChanges();
            return new DeleteMessageResponse { MessageId = deleteMessageModel.MessageId };
        }

        public AddExamToUserResponse? AddExamToUser(AddExamUserModel examuser)
        {
            User? user = Users.Include(u => u.Exams).FirstOrDefault(u => u.SaturnCode == examuser.SaturnCode);
            if (user == null) return null;
            Exam? exam = Exams.Include(e => e.Students).FirstOrDefault(e => e.Id == examuser.ExamId);
            if (exam == null) return null;
            user.Exams.Add(exam);
            SaveChanges();
            return new AddExamToUserResponse { SaturnCode = user.SaturnCode, ExamId = exam.Id };
        }

        public List<ExamModelResponse> ListExams()
        {
            List<Exam> exams = Exams.Include(e => e.Course).Include(e => e.Semester).Include(e => e.Students).ToList();
            return exams.Select(exam => new ExamModelResponse
            {
                Id = exam.Id,
                MaxSize = exam.MaxSize,
                Prof = exam.Prof,
                Course = exam.Course.Code,
                Semester = exam.Semester.Id
            }).ToList();
        }

        public ExamModelResponse AddNewExam(AddExamRequest addExamRequest)
        {
            
            Course? course = Courses.FirstOrDefault(e => e.Code == addExamRequest.Course);
            if (course == null) return null;
            Semester? semester = Semesters.FirstOrDefault(e => e.Id == addExamRequest.Semester);
            if (semester == null) return null;
            Exam newExam = new Exam
            {
                MaxSize = addExamRequest.MaxSize,
                Prof = addExamRequest.Prof,
                Course = course,
                Semester = semester
            };
            Exams.Add(newExam);
            SaveChanges();
            ExamModelResponse examModel = new ExamModelResponse
            {
                MaxSize = newExam.MaxSize,
                Prof = newExam.Prof,
                Course = newExam.Course.Code,
                Semester = newExam.Semester.Id
            };
            return examModel;
        }

        public ExamModelResponse DeleteExam(int examId)
        {
            Exam? exam = Exams.Include(e => e.Course).Include(e => e.Semester).FirstOrDefault(e => e.Id == examId);
            if (exam == null) return null;
            ExamModelResponse response = new ExamModelResponse
            {
                Id = exam.Id,
                MaxSize = exam.MaxSize,
                Prof = exam.Prof,
                Course = exam.Course.Code,
                Semester = exam.Semester.Id
            };
            Exams.Remove(exam);
            SaveChanges();
            return response;
        }

        public ExamModelResponse EditExam(ExamRequest examModel)
        {
            ExamModelResponse response = new ExamModelResponse();
            Exam? exam = Exams.Include(e => e.Course).Include(e => e.Semester).FirstOrDefault(e => e.Id == examModel.Id);
            if (exam == null) return null;
            response.Id = examModel.Id;
            if (examModel.MaxSize != 0)
            {
                exam.MaxSize = examModel.MaxSize;
                response.MaxSize = examModel.MaxSize;
            }
            if (examModel.Prof != null)
            {
                exam.Prof = examModel.Prof;
                response.Prof = examModel.Prof;
            }
            if (examModel.Course != null)
            {
                Course? course = Courses.FirstOrDefault(e => e.Code == examModel.Course);
                if (course == null) return null;
                exam.Course = course;
                response.Course = examModel.Course;
            }
            if (examModel.Semester != 0)
            {
                Semester? semester = Semesters.FirstOrDefault(e => e.Id == examModel.Semester);
                if (semester == null) return null;
                exam.Semester = semester;
                response.Semester = examModel.Semester;
            }
            SaveChanges();
            return response;
        }

        public List<ExamModelResponse>? SearchExamsByProf(string prof)
        {
            List<Exam> exams = Exams.Include(e => e.Course).Include(e => e.Semester).Include(e => e.Students).Where(e => e.Prof == prof).ToList();
            return exams.Select(exam => new ExamModelResponse
            {
                Id = exam.Id,
                MaxSize = exam.MaxSize,
                Prof = exam.Prof,
                Course = exam.Course.Code,
                Semester = exam.Semester.Id
            }).ToList();
        }

        public ExamModelResponse? SearchExamById(int id)
        {
            Exam? exam = Exams.Include(e => e.Course).Include(e => e.Semester).Include(e => e.Students).FirstOrDefault(e => e.Id == id);
            if (exam == null) return null;
            ExamModelResponse response = new ExamModelResponse
            {
                Id = exam.Id,
                MaxSize = exam.MaxSize,
                Prof = exam.Prof,
                Course = exam.Course.Code,
                Semester = exam.Semester.Id
            };
            return response;
        }

        public List<ExamModelResponse>? SearchExamByCourse(string courseCode)
        {
            List<Exam> exams = Exams.Include(e => e.Course).Include(e => e.Semester).Include(e => e.Students).Where(e => e.Course.Code == courseCode).ToList();
            return exams.Select(exam => new ExamModelResponse
            {
                Id = exam.Id,
                MaxSize = exam.MaxSize,
                Prof = exam.Prof,
                Course = exam.Course.Code,
                Semester = exam.Semester.Id
            }).ToList();
        }

        public List<ExamModelResponse>? SearchExamBySemester(int semesterId)
        {
            List<Exam> exams = Exams.Include(e => e.Course).Include(e => e.Semester).Include(e => e.Students).Where(e => e.Semester.Id == semesterId).ToList();
            return exams.Select(exam => new ExamModelResponse
            {
                Id = exam.Id,
                MaxSize = exam.MaxSize,
                Prof = exam.Prof,
                Course = exam.Course.Code,
                Semester = exam.Semester.Id
            }).ToList();
        }

        public CourseResponse? AddNewCourse(CourseRequest courseModel)
        {
            Subject? subject = Subjects.Include(s => s.Courses)
                .FirstOrDefault(e => e.Code == courseModel.SubjectCode);
            if (subject == null) return null;
            Semester? semester = Semesters.Include(s => s.SemesterCourses)
                .FirstOrDefault(e => e.Id == courseModel.CurrentSemesterId);
            if (semester == null) return null;
            Course newCourse = new Course
            {
                Code = courseModel.Code,
                Type = courseModel.Type,
                Prof = courseModel.Prof,
                Credit = courseModel.Credit,
                MaxSize = courseModel.MaxSize,
                Classes = new List<ClassModel>(),
                Subject = subject,
                Students = new List<User>(),
                Grades = new List<Grade>(),
                CurrentSemester = semester,
                Exams = new List<Exam>()
            };
            Courses.Add(newCourse);
            SaveChanges();
            return new CourseResponse
            {
                Code = newCourse.Code,
                Type = newCourse.Type,
                Prof = newCourse.Prof,
                Credit = newCourse.Credit,
                MaxSize = newCourse.MaxSize,
                SubjectCode = newCourse.Subject.Code,
                CurrentSemesterId = newCourse.CurrentSemester.Id
            };
        }

        public CourseResponse? DeleteCourse(string courseCode)
        {
            Course? course = Courses.Include(c => c.Subject).Include(c => c.CurrentSemester).FirstOrDefault(e => e.Code == courseCode);
            if (course == null) return null;
            CourseResponse response = new CourseResponse
            {
                Code = course.Code,
                Type = course.Type,
                Prof = course.Prof,
                Credit = course.Credit,
                MaxSize = course.MaxSize,
                SubjectCode = course.Subject.Code,
                CurrentSemesterId = course.CurrentSemester.Id
            };
            Courses.Remove(course);
            SaveChanges();
            return response;
        }

        public List<CourseModel> ListCourses()
        {
            return Courses.Select(course => new CourseModel
            {
                Code = course.Code,
                Type = course.Type,
                Prof = course.Prof,
                Credit = course.Credit,
                MaxSize = course.MaxSize,
                SubjectCode = course.Subject.Code,
                SemesterId = course.CurrentSemester.Id
            }).ToList();
        }

        public CourseResponse? EditCourse(CourseRequest courseRequest)
        {
            Course? course = Courses.Include(c => c.Subject).Include(c => c.CurrentSemester).FirstOrDefault(e => e.Code == courseRequest.Code);
            if (course == null) return null;
            CourseResponse courseResponse = new CourseResponse();
            if (courseRequest.Type != null)
            {
                course.Type = courseRequest.Type;
                courseResponse.Type = courseRequest.Type;
            }
            if (courseRequest.Prof != null)
            {
                course.Prof = courseRequest.Prof;
                courseResponse.Prof = courseRequest.Prof;
            }
            if (courseRequest.Credit > 0)
            {
                course.Credit = courseRequest.Credit;
                courseResponse.Credit = courseRequest.Credit;
            }
            if (courseRequest.MaxSize != 0)
            {
                course.MaxSize = courseRequest.MaxSize;
                courseResponse.MaxSize = courseRequest.MaxSize;
            }
            if (courseRequest.SubjectCode != null)
            {
                Subject? subject = Subjects.FirstOrDefault(e => e.Code == courseRequest.SubjectCode);
                if (subject == null) return null;
                course.Subject = subject;
                courseResponse.SubjectCode = courseRequest.SubjectCode;
            }
            if (courseRequest.CurrentSemesterId != 0)
            {
                Semester? semester = Semesters.FirstOrDefault(e => e.Id == courseRequest.CurrentSemesterId);
                if (semester == null) return null;
                course.CurrentSemester = semester;
                courseResponse.CurrentSemesterId = courseRequest.CurrentSemesterId;
            }
            SaveChanges();
            return courseResponse;
        }

        public List<CourseModel> SearchCoursesByProf(string prof)
        {
            return Courses.Where(c => c.Prof == prof).Select(course => new CourseModel
            {
                Code = course.Code,
                Type = course.Type,
                Prof = course.Prof,
                Credit = course.Credit,
                MaxSize = course.MaxSize,
                SubjectCode = course.Subject.Code,
                SemesterId = course.CurrentSemester.Id
            }).ToList();
        }

        public List<CourseModel> SearchCoursesByCredit(int credit)
        {
            return Courses.Where(c => c.Credit == credit).Select(course => new CourseModel
            {
                Code = course.Code,
                Type = course.Type,
                Prof = course.Prof,
                Credit = course.Credit,
                MaxSize = course.MaxSize,
                SubjectCode = course.Subject.Code,
                SemesterId = course.CurrentSemester.Id
            }).ToList();
        }

        public List<CourseModel> SearchCoursesByName(string name)
        {
            return Courses.Where(c => c.Type == name).Select(course => new CourseModel
            {
                Code = course.Code,
                Type = course.Type,
                Prof = course.Prof,
                Credit = course.Credit,
                MaxSize = course.MaxSize,
                SubjectCode = course.Subject.Code,
                SemesterId = course.CurrentSemester.Id
            }).ToList();
        }

        public List<CourseModel> SearchCoursesBySemester(int semesterId)
        {
            return Courses.Where(c => c.CurrentSemester.Id == semesterId).Select(course => new CourseModel
            {
                Code = course.Code,
                Type = course.Type,
                Prof = course.Prof,
                Credit = course.Credit,
                MaxSize = course.MaxSize,
                SubjectCode = course.Subject.Code,
                SemesterId = course.CurrentSemester.Id
            }).ToList();
        }

        public List<CourseModel> SearchCoursesBySubject(string subjectCode)
        {
           return Courses.Where(c => c.Subject.Code == subjectCode).Select(course => new CourseModel
           {
               Code = course.Code,
               Type = course.Type,
               Prof = course.Prof,
               Credit = course.Credit,
               MaxSize = course.MaxSize,
               SubjectCode = course.Subject.Code,
               SemesterId = course.CurrentSemester.Id
           }).ToList();
        }

        public ClassResponse? AddClass(AddClassRequest addClassRequest)
        {
            Course? courseExists = Courses.FirstOrDefault(e => e.Code == addClassRequest.Course);
            if (courseExists == null) return null;
            Room? roomExists = Rooms.FirstOrDefault(e => e.Code == addClassRequest.Room);
            if (roomExists == null) return null;
            ClassModel newClass = new ClassModel
            {
                Course = courseExists,
                Room = roomExists,
                StartTime = addClassRequest.StartTime,
                EndTime = addClassRequest.EndTime
            };
            Classes.Add(newClass);
            SaveChanges();
            return new ClassResponse
            {
                Course = newClass.Course.Code,
                Room = newClass.Room.Code,
                StartTime = newClass.StartTime,
                EndTime = newClass.EndTime
            };
        }

        public ClassResponse? DeleteClass(int classId)
        {
            ClassModel? classModel = Classes.Include(c => c.Course).Include(c => c.Room).FirstOrDefault(e => e.Id == classId);
            if (classModel == null) return null;
            ClassResponse response = new ClassResponse
            {
                Id = classModel.Id,
                Course = classModel.Course.Code,
                Room = classModel.Room.Code,
                StartTime = classModel.StartTime,
                EndTime = classModel.EndTime
            };
            Classes.Remove(classModel);
            SaveChanges();
            return response;
        }

        public ClassResponse? EditClass(EditClassRequest editClassModel)
        {
            ClassResponse response = new ClassResponse();
            ClassModel? classModel = Classes.Include(c => c.Course).Include(c => c.Room).FirstOrDefault(e => e.Id == editClassModel.Id);
            if (classModel == null) return null;
            response.Id = editClassModel.Id;
            if (string.IsNullOrEmpty(editClassModel.Course))
            {
                Course? courseExists = Courses.FirstOrDefault(e => e.Code == editClassModel.Course);
                if (courseExists == null) return null;
                classModel.Course = courseExists;
                response.Course = editClassModel.Course;
            }
            if (string.IsNullOrEmpty(editClassModel.Room))
            {
                Room? roomExists = Rooms.FirstOrDefault(e => e.Code == editClassModel.Room);
                if (roomExists == null) return null;
                classModel.Room = roomExists;
                response.Room = editClassModel.Room;
            }
            if (editClassModel.StartTime != null)
            {
                classModel.StartTime = (DateTime)editClassModel.StartTime;
                response.StartTime = (DateTime)editClassModel.StartTime;
            }
            if (editClassModel.EndTime != null)
            {
                classModel.EndTime = (DateTime)editClassModel.EndTime;
                response.EndTime = (DateTime)editClassModel.EndTime;
            }
            SaveChanges();
            return response;
        }

        public ClassModel? SearchClassById(int? id)
        {
            return Classes.Include(c => c.Course).Include(c => c.Room).FirstOrDefault(e => e.Id == id);
        }

        public List<ClassModel> SearchClassByTime(bool byStart, bool byMin, DateTime time)
        {
            if (Classes.Count() == 0)
            {
                return null;
            }
            List<ClassModel> classesBySearch = new List<ClassModel>();
            if (byStart)
            {
                if (byMin)
                {
                    classesBySearch = Classes.Include(c => c.Course).Include(c => c.Room).Where(c => c.StartTime >= time).ToList();
                }
                else
                {
                    classesBySearch = Classes.Include(c => c.Course).Include(c => c.Room).Where(c => c.StartTime < time).ToList();
                }
            }
            else
            {
                if (byMin)
                {
                    classesBySearch = Classes.Include(c => c.Course).Include(c => c.Room).Where(c => c.EndTime >= time).ToList();
                }
                else
                {
                    classesBySearch = Classes.Include(c => c.Course).Include(c => c.Room).Where(c => c.EndTime < time).ToList();
                }
            }
            return classesBySearch;
        }

        public List<SubjectModel> ListSubjects()
        {
            return Subjects.Select(subject => new SubjectModel
            {
                Code = subject.Code,
                Name = subject.Name
            }).ToList();
        }

        public SubjectResponse? AddNewSubject(SubjectModel subject)
        {
            if (subject == null) return null;
            Subject newSubject = new Subject
            {
                Code = subject.Code,
                Name = subject.Name,
                Courses = new List<Course>()
            };
            Subjects.Add(newSubject);
            SaveChanges();
            return new SubjectResponse
            {
                Code = newSubject.Code,
                Name = newSubject.Name
            };
        }

        public DeleteSubjectResponse? DeleteSubject(string subjectCode)
        {
            Subject subject = Subjects.FirstOrDefault(e => e.Code == subjectCode);
            if (subject == null) return null;
            DeleteSubjectResponse response = new DeleteSubjectResponse
            {
                Code = subject.Code
            };
            Subjects.Remove(subject);
            SaveChanges();
            return response;
        }

        public SubjectResponse EditSubject(SubjectModel subjectModel)
        {
            Subject? subject = Subjects.FirstOrDefault(e => e.Code == subjectModel.Code);
            if (subject == null) return null;
            if (subjectModel.Name != null)
            {
                subject.Name = subjectModel.Name;
            }
            SaveChanges();
            return new SubjectResponse
            {
                Code = subject.Code,
                Name = subject.Name
            };
        }
    }
}
