using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoDeDesignPatterns.Interfaces
{
    public interface Investimento
    {
        double Calcula(Conta conta);
    }
}