// See https://aka.ms/new-console-template for more information
using CursoDeDesignPatterns;
using CursoDeDesignPatterns.ChainsOfResposability;
using CursoDeDesignPatterns.Interfaces;
using CursoDeDesignPatterns.Strategy;
using CursoDeDesignPatterns.Strategy.Interfaces;
using CursoDeDesignPatterns.TemplateMethod;

// TemplateDeImpostoCondicional ihit = new IHIT();
// CalculadorDeImpostos calculador = new();
// Orcamento orcamento = new(500.0);
// orcamento.AdicionaItem(new Item("CANETA", 250.0));
// orcamento.AdicionaItem(new Item("CANETA", 250.0));

// double desconta = calculador.RealizaCalculo(orcamento, ihit);
// Console.WriteLine(desconta);

// Conta conta = new();
// conta.Deposita(500);

// Investimento conservador = new Conservador();
// Investimento moderado = new Moderado();
// Investimento arrojado = new Arrojado();

// RealizadorDeInvestimentos aplica = new();

// aplica.Calcula(conta, arrojado);
// aplica.Calcula(conta, moderado);
// aplica.Calcula(conta, conservador);
















Imposto iss = new ISS(new ICMS());
// Imposto icms = new ICMS();
// Imposto iccc = new ICCC();
Orcamento orcamento = new(3001.0);
// CalculadorDeImpostos calculador = new();

// calculador.RealizaCalculo(orcamento, icms);
// calculador.RealizaCalculo(orcamento, iss);
// calculador.RealizaCalculo(orcamento, iccc);




