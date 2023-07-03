using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoDeDesignPatterns
{
    public class Conta
    {
        public double Saldo { get; private set; }

        public void Deposita(double saldo)
        {
            Saldo += saldo;
        }
    }
}