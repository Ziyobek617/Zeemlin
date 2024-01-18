
using Zeemlin.Domain.Entities;

namespace Zeemlin.Service.DTOs.Group;

public class GroupForCreationDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public long TeacherId { get; set; }

}
