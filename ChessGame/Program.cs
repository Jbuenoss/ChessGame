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
                    try
                    {
                        Console.Clear();
                        Tela.ImprimirPartida(partidaDeXadrez);


                        Console.Write("\nOrigem: ");
                        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                        partidaDeXadrez.ValidarPosicaoDeOrigem(origem);

                        bool[,] posicoePossiveis = partidaDeXadrez.Tab.peca(origem).MovimentosPossiveis();

                        Console.Clear();
                        Tela.ImprimirTab(partidaDeXadrez.Tab, posicoePossiveis);

                        Console.Write("\nDestino: ");
                        Posicao Destino = Tela.LerPosicaoXadrez().ToPosicao();
                        partidaDeXadrez.ValidarPosicaoDeDestino(origem, Destino);

                        partidaDeXadrez.RealizaJogada(origem, Destino);
                    }
                    catch(TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
                
            } 
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
