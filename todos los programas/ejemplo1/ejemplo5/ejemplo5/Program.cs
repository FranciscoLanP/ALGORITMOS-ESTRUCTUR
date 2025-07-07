using System;
using System.Collections.Generic;

public class EjemploHashSet
{
    public static void Main(string[] args)
    {
        HashSet<string> frutas = new HashSet<string>();

        frutas.Add("Manzana");
        frutas.Add("Banana");
        frutas.Add("Naranja");
        frutas.Add("Manzana"); 

        Console.WriteLine("Frutas en el conjunto:");

        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        if (frutas.Contains("Banana"))
        {
            Console.WriteLine("\nEl conjunto contiene Banana.");
        }

        if (frutas.Contains("Uva"))
        {
            Console.WriteLine("El conjunto contiene Uva.");
        }
        else
        {
            Console.WriteLine("El conjunto NO contiene Uva.");
        }
    }
}