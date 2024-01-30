using Zeemlin.Domain.Entities;
using Zeemlin.Domain.Enums;

namespace Zeemlin.Service.DTOs.Sciences;

public class ScienceForResultDto
{
    public long Id { get; set; }
    public ScienceType ScienceType { get; set; }
    public string Description { get; set; }
    //public ScienceTeacherForResultDto ScienceTeacher { get; set; }

}
