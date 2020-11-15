using System;

namespace Meses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos anos você tem?");
            int idade = int.Parse(Console.ReadLine());

            int resposta = (idade*12);
            int resposta2 = (idade*365);
            int horas = (idade*365) * 24;
            int minutos = (horas*60);

            Console.WriteLine("Você  tem: " + idade + " anos, " + resposta + " meses, " + resposta2 + " dias, " + horas + " horas e " + minutos + " minutos de vida.");
        }
    }
}
