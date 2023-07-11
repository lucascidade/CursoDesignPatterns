using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoDeDesignPatterns.Builder;
using CursoDeDesignPatterns.Interfaces;

namespace CursoDeDesignPatterns.Observer
{
    public class Multiplicador : AcaoAposGerarNota
    {
        public double Fator { get; set; }

        public Multiplicador(double fator)
        {
            Fator = fator;
        }
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine(notaFiscal.ValorBruto * Fator);
        }
    }
}