using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloCanonico
{
    
    public interface Custumer
    {
        String getNome();
        void setNome(String nome);
        float getConta();
        void setConta(float conta);
        float getSaldo();
        void setSaldo(float saldo);
    }
}
