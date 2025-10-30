namespace Content.Capacities.Api.Client.Configuration;

public class CapacitiesApiOptions
{
    public string BearerToken { get; init; }

    public long TimeoutInSec { get; init; }

    public string Host { get; init; }

    public string GetSpaces { get; init; }

    public string GetStructures { get; init; }

    public string SearchInSpaces { get; init; }
    
    public string PostToDailyNote { get; init; }
}