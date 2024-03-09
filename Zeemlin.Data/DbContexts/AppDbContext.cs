using Microsoft.EntityFrameworkCore;
using Zeemlin.Data.DbContexts.Seeds.Schools;
using Zeemlin.Data.DbContexts.Seeds.Users;
using Zeemlin.Domain.Entities;
using Zeemlin.Domain.Entities.Assets;
using Zeemlin.Domain.Entities.Questions;
using Zeemlin.Domain.Entities.Users;
using static Zeemlin.Data.DbContexts.EntityConfigurations.AssetsConfiguration;
using static Zeemlin.Data.DbContexts.EntityConfigurations.SchoolConfiguration;
using static Zeemlin.Data.DbContexts.EntityConfigurations.UserConfiguration;

namespace Zeemlin.Data.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        // Schools
        public DbSet<School> School { get; set; }
        public DbSet<Course> Courses { get; set; }

        // Users
        public DbSet<SuperAdmin> SuperAdmins { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Student> Students { get; set; }

        // Assets
        public DbSet<SchoolAsset> SchoolAssets { get; set; }
        public DbSet<TeacherAsset> TeacherAssets { get; set; }
        public DbSet<HomeworkAsset> HomeworkAssets { get; set; }

        // Lessons
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<LessonAttendance> LessonAttendances { get; set; }
        public DbSet<LessonTable> LessonsTable { get; set; }

        // Groups
        public DbSet<Group> Groups { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Homework> Homework { get; set; }
        public DbSet<Grade> Grades { get; set; }

        // Questions
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Question> Questiones { get; set; } 
        public DbSet<Answer> Answers { get; set; }

        // Many-to-Many Relationships (without navigation properties)
        public DbSet<TeacherGroup> TeacherGroups { get; set; } // Explicitly define the join table

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Assets
            modelBuilder.ApplyConfiguration(new SchoolAssetConfiguration());
            modelBuilder.ApplyConfiguration(new HomeworkAssetConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherAssetConfiguration());

            // Users
            modelBuilder.ApplyConfiguration(new SuperAdminConfiguration());
            modelBuilder.ApplyConfiguration(new DirectorConfiguration());
            modelBuilder.ApplyConfiguration(new AdminConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());

            modelBuilder.Entity<SuperAdmin>().HasData(SuperAdminSeedData.GetSuperAdmins());
            modelBuilder.Entity<Admin>().HasData(AdminSeedData.GetAdmins());
            modelBuilder.Entity<Director>().HasData(DirectorSeedData.GetDirectors());
            modelBuilder.Entity<Teacher>().HasData(TeacherSeedData.GetTeachers());

            // School
            modelBuilder.ApplyConfiguration(new SchoolConfigurations());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new GroupConfiguration());
            modelBuilder.ApplyConfiguration(new StudentGroupConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherGroupConfiguration());
            modelBuilder.ApplyConfiguration(new LessonConfiguration());
            modelBuilder.ApplyConfiguration(new HomeworkConfiguration());
            modelBuilder.ApplyConfiguration(new SubjectConfiguration());
            modelBuilder.ApplyConfiguration(new LessonAttendanceConfiguration());
            modelBuilder.ApplyConfiguration(new GradeConfiguration());

            modelBuilder.Entity<School>().HasData(SchoolSeedData.GetSchools());
            modelBuilder.Entity<Course>().HasData(CourseSeedData.GetCourses());
            modelBuilder.Entity<Group>().HasData(GroupSeedData.GetGroups());
            //modelBuilder.Entity<Lesson>().HasData(LessonSeedData.GetLessons());
            //modelBuilder.Entity<Homework>().HasData(HomeworkSeedData.GetHomeworks());
            //modelBuilder.Entity<TeacherGroup>().HasData(TeacherGroupSeedData.GetTeacherGroups());
            // Other entity configurations...
        }

    }
}
