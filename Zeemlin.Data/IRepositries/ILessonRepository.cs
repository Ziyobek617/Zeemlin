using Zeemlin.Domain.Entities;

namespace Zeemlin.Data.IRepositries;

public interface ILessonRepository : IRepository<Lesson>
{
    Task<IEnumerable<Lesson>> GetSubscribedLessonsAsync(long Id);
}
