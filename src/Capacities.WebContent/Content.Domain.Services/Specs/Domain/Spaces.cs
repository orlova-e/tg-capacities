using Content.Domain.Core.Entities;

namespace Content.Domain.Services.Specs.Domain;

public class Spaces
{
    public static Spec<Space> ByName(string name) => new(x => x.Name == name);
}