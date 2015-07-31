using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ModeloCanonico;

namespace KGB
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class KgbService : MarshalByRefObject, ModeloCanonico.Custumer
    {

        string nome;
        float conta;
        float saldo;
        public string getNome()
        {
            return nome;
        }

        public Boolean obterStatusFinanceiroCliente(float valorASerTestado)
        {
            if (valorASerTestado <= saldo)
                return true;
            else
                return false;
        }
        public float obterDadosConta()
        {
            return saldo;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public float getConta()
        {
            return conta;
        }

        public void setConta(float conta)
        {
            this.conta = conta;
        }

        public float getSaldo()
        {
            return saldo;
        }

        public void setSaldo(float saldo)
        {
            this.saldo = saldo;
        }
    }
}