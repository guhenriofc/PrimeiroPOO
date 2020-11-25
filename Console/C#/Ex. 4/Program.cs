using System;

namespace Ex._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] valores = new double [10];
            double maior = 0;
            double menor = 1000000000000000;

            Console.WriteLine("Digite dez valores; ");
            for (var i = 0; i < 10; i++)
            {
                valores[i] = double.Parse(Console.ReadLine());
                if(valores[1] > maior){
                    maior = valores[i];
                }
                if(valores[i] < menor){
                    menor = valores[i];
                }

                
            }

            Console.WriteLine($"O menor valor colocado foi {menor} e o maior valor foi {maior}");
            
        }
    }
}
