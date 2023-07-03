using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoDeDesignPatterns.Strategy;
using CursoDeDesignPatterns.Strategy.Interfaces;

namespace CursoDeDesignPatterns
{
    public class CalculadorDeImpostos
    {
        public double RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            double valor = imposto.Calcula(orcamento);

            return valor;

        }
    }
}