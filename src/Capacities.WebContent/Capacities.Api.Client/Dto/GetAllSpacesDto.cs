using Newtonsoft.Json;

namespace Capacities.Api.Client.Dto;

public record GetAllSpacesDto
{
    [JsonProperty("spaces")]
    public IEnumerable<GetSpaceDto> Spaces { get; set; }
}