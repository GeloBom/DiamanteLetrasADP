using System;

namespace DiamanteLetrasADP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuInicial();

            while (true)
            {
                int letra = InputUsuario(); // Recebe a letra do usuário
                int tamanho = 2 * letra - 129; // Calcula o tamanho do diamante
                CalculoDiamante(letra, tamanho); // Desenha o diamante
                if (EncerrarPrograma()) break; // Verifica se o usuário deseja encerrar o programa
            }
        }

        private static void MenuInicial()
        {
            Console.WriteLine("=====================================================");
            Console.WriteLine("|                                                   |");
            Console.WriteLine("|             Bem-vindo ao Programa                 |");
            Console.WriteLine("|           Desenho de Diamante em X                |");
            Console.WriteLine("|                                                   |");
            Console.WriteLine("|      Prepare-se para uma jornada criativa!        |");
            Console.WriteLine("|                                                   |");
            Console.WriteLine("=====================================================\n");
            Console.WriteLine("     Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        private static void CalculoDiamante(int letra, int tamanho)
        {
            int metade = (tamanho - 1) / 2; // Calcula o ponto médio do diamante
            Console.WriteLine();

            // Loop para as linhas do diamante
            for (int i = 0; i < tamanho; i++)
            {
                int letraConsole = letra - Math.Abs(i - metade);

                // Loop para as colunas do diamante
                for (int j = 0; j < tamanho; j++)
                {
                    // Escreve a letra
                    if (Math.Abs(j - metade) == i && i <= metade)
                    {
                        Console.Write(Convert.ToChar(letraConsole));
                    }
                    else if (Math.Abs(j - metade) == Math.Abs(i - 2 * metade) && i > metade)
                    {
                        Console.Write(Convert.ToChar(letraConsole));
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        private static int InputUsuario()
        {
            while (true)
            {
                Console.WriteLine("Digite uma letra (A-Z):");
                int letra = Convert.ToInt32(Convert.ToChar(Console.ReadLine().ToUpper()));

                if (letra < 65 || letra > 90)
                {
                    Console.WriteLine("Por favor, digite uma letra válida entre A e Z.");
                    Console.WriteLine("Pressione qualquer tecla para tentar novamente...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    return letra;
                }
            }
        }

        private static bool EncerrarPrograma()
        {
            Console.WriteLine("\nDeseja continuar usando o programa? (S/N)");
            string escolha = Console.ReadLine().ToUpper();
            return escolha == "N" || escolha == "n";
        }
    }
}
