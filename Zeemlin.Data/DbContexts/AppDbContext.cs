
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
    public DbSet<Science> Sciences { get; set; }
    public DbSet<Parent> Parents { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Student> Users { get; set; }
    public DbSet<Lesson> Lessons { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Homework> Homework { get; set; }
    public DbSet<StudentGroup> UserGroups { get; set; }
    public DbSet<GroupRole> GroupRoles { get; set; }
    public DbSet<GroupPermission> GroupPermissions { get; set; }

    
}
