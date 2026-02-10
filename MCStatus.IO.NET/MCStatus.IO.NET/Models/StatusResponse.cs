using System.Text.Json.Serialization;

namespace MCStatus.IO.NET.Models;

public abstract class StatusResponse
{
  [JsonPropertyName("online")]
  public bool Online { get; set; }

  [JsonPropertyName("host")]
  public string Host { get; set; } = "";

  [JsonPropertyName("port")]
  public int Port { get; set; }

  [JsonPropertyName("ip_address")]
  public string? IpAddress { get; set; }

  [JsonPropertyName("eula_blocked")]
  public bool EulaBlocked { get; set; }

  [JsonPropertyName("retrieved_at")]
  public long RetrievedAt { get; set; }

  [JsonPropertyName("expires_at")]
  public long ExpiresAt { get; set; }
}
