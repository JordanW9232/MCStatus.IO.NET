namespace MCStatus.IO.NET.Models;

public abstract class StatusOptions
{
  public string? BaseUrl { get; set; }
  public int? Timeout { get; set; }

  public virtual string AsQueryParams()
  {
    var queryParams = "";
    if (Timeout != null)
    {
      queryParams += QueryParamsSeparator(queryParams);
      queryParams += $"timeout={Timeout}";
    }

    return queryParams;
  }

  protected char QueryParamsSeparator(string queryParams)
  {
    return queryParams == "" ? '?' : '&';
  }
}
