using ContaBancaria.Controller;
using ContaBancaria.Model;

namespace ContaBancaria
{
    public class Program

    {
        public static ConsoleKeyInfo consoleKeyInfo;

        static void Main(string[] args)
        {
            ContaController contas = new();
            int opcao, agencia, tipo, aniversario, numero, valor, numeroDestino;
            string? titular;
            decimal saldo, limite;

<<<<<<< HEAD
            Console.WriteLine("\nCriar Contas\n");

            ContaPoupanca cp1 = new(contas.GerarNumero(), 125, 2, "Mayara", 20000000M, 12);
            contas.Cadastrar(cp1);

            ContaPoupanca cp2 = new(contas.GerarNumero(), 125, 2, "Victor", 20000000M, 15);
            contas.Cadastrar(cp2);
=======
            int opcao, agencia, tipo, aniversario, numero, numeroDestino, valor;
            string? titular;
            decimal saldo, limite;

            //cria um objeto da classe ContaController para armazenar dados das contas 
            //na collection listaContas
            ContaController contas = new();

            ContaCorrente cc1 = new ContaCorrente(contas.GerarNumero(), 123, 1, "Samantha", 100000000.00M, 1000.00M);
            contas.Cadastrar(cc1);

            ContaCorrente cc2 = new(contas.GerarNumero(), 124, 1, "Maria da Silva", 2000M, 100.0M);
            contas.Cadastrar(cc2);

            ContaPoupanca cp1 = new ContaPoupanca(contas.GerarNumero(), 123, 2, "Sabrina", 1000.00M, 10);
            contas.Cadastrar(cp1);

            ContaPoupanca cp2 = new ContaPoupanca(contas.GerarNumero(), 123, 2, "Mayara", 90000.00M, 13);
>>>>>>> main

            contas.ListarTodas();

            while (true)
            {
                //Console.BackgroundColor = ConsoleColor.DarkCyan;
                ;// Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("*****************************************************");
                Console.WriteLine("                                                     ");
                Console.WriteLine("                   BANCO VIBANK                      ");
                Console.WriteLine("                                                     ");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("                                                     ");
                Console.WriteLine("            1 - Criar Conta                          ");
                Console.WriteLine("            2 - Listar todas as Contas               ");
                Console.WriteLine("            3 - Buscar Conta por Numero              ");
                Console.WriteLine("            4 - Atualizar Dados da Conta             ");
                Console.WriteLine("            5 - Apagar Conta                         ");
                Console.WriteLine("            6 - Sacar                                ");
                Console.WriteLine("            7 - Depositar                            ");
                Console.WriteLine("            8 - Transferir valores entre Contas      ");
                Console.WriteLine("            9 - Sair                                 ");
                Console.WriteLine("           10 - Mudar Cor do Plano de Fundo          ");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("Entre com a opção desejada:                          ");
                Console.WriteLine("                                                     ");
                Console.ResetColor();

                try
                {
                    opcao = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nDigite valores inteiros!");
                    opcao = 0;
                    Console.ResetColor();
                }

                if (opcao == 9)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
<<<<<<< HEAD
                    Console.WriteLine("\nVIBANK - Nosso banco.");
=======
                    Console.WriteLine("\nBEM-VINDO AO VIBANK");
>>>>>>> main
                    Sobre();
                    Console.ResetColor();
                    System.Environment.Exit(0);
                }


                switch (opcao)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Criar Conta\n\n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o Número da Agência: ");
                        agencia = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o Nome do Titular: ");
                        titular = Console.ReadLine();

<<<<<<< HEAD
=======
                        //Verifica se a variável titular é nula, através do Operador de Coalescência (??).
                        //Caso seja nula, será retornada uma string vazia
>>>>>>> main
                        titular ??= string.Empty;

                        do
                        {
<<<<<<< HEAD
                            Console.WriteLine("Digite o Tipo da Conta: ");
                            Console.WriteLine("1- Conta Corrente");
                            Console.WriteLine("2- Conta Poupança");
                            tipo = Convert.ToInt32(Console.ReadLine());
                        } while (tipo != 1 && tipo != 2);

                        Console.WriteLine("Digite o Saldo da Conta: ");
=======
                            Console.WriteLine("Digite o Tipo da Conta ([1] - CC ou [2] - CP):");
                            tipo = Convert.ToInt32(Console.ReadLine());
                        } while (tipo != 1 && tipo != 2);

                        Console.WriteLine("Digite o Saldo da Conta (R$): ");
>>>>>>> main
                        saldo = Convert.ToDecimal(Console.ReadLine());

                        switch (tipo)
                        {
                            case 1:
<<<<<<< HEAD
                                Console.WriteLine("Digite o Limite da Conta: ");
                                limite = Convert.ToDecimal(Console.ReadLine());

=======
                                Console.WriteLine("Digite o Limite de crédito (R$): ");
                                limite = Convert.ToDecimal(Console.ReadLine());
>>>>>>> main
                                contas.Cadastrar(new ContaCorrente(contas.GerarNumero(), agencia, tipo, titular, saldo, limite));
                                break;
                            case 2:
                                Console.WriteLine("Digite o dia do Aniversário da Conta: ");
                                aniversario = Convert.ToInt32(Console.ReadLine());
<<<<<<< HEAD

=======
>>>>>>> main
                                contas.Cadastrar(new ContaPoupanca(contas.GerarNumero(), agencia, tipo, titular, saldo, aniversario));
                                break;
                        }

<<<<<<< HEAD

=======
>>>>>>> main
                        KeyPress();
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Listar todas as Contas\n\n");
                        Console.ResetColor();

