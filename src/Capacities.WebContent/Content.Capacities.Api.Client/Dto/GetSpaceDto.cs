using Newtonsoft.Json;

namespace Content.Capacities.Api.Client.Dto;

public record GetSpaceDto
{
    [JsonProperty("id")]
    public Guid Id { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }
}