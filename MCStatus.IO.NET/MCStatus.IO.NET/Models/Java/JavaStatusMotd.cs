using System.Text.Json.Serialization;

namespace MCStatus.IO.NET.Models.Java;

public sealed class JavaStatusMotd
{
  [JsonPropertyName("raw")]
  public string Raw { get; set; } = "";

  [JsonPropertyName("clean")]
  public string Clean { get; set; } = "";

  [JsonPropertyName("html")]
  public string Html { get; set; } = "";
}
