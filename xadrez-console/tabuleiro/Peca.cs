using System;
using System.Collections.Generic;
using System.Text;
using xadrez_console.Tabuleiro.Enum;

namespace xadrez_console.Tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tab Tab { get; set; }

        public Peca(Posicao posicao, Cor cor, Tab tab)
        {
            Posicao = posicao;
            Cor = cor;
            QtdMovimentos = 0;
            Tab = tab;
        }
    }
}
