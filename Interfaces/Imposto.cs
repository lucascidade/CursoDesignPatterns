using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoDeDesignPatterns.Strategy.Interfaces
{
    public interface Imposto
    {
        double Calcula(Orcamento orcamento);
    }
}