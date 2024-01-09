using Tabuleiro;
using Xadrez;

namespace ChessGame
{
    internal class Tela
    {
        public static void ImprimirPartida(PartidaDeXadrez partidaDeXadrez)
        {
            ImprimirTab(partidaDeXadrez.Tab);
            Console.WriteLine();
            ImprimirPecasCapturadas(partidaDeXadrez);
            Console.WriteLine("\nTurno: " + partidaDeXadrez.Turno);
            Console.WriteLine("Aguardando jogada: " + partidaDeXadrez.JogadorAtual);
            if (partidaDeXadrez.Xeque)
            {
                Console.WriteLine("Xeque!");
            }

        }

        public static void ImprimirPecasCapturadas(PartidaDeXadrez partidaDeXadrez)
        {
            Console.WriteLine("Pecas capturadas: ");
            Console.Write("Brancas: ");
            ImprimirConjunto(partidaDeXadrez.PecasCapturadas(Cor.Branca));
            Console.Write("\nPretas: ");
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;
            ImprimirConjunto(partidaDeXadrez.PecasCapturadas(Cor.Preta));
            Console.ForegroundColor = aux;
            Console.WriteLine();

        }

        public static void ImprimirConjunto(HashSet<Peca> conjunto)
        {
            Console.Write("[");
            foreach(Peca p in conjunto)
            {
                Console.Write(p + " ");
            }
            Console.Write("]");
        }
        public static void ImprimirTab(TabuleiroGame tab)
        {
            for(int i = 0; i < tab.Linhas; i++)
            {
                Console.Write(8 - i + " ");
                for(int j = 0; j < tab.Colunas; j++)
                {
                    Tela.ImprimirPeca(tab.peca(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void ImprimirTab(TabuleiroGame tab, bool[,] posicoePossiveis)
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;
            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (posicoePossiveis[i, j])
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = fundoOriginal;
                    }
                    Tela.ImprimirPeca(tab.peca(i, j));
                    Console.BackgroundColor = fundoOriginal;
                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
            Console.BackgroundColor = fundoOriginal;

        }

        public static void ImprimirPeca(Peca peca)
        {
            if(peca == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (peca.cor == Cor.Branca)
                {
                    Console.Write(peca);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }
            
            
        }
        public static PosicaoXadrez LerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }

    }


}
