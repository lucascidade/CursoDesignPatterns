// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;
using CursoDeDesignPatterns;
using CursoDeDesignPatterns.Builder;
using CursoDeDesignPatterns.ChainsOfResposability;
using CursoDeDesignPatterns.Interfaces;
using CursoDeDesignPatterns.Observer;
using CursoDeDesignPatterns.Strategy;
using CursoDeDesignPatterns.Strategy.Interfaces;
using CursoDeDesignPatterns.TemplateMethod;


IList<AcaoAposGerarNota> acoes = new List<AcaoAposGerarNota> {
    new EnviadorDeEmail(),
    new Multiplicador(2),
    new EnviadorDeSms()
};

NotaFiscalBuilder builder = new(acoes);


builder.ParaEmpresa("TESTE DE EMPRESA")
    .ComCnpj("05.561.915/0001-90")
    .ComItem(new ItemDaNota("item 1", 200.0))
    .ComItem(new ItemDaNota("item 2", 100.0))
    .NaDataAtual()
    .ComObservacoes("QUALQUER COISA AQUI");

Console.WriteLine(builder.RazaoSocial);
Console.WriteLine(builder.Cnpj);
Console.WriteLine(builder.Data);
// builder.AdicionaAcao(new EnviadorDeEmail());
// builder.AdicionaAcao(new EnviadorDeSms());
// builder.AdicionaAcao(new NotaFiscalDao());
// builder.AdicionaAcao(new Multiplicador(3));
// builder.AdicionaAcao(new Multiplicador(4));
NotaFiscal notaFiscal = builder.Constroi();
Console.WriteLine(notaFiscal.ValorBruto);
Console.WriteLine(notaFiscal.Impostos);



// Orcamento reforma = new(500.0);
// Console.WriteLine(reforma.Valor);
// reforma.AplicaDescontoExtra();
// Console.WriteLine(reforma.Valor);
// reforma.Aprova();

// reforma.AplicaDescontoExtra();
// reforma.Finaliza();
// Console.WriteLine(reforma.Valor);
// reforma.Reprova();




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




