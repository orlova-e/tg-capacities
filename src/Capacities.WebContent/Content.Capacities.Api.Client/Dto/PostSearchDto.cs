using Newtonsoft.Json;

namespace Content.Capacities.Api.Client.Dto;

public record PostSearchDto
{
    [JsonProperty("mode")]
    public string Mode { get; set; } = "fullText";

    [JsonProperty("searchTerm")]
    public string SearchTerm { get; set; } = "Artificial Intelligence";
    
    [JsonProperty("spaceIds")]
    public IEnumerable<string> SpaceIds { get; set; }

    [JsonProperty("filterStructureIds")]
    public IEnumerable<string> FilterStructureIds { get; set; } = new List<string>();
}

