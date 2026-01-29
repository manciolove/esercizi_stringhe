namespace esercizio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esercizio 4");
            
            Console.WriteLine("inserisci frase: ");
            string frase = Console.ReadLine();

            string esiste = frase.Replace("brutta", "***");
            Console.WriteLine(esiste);

        }
    }
}
