using Xadrez;
using Tabuleiro;

namespace ChessGame 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez a1 = new PosicaoXadrez('a', 1);

            Console.WriteLine(a1);
            Console.WriteLine(a1.ToPosicao());

        }
    }
}
