using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual tabuada deseja realizar? ");
            int resposta = int.Parse(Console.ReadLine());

            int resultado;

            for (int contador = 0; contador <= 10; contador++)
            {
                resultado = resposta * contador;
                Console.WriteLine($"{resposta} * {contador} = {resultado}");
            }
        }
    }
}
