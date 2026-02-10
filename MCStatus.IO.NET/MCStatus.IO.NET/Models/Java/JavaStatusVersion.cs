using System.Text.Json.Serialization;

namespace MCStatus.IO.NET.Models.Java;

public sealed class JavaStatusVersion
{
  [JsonPropertyName("name_raw")]
  public string NameRaw { get; set; } = "";

  [JsonPropertyName("name_clean")]
  public string NameClean { get; set; } = "";

  [JsonPropertyName("name_html")]
  public string NameHtml { get; set; } = "";

  [JsonPropertyName("protocol")]
  public int Protocol { get; set; }
}
