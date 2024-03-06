﻿using Zeemlin.Domain.Entities;
using Zeemlin.Domain.Enums;

namespace Zeemlin.Data.DbContexts.Seeds.Schools;

public class SchoolSeedData
{
    public static IEnumerable<School> GetSchools()
    {
        yield return new School
        {
            Id = 1,
            CreatedAt = DateTime.Now, // Set current time as CreatedAt
            SchoolNumber = 12345,
            Name = "Toshkent Xalqaro Maktabi",
            Description = "Xalqaro standartlarga asoslangan innovatsion ta'lim muassasasi",
            DirectorId = 1, // Assuming you have a Director with ID 1
            Country = "O'zbekiston",
            Region = Region.TashkentCity,
            DistrictName = "Mirzo Ulug'bek",
            GeneralAddressMFY = "Uch Qahramon MFY",
            StreetName = "Bog'ishamol ko'chasi",
            CallCenter = "+998900000001",
            EmailCenter = "TXM@school.com",
            Website = "TXM.com"
        };

        yield return new School
        {
            Id = 2,
            CreatedAt = DateTime.Now,
            SchoolNumber = 54321,
            Name = "Samarqand Texnologiya Instituti",
            Description = "Yuqori malakali mutaxassislar tayyorlaydigan oliy ta'lim muassasasi",
            DirectorId = 2, // Assuming you have a Director with ID 2
            Country = "O'zbekiston",
            Region = Region.Samarkand,
            DistrictName = "Eskishahar",
            GeneralAddressMFY = "Xo'ja Ahror Vali MFY",
            StreetName = "Registon ko'chasi",
            CallCenter = "+998900000002",
            EmailCenter = "STI@school.com",
            Website = "STI.com"
           
        };

        yield return new School
        {
            Id = 3,
            CreatedAt = DateTime.Now,
            SchoolNumber = 67890,
            Name = "Andijon Pedagogika Instituti",
            Description = "Pedagogika sohasida yuqori malakali mutaxassislar tayyorlaydigan oliy ta'lim muassasasi",
            DirectorId = 3,
            Country = "O'zbekiston",
            Region = Region.Andijan,
            DistrictName = "Shahriston",
            GeneralAddressMFY = "Pedagogika instituti",
            StreetName = "Pedagogika ko'chasi",
            CallCenter = "+998900000003",
            EmailCenter = "API@school.com",
            Website = "API.com"
        };

        yield return new School
        {
            Id = 4,
            CreatedAt = DateTime.Now,
            SchoolNumber = 98765,
            Name = "Namangan Davlat Universiteti",
            Description = "Oliy ta'lim sohasida yuqori malakali mutaxassislar tayyorlaydigan davlat universiteti",
            DirectorId = 4,
            Country = "O'zbekiston",
            Region = Region.Namangan,
            DistrictName = "Namangan shahri",
            GeneralAddressMFY = "Universitet",
            StreetName = "Universitet ko'chasi",
            CallCenter = "+998900000004",
            EmailCenter = "NDU@school.com",
            Website = "NDU.com"
        };

        yield return new School
        {
            Id = 5,
            CreatedAt = DateTime.Now,
            SchoolNumber = 13579,
            Name = "Tashkent Language Training Center",
            Description = "Center providing language training services.",
            DirectorId = 3,
            Country = "Uzbekistan",
            Region = Region.Tashkent,
            DistrictName = "Yunusabad",
            GeneralAddressMFY = "Language Training Center",
            StreetName = "Language Street",
            CallCenter = "+998900000013",
            EmailCenter = "info@tltraining.com",
            Website = "https://tltraining.com"
        };

        yield return new School
        {
            Id = 6,
            CreatedAt = DateTime.Now,
            SchoolNumber = 24680,
            Name = "Samarkand Computer Training Center",
            Description = "Center offering computer training courses.",
            DirectorId = 4,
            Country = "Uzbekistan",
            Region = Region.Samarkand,
            DistrictName = "Samarqand shahri",
            GeneralAddressMFY = "Computer Training Center",
            StreetName = "Computer Street",
            CallCenter = "+998900000014",
            EmailCenter = "info@sctc.uz",
            Website = "https://sctc.uz"
        };

        yield return new School
        {
            Id = 7,
            CreatedAt = DateTime.Now,
            SchoolNumber = 35791,
            Name = "Navoiy Fitness Training Center",
            Description = "Fitness center offering various training programs.",
            DirectorId = 1,
            Country = "Uzbekistan",
            Region = Region.Navoiy,
            DistrictName = "Navoiy shahri",
            GeneralAddressMFY = "Fitness Training Center",
            StreetName = "Fitness Street",
            CallCenter = "+998900000015",
            EmailCenter = "info@navfit.com",
            Website = "https://navfit.com"
        };

        yield return new School
        {
            Id = 8,
            CreatedAt = DateTime.Now,
            SchoolNumber = 46802,
            Name = "Surxondaryo Photography Training Center",
            Description = "Center specializing in photography training.",
            DirectorId = 2,
            Country = "Uzbekistan",
            Region = Region.Surxondaryo,
            DistrictName = "Termiz shahri",
            GeneralAddressMFY = "Photography Training Center",
            StreetName = "Photography Street",
            CallCenter = "+998900000016",
            EmailCenter = "info@sptc.uz",
            Website = "https://sptc.uz"
        };

        yield return new School
        {
            Id = 9,
            CreatedAt = DateTime.Now,
            SchoolNumber = 13579,
            Name = "Tashkent Language Training Center",
            Description = "Center providing language training services.",
            DirectorId = 3,
            Country = "Uzbekistan",
            Region = Region.Tashkent,
            DistrictName = "Yunusabad",
            GeneralAddressMFY = "Yunusabad MFY",
            StreetName = "Mustaqillik Avenue",
            CallCenter = "+998900000017",
            EmailCenter = "info@tltraining.com",
            Website = "https://tltraining.com"
        };

        yield return new School
        {
            Id = 10,
            CreatedAt = DateTime.Now,
            SchoolNumber = 24680,
            Name = "Samarkand Computer Training Center",
            Description = "Center offering computer training courses.",
            DirectorId = 4,
            Country = "Uzbekistan",
            Region = Region.Samarkand,
            DistrictName = "Samarqand shahri",
            GeneralAddressMFY = "Samarqand MFY",
            StreetName = "Amir Temur Street",
            CallCenter = "+998900000018",
            EmailCenter = "info@sctc.uz",
            Website = "https://sctc.uz"
        };

        yield return new School
        {
            Id = 11,
            CreatedAt = DateTime.Now,
            SchoolNumber = 35791,
            Name = "Navoiy Fitness Training Center",
            Description = "Fitness center offering various training programs.",
            DirectorId = 1,
            Country = "Uzbekistan",
            Region = Region.Navoiy,
            DistrictName = "Navoiy shahri",
            GeneralAddressMFY = "Navoiy MFY",
            StreetName = "Olmazor Street",
            CallCenter = "+998900000019",
            EmailCenter = "info@navfit.com",
            Website = "https://navfit.com"
        };

        yield return new School
        {
            Id = 12,
            CreatedAt = DateTime.Now,
            SchoolNumber = 46802,
            Name = "Surxondaryo Photography Training Center",
            Description = "Center specializing in photography training.",
            DirectorId = 5,
            Country = "Uzbekistan",
            Region = Region.Surxondaryo,
            DistrictName = "Termiz shahri",
            GeneralAddressMFY = "Termiz MFY",
            StreetName = "Shaxrisabz Street",
            CallCenter = "+998900000020",
            EmailCenter = "info@sptc.uz",
            Website = "https://sptc.uz"
        };

    }
}

