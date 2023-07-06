using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoDeDesignPatterns.Builder
{
    public class ItemDaNota
    {
        public string NomeItem;
        public double Valor;

        public ItemDaNota(string nomeItem, double valor)
        {
            NomeItem = nomeItem;
            Valor = valor;
        }
    }


}