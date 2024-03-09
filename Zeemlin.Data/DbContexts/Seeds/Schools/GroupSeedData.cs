using System;
using System.Collections.Generic;
using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.DbContexts.Seeds.Schools
{
    public class GroupSeedData
    {
        public static IEnumerable<Group> GetGroups()
        {
            yield return new Group
            {
                Id = 1,
                CreatedAt = DateTime.UtcNow,
                Name = "Beginner English Group",
                Description = "A group for beginner English language learners.",
                CourseId = 1
            };

            yield return new Group
            {
                Id = 2,
                CreatedAt = DateTime.UtcNow,
                Name = "Java Programming Group",
                Description = "A group focusing on Java programming language and application development.",
                CourseId = 2
            };

            yield return new Group
            {
                Id = 3,
                CreatedAt = DateTime.UtcNow,
                Name = "Basic Photography Group",
                Description = "A group for beginners learning basic photography techniques.",
                CourseId = 3
            };

            yield return new Group
            {
                Id = 4,
                CreatedAt = DateTime.UtcNow,
                Name = "Intermediate Mathematics Group",
                Description = "A group for intermediate level mathematics students.",
                CourseId = 4
            };

            yield return new Group
            {
                Id = 5,
                CreatedAt = DateTime.UtcNow,
                Name = "Renaissance Art Group",
                Description = "A group studying Renaissance art and its influences.",
                CourseId = 5
            };

            yield return new Group
            {
                Id = 6,
                CreatedAt = DateTime.UtcNow,
                Name = "Advanced Physics Group",
                Description = "A group focusing on advanced topics in physics and theoretical physics.",
                CourseId = 6
            };

            yield return new Group
            {
                Id = 7,
                CreatedAt = DateTime.UtcNow,
                Name = "Instrumental Music Group",
                Description = "A group focusing on learning to play musical instruments and ensemble performance.",
                CourseId = 7
            };

            yield return new Group
            {
                Id = 8,
                CreatedAt = DateTime.UtcNow,
                Name = "Organic Chemistry Group",
                Description = "A group studying organic chemistry and its applications in industry and research.",
                CourseId = 8 
            };

            yield return new Group
            {
                Id = 9,
                CreatedAt = DateTime.UtcNow,
                Name = "Environmental Studies Group",
                Description = "A group exploring environmental issues and sustainability.",
                CourseId = 9
            };

            yield return new Group
            {
                Id = 10,
                CreatedAt = DateTime.UtcNow,
                Name = "Intermediate French Group",
                Description = "A group for intermediate French language learners.",
                CourseId = 10
            };

            yield return new Group
            {
                Id = 11,
                CreatedAt = DateTime.UtcNow,
                Name = "Advanced Algebra Group",
                Description = "A group focusing on advanced algebraic concepts and problem-solving techniques.",
                CourseId = 11 // Assuming CourseId 11 corresponds to "Algebra Course"
            };

            yield return new Group
            {
                Id = 12,
                CreatedAt = DateTime.UtcNow,
                Name = "Cell Biology Group",
                Description = "A group studying the cellular structure, function, and processes.",
                CourseId = 12
            };

            yield return new Group
            {
                Id = 13,
                CreatedAt = DateTime.UtcNow,
                Name = "Russian Language Conversation Group",
                Description = "A group focusing on practicing conversational Russian language skills.",
                CourseId = 13
            };

            yield return new Group
            {
                Id = 14,
                CreatedAt = DateTime.UtcNow,
                Name = "Shakespearean Literature Group",
                Description = "A group studying the works of William Shakespeare and Elizabethan literature.",
                CourseId = 14
            };

            yield return new Group
            {
                Id = 15,
                CreatedAt = DateTime.UtcNow,
                Name = "Ancient History Group",
                Description = "A group exploring ancient civilizations, cultures, and historical events.",
                CourseId = 15
            };

            yield return new Group
            {
                Id = 16,
                CreatedAt = DateTime.UtcNow,
                Name = "Advanced Algorithms Group",
                Description = "A group focusing on advanced algorithms and problem-solving strategies.",
                CourseId = 16
            };

            yield return new Group
            {
                Id = 17,
                CreatedAt = DateTime.UtcNow,
                Name = "Volcanology Group",
                Description = "A group studying volcanoes, volcanic processes, and volcanic hazards.",
                CourseId = 17
            };

            yield return new Group
            {
                Id = 18,
                CreatedAt = DateTime.UtcNow,
                Name = "Network Security Group",
                Description = "A group focusing on network security principles, protocols, and practices.",
                CourseId = 18 
            };

            yield return new Group
            {
                Id = 19,
                CreatedAt = DateTime.UtcNow,
                Name = "Process Design Group",
                Description = "A group studying chemical engineering process design and optimization.",
                CourseId = 19
            };

            yield return new Group
            {
                Id = 20,
                CreatedAt = DateTime.UtcNow,
                Name = "Team Sports Group",
                Description = "A group focusing on team sports and cooperative gameplay.",
                CourseId = 20 
            };

            yield return new Group
            {
                Id = 21,
                CreatedAt = DateTime.UtcNow,
                Name = "Abstract Algebra Group",
                Description = "A group studying abstract algebraic structures and their properties.",
                CourseId = 11 
            };

            yield return new Group
            {
                Id = 22,
                CreatedAt = DateTime.UtcNow,
                Name = "Genetics Group",
                Description = "A group focusing on the study of genes, heredity, and genetic variation.",
                CourseId = 12
            };

            yield return new Group
            {
                Id = 23,
                CreatedAt = DateTime.UtcNow,
                Name = "Advanced Russian Language Group",
                Description = "A group for advanced learners focusing on complex aspects of Russian language and literature.",
                CourseId = 13
            };

            yield return new Group
            {
                Id = 24,
                CreatedAt = DateTime.UtcNow,
                Name = "Modern Literature Group",
                Description = "A group studying modern literary works and contemporary authors.",
                CourseId = 14 
            };

            yield return new Group
            {
                Id = 25,
                CreatedAt = DateTime.UtcNow,
                Name = "Renaissance Art Group",
                Description = "A group focusing on art and artists from the Renaissance period.",
                CourseId = 15
            };

            yield return new Group
            {
                Id = 26,
                CreatedAt = DateTime.UtcNow,
                Name = "Machine Learning Group",
                Description = "A group studying machine learning algorithms and applications.",
                CourseId = 16
            };

            yield return new Group
            {
                Id = 27,
                CreatedAt = DateTime.UtcNow,
                Name = "Paleontology Group",
                Description = "A group studying fossils, ancient life forms, and prehistoric ecosystems.",
                CourseId = 17
            };

            yield return new Group
            {
                Id = 28,
                CreatedAt = DateTime.UtcNow,
                Name = "Cybersecurity Group",
                Description = "A group focusing on cybersecurity practices, threats, and defenses.",
                CourseId = 18
            };

            yield return new Group
            {
                Id = 29,
                CreatedAt = DateTime.UtcNow,
                Name = "Chemical Process Optimization Group",
                Description = "A group studying optimization techniques for chemical processes.",
                CourseId = 19
            };

            yield return new Group
            {
                Id = 30,
                CreatedAt = DateTime.UtcNow,
                Name = "Yoga and Meditation Group",
                Description = "A group focusing on yoga, meditation, and mindfulness practices.",
                CourseId = 20
            };

            yield return new Group
            {
                Id = 31,
                CreatedAt = DateTime.UtcNow,
                Name = "Yoga and Meditation Group",
                Description = "A group focusing on yoga, meditation, and mindfulness practices.",
                CourseId = 21
            };

            yield return new Group
            {
                Id = 32,
                CreatedAt = DateTime.UtcNow,
                Name = "Yoga and Meditation Group",
                Description = "A group focusing on yoga, meditation, and mindfulness practices.",
                CourseId = 15
            };
        }
    }
}
