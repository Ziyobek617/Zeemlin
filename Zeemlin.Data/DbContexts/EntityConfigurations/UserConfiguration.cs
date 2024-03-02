using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zeemlin.Domain.Entities;
using Zeemlin.Domain.Entities.Users;

namespace Zeemlin.Data.DbContexts.EntityConfigurations
{
    public class UserConfiguration
    {
        public class SuperAdminConfiguration : IEntityTypeConfiguration<SuperAdmin>
        {
            public void Configure(EntityTypeBuilder<SuperAdmin> builder)
            {
                builder.ToTable("SuperAdmins");
                builder.HasKey(e => e.Id);

                builder.Property(e => e.Username).IsRequired();
                builder.Property(e => e.FirstName).IsRequired();
                builder.Property(e => e.LastName).IsRequired();
                builder.Property(e => e.Email).IsRequired();
                builder.Property(e => e.Password).IsRequired();
                builder.Property(e => e.Gender).IsRequired();
                builder.Property(e => e.PassportSeria);

            }
        }

        public class DirectorConfiguration : IEntityTypeConfiguration<Director>
        {
            public void Configure(EntityTypeBuilder<Director> builder)
            {
                builder.ToTable("Directors");
                builder.HasKey(e => e.Id);

                builder.Property(e => e.Username).IsRequired();
                builder.Property(e => e.FirstName).IsRequired();
                builder.Property(e => e.LastName).IsRequired();
                builder.Property(e => e.Email).IsRequired();
                builder.Property(e => e.Password).IsRequired();
                builder.Property(e => e.Gender).IsRequired();
                builder.Property(e => e.PassportSeria);

                builder.HasMany(e => e.Schools)
                    .WithOne(s => s.Director)
                    .HasForeignKey(s => s.DirectorId);
            }
        }

        public class AdminConfiguration : IEntityTypeConfiguration<Admin>
        {
            public void Configure(EntityTypeBuilder<Admin> builder)
            {
                builder.ToTable("Admins");
                builder.HasKey(e => e.Id);

                builder.Property(e => e.Username).IsRequired();
                builder.Property(e => e.FirstName);
                builder.Property(e => e.LastName);
                builder.Property(e => e.Email);
                builder.Property(e => e.Password).IsRequired();
                builder.Property(e => e.Gender).IsRequired();
                builder.Property(e => e.PassportSeria);

            }
        }

        public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
        {
            public void Configure(EntityTypeBuilder<Teacher> builder)
            {
                builder.ToTable("Teachers");
                builder.HasKey(e => e.Id);

                builder.Property(e => e.FirstName).IsRequired();
                builder.Property(e => e.LastName).IsRequired();
                builder.Property(e => e.DateOfBirth).IsRequired();
                builder.Property(e => e.PhoneNumber);
                builder.Property(e => e.Email);
                builder.Property(e => e.Password);
                builder.Property(e => e.Biography);
                builder.Property(e => e.DistrictName).IsRequired().HasMaxLength(50);
                builder.Property(e => e.SchoolNumber).IsRequired();
                builder.Property(e => e.ScienceType);

                builder.HasMany(e => e.TeacherGroups)
                    .WithOne(tg => tg.Teacher)
                    .HasForeignKey(tg => tg.TeacherId);
            }
        }

        public class StudentConfiguration : IEntityTypeConfiguration<Student>
        {
            public void Configure(EntityTypeBuilder<Student> builder)
            {
                builder.ToTable("Students");
                builder.HasKey(e => e.Id);

                builder.Property(e => e.FirstName).IsRequired();
                builder.Property(e => e.LastName).IsRequired();
                builder.Property(e => e.DateOfBirth).IsRequired();
                builder.Property(e => e.PhoneNumber);
                builder.Property(e => e.Email);
                builder.Property(e => e.Password);
                builder.Property(e => e.SchoolNumber).IsRequired();
                builder.Property(e => e.GroupId).IsRequired();
                builder.Property(e => e.FatherName).IsRequired();
                builder.Property(e => e.DistrictName).IsRequired().HasMaxLength(50);
                builder.Property(e => e.GeneralAddressMFY).IsRequired().HasMaxLength(50);
                builder.Property(e => e.StreetName).IsRequired().HasMaxLength(50);
                builder.Property(e => e.BuildingNumber);
                builder.Property(e => e.EntranceNumber);
                builder.Property(e => e.Floor);
                builder.Property(e => e.HouseNumber).IsRequired();
                builder.Property(e => e.StudentUniqueId);

                builder.HasMany(e => e.Grades)
                    .WithOne(g => g.Student)
                    .HasForeignKey(g => g.UserId);
                builder.HasMany(e => e.StudentGroups)
                    .WithOne(sg => sg.Student)
                    .HasForeignKey(sg => sg.StudentId);
                builder.HasMany(e => e.LessonAttendances)
                    .WithOne(la => la.Student)
                    .HasForeignKey(la => la.StudentId);
            }
        }
    }
}
