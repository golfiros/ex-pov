using System;
using System.Collections.Generic;

class Teste
{
    public decimal Porcentagem { get; init; }
    public int TotalNegociado { get; init; }
    public int Resultado { get; init; }
}

class Program
{
    static int funcaoRetornaQuantidadePOV(decimal porcentagem, int totalNegociado)
    {
        return (int)(porcentagem * totalNegociado / (1m - porcentagem));
    }
    public static void Main()
    {
        // testes basicos
        var testes = new List<Teste>()
        {
          new Teste(){Porcentagem = 0.1m, TotalNegociado = 90, Resultado = 10},
          new Teste(){Porcentagem = 0.1m, TotalNegociado = 100, Resultado = 11},
          new Teste(){Porcentagem = 0.2m, TotalNegociado = 70, Resultado = 17}
        };

        bool passaTestes = true;
        foreach (var teste in testes)
        {
            passaTestes &= funcaoRetornaQuantidadePOV(teste.Porcentagem, teste.TotalNegociado) == teste.Resultado;
        }
        if (passaTestes)
        {
            Console.WriteLine("Todos os testes passam");
        }
        else
        {
            Console.WriteLine("Há falhas em testes");
        }
    }
}
