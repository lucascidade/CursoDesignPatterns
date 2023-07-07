using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoDeDesignPatterns.Builder;
using CursoDeDesignPatterns.Interfaces;

namespace CursoDeDesignPatterns.Observer
{
    public class EnviadorDeSms : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Simulacao de envio de SMS");
        }
    }
}