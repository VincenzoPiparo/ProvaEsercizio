using System; //riferimento della libreria di base 

namespace MyApp // Note: actual namespace depends on the project name. 
{
    internal class Program
    {
        static void Main(string[] args) //entry point 
        {
            //namespace, classe, metodo 
            int v1, v2;
            Console.WriteLine("Digita primo numero:");

            if (!int.TryParse(Console.ReadLine(), out v1))
            {
                Console.WriteLine("Errore, non è stato inserito un numero");
                System.Environment.Exit(1);
            }

            Console.WriteLine("Digita secondo numero:");

            if (!int.TryParse(Console.ReadLine(), out v2))
            {
                Console.WriteLine("Errore, non è stato inserito un numero");
                System.Environment.Exit(1);
            }

            System.Console.WriteLine("Risultato: {0}, {1}",
                Add(v1, v2), "Ciao");
        }
        static int Add(int v1, int v2)
        {
            return v1 * v2;
        }
    }
}