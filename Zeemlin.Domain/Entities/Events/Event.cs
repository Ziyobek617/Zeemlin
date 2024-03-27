using System.ComponentModel.DataAnnotations;
using Zeemlin.Domain.Commons;
using Zeemlin.Domain.Entities.Assets;
using Zeemlin.Domain.Enums.Events;

namespace Zeemlin.Domain.Entities.Events;

public class Event : Auditable
{
    [Required]
    public string Title { get; set; }
    public string Description { get; set; }
    [Required]
    public string Orginizer { get; set; }
    public EventType EventType { get; set; }
    public DateTime StartedAt { get; set; }
    public DateTime EndDate {  get; set; } 
    public EventFormat Format { get; set; }
    public EventStatus Status { get; set; }
    [Required]
    public string Location { get; set; }
    public string Address { get; set; }
    public bool IsPaid { get; set; }
    public decimal? Price { get; set; }
    [Required]
    public string Contact { get; set; }
    public string? OfficialPage { get; set; }
    public string CreatedByUsername { get; set; }


    public long? UpdaterId { get; set; }
    public long? EventAssetId {  get; set; }
    public EventAsset? EventAsset { get; set; }
}
