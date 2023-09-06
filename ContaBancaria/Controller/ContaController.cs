using ContaBancaria.Model;
using ContaBancaria.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ContaBancaria.Controller
{
    public class ContaController : IContaRepository
    
    {

        private readonly List<Conta> listaContas = new();
        int numero = 0;

        // Métodos do CRUD
        public void Atualizar(Conta conta)
        {
            var buscaConta = BuscarNaCollection(conta.GetNumero());
            if (buscaConta != null )
            {
                var indexOf = listaContas.IndexOf(buscaConta);
                listaContas[indexOf] = conta;

                Console.WriteLine($"\nA conta Nº {conta.GetNumero()} foi atualizada com sucesso!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nA conta Nº {conta.GetNumero()} não foi encontrada.");
                Console.ResetColor();
            }
        }

        public void Cadastrar(Conta conta)
        {
            listaContas.Add(conta);
            Console.WriteLine($"A conta número {conta.GetNumero()} foi criada com sucesso!");
        }

        public void Deletar(int numero)
        {
            var conta = BuscarNaCollection(numero);

            if (conta != null)
            {
                if (listaContas.Remove(conta) == true) 
                    Console.WriteLine($"\nA conta Nº {numero} foi deletada com sucesso");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nA conta Nº {numero} não foi encontrada");
                Console.ResetColor();
            }
        }

        public void ListarTodas()
        {
            foreach (var conta in listaContas)
            {
                conta.Visualizar();
            }
        }

        public void ProcurarPorNumero(int numero)
        {
            var conta = BuscarNaCollection(numero);
            if (conta != null)
                conta.Visualizar();
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n Conta número: {numero} não foi encontrada.");
                Console.ResetColor();
            }
        }


        // Métodos Bancários 

        public void Sacar(int numero, decimal valor)
        {
            
        }

        public void Depositar(int numero, decimal valor)
        {
            
        }

        public void Transferir(int numeroOrigem, int numeroDestino, decimal valor)
        {
            
        }

        // Métodos Auxiliares

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
