﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.Model
{
    public class ContaCorrente : Conta
    {
        //é acessível apenas dentro da Classe ContaCorrente.
        private decimal limite;

        public ContaCorrente(int numero, int agencia, int tipo, string titular, 
                decimal saldo, decimal limite)
            : base(numero, agencia, tipo, titular, saldo)
        {
            this.limite = limite;
        }

        public decimal GetLimite()
        {
            return limite;
        }

        public void SetLimite(decimal limite)
        {
            this.limite = limite;
        }

        //O método Sacar() foi sobreescrito = Polimorfismo de sobreescrita
        public override bool Sacar(decimal valor)
        {
            if (this.GetSaldo() + this.limite < valor)
            {
                Console.WriteLine("Saldo insuficiente.");
                return false;
            }

            this.SetSaldo(this.GetSaldo() - valor);
            return true;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Seu limite é: {this.limite}");
        }
    }
}
