using System.ComponentModel.DataAnnotations;
using Zeemlin.Domain.Enums;

namespace Zeemlin.Service.DTOs.Sciences;

public class ScienceForCreationDto
{
    [Required]
    public ScienceType ScienceType { get; set; }
    public string Description { get; set; }
}
