using System.Net;
using System.Text.Json;
using MCStatus.IO.NET.Models;
using MCStatus.IO.NET.Models.Bedrock;
using MCStatus.IO.NET.Models.Java;

namespace MCStatus.IO.NET;

public static class MCStatusClient
{
  public static Task<JavaStatusResponse> StatusJava(string host, int port = MCStatusConstants.DefaultJavaPort, JavaStatusOptions? options = null, CancellationToken cancellationToken = default)
  {
    return Status<JavaStatusResponse, JavaStatusOptions>($"/status/java/{host}:{port}", options, cancellationToken);
  }

  public static Task<JavaStatusResponse> StatusJava(string host, JavaStatusOptions? options = null, CancellationToken cancellationToken = default)
  {
    return StatusJava(host, MCStatusConstants.DefaultJavaPort, options, cancellationToken);
  }

  public static Task<JavaStatusResponse> StatusJava(string host, CancellationToken cancellationToken = default)
  {
    return StatusJava(host, MCStatusConstants.DefaultJavaPort, null, cancellationToken);
  }

  public static Task<BedrockStatusResponse> StatusBedrock(string host, int port = MCStatusConstants.DefaultBedrockPort, BedrockStatusOptions? options = null, CancellationToken cancellationToken = default)
  {
    return Status<BedrockStatusResponse, BedrockStatusOptions>($"/status/bedrock/{host}:{port}", options, cancellationToken);
  }

  public static Task<BedrockStatusResponse> StatusBedrock(string host, BedrockStatusOptions? options = null, CancellationToken cancellationToken = default)
  {
    return StatusBedrock(host, MCStatusConstants.DefaultBedrockPort, options, cancellationToken);
  }

  public static Task<BedrockStatusResponse> StatusBedrock(string host, CancellationToken cancellationToken = default)
  {
    return StatusBedrock(host, MCStatusConstants.DefaultBedrockPort, null, cancellationToken);
  }

  private static async Task<T> Status<T, TOptions>(string url, TOptions? options = null, CancellationToken cancellationToken = default) where TOptions : StatusOptions
  {
    using var client = new HttpClient();
    client.BaseAddress = new Uri(options?.BaseUrl ?? MCStatusConstants.BaseUrl);

    if (options != null)
    {
      url += options.AsQueryParams();
    }

    var response = await client.GetAsync(url, cancellationToken);
    var content = await response.Content.ReadAsStringAsync(cancellationToken);

    if (response.StatusCode != HttpStatusCode.OK)
    {
      throw new MCStatusException(content);
    }

    return JsonSerializer.Deserialize<T>(content)!;
  }
}
