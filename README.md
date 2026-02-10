# MCStatus.IO.NET
An unofficial .NET library for interacting with the [mcstatus.io](https://mcstatus.io) API.

## Usage

### Java Status

```csharp
var host = "demo.mcstatus.io";
var port = 25565;
var options = new JavaStatusOptions()
{
  Query = true
};

// The `port` argument is optional and defaults
// to 25565. The `options` and `cancellationToken`
// arguments are optional.
try
{
  var result = await MCStatusClient.StatusJava(host, port, options);
  // `result` will be the same shape and 
  // properties as what is documented on
  // our website.
  // https://mcstatus.io/docs#java-status
}
catch (Exception ex)
{
  // If the server is offline, then
  // you will NOT receive an error here.
  // Instead, you will use the `result.Online`
  // boolean values in `try`.
  // Receiving an error here means that there
  // was an error with the service itself.
}
```

### Bedrock Status

```csharp
var host = "demo.mcstatus.io";
var port = 19132;

// The `port` argument is optional and defaults
// to 19132. The `options` and `cancellationToken`
// arguments are optional.
try
{
  var result = await MCStatusClient.StatusBedrock(host, port, options);
  // `result` will be the same shape and 
  // properties as what is documented on
  // our website.
  // https://mcstatus.io/docs#bedrock-status
}
catch (Exception ex)
{
  // If the server is offline, then
  // you will NOT receive an error here.
  // Instead, you will use the `result.Online`
  // boolean values in `try`.
  // Receiving an error here means that there
  // was an error with the service itself.
}
```

## License
[MIT License](https://github.com/JordanW9232/MCStatus.IO.NET/blob/main/LICENSE)
