﻿using Newtonsoft.Json;

var client = new Quick.Onvif.OnvifClient(new Quick.Onvif.OnvifClientOptions()
{
    // HTTPS Url Example: https://127.0.0.1/onvif/device_service
    DeviceServiceAddress = "http://127.0.0.1/onvif/device_service",
    UserName = "admin",
    Password = "Bs123456"
});
Console.WriteLine("Connecting...");
await client.ConnectAsync();
Console.WriteLine("DeviceInformation: " + JsonConvert.SerializeObject(client.DeviceInformation, Formatting.Indented));

{
    var mediaClient = new Quick.Onvif.Media.MediaClient(client);
    var ret = await mediaClient.GetProfilesAsync();
    Console.WriteLine("Media Profiles: " + JsonConvert.SerializeObject(ret, Formatting.Indented));
}

{
    var mediaClient2 = new Quick.Onvif.Media2.Media2Client(client);
    var ret = mediaClient2.GetServiceCapabilitiesAsync();
    Console.WriteLine("Media2 ServiceCapabilities: " + JsonConvert.SerializeObject(ret, Formatting.Indented));
}