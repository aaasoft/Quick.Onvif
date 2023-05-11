﻿using Quick.Onvif.Factorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Quick.Onvif.DeviceIO
{
    public partial class DeviceClient
    {
        public DeviceClient(string url, string username, string password, HttpClientCredentialType clientCredentialType = HttpClientCredentialType.Digest)
    : base(
          ClientFactory.GetClientFactory(url, clientCredentialType).Binding,
          new EndpointAddress(url))
        {
            ClientFactory.GetClientFactory(url, clientCredentialType).InitClient(this, username, password);
        }
    }
}
