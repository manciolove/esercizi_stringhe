namespace esercizio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esrcizio 8");
            Console.Write("Inserisci una parola: ");
            string parola = Console.ReadLine();

            for (int i = parola.Length - 1 ; i >= 0; i--)
            {
                Console.Write(parola[i]);
            }
           
        }
    }
}
