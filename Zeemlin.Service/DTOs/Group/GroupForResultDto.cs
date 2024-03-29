﻿namespace Zeemlin.Service.DTOs.Group;

public class GroupForResultDto
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public long CourseId { get; set; }

    public ICollection<GroupDataResultDto> GroupData { get; set; }
    
}
