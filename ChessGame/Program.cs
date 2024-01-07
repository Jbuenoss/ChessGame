using Xadrez;
using Tabuleiro;

namespace ChessGame 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TabuleiroGame tab = new TabuleiroGame(8, 8);

            tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 0));
            tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(1, 0));
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(2, 0));


            Tela.ImprimirTab(tab);

        }
    }
}
