/*
 Exercício utilizando o comando "for":

List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

for (int i = 0; i < numeros.Count; i++)
{
    if (numeros[i] % 2 == 0)
    {
        Console.WriteLine(numeros[i]);
    }
}
*/

//Exercício utilizando o comando "foreach":

List<int> numeros = new () { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

foreach (int numerosPar in numeros)
{
    if (numerosPar % 2 == 0)
    {
        Console.WriteLine(numerosPar);
    }
}