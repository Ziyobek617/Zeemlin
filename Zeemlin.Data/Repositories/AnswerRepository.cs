using Zeemlin.Data.DbContexts;
using Zeemlin.Data.IRepositries;
using Zeemlin.Domain.Entities.Questions;

namespace Zeemlin.Data.Repositories;

public class AnswerRepository : Repository<Answer>, IAnswerRepository
{
    public AnswerRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}
