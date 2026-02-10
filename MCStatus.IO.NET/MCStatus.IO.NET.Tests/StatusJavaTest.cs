namespace MCStatus.IO.NET.Tests;

public class StatusJavaTest
{
  private const string Host = "demo.mcstats.io";
  private const int Port = 25565;

  [Test]
  public async Task StatusJava()
  {
    var result = await MCStatus.StatusJava(Host, Port);

    // result.Host
    Assert.That(result.Host.Length, Is.GreaterThan(0));
    Assert.That(result.Host, Is.EqualTo(Host));

    // result.Port
    Assert.That(result.Port, Is.GreaterThanOrEqualTo(0));
    Assert.That(result.Port, Is.LessThanOrEqualTo(65535));
    Assert.That(result.Port, Is.EqualTo(Port));

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
        // result.Version.NameRaw
        Assert.That(result.Version.NameRaw.Length, Is.GreaterThan(0));

        // result.Version.NameClean
        Assert.That(result.Version.NameClean.Length, Is.GreaterThan(0));

        // result.Version.NameHtml
        Assert.That(result.Version.NameHtml.Length, Is.GreaterThan(0));
      }

      // result.Players
      Assert.That(result.Players, Is.Not.Null);

      // result.Players.Online
      Assert.That(result.Players.Online, Is.GreaterThanOrEqualTo(0));

      // result.Players.Max
      Assert.That(result.Players.Max, Is.GreaterThanOrEqualTo(0));

      // result.Players.List
      foreach (var player in result.Players.List)
      {
        // result.Players.List[i].Uuid
        Assert.That(player.Uuid.Length, Is.GreaterThanOrEqualTo(0));

        // result.Players.List[i].NameRaw
        Assert.That(player.NameRaw.Length, Is.GreaterThanOrEqualTo(0));

        // result.Players.List[i].NameClean
        Assert.That(player.NameClean.Length, Is.GreaterThanOrEqualTo(0));

        // result.Players.List[i].NameHtml
        Assert.That(player.NameHtml.Length, Is.GreaterThanOrEqualTo(0));
      }

      // result.Motd
      Assert.That(result.Motd, Is.Not.Null);

      // result.Motd.Raw
      Assert.That(result.Motd.Raw.Length, Is.GreaterThanOrEqualTo(0));

      // result.Motd.Clean
      Assert.That(result.Motd.Clean.Length, Is.GreaterThanOrEqualTo(0));

      // result.Motd.Html
      Assert.That(result.Motd.Html.Length, Is.GreaterThanOrEqualTo(0));

      // result.Icon
      if (result.Icon != null)
      {
        Assert.That(result.Icon.Length, Is.GreaterThan(0));
        Assert.That(result.Icon.StartsWith("data:image/png;base64,"), Is.True);
      }

      // result.Mods
      Assert.That(result.Mods, Is.Not.Null);
      foreach (var mod in result.Mods)
      {
        // result.Mods[i].Name
        Assert.That(mod.Name.Length, Is.GreaterThan(0));

        // result.Mods[i].Version
        Assert.That(mod.Version.Length, Is.GreaterThan(0));
      }

      // result.Software
      if (result.Software != null)
      {
        Assert.That(result.Software.Length, Is.GreaterThan(0));
      }

      // result.Plugins
      Assert.That(result.Plugins, Is.Not.Null);
      foreach (var plugin in result.Plugins)
      {
        // result.Plugins[i].Name
        Assert.That(plugin.Name.Length, Is.GreaterThan(0));

        // result.Plugins[i].Version
        Assert.That(plugin.Version.Length, Is.GreaterThan(0));
      }
    }

    // result.SrvRecord
    if (result.SrvRecord != null)
    {
      // result.SrvRecord.Host
      Assert.That(result.SrvRecord.Host.Length, Is.GreaterThan(0));

      // result.SrvRecord.Port
      Assert.That(result.SrvRecord.Port, Is.GreaterThanOrEqualTo(0));
      Assert.That(result.SrvRecord.Port, Is.LessThanOrEqualTo(65535));
      Assert.That(result.SrvRecord.Port, Is.EqualTo(Port));
    }
  }
}
