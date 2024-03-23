using System.ComponentModel.DataAnnotations;
using Zeemlin.Domain.Commons;

namespace Zeemlin.Domain.Entities;

public class LessonTable : Auditable
{
    [Required]
    public DateTime Date { get; set; } // Date of the lesson (including time)
    [Required, StringLength(100)]
    public string Title { get; set; } // Lesson title

    [Required]
    public long LessonId { get; set; }
    public Lesson Lesson { get; set; }

    [Required]
    public long TeacherId { get; set; }
    public Teacher Teacher { get; set; }

    [Required,StringLength(100)]
    public string Classroom { get; set; }
    public string? Notes { get; set; }
}

