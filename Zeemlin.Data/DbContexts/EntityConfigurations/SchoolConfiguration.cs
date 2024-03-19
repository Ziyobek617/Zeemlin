using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Zeemlin.Domain.Entities;
using Zeemlin.Domain.Entities.Questions;

namespace Zeemlin.Data.DbContexts.EntityConfigurations;

public class SchoolConfiguration
{
    public class SchoolConfigurations : IEntityTypeConfiguration<School>
    {
        public void Configure(EntityTypeBuilder<School> builder)
        {
            builder.ToTable("Schools");
            builder.HasKey(s => s.Id);

            // Define property configurations
            builder.Property(s => s.SchoolNumber).IsRequired();
            builder.Property(s => s.Name).IsRequired().HasMaxLength(255);
            builder.Property(s => s.Description).IsRequired().HasMaxLength(2000);
            builder.Property(s => s.Country).IsRequired().HasMaxLength(50);
            builder.Property(s => s.DistrictName).IsRequired().HasMaxLength(50);
            builder.Property(s => s.GeneralAddressMFY).IsRequired().HasMaxLength(50);
            builder.Property(s => s.StreetName).IsRequired().HasMaxLength(50);
            builder.Property(s => s.CallCenter);
            builder.Property(s => s.EmailCenter);
            builder.Property(s => s.Website);

            // Define relationships
            builder.HasMany(s => s.Courses)
                .WithOne(c => c.School)
                .HasForeignKey(c => c.SchoolId);

            builder.HasMany(s => s.Quizzes)
                .WithOne(q => q.School)
                .HasForeignKey(q => q.SchoolId);
        }
    }

    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name).IsRequired(); ;
            builder.Property(e => e.Description);
            builder.Property(e => e.price).IsRequired();
            builder.Property(e => e.SchoolId).IsRequired();

            builder.HasMany(e => e.Groups)
                .WithOne(g => g.Course)
                .HasForeignKey(g => g.CourseId);
        }
    }

    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.ToTable("Groups");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name).IsRequired().HasMaxLength(100);
            builder.Property(e => e.Description);
            builder.Property(e => e.CourseId).IsRequired();

            builder.HasMany(e => e.StudentGroups)
                .WithOne(sg => sg.Group)
                .HasForeignKey(sg => sg.GroupId);

            builder.HasMany(e => e.TeacherGroups)
                .WithOne(tg => tg.Group)
                .HasForeignKey(tg => tg.GroupId);
        }
    }

    public class StudentGroupConfiguration : IEntityTypeConfiguration<StudentGroup>
    {
        public void Configure(EntityTypeBuilder<StudentGroup> builder)
        {
            builder.ToTable("StudentGroups");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.StudentId).IsRequired();
            builder.Property(e => e.GroupId).IsRequired();
        }
    }

    public class TeacherGroupConfiguration : IEntityTypeConfiguration<TeacherGroup>
    {
        public void Configure(EntityTypeBuilder<TeacherGroup> builder)
        {
            builder.ToTable("TeacherGroups");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.TeacherId).IsRequired();
            builder.Property(e => e.GroupId).IsRequired();
        }
    }

    public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            builder.ToTable("Lessons");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Title);
            builder.Property(e => e.Description);
            builder.Property(e => e.StartDate);
            builder.Property(e => e.EndDate);
            builder.Property(e => e.GroupId).IsRequired();
            builder.Property(e => e.TeacherId).IsRequired();

            builder.HasMany(e => e.Homework)
                .WithOne(h => h.Lesson)
                .HasForeignKey(h => h.LessonId);

            builder.HasMany(e => e.Subjects)
                .WithOne(s => s.Lesson)
                .HasForeignKey(s => s.LessonId);
        }
    }

    public class HomeworkConfiguration : IEntityTypeConfiguration<Homework>
    {
        public void Configure(EntityTypeBuilder<Homework> builder)
        {
            builder.ToTable("Homeworks");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Title);
            builder.Property(e => e.Description);
            builder.Property(e => e.Deadline).IsRequired();
            builder.Property(e => e.LessonId).IsRequired();

            builder.HasMany(e => e.Assets)
                .WithOne(a => a.Homework)
                .HasForeignKey(a => a.HomeworkId);
        }
    }

    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.ToTable("Subjects");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name);
            builder.Property(e => e.Description);
            builder.Property(e => e.LessonId).IsRequired();
        }
    }

    public class LessonAttendanceConfiguration : IEntityTypeConfiguration<LessonAttendance>
    {
        public void Configure(EntityTypeBuilder<LessonAttendance> builder)
        {
            builder.ToTable("LessonAttendances");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.LessonId).IsRequired();
            builder.Property(e => e.StudentId).IsRequired();
            builder.Property(e => e.GroupName);
            builder.Property(e => e.TeacherName);
            builder.Property(e => e.DateTime).IsRequired();
            builder.Property(e => e.LessonAttendanceType).IsRequired();
        }
    }

    public class GradeConfiguration : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> builder)
        {
            builder.ToTable("Grades");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.UserId).IsRequired();
            builder.Property(e => e.LessonId).IsRequired();
            builder.Property(e => e.DateTimeCreated).IsRequired();
            builder.Property(e => e.AssessmentType).IsRequired();
            builder.Property(e => e.Value).IsRequired();
        }
    }

    public class QuizConfiguration : IEntityTypeConfiguration<Quiz>
    {
        public void Configure(EntityTypeBuilder<Quiz> builder)
        {
            builder.ToTable("Quizzes");
            builder.HasKey(q => q.Id);

            builder.Property(q => q.Title).IsRequired();
            builder.Property(q => q.Subject).IsRequired();
            builder.Property(q => q.Description);

            // Define relationships
            builder.HasOne(q => q.School)
                .WithMany(s => s.Quizzes)
                .HasForeignKey(q => q.SchoolId);
        }
    }

    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.ToTable("Questions");
            builder.HasKey(q => q.Id);

            builder.Property(q => q.Text).IsRequired();
            builder.Property(q => q.Description);

            // Define relationships
            builder.HasOne(q => q.Quiz)
                .WithMany(qz => qz.Questions)
                .HasForeignKey(q => q.QuizId);

            builder.HasOne(q => q.Teacher)
                .WithMany(t => t.Questions)
                .HasForeignKey(q => q.TeacherId);
        }
    }

    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.ToTable("Answers");
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Text).IsRequired();
            builder.Property(a => a.IsCorrect).IsRequired();

            // Define relationships
            builder.HasOne(a => a.Question)
                .WithMany(q => q.Answers)
                .HasForeignKey(a => a.QuestionId);
        }
    }
}
