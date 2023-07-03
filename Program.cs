﻿// See https://aka.ms/new-console-template for more information
using CursoDeDesignPatterns;
using CursoDeDesignPatterns.ChainsOfResposability;
using CursoDeDesignPatterns.Interfaces;
using CursoDeDesignPatterns.Strategy;
using CursoDeDesignPatterns.Strategy.Interfaces;




CalculadorDeDescontos calculador = new();
Orcamento orcamento = new(500.0);
orcamento.AdicionaItem(new Item("CANETA", 500.0));
orcamento.AdicionaItem(new Item("LAPIS", 500.0));

double desconta = calculador.Calcula(orcamento);
Console.WriteLine(desconta);

// Conta conta = new();
// conta.Deposita(500);

// Investimento conservador = new Conservador();
// Investimento moderado = new Moderado();
// Investimento arrojado = new Arrojado();

// RealizadorDeInvestimentos aplica = new();

// aplica.Calcula(conta, arrojado);
// aplica.Calcula(conta, moderado);
// aplica.Calcula(conta, conservador);
















// Imposto iss = new ISS();
// Imposto icms = new ICMS();
// Imposto iccc = new ICCC();
// Orcamento orcamento = new(3001.0);
// CalculadorDeImpostos calculador = new();

// calculador.RealizaCalculo(orcamento, icms);
// calculador.RealizaCalculo(orcamento, iss);
// calculador.RealizaCalculo(orcamento, iccc);



