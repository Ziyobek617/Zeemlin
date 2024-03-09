using System;
using System.Collections.Generic;
using Zeemlin.Domain.Entities;
using Zeemlin.Domain.Enums;

namespace Zeemlin.Data.DbContexts.Seeds.Users
{
    public class TeacherSeedData
    {
        public static IEnumerable<Teacher> GetTeachers()
        {
            yield return new Teacher
            {
                Id = 1,
                CreatedAt = DateTime.UtcNow,
                FirstName = "John",
                LastName = "Smith",
                DateOfBirth = "1985.5.15",
                PhoneNumber = "+998900000001",
                Email = "johnsmith@school.com",
                Password = "hashed_password",
                Biography = "Experienced teacher in mathematics.",
                DistrictName = "Mirzo Ulug'bek",
                SchoolNumber = 12345,
                ScienceType = ScienceType.Mathematics,
                genderType = GenderType.Male
            };

            yield return new Teacher
            {
                Id = 2,
                CreatedAt = DateTime.UtcNow,
                FirstName = "Jane",
                LastName = "Doe",
                DateOfBirth = "1988.8.25",
                PhoneNumber = "+998900000002",
                Email = "janedoe@school.com",
                Password = "hashed_password",
                Biography = "Passionate teacher specializing in history.",
                DistrictName = "Mirzo Ulug'bek",
                SchoolNumber = 12345,
                ScienceType = ScienceType.History,
                genderType = GenderType.Female
            };

            yield return new Teacher
            {
                Id = 3,
                CreatedAt = DateTime.UtcNow,
                FirstName = "Michael",
                LastName = "Johnson",
                DateOfBirth = "1980.1.10",
                PhoneNumber = "+998900000003",
                Email = "michaeljohnson@school.com",
                Password = "hashed_password",
                Biography = "Dedicated teacher with expertise in geography.",
                DistrictName = "Eskishahar",
                SchoolNumber = 54321,
                ScienceType = ScienceType.Geography,
                genderType = GenderType.Male
            };

            yield return new Teacher
            {
                Id = 4,
                CreatedAt = DateTime.UtcNow,
                FirstName = "Umid",
                LastName = "Yo'ldoshev",
                DateOfBirth = "1980.1.1",
                PhoneNumber = "+998901234567",
                Email = "umid.yoldoshev@school1.com",
                Password = "hashed_password",
                Biography = "Experienced Mathematics teacher with 10+ years of experience.",
                DistrictName = "Mirzo Ulug'bek",
                SchoolNumber = 12345, 
                ScienceType = ScienceType.Mathematics,
                genderType = GenderType.Male
            };

            yield return new Teacher
            {
                Id = 5,
                CreatedAt = DateTime.UtcNow,
                FirstName = "Nodira",
                LastName = "Xo'jayeva",
                DateOfBirth = "1985.5.15",
                PhoneNumber = "+998907890123",
                Email = "nodira.xojayeva@school2.com",
                Password = "hashed_password", 
                Biography = "Enthusiastic English language teacher with a passion for fostering communication skills.",
                DistrictName = "Eskishahar",
                SchoolNumber = 54321,
                ScienceType = ScienceType.EnglishLanguage,
                genderType = GenderType.Female
            };

            yield return new Teacher
            {
                Id = 6,
                CreatedAt = DateTime.UtcNow,
                FirstName = "Emily",
                LastName = "Wilson",
                DateOfBirth = "1984.5.9",
                PhoneNumber = "+998900000006",
                Email = "emilywilson@school.com",
                Password = "hashed_password",
                Biography = "Experienced teacher specializing in chemistry.",
                DistrictName = "Mirzo Ulug'bek",
                SchoolNumber = 12345,
                ScienceType = ScienceType.Chemistry,
                genderType = GenderType.Female
            };

            yield return new Teacher
            {
                Id = 7,
                CreatedAt = DateTime.UtcNow,
                FirstName = "Daniel",
                LastName = "Lee",
                DateOfBirth = "2000.9.4",
                PhoneNumber = "+998900000007",
                Email = "daniellee@school.com",
                Password = "hashed_password",
                Biography = "Passionate teacher with expertise in art.",
                DistrictName = "Mirzo Ulug'bek",
                SchoolNumber = 12345,
                ScienceType = ScienceType.Art,
                genderType = GenderType.Male
            };

            yield return new Teacher
            {
                Id = 8,
                CreatedAt = DateTime.UtcNow,
                FirstName = "Ava",
                LastName = "Garcia",
                DateOfBirth = "1986.7.5",
                PhoneNumber = "+998900000008",
                Email = "avagarcia@school.com",
                Password = "hashed_password",
                Biography = "Dedicated teacher with a passion for music.",
                DistrictName = "Eskishahar",
                SchoolNumber = 54321,
                ScienceType = ScienceType.Music,
                genderType = GenderType.Female
            };

            yield return new Teacher
            {
                Id = 9,
                CreatedAt = DateTime.UtcNow,
                FirstName = "Noah",
                LastName = "Martinez",
                DateOfBirth = "1984.3.19",
                PhoneNumber = "+998900000009",
                Email = "noahmartinez@school.com",
                Password = "hashed_password",
                Biography = "Experienced mathematics teacher.",
                DistrictName = "Eskishahar",
                SchoolNumber = 54321,
                ScienceType = ScienceType.Mathematics,
                genderType = GenderType.Male
            };

            yield return new Teacher
            {
                Id = 10,
                CreatedAt = DateTime.UtcNow,
                FirstName = "Ella",
                LastName = "Lopez",
                DateOfBirth = "1989.9.30",
                PhoneNumber = "+998900000010",
                Email = "ellalopez@school.com",
                Password = "hashed_password",
                Biography = "Passionate teacher specializing in biology.",
                DistrictName = "Shahriston",
                SchoolNumber = 67890,
                ScienceType = ScienceType.Biology,
                genderType = GenderType.Female
            };

            yield return new Teacher
            {
                Id = 11,
                CreatedAt = DateTime.UtcNow,
                FirstName = "William",
                LastName = "Taylor",
                DateOfBirth = "1981.12.10",
                PhoneNumber = "+998900000011",
                Email = "williamtaylor@school.com",
                Password = "hashed_password",
                Biography = "Experienced history teacher.",
                DistrictName = "Shahriston",
                SchoolNumber = 67890,
                ScienceType = ScienceType.History,
                genderType = GenderType.Male
            };

            yield return new Teacher
            {
                Id = 12,
                CreatedAt = DateTime.UtcNow,
                FirstName = "Sofia",
                LastName = "Hernandez",
                DateOfBirth = "1992.11.12",
                PhoneNumber = "+998900000012",
                Email = "sofiahernandez@school.com",
                Password = "hashed_password",
                Biography = "Dedicated teacher with expertise in physics.",
                DistrictName = "Namangan shahri",
                SchoolNumber = 98765,
                ScienceType = ScienceType.Physics,
                genderType = GenderType.Female
            };

            yield return new Teacher
            {
                Id = 13,
                CreatedAt = DateTime.UtcNow,
                FirstName = "Oliver",
                LastName = "Scott",
                DateOfBirth = "1982.12.17",
                PhoneNumber = "+998900000013",
                Email = "oliverscott@school.com",
                Password = "hashed_password",
                Biography = "Passionate teacher specializing in algebra.",
                DistrictName = "Namangan shahri",
                SchoolNumber = 98765,
                ScienceType = ScienceType.Algebra,
                genderType = GenderType.Male
            };

            yield return new Teacher
            {
                Id = 14,
                CreatedAt = DateTime.UtcNow,
                FirstName = "Sarvar",
                LastName = "Qosimov",
                DateOfBirth = "1996.2.25",
                PhoneNumber = "+998909876543",
                Email = "sarvar.qosimov@school3.com",
                Password = "hashed_password",
                Biography = "Dedicated History teacher with a strong emphasis on critical thinking skills.",
                DistrictName = "Shahriston",
                SchoolNumber = 67890, 
                ScienceType = ScienceType.History,
                genderType = GenderType.Male
            };

            yield return new Teacher
            {
                Id = 15,
                CreatedAt = DateTime.UtcNow,
                FirstName = "Malika",
                LastName = "Azizova",
                DateOfBirth = "2000.2.29",
                PhoneNumber = "+998901239876",
                Email = "malika.azizova@school4.com",
                Password = "hashed_password",
                Biography = "Skilled Uzbek language teacher passionate about preserving cultural heritage.",
                DistrictName = "Namangan shahri",
                SchoolNumber = 98765,
                ScienceType = ScienceType.UzbekLanguage,
                genderType = GenderType.Female
            };

            yield return new Teacher
            {
                Id = 16,
                CreatedAt = DateTime.UtcNow,
                FirstName = "Emma",
                LastName = "Perez",
                DateOfBirth = "1994.6.29",
                PhoneNumber = "+998900000016",
                Email = "emmaperez@school.com",
                Password = "hashed_password",
                Biography = "Experienced teacher specializing in geography.",
                DistrictName = "Namangan shahri",
                SchoolNumber = 98765,
                ScienceType = ScienceType.Geography,
                genderType = GenderType.Female
            };

            yield return new Teacher
            {
                Id = 17,
                CreatedAt = DateTime.UtcNow,
                FirstName = "Lucas",
                LastName = "Nguyen",
                DateOfBirth = "1992.8.16",
                PhoneNumber = "+998900000017",
                Email = "lucasnguyen@school.com",
                Password = "hashed_password",
                Biography = "Passionate teacher with expertise in biology.",
                DistrictName = "Samarkand shahri",
                SchoolNumber = 24680,
                ScienceType = ScienceType.Biology,
                genderType = GenderType.Male
            };

            yield return new Teacher
            {
                Id = 18,
                CreatedAt = DateTime.UtcNow,
                FirstName = "Lily",
                LastName = "Gonzalez",
                DateOfBirth = "1993.10.4",
                PhoneNumber = "+998900000018",
                Email = "lilygonzalez@school.com",
                Password = "hashed_password",
                Biography = "Dedicated teacher with a passion for music.",
                DistrictName = "Samarkand shahri",
                SchoolNumber = 24680,
                ScienceType = ScienceType.Music,
                genderType = GenderType.Female
            };

            yield return new Teacher
            {
                Id = 19,
                CreatedAt = DateTime.UtcNow,
                FirstName = "Jackson",
                LastName = "Adams",
                DateOfBirth = "1993.10.4",
                PhoneNumber = "+998900000019",
                Email = "jacksonadams@school.com",
                Password = "hashed_password",
                Biography = "Experienced mathematics teacher.",
                DistrictName = "Yunusabad",
                SchoolNumber = 13579,
                ScienceType = ScienceType.Mathematics,
                genderType = GenderType.Male
            };

            yield return new Teacher
            {
                Id = 20,
                CreatedAt = DateTime.UtcNow,
                FirstName = "Chloe",
                LastName = "Kim",
                DateOfBirth = "1998.10.16",
                PhoneNumber = "+998900000020",
                Email = "chloekim@school.com",
                Password = "hashed_password",
                Biography = "Passionate teacher specializing in physics.",
                DistrictName = "Yunusabad",
                SchoolNumber = 13579,
                ScienceType = ScienceType.Physics,
                genderType = GenderType.Female
            };

            yield return new Teacher
            {
                Id = 21,
                CreatedAt = DateTime.UtcNow,
                FirstName = "Ryan",
                LastName = "Harris",
                DateOfBirth = "1990.7.14",
                PhoneNumber = "+998900000021",
                Email = "ryanharris@school.com",
                Password = "hashed_password",
                Biography = "Experienced teacher with expertise in chemistry.",
                DistrictName = "Navoiy shahri",
                SchoolNumber = 35791,
                ScienceType = ScienceType.Chemistry,
                genderType = GenderType.Male
            };

            yield return new Teacher
            {
                Id = 22,
                CreatedAt = DateTime.UtcNow,
                FirstName = "Madison",
                LastName = "Lopez",
                DateOfBirth = "1989.10.13",
                PhoneNumber = "+998900000022",
                Email = "madisonlopez@school.com",
                Password = "hashed_password",
                Biography = "Passionate teacher specializing in algebra.",
                DistrictName = "Navoiy shahri",
                SchoolNumber = 35791,
                ScienceType = ScienceType.Algebra,
                genderType = GenderType.Female
            };

            yield return new Teacher
            {
                Id = 23,
                CreatedAt = DateTime.UtcNow,
                FirstName = "Ethan",
                LastName = "Wright",
                DateOfBirth = "1997.1.1",
                PhoneNumber = "+998900000023",
                Email = "ethanwright@school.com",
                Password = "hashed_password",
                Biography = "Dedicated teacher with a passion for art.",
                DistrictName = "Termiz shahri",
                SchoolNumber = 46802,
                ScienceType = ScienceType.Art,
                genderType = GenderType.Male
            };

            yield return new Teacher
            {
                Id = 24,
                CreatedAt = DateTime.UtcNow,
                FirstName = "Avery",
                LastName = "Martin",
                DateOfBirth = "1991.11.10",
                PhoneNumber = "+998900000024",
                Email = "averymartin@school.com",
                Password = "hashed_password",
                Biography = "Experienced teacher specializing in history.",
                DistrictName = "Termiz shahri",
                SchoolNumber = 46802,
                ScienceType = ScienceType.History,
                genderType = GenderType.Female
            };

            yield return new Teacher
            {
                Id = 25,
                CreatedAt = DateTime.UtcNow,
                FirstName = "Harper",
                LastName = "Thompson",
                DateOfBirth = "1993.10.4",
                PhoneNumber = "+998900000025",
                Email = "harperthompson@school.com",
                Password = "hashed_password",
                Biography = "Passionate teacher specializing in information technology.",
                DistrictName = "Termiz shahri",
                SchoolNumber = 46802,
                ScienceType = ScienceType.InformationTechnology,
                genderType = GenderType.Female
            };
        }
    }
}
