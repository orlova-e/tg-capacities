using Newtonsoft.Json;

namespace Content.Capacities.Api.Client.Dto;

public record PostDailyNoteDto
{
    [JsonProperty("spaceId")]
    public Guid SpaceId { get; set; }

    [JsonProperty("mdText")]
    public string Text { get; set; }

    [JsonProperty("origin")]
    public Origins Origin { get; set; } = Origins.CommandPalette;

    [JsonProperty("noTimeStamp")]
    public bool NoTimeStamp { get; set; } = true;
}