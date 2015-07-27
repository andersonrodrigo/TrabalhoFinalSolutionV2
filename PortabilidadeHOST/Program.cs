using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Anatel;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;

namespace PortabilidadeHOST
{
    class Program
    {
        static void Main(string[] args)
        {

            Anatel.Anatel remotingService = new Anatel.Anatel();
            TcpChannel channel = new TcpChannel(8091);
            ChannelServices.RegisterChannel(channel);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Anatel.Anatel), "SolicitarPortabilidadeNumerica", WellKnownObjectMode.Singleton);

            Console.Write("Serviço Anatel iniciado @ "+DateTime.Now);
            Console.Read();

        }
    }
}
