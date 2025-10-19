using Newtonsoft.Json;

namespace Capacities.Api.Client.Dto;

public record GetAllSearchDto
{
    [JsonProperty("results")]
    public IEnumerable<Result> Results { get; set; }
}

public record Result
{
    [JsonProperty("id")]
    public string Id { get; set; }
    
    [JsonProperty("spaceId")]
    public string SpaceId { get; set; }
    
    [JsonProperty("structureId")]
    public string StructureId { get; set; }
    
    [JsonProperty("title")]
    public string Title { get; set; }
    
    [JsonProperty("highlights")]
    public IEnumerable<Highlight> Highlights { get; set; }
}

public record Highlight
{
    [JsonProperty("context")]
    public Context Context { get; set; }
    
    [JsonProperty("snippets")]
    public IEnumerable<string> Snippets { get; set; }
    
    [JsonProperty("score")]
    public int Score { get; set; }
}

public record Context
{
    [JsonProperty("field")]
    public string Field { get; set; }
}

