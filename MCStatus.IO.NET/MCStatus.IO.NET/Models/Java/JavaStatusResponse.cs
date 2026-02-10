using System.Text.Json.Serialization;

namespace MCStatus.IO.NET.Models.Java;

public sealed class JavaStatusResponse : StatusResponse
{
  [JsonPropertyName("version")]
  public JavaStatusVersion? Version { get; set; }

  [JsonPropertyName("players")]
  public JavaStatusPlayers? Players { get; set; }

  [JsonPropertyName("motd")]
  public JavaStatusMotd? Motd { get; set; }

  [JsonPropertyName("icon")]
  public string? Icon { get; set; }

  [JsonPropertyName("mods")]
  public List<JavaStatusMod>? Mods { get; set; }

  [JsonPropertyName("plugins")]
  public List<JavaStatusPlugin>? Plugins { get; set; }

  [JsonPropertyName("software")]
  public string? Software { get; set; }

  [JsonPropertyName("srv_record")]
  public JavaStatusSrvRecord? SrvRecord { get; set; }
}
