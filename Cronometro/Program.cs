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

            string opcaoDigitado = Console.ReadLine().ToLower();
            char tipo = char.Parse(opcaoDigitado.Substring(opcaoDigitado.Length - 1, 1));
            int tempoDigitado = int.Parse(opcaoDigitado.Substring(0, opcaoDigitado.Length - 1));

            int multiplicador = 1;

            if (tipo == 'm')
                multiplicador = 60;

            if (tipo == '0')
                System.Environment.Exit(0);

            Carregando(tempoDigitado * multiplicador);

        }

        static void Carregando(int tempo)
        {
            Console.Clear();
            Console.WriteLine("Preparando...");
            Thread.Sleep(1000);
            Console.WriteLine("Começando...");
            Thread.Sleep(2500);

            Start(tempo);
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
            Menu();

        }
    }

}
