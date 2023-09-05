using ContaBancaria.Model;

namespace ContaBancaria
{
    internal class Program

    {
        private static ConsoleKeyInfo consoleKeyInfo;

        static void Main(string[] args)
        {

            int opcao;

            ContaCorrente cc1 = new ContaCorrente(2, 123, 1, "Samantha", 100000000.00M, 1000.00M);
            cc1.Visualizar();
            cc1.Sacar(200000000.00M);
            cc1.Visualizar();
            cc1.Depositar(50);
            cc1.Visualizar();
           

            ContaPoupanca cp1 = new ContaPoupanca(3, 123, 2, "Victor", 8000000.00M, 30);
            cp1.Visualizar();

            while (true)
            {
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.ForegroundColor = ConsoleColor.White;
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


                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 9)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("\nBanco Seguro - Você seguro.");
                    Sobre();
                    Console.ResetColor();
                    System.Environment.Exit(0);
                }

                switch (opcao)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Criar Conta\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Listar todas as Contas\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Consultar dados da Conta - por número\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;

                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Atualizar dados da Conta\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;

                    case 5:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Apagar a Conta\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;

                    case 6:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Saque\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;

                    case 7:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Depósito\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;

                    case 8:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Transferência entre Contas\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nOpção Inválida!\n");
                        Console.ResetColor();

                        KeyPress();
                        break;
                }
            }
        }

        static void Sobre()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n*********************************************************");
            Console.WriteLine("Projeto Desenvolvido por: Victor Paliari.");
            Console.WriteLine("Victor - victorrpaliari@gmail.com");
            Console.WriteLine("github.com/https://github.com/victorpaliari");
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


