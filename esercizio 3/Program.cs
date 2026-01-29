namespace esercizio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esercizio 3");
            Console.WriteLine(" ");
            Console.WriteLine("inserisci nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("inserisci cognome: ");
            string cognome = Console.ReadLine();

            char[] nomeArray = nome.ToCharArray();
            char[] cognomeArray = cognome.ToCharArray();
            Console.WriteLine($"{nome[0]}.{cognome[0]}");

        }
    }
}
