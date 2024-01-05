using System.Collections.Generic;
using Zeemlin.Domain.Commons;

namespace Zeemlin.Domain.Entities;

public class LessonTable : Auditable
{
    public DateTime GetDate { get; set; } // What day is the lesson? For example: Monday or Tuesday
    public string Title { get; set; } // Which science is written here

    public int GroupId { get; set; } // It is written here which group it belongs to
    public Group Group { get; set; }
    public int TeacherId { get; set; } // Write here which teacher will teach the group
    public Teacher Teacher { get; set; }

}
