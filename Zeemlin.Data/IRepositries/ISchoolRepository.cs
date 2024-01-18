﻿using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.IRepositries;

public interface ISchoolRepository : IRepository<School>
{
    Task<bool> ExistsAsync(long schoolNumber);
}
