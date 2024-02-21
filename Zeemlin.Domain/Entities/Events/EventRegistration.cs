using Zeemlin.Domain.Commons;
using Zeemlin.Domain.Enums.Events;

namespace Zeemlin.Domain.Entities.Events
{
    public class EventRegistration : Auditable
    {
        public long EventId { get; set; }

        // Participant information:
        public string Name { get; set; } 
        public string Email { get; set; } 
        public string PhoneNumber { get; set; } 
        public string Role { get; set; } 
        public string Interests { get; set; } 
        public DateTime RegistrationDate { get; set; }
    }
}
