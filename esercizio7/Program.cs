namespace esercizio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esercizio 7");

            Console.Write("Inserisci una parola: ");
            string parola = Console.ReadLine();
            int c = 0;

            for (int i = 0; i < parola.Length; i++)
            {
                if (parola[i] == 'a' || parola[i] == 'A')
                {
                    c++;
                }
            }
            Console.WriteLine($"le 'a' sono: {c}");
        }
    }
}
