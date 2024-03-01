using Zeemlin.Domain.Commons;
using Zeemlin.Domain.Entities.Assets;

namespace Zeemlin.Domain.Entities;

public class Homework : Auditable
{
    public string Title { get; set; } // Added
    public string Description { get; set; }
    public DateTime DueTime { get; set; }
    public long LessonId { get; set; } // Added
    public Lesson Lesson { get; set; } // Added
    public long ScienceId { get; set; }
    public Science Science { get; set; }
    public long GroupId { get; set; }
    public Group Group { get; set; }
    public long TeacherId { get; set; }
    public Teacher Teacher { get; set; }


    public ICollection<HomeworkAsset> Assets { get; set; }
}
