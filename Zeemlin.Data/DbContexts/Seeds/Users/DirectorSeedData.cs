using Zeemlin.Domain.Entities.Users;
using Zeemlin.Domain.Entities;
using Zeemlin.Domain.Enums;

namespace Zeemlin.Data.DbContexts.Seeds.Users;

public static class DirectorSeedData
{
    public static IEnumerable<Director> GetDirectors()
    {
        yield return new Director
        {
            Id = 1,
            Username = "director1",
            FirstName = "Olimjon", 
            LastName = "To'rayev", 
            Email = "olimjon.torayev@director.com",
            Password = "hashed_password", 
            Gender = GenderType.Male,
            PassportSeria = "AB123456",
            CreatedAt = DateTime.UtcNow,
            Schools = new List<School>() 
        };

        yield return new Director
        {
            Id = 2,
            Username = "director2",
            FirstName = "Nodira",
            LastName = "Xolmirzayeva",
            Email = "nodira.xolmirzayeva@director.com",
            Password = "hashed_password", 
            Gender = GenderType.Female,
            PassportSeria = "CD789012",
            CreatedAt = DateTime.UtcNow,
            Schools = new List<School>() 
        };

        yield return new Director
        {
            Id = 3,
            Username = "director3",
            FirstName = "Sarvar", 
            LastName = "Qosimov",
            Email = "sarvar.qosimov@director.com",
            Password = "hashed_password", 
            Gender = GenderType.Male,
            PassportSeria = "EF345678",
            CreatedAt = DateTime.UtcNow,
            Schools = new List<School>()
        };

        yield return new Director
        {
            Id = 4,
            Username = "director4",
            FirstName = "Malika", 
            LastName = "Azizova", 
            Email = "malika.azizova@director.com",
            Password = "hashed_password", 
            Gender = GenderType.Female,
            PassportSeria = "GH567890",
            CreatedAt = DateTime.UtcNow,
            Schools = new List<School>() 
        };

        yield return new Director
        {
            Id = 5,
            Username = "director5",
            FirstName = "Islom",
            LastName = "Karimov",
            Email = "islom.karimov@director.com",
            Password = "hashed_password",
            Gender = GenderType.Male,
            PassportSeria = "IJ789012",
            CreatedAt = DateTime.UtcNow,
            Schools = new List<School>() 
        };

        yield return new Director
        {
            Id = 6,
            Username = "director5",
            FirstName = "mcpw",
            LastName = "cmla",
            Email = "ikcmwopv@director.com",
            Password = "hashed_password",
            Gender = GenderType.Male,
            PassportSeria = "IJ785212",
            CreatedAt = DateTime.UtcNow,
            Schools = new List<School>()
        };
    }
}
