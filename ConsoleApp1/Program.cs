// writeline mostra a saida de dados e quebra a linha

using System.Globalization;

Console.WriteLine("Primeira linha");
Console.WriteLine("Segunda linha");

//write mostra a saida de dados e nao quebra a linha

Console.Write("Sem quebra de linha ");
Console.Write("Exemplo");
Console.WriteLine(".");

//Para escrever o conteudo de uma variavel com ponto flutuante

//suponha uma variavel tipo double declarada e iniciada

double x = 10.35784;

Console.WriteLine(x);

Console.WriteLine(x.ToString("F2"));
Console.WriteLine(x.ToString("F4"));

Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
