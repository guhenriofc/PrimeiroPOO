using System;

namespace Revisão_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];
            double[] nota1 = new double[10];
            double[] nota2 = new double[10];
            double[] nota3 = new double[10];
            double[] nota4 = new double[10];
            double[] media = new double[10];
            string[] situacao = new string[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o nome do aluno: ");
                nomes[i] = Console.ReadLine();
                Console.Write("Digite a nota 1 do aluno: ");
                nota1[i] = double.Parse(Console.ReadLine());
                Console.Write("Digite a nota 2 do aluno: ");
                nota2[i] = double.Parse(Console.ReadLine());
                Console.Write("Digite a nota 3 do aluno: ");
                nota3[i] = double.Parse(Console.ReadLine());
                Console.Write("Digite a nota 4 do aluno: ");
                nota4[i] = double.Parse(Console.ReadLine());
                media[i] = (nota1[i] + nota2[i] + nota3[i] + nota4[i]) / 4;

            }
                for (var i = 0; i < 10; i++)
                {
                    Console.WriteLine($"O Aluno: {nomes[i]} possui média = {media[i]}");
                    if(media[i] > 7){
                        situacao[i] = "Aprovado";
                    } else{
                        situacao[i] = "Reprovado";
                    }
                }
        }
    }
}
