using System.Text.Json.Serialization;

namespace MCStatus.IO.NET.Models.Bedrock;

public sealed class BedrockStatusPlayers
{
  [JsonPropertyName("online")]
  public int Online { get; set; }

  [JsonPropertyName("max")]
  public int Max { get; set; }
}
