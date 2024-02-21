namespace Zeemlin.Service.DTOs.Events.EventRegistrations;

public class EventRegistrationCreationDto
{
    public long EventId { get; set; }

    // Participant information:
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Role { get; set; }
    public string Interests { get; set; }
}
