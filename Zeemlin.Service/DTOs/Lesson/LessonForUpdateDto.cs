﻿namespace Zeemlin.Service.DTOs.Lesson;

public class LessonForUpdateDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string StartDate { get; set; }
    public string EndDate { get; set; }
    public long GroupId { get; set; }
    public long TeacherId { get; set; }
}
