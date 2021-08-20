using System;

namespace Adivina_Programador
{
    class Program
    {
        static void Main()
        {
            var sorteado = new Random().Next(101);
            var num = -1;
            var intentos = 1;

            try
            {
                do
                {
                    Console.WriteLine("Ingrese otro numero:");
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num > sorteado)
                    {
                        Console.WriteLine("El numero ingresado es mayor que el buscado..");
                    }
                    if (num < sorteado)
                    {
                        Console.WriteLine("El numero ingresado es menor que el buscado..");
                    }
                    if (num == sorteado)
                    {
                        Console.WriteLine("Encontro el numero!"); break;
                    }
                    intentos++;
                } while (num != sorteado);
                Console.WriteLine($"Adivino la palabra en {intentos} intentos");
            }
            catch (Exception ex)
            {
                intentos++;
                Console.WriteLine($"Valor fuera de rango, intentos: {intentos}");
                Console.WriteLine($"ERROR: {ex}");
            }
        }
    }
}
