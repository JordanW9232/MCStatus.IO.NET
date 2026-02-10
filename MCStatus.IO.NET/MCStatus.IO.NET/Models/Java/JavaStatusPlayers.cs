using System.Text.Json.Serialization;

namespace MCStatus.IO.NET.Models.Java;

public sealed class JavaStatusPlayers
{
  [JsonPropertyName("online")]
  public int Online { get; set; }

  [JsonPropertyName("max")]
  public int Max { get; set; }

  [JsonPropertyName("list")]
  public List<JavaStatusPlayer> List { get; set; } = new();
}
