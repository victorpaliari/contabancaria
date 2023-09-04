using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ContaBancaria.Model
{
    public abstract class Conta
    {
        private int numero;
        private int agencia;
        private int tipo;
        private string titular = string.Empty;
        private decimal saldo;

        //metodo construtor
        public Conta(int numero, int agencia, int tipo, string titular, decimal saldo)
        {
            this.numero = numero;
            this.agencia = agencia;
            this.tipo = tipo;
            this.titular = titular;
            this.saldo = saldo;
        }

        //Polimorfismo de sobrecarga = quando eu crio um método dentro da minha superclasse
      
        //Usa uma assinatura diferente do método, no caso abaixo está vazio, logo != da assinatura da superclasse
        //Método vazio = pode ser usado para fazer testes/validações

        //Métodos Get e Set
        public int GetNumero()
        {
            //mostrar numero da conta
            return numero;
        }

        public void SetNumero(int numero)
        {
            //alterar o numero da conta
            this.numero = numero;
        }

        public int GetAgencia()
        {
            //mostrar o numero da agencia
            return agencia;
        }

        public void SetAgencia(int agencia)
        {
            //alterar o numero da agencia
            this.agencia = agencia;
        }

        public int GetTipo()
        {
            return tipo;
        }

        public void SetTipo(int tipo)
        {
            this.tipo = tipo;
        }

        public string GetTitular()
        {
            return titular;
        }

        public void SetTitular(string titular)
        {
            this.titular = titular;
        }

        public decimal GetSaldo()
        {
            return saldo;
        }

        public void SetSaldo(decimal saldo)
        {
            this.saldo = saldo;
        }

        //O método Sacar() foi herdado daqui e sobreescrito em ContaCorrente = Polimorfismo de sobreescrita
        public virtual bool Sacar(decimal valor)
        {
            if (this.saldo < valor)
            {
                Console.WriteLine("Saldo insuficiente.");
                return false;
            }

            this.SetSaldo(this.saldo - valor);
            return true;
        }

        public void Depositar(decimal valor)
        {
            this.SetSaldo(this.saldo + valor);
        }
        
        public virtual void Visualizar()
        {
            string tipo = string.Empty;

            switch (this.tipo)
            {
                case 1: tipo = "Conta Corrente";
                    break;
                case 2:
                    tipo = "Conta poupança";
                    break;
            }
            Console.WriteLine("******************************************************");
            Console.WriteLine("Dados da conta");
            Console.WriteLine("******************************************************");
            Console.WriteLine($"Número da conta: {this.numero}");
            Console.WriteLine($"Número da agencia: {this.agencia}");
            Console.WriteLine($"tipo da conta: {tipo}");
            Console.WriteLine($"Titular da conta: {this.titular}");
            Console.WriteLine($"Saldo da conta: {this.saldo.ToString("C")}");
        }
    }
}
