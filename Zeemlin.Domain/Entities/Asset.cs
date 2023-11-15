using Zeemlin.Domain.Commons;

namespace Zeemlin.Domain.Entities;

public class Asset : Auditable
{
    public string Path { get; set; }
}
