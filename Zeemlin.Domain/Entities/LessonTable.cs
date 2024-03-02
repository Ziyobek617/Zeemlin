using System.Collections.Generic;
using Zeemlin.Domain.Commons;

namespace Zeemlin.Domain.Entities;

public class LessonTable : Auditable
{
    public DateTime GetDate { get; set; } // What day is the lesson? For example: Monday or Tuesday
    public string Title { get; set; } // Which science is written here

    public long LessonId { get; set; }
    public Lesson Lesson { get; set; }

}
