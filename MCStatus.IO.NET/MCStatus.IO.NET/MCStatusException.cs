namespace MCStatus.IO.NET;

public sealed class MCStatusException : Exception
{
  public MCStatusException()
  { }

  public MCStatusException(string? message)
    : base(message)
  { }

  public MCStatusException(string? message, Exception? innerException)
    : base(message, innerException)
  { }
}
