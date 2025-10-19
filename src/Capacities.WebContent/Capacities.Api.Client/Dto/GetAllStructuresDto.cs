using Newtonsoft.Json;

namespace Capacities.Api.Client.Dto;

public record GetAllStructuresDto
{
    [JsonProperty("structures")]
    public IEnumerable<Structure> Structures { get; set; }
}

public record Structure
{
    [JsonProperty("id")]
    public string Id { get; set; }
    
    [JsonProperty("title")]
    public string Title { get; set; }
    
    [JsonProperty("pluralName")]
    public string PluralName { get; set; }
    
    [JsonProperty("propertyDefinitions")]
    public IEnumerable<PropertyDefinition> PropertyDefinitions { get; set; }
    
    [JsonProperty("labelColor")]
    public string LabelColor { get; set; }
    
    [JsonProperty("collections")]
    public IEnumerable<Collection> Collections { get; set; }
}

public record PropertyDefinition
{
    [JsonProperty("id")]
    public string Id { get; set; }
    
    [JsonProperty("type")]
    public string Type { get; set; }
    
    [JsonProperty("dataType")]
    public string DataType { get; set; }
    
    [JsonProperty("name")]
    public string Name { get; set; }
}

public record Collection
{
    [JsonProperty("id")]
    public string Id { get; set; }
    
    [JsonProperty("title")]
    public string Title { get; set; }
}

