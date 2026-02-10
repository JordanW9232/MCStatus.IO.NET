namespace MCStatus.IO.NET.Console;

public class Program
{
  public static async Task<int> Main(string[] args)
  {
    var status = await MCStatusClient.StatusJava("mc.hypixel.net");


    return Environment.ExitCode;
  }
}
