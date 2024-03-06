using Zeemlin.Domain.Entities.Users;
using Zeemlin.Domain.Enums;

namespace Zeemlin.Data.DbContexts.Seeds.Users;

public class SuperAdminSeedData
{
    public static IEnumerable<SuperAdmin> GetSuperAdmins()
    {
        yield return new SuperAdmin
        {
            Id = 1,
            Username = "superadmin1",
            FirstName = "Shahnoza",
            LastName = "Odilova",
            Email = "shahnozaodilova@gmail.com",
            Password = "hashed_password", // Replace with actual hashed password
            Gender = GenderType.Female,
            PassportSeria = "AB123456",
            CreatedAt = DateTime.UtcNow,
        };

        yield return new SuperAdmin
        {
            Id = 2,
            Username = "superadmin2",
            FirstName = "Moxinur",
            LastName = "Zokirova",
            Email = "moxi05@gmail.com",
            Password = "hashed_password", // Replace with actual hashed password
            Gender = GenderType.Female,
            PassportSeria = "CD789012",
            CreatedAt = DateTime.UtcNow,
        };
        yield return new SuperAdmin
        {
            Id = 3,
            Username = "superadmin3",
            FirstName = "Muhammadjon",
            LastName = "Akbarov",
            Email = "akbarov@gmail.com",
            Password = "hashed_password", // Replace with actual hashed password
            Gender = GenderType.Male,
            PassportSeria = "AB123458",
            CreatedAt = DateTime.UtcNow,
        };

        yield return new SuperAdmin
        {
            Id = 4,
            Username = "superadmin4",
            FirstName = "Ruxshona",
            LastName = "Nodirova",
            Email = "ruxshona0@gmail.com",
            Password = "hashed_password", // Replace with actual hashed password
            Gender = GenderType.Female,
            PassportSeria = "CD789013",
            CreatedAt = DateTime.UtcNow,
        };

        // ... Add 8 more SuperAdmin seed data instances here ...
    }

}
