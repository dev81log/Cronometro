namespace Cronometro
{
    static class Program
    {

        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S - Segundos -> 1s");
            Console.WriteLine("M - Minutos -> 1m");
            Console.WriteLine("0 - Parar Cronometro");
            Console.WriteLine("Quanto tempo deseja cronometrar?");

            string opcaoDigitada = Console.ReadLine().ToLower();
            Console.WriteLine(opcaoDigitada);

        }

        static void Start(int tempo)
        {
            int tempoAtual = 0;

            while (tempoAtual != tempo)
            {
                tempoAtual++;
                Console.Clear();
                Console.WriteLine($"Tempo atual {tempoAtual}");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Tempo finalizado");
            Thread.Sleep(2000);

        }
    }

}
