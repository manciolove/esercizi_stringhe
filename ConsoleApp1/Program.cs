namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esercizio 2");
            Console.WriteLine("");
            string email = "mancini.francesco@gmail.it";

            int l = email.Length;
            int chiocciolaIndex = email.IndexOf('@');
            int sottrazione = l - chiocciolaIndex; 
            string parte = email.Substring(chiocciolaIndex + 1, sottrazione - 1);
            Console.WriteLine($"La parte dell'email dopo la chiocciola è: {parte}");


        }
    }
}
