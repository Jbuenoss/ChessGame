using Xadrez;
using Tabuleiro;

namespace ChessGame 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TabuleiroGame tab = new TabuleiroGame(8, 8);

            tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(2, 3));
            tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(0, 7));
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 3));
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(6, 1));

            Tela.ImprimirTab(tab);
        }
    }
}
