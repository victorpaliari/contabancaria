using ContaBancaria.Model;
using ContaBancaria.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
=======
using System.Xml.Schema;
>>>>>>> main

namespace ContaBancaria.Controller
{
    public class ContaController : IContaRepository
<<<<<<< HEAD
    {
        private readonly List<Conta> listaContas = new();
        int numero = 0;
=======
    
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

>>>>>>> main
        public void ListarTodas()
        {
            foreach (var conta in listaContas)
            {
                conta.Visualizar();
            }
        }
<<<<<<< HEAD
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

        public void MudarBackground()
        {
            Console.WriteLine("Mudar a cor do plano de fundo");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1 - Amarelo");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("2 - Vermelho");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("3 - Verde");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("4 - Azul");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("5 - Magenta");
            Console.ResetColor();

            int opcao = 0;

            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;

            }
        }



=======
>>>>>>> main

        public void ProcurarPorNumero(int numero)
        {
            var conta = BuscarNaCollection(numero);
            if (conta != null)
                conta.Visualizar();
            else
            {
<<<<<<< HEAD
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
                if (conta.Sacar(valor) == true)
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
=======
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
            
>>>>>>> main
        }

        public void Transferir(int numeroOrigem, int numeroDestino, decimal valor)
        {
<<<<<<< HEAD
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

=======
            
        }

        // Métodos Auxiliares

        //Método para gerar automaticamente o número da conta
>>>>>>> main
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
