using System;
using xadrez_console.Tabuleiro;
using xadrez_console.Tabuleiro.Enum;
using xadrez_console.Xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tab Tab = new Tab(8, 8);

            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new Posicao(0, 0));
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new Posicao(1, 2));
            Tab.ColocarPeca(new Rei(Tab, Cor.Preta), new Posicao(2, 4));

            Tela.ImprimirTabuleiro(Tab);

            Console.ReadLine();
        }
    }
}
