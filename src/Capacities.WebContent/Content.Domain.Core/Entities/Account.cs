using System;
using Content.Domain.Core.Interfaces;

namespace Content.Domain.Core.Entities;

public sealed class Account : IDomainEntity, IHistorical
{
    public Guid Id { get; set; }
    
    public bool IsDeleted { get; set; }
    
    public DateTime Created { get; set; }
    
    public DateTime? Updated { get; set; }
    
    public DateTime? Deleted { get; set; }

    public long TelegramId { get; set; }

    public string CapacitiesToken { get; set; }

    public string Name { get; set; }
}