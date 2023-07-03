using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoDeDesignPatterns.Interfaces;

namespace CursoDeDesignPatterns.Strategy
{
    public class Arrojado : Investimento
    {
        private Random random;

        public Arrojado()
        {
            random = new Random();
        }

        public double Calcula(Conta conta)
        {
            int chute = random.Next(10);

            if (chute >= 0 && chute <= 1) return conta.Saldo * 0.05;
            else if (chute >= 2 && chute <= 4) return conta.Saldo * 0.03;
            else return conta.Saldo * 0.06;
        }
    }
}