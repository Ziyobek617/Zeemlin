using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.DbContexts.EntityConfigurations;

public class TeacherEntityConfiguration : IEntityTypeConfiguration<Teacher>
{
    public void Configure(EntityTypeBuilder<Teacher> builder)
    {
        builder.ToTable("Teachers");
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
            .Property(p => p.Password)
            .IsRequired(true);

        builder
            .Property(p => p.Biography)
            .HasMaxLength(4000);  // Assuming a max length of 4000 characters

        builder
            .Property(p => p.DistrictName)
            .IsRequired(true)
            .HasMaxLength(50);

        builder
            .Property(p => p.SchoolNumber)
            .IsRequired(true);

        builder
            .Property(p => p.GroupId)
            .IsRequired(false);
    }
}
