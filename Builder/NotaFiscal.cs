using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoDeDesignPatterns.Builder
{
    public class NotaFiscal
    {
        public NotaFiscal(string razaoSocial, string cnpj, DateTime dataDeEmissao, double valorBruto, double impostos, string observacoes, IList<ItemDaNota> itemDaNotas)
        {
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
            DataDeEmissao = dataDeEmissao;
            ValorBruto = valorBruto;
            Impostos = impostos;
            Observacoes = observacoes;
            this.itemDaNotas = itemDaNotas;
        }

        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataDeEmissao { get; set; }
        public double ValorBruto { get; set; }
        public double Impostos { get; set; }
        public string Observacoes { get; set; }
        public IList<ItemDaNota> itemDaNotas { get; set; }


    }
}