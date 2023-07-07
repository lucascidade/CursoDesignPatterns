using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoDeDesignPatterns.Builder
{
    class ItemDaNotaBuilder
    {
        public String Descricao { get; private set; }
        public double Valor { get; private set; }

        public ItemDaNotaBuilder ComDescricao(String descricao)
        {
            Descricao = descricao;
            return this;
        }

        public ItemDaNotaBuilder ComValor(double valor)
        {
            Valor = valor;
            return this;
        }

        public ItemDaNota Constroi()
        {
            return new ItemDaNota(Descricao, Valor);
        }
    }
}