using System.Runtime.CompilerServices;

namespace DiamanteLetrasADP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int letra = InputUsuario(); // Input do usuário
                int tamanho = 2 * letra - 129; // Tamanho do grid
                CalculoDiamante(letra, tamanho); // Desenho/calculo
                if (EncerrarPrograma()) break;
            }

        }

        private static void CalculoDiamante(int letra, int tamanho)
        {
            int metade = (tamanho - 1) / 2; // Calcula o ponto médio do diamante.
            Console.WriteLine();

            // Loop linhas do diamante
            for (int i = 0; i < tamanho; i++)
            {
                int letraConsole = letra - Convert.ToInt32(Math.Abs(i - metade));

                // Loop colunas do diamante
                for (int j = 0; j < tamanho; j++)
                {
                    // Escreve a letra.
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
                Console.WriteLine("Informe uma letra (A-Z):");
                int letra;
                letra = Convert.ToInt32(Convert.ToChar(Console.ReadLine().ToUpper()));

                if (letra < 65 || letra > 90)
                {
                    Console.WriteLine("Letra invalida, digite qualquer tecla e tente novamente:");
                    Console.ReadKey();
                    Console.Clear();
                }

                Console.Clear();
                return letra;
            }
        }

        private static bool EncerrarPrograma()
        {
            Console.WriteLine("\nDeseja finalizar o programa? (S/N)");
            string escolha = Console.ReadLine();
            return escolha == "N" || escolha == "n";

        }
    }
}
