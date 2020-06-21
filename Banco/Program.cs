using System;
using System.Globalization;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            Cadastro cadastro;

            Console.Write("Entre com o numero da conta: ");
            int conta = int.Parse(Console.ReadLine(), CI);
            Console.Write("Entre com o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Havera deposito inicial(S/N)? ");
            char escolha = char.Parse(Console.ReadLine());
            if (escolha == 's' || escolha == 'S') {
                Console.WriteLine("Entre com o valor do deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CI);
                cadastro = new Cadastro(conta, nome, depositoInicial);
            } 
            else
            {
                cadastro = new Cadastro(conta, nome);
            }

            

            Console.WriteLine();
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(cadastro);

            Console.WriteLine();
            Console.Write("Entre com um valor para deposito: ");
            double qte = double.Parse(Console.ReadLine(), CI);
            cadastro.Adicionar(qte);

            Console.WriteLine("Dados da Conta atualizados: ");
            Console.WriteLine(cadastro);

            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            qte = double.Parse(Console.ReadLine(), CI);
            cadastro.Remover(qte);

            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(cadastro);

        }
    }
}
