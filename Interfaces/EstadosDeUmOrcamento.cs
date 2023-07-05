using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoDeDesignPatterns.Interfaces
{
    public interface EstadosDeUmOrcamento
    {
        void AplicaDescontoExtra(Orcamento orcamento);
        void Aprova(Orcamento orcamento);
        void Reprova(Orcamento orcamento);
        void Finaliza(Orcamento orcamento);

    }
}