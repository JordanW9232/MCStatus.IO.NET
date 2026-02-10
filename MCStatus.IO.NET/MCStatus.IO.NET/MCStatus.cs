using System.Net;
using System.Text.Json;
using MCStatus.IO.NET.Models;
using MCStatus.IO.NET.Models.Bedrock;
using MCStatus.IO.NET.Models.Java;

namespace MCStatus.IO.NET;

public static class MCStatus
{
  public static Task<JavaStatusResponse> StatusJava(string host, int port = 25565, JavaStatusOptions? options = null, CancellationToken cancellationToken = default)
  {
    return Status<JavaStatusResponse, JavaStatusOptions>($"/status/java/{host}:{port}", options, cancellationToken);
  }

  public static Task<BedrockStatusResponse> StatusBedrock(string host, int port = 19132, BedrockStatusOptions? options = null, CancellationToken cancellationToken = default)
  {
    return Status<BedrockStatusResponse, BedrockStatusOptions>($"/status/bedrock/{host}:{port}", options, cancellationToken);
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
