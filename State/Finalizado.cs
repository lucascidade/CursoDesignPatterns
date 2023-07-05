using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoDeDesignPatterns.Interfaces;

namespace CursoDeDesignPatterns.State
{
    public class Finalizado : EstadosDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos Finalizados/Reprovados não recebem descontos");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("O orçamento já está finalizado, não pode sofrer alteração de estados.");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("O orçamento já está finalizado, não pode sofrer alteração de estados.");
        }
        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("O orçamento já está finalizado, não pode sofrer alteração de estados.");
        }


    }
}