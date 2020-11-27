using System;

namespace Cadastro_de_passagem_area
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis
            bool senhaValida;
            int escolha;
            int contador = 0;
            string resposta;

            //Dados das passagens 
            string [] nomes = new string [5];
            string [] origem = new string [5];
            string [] destino = new string [5];
            string [] data = new string [5];


            Console.Clear();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("----- Sistema de Passagens -----");
            Console.WriteLine("--------------------------------");

            //Login
            do
            {
                Console.Write("Digite a senha para acessar o sistema: ");
                string senha = Console.ReadLine();
                senhaValida = EfetuarLogin(senha);
                
            } while (!senhaValida);

            // Menu Principal
            do
            {
                Console.WriteLine("Menu Principal");
                Console.WriteLine("Selecione uma opção abaixo:");
                Console.WriteLine("[1]-Cadastrar passagens");
                Console.WriteLine("[2]-Listar passagens");
                Console.WriteLine("[0]-Sair");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("-----Cadastrar passageiro-----");
                            do
                            {
                                if(contador < 5)
                                {
                                Console.Write($"Digite o nome do {contador+1}º passageiro: ");
                                nomes[contador] = Console.ReadLine();
                                Console.Write("Ponto de partida: ");
                                origem[contador] = Console.ReadLine();
                                Console.Write("Destino: ");
                                destino[contador] = Console.ReadLine();
                                Console.Write("Data do voô: ");
                                data[contador] = Console.ReadLine();
                                contador++;
                                } else{
                                    Console.WriteLine("LIMITE EXCEDIDO!");
                                    break;
                                }
                                Console.Write("Gostaria de cadastrar mais um passageiro? ");
                                resposta = Console.ReadLine();
                                
                            } while (resposta.ToUpper() == "SIM");
                            Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("-----Lista de Passagens-----");
                        for (var i = 0; i < contador; i++)
                        {
                            Console.WriteLine($"Passageiro {nomes[i]}, parte de {origem[i]} com destino à {destino[i]} no dia {data[i]}");
                            
                        }
                        break;
                    case 0:
                        Console.WriteLine("Obrigado por viajar conosco. Boa viagem, volte sempre!");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
                
            } while (escolha !=0);
            
            // Funções
            bool EfetuarLogin(string senha){
                if(senha == "123456"){
                    return true;
                } else{
                    Console.Write("Senha Inválida. ");
                    return false;
                }
            }
            
        }
    }
}
