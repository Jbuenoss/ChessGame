using Xadrez;
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

                    Console.Write("Destino: ");
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
