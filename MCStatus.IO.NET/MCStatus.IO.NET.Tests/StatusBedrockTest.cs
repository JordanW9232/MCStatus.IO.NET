namespace MCStatus.IO.NET.Tests;

public class StatusBedrockTest
{
  private const string Host = "demo.mcstatus.io";
  private const int Port = 19132;

  [Test]
  public async Task StatusBedrock()
  {
    var result = await MCStatusClient.StatusBedrock(Host, Port);

    // result.Host
    Assert.That(result.Host.Length, Is.GreaterThan(0));
    Assert.That(result.Host, Is.EqualTo(Host));

    // result.Port
    Assert.That(result.Port, Is.GreaterThanOrEqualTo(0));
    Assert.That(result.Port, Is.LessThanOrEqualTo(65535));
    Assert.That(result.Port, Is.EqualTo(Port));

    // result.IpAddress
    if (result.IpAddress != null)
    {
      Assert.That(result.IpAddress.Length, Is.GreaterThan(0));
    }

    // result.RetrievedAt
    Assert.That(result.RetrievedAt, Is.GreaterThan(0));

    // result.ExpiresAt
    Assert.That(result.ExpiresAt, Is.GreaterThan(0));
    Assert.That(result.ExpiresAt, Is.GreaterThan(result.RetrievedAt));

    if (result.Online)
    {
      // result.Version
      if (result.Version != null)
      {
        // result.Version.Name
        Assert.That(result.Version.Name.Length, Is.GreaterThan(0));
      }

      // result.Players
      Assert.That(result.Players, Is.Not.Null);

      // result.Players.Online
      Assert.That(result.Players.Online, Is.GreaterThanOrEqualTo(0));

      // result.Players.Max
      Assert.That(result.Players.Max, Is.GreaterThanOrEqualTo(0));

      // result.Motd
      Assert.That(result.Motd, Is.Not.Null);

      // result.Motd.Raw
      Assert.That(result.Motd.Raw.Length, Is.GreaterThanOrEqualTo(0));

      // result.Motd.Clean
      Assert.That(result.Motd.Clean.Length, Is.GreaterThanOrEqualTo(0));

      // result.Motd.Html
      Assert.That(result.Motd.Html.Length, Is.GreaterThanOrEqualTo(0));

      // result.Gamemode
      Assert.That(result.Gamemode, Is.Not.Null);
      Assert.That(result.Gamemode.Length, Is.GreaterThan(0));

      // result.ServerId
      Assert.That(result.ServerId, Is.Not.Null);
      Assert.That(result.ServerId.Length, Is.GreaterThan(0));

      // result.Edition
      Assert.That(result.Edition, Is.Not.Null);
      Assert.That(result.Edition, Is.AnyOf("MCPE", "MCEE"));
    }
  }
}
