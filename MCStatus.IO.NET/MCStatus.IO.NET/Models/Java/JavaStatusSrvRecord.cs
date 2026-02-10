using System.Text.Json.Serialization;

namespace MCStatus.IO.NET.Models.Java;

public sealed class JavaStatusSrvRecord
{
  [JsonPropertyName("host")]
  public string Host { get; set; } = "";

  [JsonPropertyName("port")]
  public int Port { get; set; }
}
