using System;

namespace Natação
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if(idade >= 5 && idade <= 7){
                Console.WriteLine("Você vai para a categoria Infantil A");
            } else{
                if(idade >= 8 && idade <= 10){
                    Console.WriteLine("Você vai para a categoria Infantil B");
                } else{
                    if(idade >= 11 && idade <= 13){
                        Console.WriteLine("Você vai para a categoria Juvenil A");
                    } else{
                        if(idade >= 14 && idade <= 17){
                            Console.WriteLine("Você vai para a categoria Juvenil B");
                        } else{
                            Console.WriteLine("Você vai para a categoria Sênior");
                        }
                    }
                }
            }
        }
    }
}
