using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace Fullerene.Classes
{
    class Carbon
    {
        public Carbon(string CarbonServer,int CarbonPort)
        {
            using (TcpClient test = new TcpClient(hostname: CarbonServer, port: CarbonPort))
            {
                if (test.Connected)
                {
                    _server = CarbonServer;
                    _port = CarbonPort;
                }
                test.Close();
            }
        }
        private string _server { get; set; }
        private int _port { get; set; }
        public string Server
        {
            get
            {
                return _server;
            }
        }

        public int Port
        {
            get
            {
                return _port;
            }
        }

        public bool SendMetric(String Metric)
        {
            return false;
        }
    }
}
