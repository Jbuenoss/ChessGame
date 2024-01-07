using Tabuleiro;
namespace Xadrez
{
    internal class Rei : Peca
    {
        public Rei(TabuleiroGame tab, Cor cor) : base(cor, tab)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
