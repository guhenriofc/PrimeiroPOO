using System;

namespace Calculadora_Simples
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Qual operacao deseja realizar? \nSoma, Subtracao, Multiplicacao ou Divisao?");
          string operacao = Console.ReadLine().ToLower();

          Console.WriteLine("Dgite o 1º numero: ");
          float num1 = float.Parse(Console.ReadLine());

          Console.WriteLine("Dgite o 2º numero: ");
          float num2 = float.Parse(Console.ReadLine());

          float resultado = 0;

          switch(operacao){

               case "soma":
                    resultado = num1 + num2;
                    break;

               case "subtracao":
                    resultado = num1 - num2;
                    break;

               case "multiplicacao":
                    resultado = num1 * num2;
                    break;

               case "divisao":
                    resultado = num1 / num2;
                    break;    

               default:
                    Console.WriteLine("Oprecao inválida!");
                    break;

          }
                Console.WriteLine($"Cálculo: {num1} com {num2} = {resultado}");
        }
    }
}
