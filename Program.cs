using System;

namespace ANALISADOR
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Criação do cliente
            Cliente cliente = new Cliente
            {
                nome = "João",
                estadoUF = "SE"
            };

            // Criação da conta bancária
            ContaBancaria conta = new ContaBancaria
            {
                saldo = 6000,
                titular = cliente
            };

            // Analisador de crédito
            AnalisadorCredito analisador = new AnalisadorCredito();
            int score = analisador.Calcular(conta);

            Console.WriteLine($"Score de crédito para {cliente.nome} ({cliente.estadoUF}): {score}");
        }
    }
}
