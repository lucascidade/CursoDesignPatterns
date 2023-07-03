using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoDeDesignPatterns.Interfaces;
using CursoDeDesignPatterns.Strategy.Interfaces;

namespace CursoDeDesignPatterns.Strategy
{
    public class Moderado : Investimento
    {
        private Random random;

        public Moderado()
        {
            random = new Random();
        }

        public double Calcula(Conta conta)
        {
            if (random.Next(2) == 0)
                return conta.Saldo * 0.025;
            else
                return conta.Saldo * 0.07;
        }
    }
}