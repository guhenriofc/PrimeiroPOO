using System;

namespace Ex._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do produto: ");
            string nomeDoProduto = Console.ReadLine();
            
            Console.Write("Insira a quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.Write("Insira o valor unitario do produto: ");
            float preco = float.Parse(Console.ReadLine());

            float totalAPagar = TotalAPagar(nomeDoProduto,quantidade,preco);



            float TotalAPagar(string nome, int quantidade, float preco){
                float total = quantidade * preco;
                float desconto;
                if(quantidade<=5){
                    desconto = 0.02f;
                }else if(quantidade<=10){
                    desconto = 0.03f;
                }else {
                    desconto = 0.05f;
                }
                float valorDoDesconto = total * desconto;
                float totalComDesconto = total - valorDoDesconto;

                Console.WriteLine($"Sua compra ficou em R${total}");
                Console.WriteLine($"Você ira receber R${valorDoDesconto} de desconto");
                Console.WriteLine($"Total a pagar R${totalComDesconto}");
                
                return totalComDesconto;
            }
        }
    }
}
