using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.Model
{
    public class ContaPoupanca : Conta
    {
        private int aniversario;
        public ContaPoupanca(int numero, int agencia, int tipo, string titular, decimal saldo, int aniversario)
            : base(numero, agencia, tipo, titular, saldo)
        {
            this.aniversario = aniversario;
        }

        public int GetAniversario()
        {
            return this.aniversario;
        }

        public void SetAniversario(int aniversario)
        {
            this.aniversario = aniversario;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"O aniversário da conta é: {this.aniversario}");
        }
    }
}
