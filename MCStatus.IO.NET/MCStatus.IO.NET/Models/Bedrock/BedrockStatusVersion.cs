using System.Text.Json.Serialization;

namespace MCStatus.IO.NET.Models.Bedrock;

public sealed class BedrockStatusVersion
{
  [JsonPropertyName("name")]
  public string Name { get; set; } = "";

  [JsonPropertyName("protocol")]
  public int Protocol { get; set; }
}
