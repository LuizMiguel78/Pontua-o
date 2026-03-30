using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANALISADOR
{
    public class AnalisadorCredito
    {
        public int Calcular (ContaBancaria conta)
        {
            int score = 1000;

            if(conta.saldo > 5000)
            {
                score = score + 100;
            }

            if(conta.saldo < 0)
            {
                score = score - 200;
            }

            if(conta.titular.estadoUF == "SE")
            {
                score = score + 150;
            }

            if (conta.titular.nome.Length < 5)
            {
                score = score - 50;
            }

            if (conta.saldo == 0)
            {
                score = score - 100;
            }

            if (conta.saldo > 100000)
            {
                score = score + 300;
            }

            if (conta.titular.estadoUF == "BA" || conta.titular.estadoUF == "PE" || conta.titular.estadoUF == "AL" || conta.titular.estadoUF == "SE" || conta.titular.estadoUF == "CE" || conta.titular.estadoUF == "PB" || conta.titular.estadoUF == "PI" || conta.titular.estadoUF == "RN" )
            {
                score = score + 40;
            }

            if (conta.saldo >= 1 && conta.saldo <= 500)
            {
                score = score + 10;
            }

            return score;
        }
    }
}
