namespace Zeemlin.Domain.Enums.Events;

public enum EventStatus : short
{
    Approved = 1,
    Rejected,
    Cancelled,
    Completed,
    InProcess
}
