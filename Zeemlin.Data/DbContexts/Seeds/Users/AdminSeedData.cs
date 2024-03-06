using Zeemlin.Domain.Entities.Users;
using Zeemlin.Domain.Enums;

namespace Zeemlin.Data.DbContexts.Seeds.Users;

public static class AdminSeedData
{
    public static IEnumerable<Admin> GetAdmins()
    {
        yield return new Admin
        {
            Id = 1,
            CreatedAt = DateTime.Now,
            Username = "admin1_school1",
            FirstName = "John",
            LastName = "Doe",
            Email = "johndoe@admin1.com",
            Password = "hashed_password",
            Gender = GenderType.Male,
            PassportSeria = "AB123456",
            SchoolId = 1
        };

        yield return new Admin
        {
            Id = 2,
            CreatedAt = DateTime.Now,
            Username = "admin2_school1",
            FirstName = "Jane",
            LastName = "Smith",
            Email = "janesmith@admin2.com",
            Password = "hashed_password", 
            Gender = GenderType.Female,
            PassportSeria = "CD789012",
            SchoolId = 1 
        };

        yield return new Admin
        {
            Id = 3,
            CreatedAt = DateTime.Now,
            Username = "admin1_school2",
            FirstName = "Michael",
            LastName = "Johnson",
            Email = "michaeljohnson@admin1.com",
            Password = "hashed_password",
            Gender = GenderType.Male,
            PassportSeria = "EF345678",
            SchoolId = 2
        };

        yield return new Admin
        {
            Id = 4,
            CreatedAt = DateTime.Now,
            Username = "admin2_school2",
            FirstName = "Emma",
            LastName = "Davis",
            Email = "emmadavis@admin2.com",
            Password = "hashed_password",
            Gender = GenderType.Female,
            PassportSeria = "GH901234",
            SchoolId = 2
        };

        yield return new Admin
        {
            Id = 5,
            CreatedAt = DateTime.Now,
            Username = "admin1_school3",
            FirstName = "William",
            LastName = "Brown",
            Email = "williambrown@admin1.com",
            Password = "hashed_password",
            Gender = GenderType.Male,
            PassportSeria = "IJ567890",
            SchoolId = 3
        };

        yield return new Admin
        {
            Id = 6,
            CreatedAt = DateTime.Now,
            Username = "admin2_school3",
            FirstName = "Olivia",
            LastName = "Taylor",
            Email = "oliviataylor@admin2.com",
            Password = "hashed_password",
            Gender = GenderType.Female,
            PassportSeria = "KL123456",
            SchoolId = 3
        };

        yield return new Admin
        {
            Id = 7,
            CreatedAt = DateTime.Now,
            Username = "admin1_school4",
            FirstName = "David",
            LastName = "Wilson",
            Email = "davidwilson@admin1.com",
            Password = "hashed_password",
            Gender = GenderType.Male,
            PassportSeria = "MN789012",
            SchoolId = 4
        };

        yield return new Admin
        {
            Id = 8,
            CreatedAt = DateTime.Now,
            Username = "admin2_school4",
            FirstName = "Sophia",
            LastName = "Martinez",
            Email = "sophiamartinez@admin2.com",
            Password = "hashed_password",
            Gender = GenderType.Female,
            PassportSeria = "OP345678",
            SchoolId = 4
        };

        yield return new Admin
        {
            Id = 9,
            CreatedAt = DateTime.Now,
            Username = "admin1_school5",
            FirstName = "James",
            LastName = "Anderson",
            Email = "jamesanderson@admin1.com",
            Password = "hashed_password",
            Gender = GenderType.Male,
            PassportSeria = "QR901234",
            SchoolId = 5
        };

        yield return new Admin
        {
            Id = 10,
            CreatedAt = DateTime.Now,
            Username = "admin2_school5",
            FirstName = "Ava",
            LastName = "Hernandez",
            Email = "avahernandez@admin2.com",
            Password = "hashed_password",
            Gender = GenderType.Female,
            PassportSeria = "ST567890",
            SchoolId = 5
        };

        yield return new Admin
        {
            Id = 11,
            CreatedAt = DateTime.Now,
            Username = "admin1_school6",
            FirstName = "Benjamin",
            LastName = "Young",
            Email = "benjaminyoung@admin1.com",
            Password = "hashed_password",
            Gender = GenderType.Male,
            PassportSeria = "UV123456",
            SchoolId = 6
        };

        yield return new Admin
        {
            Id = 12,
            CreatedAt = DateTime.Now,
            Username = "admin2_school6",
            FirstName = "Mia",
            LastName = "Lopez",
            Email = "mialopez@admin2.com",
            Password = "hashed_password",
            Gender = GenderType.Female,
            PassportSeria = "WX789012",
            SchoolId = 6
        };

        yield return new Admin
        {
            Id = 13,
            CreatedAt = DateTime.Now,
            Username = "admin1_school7",
            FirstName = "Daniel",
            LastName = "Gonzalez",
            Email = "danielgonzalez@admin1.com",
            Password = "hashed_password",
            Gender = GenderType.Male,
            PassportSeria = "YZ345678",
            SchoolId = 7
        };

        yield return new Admin
        {
            Id = 14,
            CreatedAt = DateTime.Now,
            Username = "admin2_school7",
            FirstName = "Isabella",
            LastName = "Perez",
            Email = "isabellaperez@admin2.com",
            Password = "hashed_password",
            Gender = GenderType.Female,
            PassportSeria = "AB901234",
            SchoolId = 7
        };

        yield return new Admin
        {
            Id = 15,
            CreatedAt = DateTime.Now,
            Username = "admin1_school4",
            FirstName = "Islom",
            LastName = "Karimov",
            Email = "islom.karimov@admin1.com",
            Password = "hashed_password", 
            Gender = GenderType.Male,
            PassportSeria = "MN567890",
            SchoolId = 8 
        };

        yield return new Admin
        {
            Id = 16,
            CreatedAt = DateTime.Now,
            Username = "admin2_school4",
            FirstName = "Nozima",
            LastName = "Yo'ldosheva",
            Email = "noziman.yoldosheva@admin2.com",
            Password = "hashed_password",
            Gender = GenderType.Female,
            PassportSeria = "OP123456",
            SchoolId = 8 
        };

        yield return new Admin
        {
            Id = 17,
            CreatedAt = DateTime.Now,
            Username = "admin1_school9",
            FirstName = "Ethan",
            LastName = "Moore",
            Email = "ethanmoore@admin1.com",
            Password = "hashed_password",
            Gender = GenderType.Male,
            PassportSeria = "CD901234",
            SchoolId = 9
        };

        yield return new Admin
        {
            Id = 18,
            CreatedAt = DateTime.Now,
            Username = "admin2_school9",
            FirstName = "Charlotte",
            LastName = "Rogers",
            Email = "charlotterogers@admin2.com",
            Password = "hashed_password",
            Gender = GenderType.Female,
            PassportSeria = "EF567890",
            SchoolId = 9
        };

        yield return new Admin
        {
            Id = 19,
            CreatedAt = DateTime.Now,
            Username = "admin1_school10",
            FirstName = "Alexander",
            LastName = "Scott",
            Email = "alexanderscott@admin1.com",
            Password = "hashed_password",
            Gender = GenderType.Male,
            PassportSeria = "GH123456",
            SchoolId = 10
        };

        yield return new Admin
        {
            Id = 20,
            CreatedAt = DateTime.Now,
            Username = "admin2_school10",
            FirstName = "Amelia",
            LastName = "Gomez",
            Email = "ameliagomez@admin2.com",
            Password = "hashed_password",
            Gender = GenderType.Female,
            PassportSeria = "IJ789012",
            SchoolId = 10
        };

        yield return new Admin
        {
            Id = 21,
            CreatedAt = DateTime.Now,
            Username = "admin1_school11",
            FirstName = "Henry",
            LastName = "Wright",
            Email = "henrywright@admin1.com",
            Password = "hashed_password",
            Gender = GenderType.Male,
            PassportSeria = "KL345678",
            SchoolId = 11
        };

        yield return new Admin
        {
            Id = 22,
            CreatedAt = DateTime.Now,
            Username = "admin2_school11",
            FirstName = "Sophie",
            LastName = "Flores",
            Email = "sophieflores@admin2.com",
            Password = "hashed_password",
            Gender = GenderType.Female,
            PassportSeria = "MN901234",
            SchoolId = 11
        };

        yield return new Admin
        {
            Id = 23,
            CreatedAt = DateTime.Now,
            Username = "admin1_school12",
            FirstName = "Liam",
            LastName = "Sanchez",
            Email = "liamsanchez@admin1.com",
            Password = "hashed_password",
            Gender = GenderType.Male,
            PassportSeria = "OP567890",
            SchoolId = 12
        };

        yield return new Admin
        {
            Id = 24,
            CreatedAt = DateTime.Now,
            Username = "admin2_school12",
            FirstName = "Grace",
            LastName = "Chang",
            Email = "gracechang@admin2.com",
            Password = "hashed_password",
            Gender = GenderType.Female,
            PassportSeria = "QR123456",
            SchoolId = 12
        };

    }
}
