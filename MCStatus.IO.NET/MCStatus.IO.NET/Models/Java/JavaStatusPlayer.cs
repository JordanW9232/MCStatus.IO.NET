using System.Text.Json.Serialization;

namespace MCStatus.IO.NET.Models.Java;

public sealed class JavaStatusPlayer
{
  [JsonPropertyName("uuid")]
  public string Uuid { get; set; } = "";

  [JsonPropertyName("name_raw")]
  public string NameRaw { get; set; } = "";

  [JsonPropertyName("name_clean")]
  public string NameClean { get; set; } = "";

  [JsonPropertyName("name_html")]
  public string NameHtml { get; set; } = "";
}
