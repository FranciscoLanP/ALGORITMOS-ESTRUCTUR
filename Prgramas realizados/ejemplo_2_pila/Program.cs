using System;
using System.Collections.Generic;

public class MiPila<T>
{
    private List<T> _elementos;

    public MiPila()
    {
        _elementos = new List<T>();
    }

    public void Push(T item)
    {
        _elementos.Add(item);
        Console.WriteLine($"Se añadió: {item}");
    }

    public T Pop()
    {
        if (EstaVacia())
        {
            throw new InvalidOperationException("La pila está vacía. No se puede sacar.");
        }

        int ultimoIndice = _elementos.Count - 1;
        T item = _elementos[ultimoIndice];
        _elementos.RemoveAt(ultimoIndice);
        Console.WriteLine($"Se sacó: {item}");
        return item;
    }

    public T Peek()
    {
        if (EstaVacia())
        {
            throw new InvalidOperationException("La pila está vacía. No se puede ver el tope.");
        }

        return _elementos[_elementos.Count - 1];
    }

    public bool EstaVacia()
    {
        return _elementos.Count == 0;
    }

    public int Cantidad
    {
        get { return _elementos.Count; }
    }

    public void MostrarPila()
    {
        if (EstaVacia())
        {
            Console.WriteLine("La pila está vacía.");
            return;
        }

        Console.WriteLine("Elementos de la pila (de Arriba a Abajo):");
        for (int i = _elementos.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(_elementos[i]);
        }
    }
}

public class Programa
{
    public static void Main(string[] args)
    {
        MiPila<int> pilaEnteros = new MiPila<int>();

        Console.WriteLine("--- Operaciones con Pila de Enteros ---");
        pilaEnteros.Push(10);
        pilaEnteros.Push(20);
        pilaEnteros.Push(30);

        pilaEnteros.MostrarPila();

        Console.WriteLine($"\n¿Está la pila vacía? {pilaEnteros.EstaVacia()}");
        Console.WriteLine($"Cantidad de elementos en la pila: {pilaEnteros.Cantidad}");

        Console.WriteLine($"\nElemento en la cima (Peek): {pilaEnteros.Peek()}");

        pilaEnteros.Pop();
        pilaEnteros.MostrarPila();

        pilaEnteros.Pop();
        pilaEnteros.MostrarPila();

        try
        {
            pilaEnteros.Pop();
            pilaEnteros.Pop(); 
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"\nError: {ex.Message}");
        }

        Console.WriteLine($"\n¿Está la pila vacía después de sacar elementos? {pilaEnteros.EstaVacia()}");
        pilaEnteros.MostrarPila();

        Console.WriteLine("\n--- Operaciones con Pila de Cadenas ---");
        MiPila<string> pilaCadenas = new MiPila<string>();
        pilaCadenas.Push("Manzana");
        pilaCadenas.Push("Banana");
        pilaCadenas.Push("Cereza");

        pilaCadenas.MostrarPila();
        Console.WriteLine($"Elemento superior de la cadena: {pilaCadenas.Peek()}");
        pilaCadenas.Pop();
        pilaCadenas.MostrarPila();
    }
}

