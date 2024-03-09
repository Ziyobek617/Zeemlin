using System;
using System.Collections.Generic;
using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.DbContexts.Seeds.Schools
{
    public class TeacherGroupSeedData
    {
        public static IEnumerable<TeacherGroup> GetTeacherGroups()
        {
            yield return new TeacherGroup
            {
                Id = 1,
                CreatedAt = DateTime.UtcNow,
                TeacherId = 1,
                GroupId = 1
            };

            yield return new TeacherGroup
            {
                Id = 2,
                CreatedAt = DateTime.UtcNow,
                TeacherId = 1,
                GroupId = 2 
            };

            yield return new TeacherGroup
            {
                Id = 3,
                CreatedAt = DateTime.UtcNow,
                TeacherId = 2, 
                GroupId = 3 
            };

            yield return new TeacherGroup
            {
                Id = 4,
                CreatedAt = DateTime.UtcNow,
                TeacherId = 2, 
                GroupId = 4 
            };

            yield return new TeacherGroup
            {
                Id = 5,
                CreatedAt = DateTime.UtcNow,
                TeacherId = 3,
                GroupId = 5 
            };

            yield return new TeacherGroup
            {
                Id = 6,
                CreatedAt = DateTime.UtcNow,
                TeacherId = 3,
                GroupId = 6
            };

            yield return new TeacherGroup
            {
                Id = 7,
                CreatedAt = DateTime.UtcNow,
                TeacherId = 4,
                GroupId = 7
            };

            yield return new TeacherGroup
            {
                Id = 8,
                CreatedAt = DateTime.UtcNow,
                TeacherId = 5,
                GroupId = 8 
            };

            yield return new TeacherGroup
            {
                Id = 9,
                CreatedAt = DateTime.UtcNow,
                TeacherId = 6,
                GroupId = 9
            };

            yield return new TeacherGroup
            {
                Id = 10,
                CreatedAt = DateTime.UtcNow,
                TeacherId = 7,
                GroupId = 10
            };

            yield return new TeacherGroup
            {
                Id = 11,
                CreatedAt = DateTime.UtcNow,
                TeacherId = 8,
                GroupId = 11
            };

            yield return new TeacherGroup
            {
                Id = 12,
                CreatedAt = DateTime.UtcNow,
                TeacherId = 9,
                GroupId = 12
            };

            yield return new TeacherGroup
            {
                Id = 13,
                CreatedAt = DateTime.UtcNow,
                TeacherId = 10,
                GroupId = 13
            };

            yield return new TeacherGroup
            {
                Id = 14,
                CreatedAt = DateTime.UtcNow,
                TeacherId = 11,
                GroupId = 14
            };

            yield return new TeacherGroup
            {
                Id = 15,
                CreatedAt = DateTime.UtcNow,
                TeacherId = 12,
                GroupId = 15
            };

            yield return new TeacherGroup
            {
                Id = 16,
                CreatedAt = DateTime.UtcNow,
                TeacherId = 13,
                GroupId = 16
            };

            yield return new TeacherGroup
            {
                Id = 17,
                CreatedAt = DateTime.UtcNow,
                TeacherId = 14,
                GroupId = 17
            };

            yield return new TeacherGroup
            {
                Id = 18,
                CreatedAt = DateTime.UtcNow,
                TeacherId = 15,
                GroupId = 18
            };

            yield return new TeacherGroup
            {
                Id = 19,
                CreatedAt = DateTime.UtcNow,
                TeacherId = 16, 
                GroupId = 19 
            };

            yield return new TeacherGroup
            {
                Id = 20,
                CreatedAt = DateTime.UtcNow,
                TeacherId = 17,
                GroupId = 20
            };

            yield return new TeacherGroup
            {
                Id = 21,
                CreatedAt = DateTime.UtcNow,
                TeacherId = 18,
                GroupId = 21
            };

            yield return new TeacherGroup
            {
                Id = 22,
                CreatedAt = DateTime.UtcNow,
                TeacherId = 19,
                GroupId = 22 
            };

            yield return new TeacherGroup
            {
                Id = 23,
                CreatedAt = DateTime.UtcNow,
                TeacherId = 20,
                GroupId = 23 
            };

            yield return new TeacherGroup
            {
                Id = 24,
                CreatedAt = DateTime.UtcNow,
                TeacherId = 21,
                GroupId = 24
            };
        }
    }
}
