using System;
using System.Globalization;

namespace Banco
{
    class Cadastro
    {
        public int Conta { get; private set; }
        private string Nome { get; set; }
        public double DepositoInicial { get; private set; }

        public Cadastro(int conta, string nome)
        {
            Conta = conta;
            Nome = nome;
        }

        public Cadastro(int conta, string nome, double depositoInicial) : this(conta, nome) 
        {
            Conta = conta;
            Nome = nome;
            DepositoInicial = depositoInicial;
        }


        public void Adicionar(double quantity)
        {
            DepositoInicial += quantity;
        }

        public void Remover(double quantity)
        {
            DepositoInicial -= quantity + 5.00;
        }

        public double Saldo()
        {
            return DepositoInicial;
        }

        public override string ToString()
        {
            return "Conta " + Conta + ", Titutlar: " + Nome + ", Saldo: $" + Saldo().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
