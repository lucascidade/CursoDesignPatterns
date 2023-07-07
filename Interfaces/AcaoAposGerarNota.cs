using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoDeDesignPatterns.Builder;

namespace CursoDeDesignPatterns.Interfaces
{
    public interface AcaoAposGerarNota
    {
        void Executa(NotaFiscal notaFiscal);
    }
}