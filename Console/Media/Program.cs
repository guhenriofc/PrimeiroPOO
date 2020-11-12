using System;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2) / 2;

            string situacao = "";

            Console.WriteLine("Media: " + media);

            if(media > 7){
                situacao = "Aprovado";
            } else{
                situacao = "Reprovado";
            }

            Console.WriteLine(situacao);
        }
    }
}
