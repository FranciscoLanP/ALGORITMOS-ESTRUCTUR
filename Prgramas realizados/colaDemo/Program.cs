using System;
using System.Collections.Generic;

public class Cola<T>
{
    private readonly List<T> _listaDeElementos = new List<T>();

    public void Encolar(T elemento)
    {
        _listaDeElementos.Add(elemento);
        Console.WriteLine($"Elemento '{elemento}' encolado.");
    }

    public T Desencolar()
    {
        if (EstaVacia())
            throw new InvalidOperationException("La cola está vacía. No se puede desencolar.");

        T elementoFrente = _listaDeElementos[0];
        _listaDeElementos.RemoveAt(0);
        Console.WriteLine($"Elemento '{elementoFrente}' desencolado.");
        return elementoFrente;
    }

    public T Frente()
    {
        if (EstaVacia())
            throw new InvalidOperationException("La cola está vacía. No hay elemento en el frente.");

        return _listaDeElementos[0];
    }

    public bool EstaVacia() => _listaDeElementos.Count == 0;

    public int Tamano() => _listaDeElementos.Count;

    public void MostrarCola()
    {
        if (EstaVacia())
        {
            Console.WriteLine("La cola está vacía.");
            return;
        }

        Console.WriteLine("Elementos de la cola (Frente a Final):");
        foreach (var elemento in _listaDeElementos)
        {
            Console.WriteLine(elemento);
        }
    }
}

public class Programa
{
    public static void Main(string[] args)
    {
        var miCola = new Cola<int>();

        Console.WriteLine("Cola creada. ¿Está vacía? " + miCola.EstaVacia());

        miCola.Encolar(10);
        miCola.Encolar(20);
        miCola.Encolar(30);

        miCola.MostrarCola();

        Console.WriteLine("Elemento en el frente: " + miCola.Frente());

        miCola.Desencolar(); 
        miCola.Desencolar(); 

        miCola.MostrarCola();

        try
        {
            miCola.Desencolar(); 
            miCola.Desencolar(); 
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine("ERROR: " + e.Message);
        }

        Console.WriteLine("¿Está la cola vacía ahora? " + miCola.EstaVacia());
        Console.WriteLine("Tamaño actual: " + miCola.Tamano());
    }
}
