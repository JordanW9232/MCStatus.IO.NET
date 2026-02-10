using System.Text.Json.Serialization;

namespace MCStatus.IO.NET.Models.Bedrock;

public sealed class BedrockStatusResponse : StatusResponse
{
  [JsonPropertyName("version")]
  public BedrockStatusVersion? Version { get; set; }

  [JsonPropertyName("players")]
  public BedrockStatusPlayers? Players { get; set; }

  [JsonPropertyName("motd")]
  public BedrockStatusMotd? Motd { get; set; }

  [JsonPropertyName("gamemode")]
  public string? Gamemode { get; set; }

  [JsonPropertyName("server_id")]
  public string? ServerId { get; set; }

  [JsonPropertyName("edition")]
  public string? Edition { get; set; }
}
