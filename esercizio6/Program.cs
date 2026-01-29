namespace esercizio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esercizio 6");

            Console.WriteLine("Inserisci nome file: ");
            string file = Console.ReadLine();

            int l = file.Length;
            int puntoIndex = file.LastIndexOf('.');
            int sottrazione = l - puntoIndex;
            string estensione = file.Substring(puntoIndex + 1, sottrazione - 1);
            Console.WriteLine($"L'etsensione è: {estensione}");
        }
    }
}
