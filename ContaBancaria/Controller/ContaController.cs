using ContaBancaria.Model;
using ContaBancaria.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.Controller
{
    public class ContaController : IContaRepository
    {
        private readonly List<Conta> listaContas = new();
        int numero = 0;
        public void ListarTodas()
        {
            foreach (var conta in listaContas)
            {
                conta.Visualizar();
            }
        }
        public void Cadastrar(Conta conta)
        {
            listaContas.Add(conta);
            Console.WriteLine($"A conta Nº {conta.GetNumero()} foi criada com sucesso.");
        }

        public void Atualizar(Conta conta)
        {
            var buscaConta = BuscarNaCollection(conta.GetNumero());

            if (buscaConta is not null)
            {
                var index = listaContas.IndexOf(buscaConta);

                listaContas[index] = conta;

                Console.WriteLine($"A conta numero {conta.GetNumero()} foi atualizada com sucesso!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"A conta numero {numero} não foi encontrada!");
                Console.ResetColor();
            }

        }


    public void Deletar(int numero)
        {
            var conta = BuscarNaCollection(numero);

            if (conta is not null)
            {
                if (listaContas.Remove(conta) == true)
                    Console.WriteLine($"A Conta número {numero} foi apagada com sucesso!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"A conta numero {numero} não foi encontrada!");
                Console.ResetColor();
            }
        }




        public void ProcurarPorNumero(int numero)
        {
            var conta = BuscarNaCollection(numero);
                if (conta != null)
                conta.Visualizar();
                else
            {
                Console.WriteLine($"\n A conta Nº {numero} não foi encontrada");
                Console.ResetColor();
            }

            

            
        }

        //Métodos Bancários
        public void Sacar(int numero, decimal valor)
        {
            var conta = BuscarNaCollection(numero);
            if (conta != null)
            {
               if(conta.Sacar(valor) == true)
                    Console.WriteLine($"\n O saque de R${valor} na conta Nº {numero} foi efetuado com sucesso");
            }
            else
            {
                Console.WriteLine($"\n A conta Nº {numero} não foi encontrada");
                Console.ResetColor();
            }
        }
        public void Depositar(int numero, decimal valor)
        {
            var conta = BuscarNaCollection(numero);
            if (conta != null)
            {
                conta.Depositar(valor);
                Console.WriteLine($"\n O depósito de R${valor} na conta Nº {numero} foi efetuado com sucesso");
            }
            else
            {
                Console.WriteLine($"\n A conta Nº {numero} não foi encontrada");
                Console.ResetColor();
            }
        }

        public void Transferir(int numeroOrigem, int numeroDestino, decimal valor)
        {
            var contaOrigem = BuscarNaCollection(numeroOrigem);
            var contaDestino = BuscarNaCollection(numeroDestino);

            if (contaOrigem != null && contaDestino != null)
            {
                if (contaOrigem.Sacar(valor) == true)
                {
                    contaDestino.Depositar(valor);
                    Console.WriteLine($"\n A transferência de R${valor} na conta Nº {numero} foi efetuada com sucesso");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n Conta Origem e/ou Conta Destino não foi encontrada");
                Console.ResetColor();
            }
        }

        //Métodos auxiliares

        //Método para gerar automaticamente o número da conta

        public int GerarNumero()
        {
            return ++numero;
        }

        //Método para buscar a conta na Collection
        public Conta? BuscarNaCollection(int numero)
        {
            foreach (var conta in listaContas)
            {
                if (conta.GetNumero() == numero)
                {
                    return conta;
                }
            }
            return null;
        }
    }
}
