using System;
using System.Collections.Generic;

public class EjemploLista
{
    public static void Main(string[] args)
    {
        List<int> numeros = new List<int>();

        numeros.Add(10);
        numeros.Add(20);
        numeros.Add(30);

        Console.WriteLine("Elementos en la lista:");

        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}
