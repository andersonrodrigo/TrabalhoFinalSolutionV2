using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ModeloCanonico;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;

namespace APT
{
    public class AptSevice: IAptService
    {
        public Portability SolicitarBilhetePortabilidade(Custumer custumer, Acount acount)
        {

            //[chamando o webservice do módulo Anatel]
            Anatel.IAnatel client;
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel);
            client = (Anatel.IAnatel)Activator.GetObject(typeof(Anatel.IAnatel), "tcp://localhost:8091/SolicitarPortabilidadeNumerica");

            //[obtendo resposta da Anatel para a portabilidade]
            RetornoPortabilidade retorno = client.SolicitarPortabilidadeNumerica(custumer);

            //[TODO gerar numero do bilhete]
            Portability portabilidade = new Portability();
            portabilidade.Bilhete = "123456789";

            return portabilidade;
        }
    }
}