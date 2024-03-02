using Microsoft.EntityFrameworkCore;
using Zeemlin.Domain.Entities;
using Zeemlin.Domain.Entities.Assets;
using Zeemlin.Domain.Entities.Users;
using static Zeemlin.Data.DbContexts.EntityConfigurations.AssetsConfiguration;

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

        // Many-to-Many Relationships (without navigation properties)
        public DbSet<TeacherGroup> TeacherGroups { get; set; } // Explicitly define the join table

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SchoolAssetConfiguration());
            modelBuilder.ApplyConfiguration(new HomeworkAssetConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherAssetConfiguration());

            // Other entity configurations...
        }

    }
}
