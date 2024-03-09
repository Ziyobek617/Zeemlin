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
                DateOfBirth = new DateTime(1985, 5, 15),
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
                DateOfBirth = new DateTime(1988, 8, 25),
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
                DateOfBirth = new DateTime(1980, 10, 10),
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
                DateOfBirth = new DateTime(1980, 1, 1),
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
                DateOfBirth = new DateTime(1985, 5, 15),
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
                DateOfBirth = new DateTime(1987, 4, 20),
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
                DateOfBirth = new DateTime(1982, 9, 12),
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
                DateOfBirth = new DateTime(1986, 7, 5),
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
                DateOfBirth = new DateTime(1984, 3, 18),
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
                DateOfBirth = new DateTime(1989, 6, 30),
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
                DateOfBirth = new DateTime(1981, 10, 8),
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
                DateOfBirth = new DateTime(1983, 5, 21),
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
                DateOfBirth = new DateTime(1980, 12, 17),
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
                DateOfBirth = new DateTime(1982, 8, 10),
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
                DateOfBirth = new DateTime(1992, 2, 2),
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
                DateOfBirth = new DateTime(1984, 9, 28),
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
                DateOfBirth = new DateTime(1982, 7, 14),
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
                DateOfBirth = new DateTime(1987, 3, 9),
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
                DateOfBirth = new DateTime(1981, 12, 3),
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
                DateOfBirth = new DateTime(1985, 10, 25),
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
                DateOfBirth = new DateTime(1983, 8, 18),
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
                DateOfBirth = new DateTime(1989, 5, 12),
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
                DateOfBirth = new DateTime(1980, 11, 6),
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
                DateOfBirth = new DateTime(1986, 6, 9),
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
                DateOfBirth = new DateTime(1984, 4, 3),
                PhoneNumber = "+998900000025",
                Email = "harperthompson@school.com",
                Password = "hashed_password",
                Biography = "Passionate teacher specializing in information technology.",
                DistrictName = "Termiz shahri",
                SchoolNumber = 46802,
                ScienceType = ScienceType.InformationTechnology,
                genderType = GenderType.Female
            };

            yield return new Teacher
            {
                Id = 26,
                CreatedAt = DateTime.UtcNow,
                FirstName = "Dilshod",
                LastName = "Karimov",
                DateOfBirth = new DateTime(1985, 9, 5),
                PhoneNumber = "+998901234568",
                Email = "dilshod.karimov@school5.com",
                Password = "hashed_password", 
                Biography = "Motivated Physics teacher with a talent for explaining complex concepts clearly.",
                DistrictName = "Yunusabad",
                SchoolNumber = 13579, 
                ScienceType = ScienceType.Physics,
                genderType = GenderType.Male
            };

            yield return new Teacher
            {
                Id = 27,
                CreatedAt = DateTime.UtcNow,
                FirstName = "Sevinch",
                LastName = "Tojieva",
                DateOfBirth = new DateTime(1990, 3, 12),
                PhoneNumber = "+998908765432",
                Email = "sevinch.tojieva@school6.com",
                Password = "hashed_password",
                Biography = "Energetic Art teacher fostering creativity and artistic expression in students.",
                DistrictName = "Samarqand shahri",
                SchoolNumber = 24680, 
                ScienceType = ScienceType.Art,
                genderType = GenderType.Female
            };

            yield return new Teacher
            {
                Id = 28,
                CreatedAt = DateTime.UtcNow,
                FirstName = "Olivia",
                LastName = "White",
                DateOfBirth = new DateTime(1987, 12, 15),
                PhoneNumber = "+998900000028",
                Email = "oliviawhite@school.com",
                Password = "hashed_password",
                Biography = "Passionate teacher specializing in French language.",
                DistrictName = "Mirzo Ulug'bek",
                SchoolNumber = 1, 
                ScienceType = ScienceType.FrenchLanguage,
                genderType = GenderType.Female
            };

            yield return new Teacher
            {
                Id = 29,
                CreatedAt = DateTime.UtcNow,
                FirstName = "Max",
                LastName = "Wilson",
                DateOfBirth = new DateTime(1985, 10, 20),
                PhoneNumber = "+998900000029",
                Email = "maxwilson@school.com",
                Password = "hashed_password",
                Biography = "Experienced teacher specializing in English language.",
                DistrictName = "Eskishahar",
                SchoolNumber = 2, 
                ScienceType = ScienceType.EnglishLanguage,
                genderType = GenderType.Male
            };

            yield return new Teacher
            {
                Id = 30,
                CreatedAt = DateTime.UtcNow,
                FirstName = "Sophia",
                LastName = "Lee",
                DateOfBirth = new DateTime(1988, 5, 25),
                PhoneNumber = "+998900000030",
                Email = "sophialee@school.com",
                Password = "hashed_password",
                Biography = "Passionate teacher specializing in German language.",
                DistrictName = "Shahriston",
                SchoolNumber = 3, 
                ScienceType = ScienceType.GermanLanguage,
                genderType = GenderType.Female
            };

            yield return new Teacher
            {
                Id = 31,
                CreatedAt = DateTime.UtcNow,
                FirstName = "Sophia",
                LastName = "Lee",
                DateOfBirth = new DateTime(1988, 5, 25),
                PhoneNumber = "+998900000031",
                Email = "sophidalee@school.com",
                Password = "hashed_password",
                Biography = "Passionate teacher specializing in German language.",
                DistrictName = "Shahriston",
                SchoolNumber = 3,
                ScienceType = ScienceType.GermanLanguage,
                genderType = GenderType.Female
            };

            yield return new Teacher
            {
                Id = 32,
                CreatedAt = DateTime.UtcNow,
                FirstName = "Sophia",
                LastName = "Lee",
                DateOfBirth = new DateTime(1988, 5, 25),
                PhoneNumber = "+998900000032",
                Email = "sophsdidalee@school.com",
                Password = "hashed_password",
                Biography = "Passionate teacher specializing in German language.",
                DistrictName = "Shahriston",
                SchoolNumber = 3,
                ScienceType = ScienceType.GermanLanguage,
                genderType = GenderType.Female
            };
        }
    }
}
