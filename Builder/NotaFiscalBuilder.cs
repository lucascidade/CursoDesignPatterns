using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoDeDesignPatterns.Interfaces;

namespace CursoDeDesignPatterns.Builder
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string Observacoes { get; private set; }
        public string Cnpj { get; private set; }
        public DateTime Data { get; private set; }
        private double valorTotal;
        private double impostos;
        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();
        private IList<AcaoAposGerarNota> todasAcoesASeremExecutadas = new List<AcaoAposGerarNota>();


        public NotaFiscalBuilder(IList<AcaoAposGerarNota> lista)
        {
            todasAcoesASeremExecutadas = lista;
        }

        public NotaFiscalBuilder()
        {
        }

        public NotaFiscal Constroi()
        {
            NotaFiscal notaFiscal = new NotaFiscal(RazaoSocial, Cnpj, Data, valorTotal, impostos, Observacoes, todosItens);
            foreach (AcaoAposGerarNota acao in todasAcoesASeremExecutadas)
            {
                acao.Executa(notaFiscal);
            }
            return notaFiscal;
        }

        public void AdicionaAcao(AcaoAposGerarNota novaAcao)
        {
            todasAcoesASeremExecutadas.Add(novaAcao);
        }

        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this;
        }
        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(string observacoes)
        {
            Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder NaDataAtual()
        {
            Data = DateTime.Now;
            return this;
        }
        public NotaFiscalBuilder ComItem(ItemDaNota item)
        {
            todosItens.Add(item);
            valorTotal += item.Valor;
            impostos += item.Valor * 0.05;
            return this;
        }
    }
}