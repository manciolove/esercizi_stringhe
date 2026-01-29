namespace esercizio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esercizio 5");

            string voti = "8,7,5,9,10,6,7,8,9,4";
            string [] votiArray = voti.Split(',');
            
            Console.WriteLine("I voti sono: ");
            for (int i = 0; i < votiArray.Length; i++)
            {
                Console.WriteLine(votiArray[i]);
            }
            
        }
    }
}
