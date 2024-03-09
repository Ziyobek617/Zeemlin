using System;
using System.Collections.Generic;
using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.DbContexts.Seeds.Schools
{
    public class HomeworkSeedData
    {
        public static IEnumerable<Homework> GetHomeworks()
        {
            // Homework for Introduction to English Grammar
            yield return new Homework
            {
                Id = 1,
                CreatedAt = DateTime.UtcNow,
                Title = "Practice Exercise 1",
                Description = "Complete the exercises on basic English grammar concepts covered in the lesson.",
                Deadline = "23:59:59",
                LessonId = 1
            };

            yield return new Homework
            {
                Id = 2,
                CreatedAt = DateTime.UtcNow,
                Title = "Writing Assignment",
                Description = "Write a short paragraph applying the grammar rules discussed in class.",
                Deadline = "23:59:59",
                LessonId = 1 
            };

            // Homework for Introduction to Java Programming
            yield return new Homework
            {
                Id = 3,
                CreatedAt = DateTime.UtcNow,
                Title = "Code Exercise: Variables and Data Types",
                Description = "Write a Java program that demonstrates the use of variables and different data types.",
                Deadline = "23:59:59",
                LessonId = 2
            };

            yield return new Homework
            {
                Id = 4,
                CreatedAt = DateTime.UtcNow,
                Title = "Problem-solving Exercise",
                Description = "Solve the programming problems provided and submit your solutions.",
                Deadline = "23:59:59",
                LessonId = 2
            };

            yield return new Homework
            {
                Id = 5,
                CreatedAt = DateTime.UtcNow,
                Title = "Photo Composition Project",
                Description = "Take photographs applying the composition techniques discussed in class.",
                Deadline = "23:59:59",
                LessonId = 3
            };

            yield return new Homework
            {
                Id = 6,
                CreatedAt = DateTime.UtcNow,
                Title = "Editing Exercise",
                Description = "Edit the provided photographs using editing software and submit your edited versions.",
                Deadline = "23:59:59",
                LessonId = 3 
            };

            yield return new Homework
            {
                Id = 7,
                CreatedAt = DateTime.UtcNow,
                Title = "Problem-solving Assignment",
                Description = "Solve the algebraic problems provided and submit your solutions.",
                Deadline = "23:59:59",
                LessonId = 4
            };

            yield return new Homework
            {
                Id = 8,
                CreatedAt = DateTime.UtcNow,
                Title = "Algebraic Equations Exercise",
                Description = "Practice solving algebraic equations of different types.",
                Deadline = "23:59:59",
                LessonId = 4 
            };

            yield return new Homework
            {
                Id = 9,
                CreatedAt = DateTime.UtcNow,
                Title = "Art Analysis Project",
                Description = "Analyze a Renaissance artwork of your choice and write an essay.",
                Deadline = "23:59:59",
                LessonId = 5 
            };

            yield return new Homework
            {
                Id = 10,
                CreatedAt = DateTime.UtcNow,
                Title = "Artwork Reproduction",
                Description = "Reproduce a famous Renaissance artwork using your preferred medium.",
                Deadline = "23:59:59",
                LessonId = 5
            };

            yield return new Homework
            {
                Id = 11,
                CreatedAt = DateTime.UtcNow,
                Title = "Artwork Reproduction",
                Description = "Reproduce a famous Renaissance artwork using your preferred medium.",
                Deadline = "23:59:59",
                LessonId = 8
            };

            yield return new Homework
            {
                Id = 12,
                CreatedAt = DateTime.UtcNow,
                Title = "Artwork Reproduction",
                Description = "Reproduce a famous Renaissance artwork using your preferred medium.",
                Deadline = "23:59:59",
                LessonId = 8
            };
        }
    }
}
