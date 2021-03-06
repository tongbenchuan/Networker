using System;

namespace Networker.Server
{
    public class ServerConfiguration
    {
        public ServerConfiguration()
        {
            this.IpAddresses = new[] {"localhost"};
            this.Advanced = new ServerConfigurationAdvanced();
        }

        public ServerConfigurationAdvanced Advanced { get; }

        public string[] IpAddresses { get; set; }
        public int TcpPort { get; set; }
        public int UdpPortLocal { get; set; }
        public int UdpPortRemote { get; set; }
        public bool UseTcp { get; set; }
        public bool UseUdp { get; set; }
    }
}