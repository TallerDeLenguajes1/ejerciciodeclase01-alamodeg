using System;

namespace Problema04
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            try
            {
                Console.WriteLine("{0} - {1} - {2}", a, b);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al mostrar los datos por mal formateo de argumentos");
            }
            Console.ReadLine();
        }
    }
}
