using System;
using System.Collections.Generic;
using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.DbContexts.Seeds.Schools
{
    public class CourseSeedData
    {
        public static IEnumerable<Course> GetCourses()
        {
            yield return new Course
            {
                Id = 1,
                CreatedAt = DateTime.UtcNow,
                Name = "English Language Course",
                Description = "A comprehensive course covering all aspects of the English language.",
                SchoolId = 1 
            };

            yield return new Course
            {
                Id = 2,
                CreatedAt = DateTime.UtcNow,
                Name = "Computer Science Course",
                Description = "A course focusing on various aspects of computer science and programming.",
                SchoolId = 2 
            };

            yield return new Course
            {
                Id = 3,
                CreatedAt = DateTime.UtcNow,
                Name = "Photography Course",
                Description = "A course covering photography techniques, equipment, and artistic aspects.",
                SchoolId = 8 
            };

            yield return new Course
            {
                Id = 4,
                CreatedAt = DateTime.UtcNow,
                Name = "Mathematics Course",
                Description = "A comprehensive course covering various mathematical concepts and techniques.",
                SchoolId = 3 
            };

            yield return new Course
            {
                Id = 5,
                CreatedAt = DateTime.UtcNow,
                Name = "Art History Course",
                Description = "A course exploring the history and development of art from different periods and cultures.",
                SchoolId = 4
            };

            yield return new Course
            {
                Id = 6,
                CreatedAt = DateTime.UtcNow,
                Name = "Physics Course",
                Description = "A course covering fundamental principles of physics and their practical applications.",
                SchoolId = 5 
            };

            yield return new Course
            {
                Id = 7,
                CreatedAt = DateTime.UtcNow,
                Name = "Music Theory Course",
                Description = "A course exploring music theory, notation, composition, and performance.",
                SchoolId = 6
            };

            yield return new Course
            {
                Id = 8,
                CreatedAt = DateTime.UtcNow,
                Name = "Chemistry Course",
                Description = "A course covering the principles of chemistry, including atomic structure, chemical reactions, and bonding.",
                SchoolId = 7 
            };

            yield return new Course
            {
                Id = 9,
                CreatedAt = DateTime.UtcNow,
                Name = "Geography Course",
                Description = "A course studying the Earth's landscapes, environments, and human geography.",
                SchoolId = 8 
            };

            yield return new Course
            {
                Id = 10,
                CreatedAt = DateTime.UtcNow,
                Name = "French Language Course",
                Description = "A course focusing on the French language, covering vocabulary, grammar, and conversation.",
                SchoolId = 9 
            };

            yield return new Course
            {
                Id = 11,
                CreatedAt = DateTime.UtcNow,
                Name = "Algebra Course",
                Description = "A course covering algebraic concepts and techniques, including equations, functions, and polynomials.",
                SchoolId = 10 
            };

            yield return new Course
            {
                Id = 12,
                CreatedAt = DateTime.UtcNow,
                Name = "Biology Course",
                Description = "A course exploring the principles of biology, including cell biology, genetics, and ecology.",
                SchoolId = 11 
            };

            yield return new Course
            {
                Id = 13,
                CreatedAt = DateTime.UtcNow,
                Name = "Russian Language Course",
                Description = "A course focusing on the Russian language, covering vocabulary, grammar, and conversation.",
                SchoolId = 12
            };

            yield return new Course
            {
                Id = 14,
                CreatedAt = DateTime.UtcNow,
                Name = "English Literature Course",
                Description = "A course exploring classic and contemporary works of English literature.",
                SchoolId = 13 
            };

            yield return new Course
            {
                Id = 15,
                CreatedAt = DateTime.UtcNow,
                Name = "History of Art Course",
                Description = "A course examining the history and development of art from different cultures and periods.",
                SchoolId = 1 
            };

            yield return new Course
            {
                Id = 16,
                CreatedAt = DateTime.UtcNow,
                Name = "Computer Science Course",
                Description = "A course covering fundamental concepts of computer science, programming, and algorithms.",
                SchoolId = 2 
            };

            yield return new Course
            {
                Id = 17,
                CreatedAt = DateTime.UtcNow,
                Name = "Geology Course",
                Description = "A course studying the Earth's structure, rocks, minerals, and geological processes.",
                SchoolId = 3
            };

            yield return new Course
            {
                Id = 18,
                CreatedAt = DateTime.UtcNow,
                Name = "Information Technology Course",
                Description = "A course focusing on IT concepts, including hardware, software, networks, and cybersecurity.",
                SchoolId = 4
            };

            yield return new Course
            {
                Id = 19,
                CreatedAt = DateTime.UtcNow,
                Name = "Chemical Engineering Course",
                Description = "A course covering principles and techniques of chemical engineering, including unit operations and process design.",
                SchoolId = 5
            };

            yield return new Course
            {
                Id = 20,
                CreatedAt = DateTime.UtcNow,
                Name = "Physical Education Course",
                Description = "A course focusing on physical fitness, sports, and exercise physiology.",
                SchoolId = 6
            };

            yield return new Course
            {
                Id = 21,
                CreatedAt = DateTime.UtcNow,
                Name = "Algebraic Geometry Course",
                Description = "A course exploring advanced concepts in algebraic geometry, including varieties and schemes.",
                SchoolId = 7
            };

            yield return new Course
            {
                Id = 22,
                CreatedAt = DateTime.UtcNow,
                Name = "Environmental Science Course",
                Description = "A course studying the Earth's environment, ecosystems, and human impact on nature.",
                SchoolId = 8
            };

            yield return new Course
            {
                Id = 23,
                CreatedAt = DateTime.UtcNow,
                Name = "French Cuisine Course",
                Description = "A course exploring the art and techniques of French cuisine, including cooking methods and recipes.",
                SchoolId = 9
            };

            yield return new Course
            {
                Id = 24,
                CreatedAt = DateTime.UtcNow,
                Name = "Course",
                Description = "A course exploring the art and techniques of French cuisine, including cooking methods and recipes.",
                SchoolId = 9
            };

            yield return new Course
            {
                Id = 25,
                CreatedAt = DateTime.UtcNow,
                Name = "Course",
                Description = "A course exploring the art and techniques of French cuisine, including cooking methods and recipes.",
                SchoolId = 10
            };
        }
    }
}
