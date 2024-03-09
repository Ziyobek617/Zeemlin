using System;
using System.Collections.Generic;
using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.DbContexts.Seeds.Schools
{
    public class LessonSeedData
    {
        public static IEnumerable<Lesson> GetLessons()
        {
            yield return new Lesson
            {
                Id = 1,
                CreatedAt = DateTime.UtcNow,
                Title = "Introduction to English Grammar",
                Description = "An introductory lesson covering basic English grammar concepts.",
                StartDate = "9:00",
                EndDate = "10:00",
                GroupId = 1, // Assuming group with Id 1
                TeacherId = 1 // Assuming teacher with Id 1
            };

            yield return new Lesson
            {
                Id = 2,
                CreatedAt = DateTime.UtcNow,
                Title = "Introduction to Java Programming",
                Description = "A beginner-level lesson introducing fundamental Java programming concepts.",
                StartDate = "9:00",
                EndDate = "10:00",
                GroupId = 2, // Assuming group with Id 2
                TeacherId = 2 // Assuming teacher with Id 2
            };

            yield return new Lesson
            {
                Id = 3,
                CreatedAt = DateTime.UtcNow,
                Title = "Introduction to Photography",
                Description = "An introductory lesson covering basic photography techniques and principles.",
                StartDate = "9:00",
                EndDate = "10:00",
                GroupId = 3, // Assuming group with Id 3
                TeacherId = 3 // Assuming teacher with Id 3
            };

            yield return new Lesson
            {
                Id = 4,
                CreatedAt = DateTime.UtcNow,
                Title = "Intermediate Mathematics: Algebra",
                Description = "A lesson focusing on intermediate-level algebraic concepts and problem-solving techniques.",
                StartDate = "9:00",
                EndDate = "10:00",
                GroupId = 4, // Assuming group with Id 4
                TeacherId = 4 // Assuming teacher with Id 4
            };

            yield return new Lesson
            {
                Id = 5,
                CreatedAt = DateTime.UtcNow,
                Title = "Renaissance Art: Introduction",
                Description = "A lesson introducing Renaissance art and its historical significance.",
                StartDate = "9:00",
                EndDate = "10:00",
                GroupId = 5, // Assuming group with Id 5
                TeacherId = 5 // Assuming teacher with Id 5
            };

            yield return new Lesson
            {
                Id = 6,
                CreatedAt = DateTime.UtcNow,
                Title = "Advanced Physics: Quantum Mechanics",
                Description = "An advanced lesson covering quantum mechanics and its applications.",
                StartDate = "9:00",
                EndDate = "10:00",
                GroupId = 6, // Assuming group with Id 6
                TeacherId = 6 // Assuming teacher with Id 6
            };

            yield return new Lesson
            {
                Id = 7,
                CreatedAt = DateTime.UtcNow,
                Title = "Instrumental Music: Introduction to Piano",
                Description = "A beginner-level lesson introducing piano playing techniques and music theory.",
                StartDate = "9:00",
                EndDate = "10:00",
                GroupId = 7, // Assuming group with Id 7
                TeacherId = 7 // Assuming teacher with Id 7
            };

            yield return new Lesson
            {
                Id = 8,
                CreatedAt = DateTime.UtcNow,
                Title = "Organic Chemistry: Introduction",
                Description = "An introductory lesson covering basic organic chemistry principles and reactions.",
                StartDate = "9:00",
                EndDate = "10:00",
                GroupId = 8, // Assuming group with Id 8
                TeacherId = 8 // Assuming teacher with Id 8
            };

            yield return new Lesson
            {
                Id = 9,
                CreatedAt = DateTime.UtcNow,
                Title = "World History: Ancient Civilizations",
                Description = "A lesson exploring ancient civilizations and their contributions to world history.",
                StartDate = "9:00",
                EndDate = "10:00",
                GroupId = 9, // Assuming group with Id 9
                TeacherId = 9 // Assuming teacher with Id 9
            };

            yield return new Lesson
            {
                Id = 10,
                CreatedAt = DateTime.UtcNow,
                Title = "Introduction to Graphic Design",
                Description = "An introductory lesson covering basic graphic design principles and software tools.",
                StartDate = "9:00",
                EndDate = "10:00",
                GroupId = 10, // Assuming group with Id 10
                TeacherId = 10 // Assuming teacher with Id 10
            };

            yield return new Lesson
            {
                Id = 11,
                CreatedAt = DateTime.UtcNow,
                Title = "Introduction to Web Development",
                Description = "A beginner-level lesson introducing basic web development concepts and technologies.",
                StartDate = "9:00",
                EndDate = "10:00",
                GroupId = 11, // Assuming group with Id 11
                TeacherId = 11 // Assuming teacher with Id 11
            };

            yield return new Lesson
            {
                Id = 12,
                CreatedAt = DateTime.UtcNow,
                Title = "Introduction to Web Development",
                Description = "A beginner-level lesson introducing basic web development concepts and technologies.",
                StartDate = "9:00",
                EndDate = "10:00",
                GroupId = 12, 
                TeacherId = 12
            };

            yield return new Lesson
            {
                Id = 13,
                CreatedAt = DateTime.UtcNow,
                Title = "Introduction to Web Development",
                Description = "A beginner-level lesson introducing basic web development concepts and technologies.",
                StartDate = "9:00",
                EndDate = "10:00",
                GroupId = 13,
                TeacherId = 13
            };
        }
    }
}
