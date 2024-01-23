using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.DbContexts.EntityConfigurations;

public class StudentEntityConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.ToTable("Students");
        builder.HasKey(p => p.Id);

        builder
            .Property(p => p.FirstName)
            .IsRequired(true)
            .HasMaxLength(50);

        builder
            .Property(p => p.LastName)
            .IsRequired(true)
            .HasMaxLength(50);

        builder
            .Property(p => p.DateOfBirth)
            .IsRequired(true);

        builder
            .Property(p => p.PhoneNumber)
            .HasMaxLength(20)
            .IsRequired(false);

        builder
            .Property(p => p.Email)
            .IsRequired(true)
            .HasMaxLength(100);

        builder
            .HasIndex(p => p.Email)
            .IsUnique(true);

        builder
            .Property(p => p.Password)
            .IsRequired(true);

        builder
            .Property(p => p.SchoolNumber)
            .IsRequired(true);

        builder
            .Property(p => p.GroupId)
            .IsRequired(true);

        builder
            .Property(p => p.FatherName)
            .IsRequired(true)
            .HasMaxLength(50);

        builder
            .Property(p => p.DistrictName)
            .IsRequired(true)
            .HasMaxLength(50);

        builder
            .Property(p => p.GeneralAddressMFY)
            .IsRequired(true)
            .HasMaxLength(50);

        builder
            .Property(p => p.StreetName)
            .IsRequired(true)
            .HasMaxLength(50);

        builder
            .Property(p => p.BuildingNumber)
            .IsRequired(false);

        builder
            .Property(p => p.EntranceNumber)
            .IsRequired(false);

        builder
            .Property(p => p.Floor)
            .IsRequired(false);

        builder
            .Property(p => p.HouseNumber)
            .IsRequired(true);

        builder
            .Property(p => p.StudentUniqueId)
            .IsRequired(true)
            .HasMaxLength(7);


        builder
            .HasIndex(p => p.StudentUniqueId)
            .IsUnique(true);
        
    }
}
