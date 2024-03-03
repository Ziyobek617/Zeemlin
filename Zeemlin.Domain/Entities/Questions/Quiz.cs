using System.ComponentModel.DataAnnotations;
using Zeemlin.Domain.Commons;

namespace Zeemlin.Domain.Entities.Questions;

public class Quiz : Auditable
{
    
    [Required]
    public string Title { get; set; }
    public string Description { get; set; }
    [Required]
    public string Subject { get; set; }
    public long SchoolId { get; set; }
    public School School { get; set; }


    public ICollection<Question> Questions { get; set; }
}
