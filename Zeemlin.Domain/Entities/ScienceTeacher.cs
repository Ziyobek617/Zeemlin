using Zeemlin.Domain.Commons;

namespace Zeemlin.Domain.Entities;

public class ScienceTeacher : Auditable
{
    public long ScienceId { get; set; }
    public Science Science { get; set; }

    public long TeacherId { get; set; }
    public Teacher Teacher { get; set;}
}
