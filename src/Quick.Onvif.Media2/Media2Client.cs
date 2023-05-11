﻿using Quick.Onvif.Factorys;
using System.ServiceModel;

namespace Quick.Onvif.Media2
{
    public partial class Media2Client
    {
        public Media2Client(string url, string username, string password, HttpClientCredentialType clientCredentialType = HttpClientCredentialType.Digest)
            : base(
                  ClientFactory.GetClientFactory(url, clientCredentialType).Binding,
                  new EndpointAddress(url))
        {
            ClientFactory.GetClientFactory(url, clientCredentialType).InitClient(this, username, password);
        }
    }
}