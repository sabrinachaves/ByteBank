using bytebank.Titular;
using System;

namespace bytebank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        private string _conta;
        public string Conta 
        { 
            get
            {
                return _conta;
            }
            set
            {
                if(value == null)
                {
                    return;
                }
                else
                {
                    _conta = value;
                }
            }
        }


        private int _numero_agencia;
        public int Numero_agencia 
        {
            get
            {
                return _numero_agencia;
            }
            set
            {
                if(_numero_agencia < 0)
                {
                    return;
                }
                else
                {
                    _numero_agencia = value;
                }
            } 
        }

        public string Nome_agencia { get; set; }

        private double saldo;
      
        //definindo uma propriedade
        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if(value < 0)
                {
                    return;
                }
                else
                {
                    saldo = value;
                }
            }
        }

        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                destino.saldo += valor;
                return true;
            }
        }

        public void StatusConta()
        {
            Console.WriteLine($"Titular: {Titular.Nome}");
            Console.WriteLine($"Conta: {Conta}");
            Console.WriteLine($"Número da agência: {Numero_agencia}");
            Console.WriteLine($"Nome da agência: {Nome_agencia}");
            Console.WriteLine($"Saldo: {Saldo}");
        }

        // A catacterística "static" define a propriedade para a classe e não para os objetos da classe
        public static int TotalDeContasCriadas { get; set; }

        public ContaCorrente(Cliente titular, string conta, int numero_agencia, string nome_agencia)
        {
            Titular = titular;
            Nome_agencia = nome_agencia;
            Numero_agencia = numero_agencia;
            Conta = conta;
            TotalDeContasCriadas++;
        }
    }
}