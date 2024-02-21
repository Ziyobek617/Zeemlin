namespace Zeemlin.Service.DTOs.Events.EventRegistrations;

public class EventRegistrationResultDto
{
    public long Id { get; set; }

    public long EventId { get; set; }
    public string EventTitle { get; set; } 

    // Participant information:
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Role { get; set; }
    public string Interests { get; set; }
    public DateTime RegistrationDate { get; set; }
}
