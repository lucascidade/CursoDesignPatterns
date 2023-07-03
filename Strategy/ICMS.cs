using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoDeDesignPatterns.Strategy;
using CursoDeDesignPatterns.Strategy.Interfaces;
namespace CursoDeDesignPatterns
{
    public class ICMS : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }


    }
}