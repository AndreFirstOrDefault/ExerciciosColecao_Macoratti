using ReverterEImprimir;

//int[] arrayInt = { 1, 2, 3, 4, 5, 6 };
//string[] arrayString = { "arquivo 1", "arquivo 2", "arquivo 3", "arquivo 4", "arquivo 5", "arquivo 6" };
//double[] arrayDouble = { 1.1, 1.2, 1.3, 1.4, 1.5, 1.6 };

var arrayInt = new[] { 1, 2, 3, 4, 5, 6 };
var arrayString = new[] { "arquivo 1", "arquivo 2", "arquivo 3", "arquivo 4", "arquivo 5", "arquivo 6" };
var arrayDouble = new[] { 1.1, 1.2, 1.3, 1.4, 1.5, 1.6 };

Exemplo ex = new Exemplo();
Console.WriteLine("Imprimindo array de int...\n");
ex.ReverterEImprimir(arrayInt);
Console.WriteLine("Imprimindo array de string...\n");
ex.ReverterEImprimir(arrayString);
Console.WriteLine("Imprimindo array de double...\n");
ex.ReverterEImprimir(arrayDouble);
Console.WriteLine("Fim");

Console.ReadKey();
