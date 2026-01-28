namespace esercizi_stringhe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esercizio 1");
            string nome;
            Console.Write("Inserisci il tuo nome:");
            Console.Write(" ");
            nome = Console.ReadLine();

            nome = nome.Trim();
            nome = nome.ToUpper();
            int l = nome.Length;
            Console.WriteLine($"Il tuo nome è: {nome}");
            Console.WriteLine($"La lunghezza del tuo nome è: {l}");

        }
    }
}
