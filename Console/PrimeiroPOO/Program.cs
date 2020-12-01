using System;

namespace PrimeiroPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem jogador1 = new Personagem();
            jogador1.nome = "Gustavo";
            jogador1.idade = 18;
            jogador1.armadura = "MARK-3";
            jogador1.iA = "Jarvis";

            Personagem jogador2 = new Personagem();
            jogador2.nome = "Guilherme";
            jogador2.idade = 17;
            jogador2.armadura = "MARK-5";
            jogador2.iA = "Pure Skill";

            Console.WriteLine($"Partida -> {jogador1.nome} VS {jogador2.nome}");
            Console.WriteLine($"Idade -> {jogador1.idade} VS {jogador2.idade}");
            Console.WriteLine($"Armadura -> {jogador1.armadura} VS {jogador2.armadura}");
            Console.WriteLine($"iA -> {jogador1.iA} VS {jogador2.iA}");
            
            
            
            
        }
    }
}
