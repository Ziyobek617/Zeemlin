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
                DueTime = new DateTime(2024, 3, 17, 23, 59, 59),
                LessonId = 1 // Assuming lesson with Id 1
            };

            yield return new Homework
            {
                Id = 2,
                CreatedAt = DateTime.UtcNow,
                Title = "Writing Assignment",
                Description = "Write a short paragraph applying the grammar rules discussed in class.",
                DueTime = new DateTime(2024, 3, 19, 23, 59, 59),
                LessonId = 1 // Assuming lesson with Id 1
            };

            // Homework for Introduction to Java Programming
            yield return new Homework
            {
                Id = 3,
                CreatedAt = DateTime.UtcNow,
                Title = "Code Exercise: Variables and Data Types",
                Description = "Write a Java program that demonstrates the use of variables and different data types.",
                DueTime = new DateTime(2024, 3, 18, 23, 59, 59),
                LessonId = 2 // Assuming lesson with Id 2
            };

            yield return new Homework
            {
                Id = 4,
                CreatedAt = DateTime.UtcNow,
                Title = "Problem-solving Exercise",
                Description = "Solve the programming problems provided and submit your solutions.",
                DueTime = new DateTime(2024, 3, 20, 23, 59, 59),
                LessonId = 2 // Assuming lesson with Id 2
            };

            // Homework for Introduction to Photography
            yield return new Homework
            {
                Id = 5,
                CreatedAt = DateTime.UtcNow,
                Title = "Photo Composition Project",
                Description = "Take photographs applying the composition techniques discussed in class.",
                DueTime = new DateTime(2024, 3, 19, 23, 59, 59),
                LessonId = 3 // Assuming lesson with Id 3
            };

            yield return new Homework
            {
                Id = 6,
                CreatedAt = DateTime.UtcNow,
                Title = "Editing Exercise",
                Description = "Edit the provided photographs using editing software and submit your edited versions.",
                DueTime = new DateTime(2024, 3, 21, 23, 59, 59),
                LessonId = 3 // Assuming lesson with Id 3
            };

            // Homework for Intermediate Mathematics: Algebra
            yield return new Homework
            {
                Id = 7,
                CreatedAt = DateTime.UtcNow,
                Title = "Problem-solving Assignment",
                Description = "Solve the algebraic problems provided and submit your solutions.",
                DueTime = new DateTime(2024, 3, 20, 23, 59, 59),
                LessonId = 4 // Assuming lesson with Id 4
            };

            yield return new Homework
            {
                Id = 8,
                CreatedAt = DateTime.UtcNow,
                Title = "Algebraic Equations Exercise",
                Description = "Practice solving algebraic equations of different types.",
                DueTime = new DateTime(2024, 3, 22, 23, 59, 59),
                LessonId = 4 // Assuming lesson with Id 4
            };

            // Homework for Renaissance Art: Introduction
            yield return new Homework
            {
                Id = 9,
                CreatedAt = DateTime.UtcNow,
                Title = "Art Analysis Project",
                Description = "Analyze a Renaissance artwork of your choice and write an essay.",
                DueTime = new DateTime(2024, 3, 21, 23, 59, 59),
                LessonId = 5 // Assuming lesson with Id 5
            };

            yield return new Homework
            {
                Id = 10,
                CreatedAt = DateTime.UtcNow,
                Title = "Artwork Reproduction",
                Description = "Reproduce a famous Renaissance artwork using your preferred medium.",
                DueTime = new DateTime(2024, 3, 23, 23, 59, 59),
                LessonId = 5 // Assuming lesson with Id 5
            };
        }
    }
}
