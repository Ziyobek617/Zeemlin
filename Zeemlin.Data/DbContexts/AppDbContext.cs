using Microsoft.EntityFrameworkCore;
using Zeemlin.Domain.Entities;
using Zeemlin.Domain.Entities.Assets;
using Zeemlin.Domain.Entities.Users;

namespace Zeemlin.Data.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        // Schools
        public DbSet<School> School { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Science> Sciences { get; set; }

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
            // School
            modelBuilder.Entity<School>()
                .HasIndex(e => e.SchoolNumber) // Optional: Add a unique index for SchoolNumber
                .IsUnique();

            modelBuilder.Entity<School>()
                .HasOne(e => e.Director)
                .WithMany(d => d.Schools) // Assuming a Director can have multiple Schools
                .HasForeignKey(e => e.DirectorId);

            // Teacher
            modelBuilder.Entity<Teacher>()
                .HasIndex(e => e.PhoneNumber) // Optional: Add a unique index for PhoneNumber
                .IsUnique();

            // **Remove unnecessary property:**
            // Teacher.GroupId (not needed for many-to-many relationship)

            // Group
            


            //modelBuilder.Entity<Group>()
            //    .HasOne(e => e.) // Navigation property for reference (optional)
            //    .WithMany(s => s.Groups) // Navigation property for reference (optional)
            //    .HasForeignKey(e => e.SchoolId);

            // Configure the many-to-many relationship using the join table
            modelBuilder.Entity<TeacherGroup>()
                .HasKey(tg => new { tg.TeacherId, tg.GroupId }); // Composite primary key

            modelBuilder.Entity<TeacherGroup>()
                .HasOne(tg => tg.Teacher)
                .WithMany(t => t.TeacherGroups)
                .HasForeignKey(tg => tg.TeacherId);

            modelBuilder.Entity<TeacherGroup>()
                .HasOne(tg => tg.Group)
                .WithMany(g => g.TeacherGroups)
                .HasForeignKey(tg => tg.GroupId);


            // Additional mappings can be added here for other entities and relationships
        }
    }
}
