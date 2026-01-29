namespace esercizio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci data: ");
            string data = Console.ReadLine();

            string[] parti = data.Split('/');
            string x;
            x = parti[0];
            parti[0] = parti[2];
            parti[2] = x;
            string dataFinale = string.Join("-", parti);
            Console.WriteLine($"La data riformattata è {dataFinale}");

        }
    }
}
