
using Microsoft.EntityFrameworkCore;
using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.DbContexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }

    public DbSet<School> School { get; set; }
    public DbSet<Grade> Grades { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<TeacherGroup> teacherGroups { get; set; }
    public DbSet<Science> Sciences { get; set; }
    public DbSet<ScienceTeacher> scienceTeachers { get; set; }
    public DbSet<Parent> Parents { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Lesson> Lessons { get; set; }
    public DbSet<Homework> Homework { get; set; }
    public DbSet<StudentGroup> StudentGroups { get; set; }
    public DbSet<GroupRole> GroupRoles { get; set; }
    public DbSet<GroupPermission> GroupPermissions { get; set; }

}
