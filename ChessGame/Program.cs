﻿using Xadrez;
using Tabuleiro;

namespace ChessGame 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partidaDeXadrez = new PartidaDeXadrez();
                while (!partidaDeXadrez.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTab(partidaDeXadrez.Tab);


                    Console.Write("\nOrigem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();

                    bool[,] posicoePossiveis = partidaDeXadrez.Tab.peca(origem).MovimentosPossiveis();

                    Console.Clear();
                    Tela.ImprimirTab(partidaDeXadrez.Tab, posicoePossiveis);

                    Console.Write("\nDestino: ");
                    Posicao Destino = Tela.LerPosicaoXadrez().ToPosicao();

                    partidaDeXadrez.ExecutaMovimento(origem, Destino);
                }
                
            } 
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