                        contas.ListarTodas();

                        KeyPress();
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Consultar dados da Conta - por número\n\n");
                        Console.ResetColor();

                        Console.WriteLine("Digite o número da conta: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        contas.ProcurarPorNumero(numero);

                        KeyPress();
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Atualizar dados da Conta\n\n");
                        Console.ResetColor();

<<<<<<< HEAD
                        Console.WriteLine("Digite o número da Conta: ");
=======
                        Console.WriteLine("Digite o número da conta: ");
>>>>>>> main
                        numero = Convert.ToInt32(Console.ReadLine());

                        var conta = contas.BuscarNaCollection(numero);

<<<<<<< HEAD
                        if (conta is not null)
=======
                        if (conta != null)
>>>>>>> main
                        {
                            Console.WriteLine("Digite o Número da Agência: ");
                            agencia = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Digite o Nome do Titular: ");
                            titular = Console.ReadLine();

<<<<<<< HEAD
                            //Verifica se a variável titular é nula, através do Operador de Coalescência (??).
                            //Caso seja nula, será retornada uma string vazia.
=======
>>>>>>> main
                            titular ??= string.Empty;

                            Console.WriteLine("Digite o Saldo da Conta: ");
                            saldo = Convert.ToDecimal(Console.ReadLine());

                            tipo = conta.GetTipo();

                            switch (tipo)
                            {
                                case 1:
<<<<<<< HEAD
                                    Console.WriteLine("Digite o Limite da Conta: ");
                                    limite = Convert.ToDecimal(Console.ReadLine());

                                    contas.Atualizar(new ContaCorrente(numero, agencia, tipo, titular, saldo, limite));
=======
                                    Console.WriteLine("Digite o Limite de crédito (R$): ");
                                    limite = Convert.ToDecimal(Console.ReadLine());
                                    contas.Cadastrar(new ContaCorrente(contas.GerarNumero(), agencia, tipo, titular, saldo, limite));
>>>>>>> main
                                    break;
                                case 2:
                                    Console.WriteLine("Digite o dia do Aniversário da Conta: ");
                                    aniversario = Convert.ToInt32(Console.ReadLine());
<<<<<<< HEAD

                                    contas.Atualizar(new ContaPoupanca(numero, agencia, tipo, titular, saldo, aniversario));
                                    break;
                            }
=======
                                    contas.Cadastrar(new ContaPoupanca(contas.GerarNumero(), agencia, tipo, titular, saldo, aniversario));
                                    break;
                            }


>>>>>>> main
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
<<<<<<< HEAD
                            Console.WriteLine($"A conta numero {numero} não foi encontrada!");
=======
                            Console.WriteLine("\n Conta não encontrada.");
>>>>>>> main
                            Console.ResetColor();
                        }

                        KeyPress();
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Apagar a Conta\n\n");
                        Console.ResetColor();

<<<<<<< HEAD
                        Console.WriteLine("Digite o número da Conta: ");
=======
                        Console.WriteLine("Digite o número da conta: ");
>>>>>>> main
                        numero = Convert.ToInt32(Console.ReadLine());

                        contas.Deletar(numero);

                        KeyPress();
                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Saque\n\n");
                        Console.ResetColor();
                        
                      

                        Console.WriteLine("Digite o número da Conta: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o valor do saque: ");
                        valor = Convert.ToInt32(Console.ReadLine());

                        contas.Sacar(numero, valor);


                        KeyPress();
                        break;
                    case 7:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Depósito\n\n");
                        Console.ResetColor();

<<<<<<< HEAD
                        Console.WriteLine("Digite o número da conta: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o valor do depósito: ");
                        valor = Convert.ToInt32(Console.ReadLine());

                        contas.Depositar(numero, valor);
=======
                       
>>>>>>> main

                        KeyPress();
                        break;
                    case 8:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Transferência entre Contas\n\n");

                        

                        Console.WriteLine("Digite o número da Conta Origem: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o número da Conta Destino: ");
                        numeroDestino = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o valor da transferência: ");
                        valor = Convert.ToInt32(Console.ReadLine());

                        contas.Transferir(numero, numeroDestino, valor);

                        KeyPress();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nOpção Inválida!\n");
                        Console.ResetColor();

                        KeyPress();
                        break;

<<<<<<< HEAD
                    case 10:
                        contas.MudarBackground();
                        KeyPress();
                        break;


=======
>>>>>>> main


                }

            }


        }






        static void Sobre()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n*********************************************************");
            Console.WriteLine("Projeto Desenvolvido por: Victor Paliari.");
<<<<<<< HEAD
            Console.WriteLine("Victor - victorrpaliari@gmail.com");
=======
            Console.WriteLine("E-mail - victorrpaliari@gmail.com");
>>>>>>> main
            Console.WriteLine("github.com/victorpaliari");
            Console.WriteLine("*********************************************************");

        }

        static void KeyPress()
        {
            do
            {
                Console.Write("\nPressione Enter para Continuar...");
                consoleKeyInfo = Console.ReadKey();
            } while (consoleKeyInfo.Key != ConsoleKey.Enter);
        }



    }
}




