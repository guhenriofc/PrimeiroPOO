using System;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine("Bem-vindo à seletiva paa o time de Counter Strike");
            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine("Você gostaria de participar? Sim ou Não");
            string resposta = Console.ReadLine();
            if(resposta == "Sim"){
                Console.WriteLine("Que legal! Agora vamos analisar seu curriculo");
                Console.WriteLine("Insira sua media escolar");
                int media = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a sua quantidade de faltas");
                int faltas = int.Parse(Console.ReadLine());
                if(media >= 50 && faltas <= 10){
                    Console.WriteLine("Parabéns seja bem vindo");
                }else{
                    Console.WriteLine("Que pena, você precisa melhorar mais suas notas e faltas");
                }
            }else{
                Console.WriteLine("Blz, Passar bem!");
            }

        }
    }
}
