using System;
using System.Collections.Generic;

public class EjemploPilaIncorporada
{
    public static void Main(string[] args)
    {
        Stack<int> miPilaIncorporada = new Stack<int>();

        Console.WriteLine("--- Ejemplo de Pila Incorporada ---");

        miPilaIncorporada.Push(100);
        miPilaIncorporada.Push(200);
        miPilaIncorporada.Push(300);

        Console.WriteLine($"Elemento superior: {miPilaIncorporada.Peek()}");
        Console.WriteLine($"Cantidad: {miPilaIncorporada.Count}");

        int elementoSacado = miPilaIncorporada.Pop();
        Console.WriteLine($"Se sacó: {elementoSacado}");

        Console.WriteLine($"Cantidad después de sacar: {miPilaIncorporada.Count}");

        
        Console.WriteLine("Elementos de la pila (enumerados):");
        foreach (int item in miPilaIncorporada)
        {
            Console.WriteLine(item);
        }

        miPilaIncorporada.Clear(); 
        Console.WriteLine($"Cantidad después de limpiar: {miPilaIncorporada.Count}");
    }
}
