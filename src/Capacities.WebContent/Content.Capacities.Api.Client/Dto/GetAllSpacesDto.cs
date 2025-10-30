using Newtonsoft.Json;

namespace Content.Capacities.Api.Client.Dto;

public record GetAllSpacesDto
{
    [JsonProperty("spaces")]
    public IEnumerable<GetSpaceDto> Spaces { get; set; }
}