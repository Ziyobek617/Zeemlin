﻿namespace Zeemlin.Service.DTOs.Events;

public class EventForPublicDto
{
    public long Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Orginizer { get; set; }
    public string EventType { get; set; }
    public string StartedAt { get; set; }
    public string EndDate { get; set; }
    public string Format { get; set; }
    public string Location { get; set; }
    public string Address { get; set; }
    public bool IsPaid { get; set; }
    public decimal? Price { get; set; }
    public string Contact { get; set; }
    public string? OfficialPage { get; set; } 
}

