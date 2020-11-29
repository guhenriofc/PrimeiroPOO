using System;

namespace Cadastro_de_produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variável
            bool Promocao;
            int contador = 0;
            int selecao;
            string escolha;
            // string resposta;

            // Dados dos produtos
            string[] nomes = new string[10];
            float[] preco= new float[10];

            Console.Clear();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("------- Cadastro de Produtos -------");
            Console.WriteLine("------------------------------------");


            do
            {
                Console.WriteLine("Menu Principal");
                Console.WriteLine("Selecione uma das opções abaixo:");
                Console.WriteLine("[1]-Cadastrar produtos");
                Console.WriteLine("[2]-Listar produtos");
                Console.WriteLine("[3]-Sair");
                selecao = int.Parse(Console.ReadLine());

                switch (selecao)
                {
                    case 1:
                        Console.WriteLine("====== Cadastre seu produto ======");
                        do
                        {
                            if(contador < 10){
                                Console.Write($"Nome do {contador+1}º produto: ");
                                nomes[contador] = Console.ReadLine();
                                Console.Write("Preço do produto: ");
                                preco[contador] = float.Parse(Console.ReadLine());
                                do
                                    {
                                        Console.WriteLine("O produto é promocional?");
                                        string resposta = Console.ReadLine();
                                        Promocao = ProdutoPromocional(resposta);
                                    } while (!Promocao);
                                contador++;
                                Console.WriteLine("Deseja cadastrar mais produtos?");
                                escolha = Console.ReadLine();
                            } else{
                                Console.WriteLine("LIMITE DE CADASTRO EXCEDIDO!");
                                break;
                            }
                        } while (escolha.ToUpper() == "SIM");
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("====== Produtos cadastrados ======");
                        for (var i = 0; i < contador; i++)
                        {
                            Console.WriteLine($"Produto {nomes[i]} \nValor: {preco[i]} \n----------------");
                            
                        }
                        break;
                    case 3:
                        Console.WriteLine("Agradecemos a prefência e confiança em nossos produtos! VOLTE SEMPRE!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (selecao != 3);

            bool ProdutoPromocional(string resposta){
                if(resposta == "Sim"){
                    return true;
                } else{
                    return false;
                }
            }
            
        }
    }
}
