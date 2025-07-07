using System;
using System.Collections.Generic;

public class EjemploDiccionario
{
    public static void Main(string[] args)
    {
        Dictionary<string, int> edades = new Dictionary<string, int>();

        edades.Add("Alice", 30);
        edades.Add("Bob", 24);
        edades.Add("Charlie", 35);

        if (edades.TryGetValue("Bob", out int edadBob))
        {
            Console.WriteLine($"La edad de Bob es: {edadBob}");
        }
        else
        {
            Console.WriteLine("Bob no se encontró en el diccionario.");
        }
        if (edades.TryGetValue("David", out int edadDavid))
        {
            Console.WriteLine($"La edad de David es: {edadDavid}");
        }
        else
        {
            Console.WriteLine("David no se encontró en el diccionario.");
        }
    }
}