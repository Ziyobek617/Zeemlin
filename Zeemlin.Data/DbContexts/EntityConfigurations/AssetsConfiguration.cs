using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zeemlin.Domain.Entities.Assets;

namespace Zeemlin.Data.DbContexts.EntityConfigurations
{
    public class AssetsConfiguration
    {
        public class SchoolLogoAssetConfiguration : IEntityTypeConfiguration<SchoolLogoAsset>
        {
            public void Configure(EntityTypeBuilder<SchoolLogoAsset> builder)
            {
                builder.ToTable("SchoolLogoAssets");
                builder.HasKey(e => e.Id);

                builder.Property(e => e.Path).IsRequired();
                builder.Property(e => e.UploadedDate).IsRequired();

                builder.HasOne(e => e.School)
                    .WithMany()
                    .HasForeignKey(e => e.SchoolId);
            }
        }
        public class SchoolAssetConfiguration : IEntityTypeConfiguration<SchoolAsset>
        {
            public void Configure(EntityTypeBuilder<SchoolAsset> builder)
            {
                builder.ToTable("SchoolAssets");
                builder.HasKey(e => e.Id);

                builder.Property(e => e.Path).IsRequired();
                builder.Property(e => e.UploadedDate).IsRequired();

                builder.HasOne(e => e.School)
                    .WithMany()
                    .HasForeignKey(e => e.SchoolId);
            }
        }

        public class HomeworkAssetConfiguration : IEntityTypeConfiguration<HomeworkAsset>
        {
            public void Configure(EntityTypeBuilder<HomeworkAsset> builder)
            {
                builder.ToTable("HomeworkAssets");
                builder.HasKey(e => e.Id);

                builder.Property(e => e.Path).IsRequired();
                builder.Property(e => e.UploadedDate).IsRequired();

                builder.HasOne(e => e.Homework)
                    .WithMany()
                    .HasForeignKey(e => e.HomeworkId);
            }
        }

        public class TeacherAssetConfiguration : IEntityTypeConfiguration<TeacherAsset>
        {
            public void Configure(EntityTypeBuilder<TeacherAsset> builder)
            {
                builder.ToTable("TeacherAssets");
                builder.HasKey(e => e.Id);

                builder.Property(e => e.Path).IsRequired();
                builder.Property(e => e.UploadedDate).IsRequired();

                builder.HasOne(e => e.Teacher)
                    .WithMany()
                    .HasForeignKey(e => e.TeacherId);
            }
        }

        public class EventAssetConfiguration : IEntityTypeConfiguration<EventAsset>
        {
            public void Configure(EntityTypeBuilder<EventAsset> builder)
            {
                builder.ToTable("EventAssets");
                builder.HasKey(e => e.Id);

                builder.Property(e => e.Path).IsRequired();
                builder.Property(e => e.UploadedDate).IsRequired();

                builder.HasOne(e => e.Event)
                    .WithMany()
                    .HasForeignKey(e => e.EventId);
            }
        }


        public class QuestionAssetConfiguration : IEntityTypeConfiguration<QuestionAsset>
        {
            public void Configure(EntityTypeBuilder<QuestionAsset> builder)
            {
                builder.ToTable("QuestionAssets");
                builder.HasKey(e => e.Id);

                builder.Property(e => e.Path).IsRequired();
                builder.Property(e => e.UploadedDate).IsRequired();

                builder.HasOne(e => e.Question)
                    .WithMany()
                    .HasForeignKey(e => e.QuestionId);
            }
        }
    }
}
