namespace Codigo
{
    internal class Program
    {
        #region Variáveis globais
        static Regras regras = new Regras();
        #endregion

        #region Metodos
        static void Main(string[] args)
        {
            MenuCommand();
		}

        static void MenuCommand()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("===== JOGO DA VELHA =====");
                Console.WriteLine("1 - Jogar");
                Console.WriteLine("2 - Ver regras");
                Console.WriteLine("3 - Sair");
                Console.WriteLine("=========================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Jogar();
                        break;
                    case 2:
                        ImpRegras();
                        break;
                    case 3:
                        Console.WriteLine("Obrigado por jogar!");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida!");
                        Console.WriteLine($"\nPressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            } while (opcao != 3);
        }

        static void ImpRegras()
        {
            Console.Clear();

            string regrasImpressas = regras.LerArquivo();

            Console.WriteLine(regrasImpressas);

            Console.WriteLine($"\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        static void Jogar()
        {
            Console.Clear();

            Tabuleiro tabuleiro = new Tabuleiro();

            tabuleiro.LancaJogado('1', 'O');
            tabuleiro.LancaJogado('2', 'X');
            tabuleiro.LancaJogado('3', 'O');
            tabuleiro.LancaJogado('4', 'X');
            tabuleiro.LancaJogado('5', 'O');
            tabuleiro.LancaJogado('6', 'X');
            tabuleiro.LancaJogado('7', 'O');
            tabuleiro.LancaJogado('8', 'X');
            tabuleiro.LancaJogado('9', 'O');





            tabuleiro.ImprimirTabuleiro();

            Console.WriteLine("\nJogando...");
            Console.WriteLine($"Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        #endregion 
    }
}
