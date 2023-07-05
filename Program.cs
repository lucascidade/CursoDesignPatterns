// See https://aka.ms/new-console-template for more information
using CursoDeDesignPatterns;
using CursoDeDesignPatterns.ChainsOfResposability;
using CursoDeDesignPatterns.Interfaces;
using CursoDeDesignPatterns.Strategy;
using CursoDeDesignPatterns.Strategy.Interfaces;
using CursoDeDesignPatterns.TemplateMethod;





Orcamento reforma = new(500.0);
Console.WriteLine(reforma.Valor);
reforma.AplicaDescontoExtra();
Console.WriteLine(reforma.Valor);
reforma.Aprova();

reforma.AplicaDescontoExtra();
reforma.Finaliza();
Console.WriteLine(reforma.Valor);
reforma.Reprova();




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

// Imposto iss = new ISS(new ICMS());
// Imposto icms = new ICMS();
// Imposto iccc = new ICCC();

// CalculadorDeImpostos calculador = new();

// calculador.RealizaCalculo(orcamento, icms);
// calculador.RealizaCalculo(orcamento, iss);
// calculador.RealizaCalculo(orcamento, iccc);




