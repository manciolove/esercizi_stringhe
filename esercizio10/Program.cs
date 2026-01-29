namespace esercizio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esercizio 10");

            Console.WriteLine("insersici una parola: ");
            string parola = Console.ReadLine();


            parola = parola.ToUpper();  
            bool palindroma = true;
            int l = parola.Length;
            for (int i = 0; i < l / 2; i++)
            {
                if (parola[i] != parola[l - 1 - i])
                {
                    palindroma = false;
                    
                }
            }
            Console.WriteLine(palindroma);

        }
    }
}
