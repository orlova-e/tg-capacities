using System;
using Content.Domain.Core.Interfaces;

namespace Content.Domain.Core.Entities;

public class Space : IDomainEntity, IHistorical
{
    public Guid Id { get; }
    
    public bool IsDeleted { get; set; }
    
    public DateTime Created { get; set; }
    
    public DateTime? Updated { get; set; }
    
    public DateTime? Deleted { get; set; }
    
    public string Name { get; set; }

    public Guid CapacitiesId { get; set; }
}