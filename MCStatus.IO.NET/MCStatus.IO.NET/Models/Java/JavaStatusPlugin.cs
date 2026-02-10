using System.Text.Json.Serialization;

namespace MCStatus.IO.NET.Models.Java;

public sealed class JavaStatusPlugin
{
  [JsonPropertyName("name")]
  public string Name { get; set; } = "";

  [JsonPropertyName("version")]
  public string Version { get; set; } = "";
}
