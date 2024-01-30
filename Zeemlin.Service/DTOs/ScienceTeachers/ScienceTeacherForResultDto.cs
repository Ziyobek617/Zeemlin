using Zeemlin.Service.DTOs.Sciences;
using Zeemlin.Service.DTOs.Teachers;

namespace Zeemlin.Service.DTOs.ScienceTeachers;

public class ScienceTeacherForResultDto
{
    public long Id { get; set; }
    public ScienceForResultDto ScienceForResultDto { get; set; }
    public TeacherForResultDto TeacherForResultDto { get; set; }
}
