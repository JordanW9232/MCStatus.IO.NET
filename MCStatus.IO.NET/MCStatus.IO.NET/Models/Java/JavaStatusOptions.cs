namespace MCStatus.IO.NET.Models.Java;

public sealed class JavaStatusOptions : StatusOptions
{
  public bool? Query { get; set; }

  public override string AsQueryParams()
  {
    var queryParams = base.AsQueryParams();
    if (Query != null)
    {
      queryParams += QueryParamsSeparator(queryParams);
      queryParams += $"query={Query}";
    }

    return queryParams;
  }
}
