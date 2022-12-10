using System;

namespace jogo_da_velha{

    public class JogoDaVelha
    {
        public char[,] tabuleiro = new char[3, 3] { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
        
        public void Movimento(int linha, int coluna, char jogador) {
            Console.WriteLine("---Bem-vindo ao jogo da velha---");
            Console.WriteLine("De 1 a 3, escolha uma linha jogador 1");
            // linha_p1 = Console.ReadLine();
            Console.WriteLine("De 1 a 3, escolha uma coluna jogador 1");
            // colum_p1 = Console.ReadLine();

            tabuleiro[linha, coluna] = jogador;
            // Console.WriteLine(tabuleiro);
        }
    }
}
