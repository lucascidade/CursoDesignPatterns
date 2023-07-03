using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CursoDeDesignPatterns.Interfaces;

namespace CursoDeDesignPatterns.Strategy
{
    public class RealizadorDeInvestimentos
    {
        public void Calcula(Conta conta, Investimento investimento)
        {
            double retorno = investimento.Calcula(conta);
            conta.Deposita(retorno * 0.75);
            Console.WriteLine("Novo Saldo: " + conta.Saldo);
        }
    }
}