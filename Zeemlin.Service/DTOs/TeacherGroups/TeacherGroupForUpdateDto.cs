﻿using Zeemlin.Domain.Enums;

namespace Zeemlin.Service.DTOs.TeacherGroups;

public class TeacherGroupForUpdateDto
{
    public long TeacherId { get; set; }
    public long GroupId { get; set; }
    public TeacherRole Role { get; set; }
}
