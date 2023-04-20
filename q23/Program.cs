using static System.Console;
using System.Collections.Generic;

void candidatos = getCandidatos();

// Use as seguintes funções para realizar essa tarefa:
// collection.Select(função)
// collection.Where(condição)
// collection.Take(quantidade)
// collection.Skip(quantidade)
// collection.First()
// collection.Last()
// collection.Count()
// collection.OrderBy(função que escolhe pelo que você quer ordenar) [função quer ordena]
// collection.Average() [Função que tira média]

// Consulta 1: Nome de todos os cadidatos que obtiveram nota superior ou igual a 700 em todas as etapas
var query1 = candidatos;

foreach (var item in query1)
    WriteLine(item);


// Consulta 2: Top 3 candidatos em nota da prova
var query2 = candidatos;

foreach (var item in query2)
    WriteLine(item);

// Consulta 3: Quantidade de candidatos aprovados, isto é, nenhuma nota abaixo de 600 e ao menos uma igual ou maior que 800
var query3 = candidatos;
WriteLine(query3);

IEnumerable<Candidato> getCandidatos()
{
    yield return new Candidato
    {
        Nome = "Tigas",
        PontuacaoProva = 900,
        PontuacaoDinamica = 700,
        PontuacaoDinamica2 = 700,
        PontuacaoEntrevista = 900
    };
    
    yield return new Candidato
    {
        Nome = "Falas",
        PontuacaoProva = 900,
        PontuacaoDinamica = 900,
        PontuacaoDinamica2 = 900,
        PontuacaoEntrevista = 500
    };
    
    yield return new Candidato
    {
        Nome = "Moll",
        PontuacaoProva = 800,
        PontuacaoDinamica = 800,
        PontuacaoDinamica2 = 800,
        PontuacaoEntrevista = 800
    };
    
    yield return new Candidato
    {
        Nome = "Trevisan",
        PontuacaoProva = 500,
        PontuacaoDinamica = 500,
        PontuacaoDinamica2 = 500,
        PontuacaoEntrevista = 500
    };

    yield return new Candidato
    {
        Nome = "Don",
        PontuacaoProva = 1000,
        PontuacaoDinamica = 1000,
        PontuacaoDinamica2 = 1000,
        PontuacaoEntrevista = 1000
    };
}

public class Candidato
{
    public string Nome { get; set; }
    public int PontuacaoProva { get; set; }
    public int PontuacaoDinamica { get; set; }
    public int PontuacaoDinamica2 { get; set; }
    public int PontuacaoEntrevista { get; set; }
}