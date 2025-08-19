using System;

public class Nodo
{
    public int valor;
    public Nodo izquierdo;
    public Nodo derecho;

    public Nodo(int valor)
    {
        this.valor = valor;
        this.izquierdo = null;
        this.derecho = null;
    }
}

public class ArbolBinarioBusqueda
{
    private Nodo raiz;

    public ArbolBinarioBusqueda()
    {
        raiz = null;
    }

    public void Insertar(int valor)
    {
        raiz = InsertarRecursivo(raiz, valor);
    }

    private Nodo InsertarRecursivo(Nodo nodoActual, int valor)
    {
        if (nodoActual == null)
        {
            return new Nodo(valor);
        }

        if (valor < nodoActual.valor)
        {
            nodoActual.izquierdo = InsertarRecursivo(nodoActual.izquierdo, valor);
        }
        else if (valor > nodoActual.valor)
        {
            nodoActual.derecho = InsertarRecursivo(nodoActual.derecho, valor);
        }

        return nodoActual;
    }

    public bool Buscar(int valor)
    {
        return BuscarRecursivo(raiz, valor);
    }

    private bool BuscarRecursivo(Nodo nodoActual, int valor)
    {
        if (nodoActual == null)
        {
            return false;
        }

        if (valor == nodoActual.valor)
        {
            return true;
        }

        if (valor < nodoActual.valor)
        {
            return BuscarRecursivo(nodoActual.izquierdo, valor);
        }
        else
        {
            return BuscarRecursivo(nodoActual.derecho, valor);
        }
    }

    public void RecorridoInorden()
    {
        Console.Write("Recorrido Inorden: ");
        RecorridoInordenRecursivo(raiz);
        Console.WriteLine();
    }
    private void RecorridoInordenRecursivo(Nodo nodo)
    {
        if (nodo != null)
        {
            RecorridoInordenRecursivo(nodo.izquierdo);
            Console.Write(nodo.valor + " ");
            RecorridoInordenRecursivo(nodo.derecho);
        }
    }

    public void RecorridoPreorden()
    {
        Console.Write("Recorrido Preorden: ");
        RecorridoPreordenRecursivo(raiz);
        Console.WriteLine();
    }
    private void RecorridoPreordenRecursivo(Nodo nodo)
    {
        if (nodo != null)
        {
            Console.Write(nodo.valor + " ");
            RecorridoPreordenRecursivo(nodo.izquierdo);
            RecorridoPreordenRecursivo(nodo.derecho);
        }
    }

    public void RecorridoPostorden()
    {
        Console.Write("Recorrido Postorden: ");
        RecorridoPostordenRecursivo(raiz);
        Console.WriteLine();
    }
    private void RecorridoPostordenRecursivo(Nodo nodo)
    {
        if (nodo != null)
        {
            RecorridoPostordenRecursivo(nodo.izquierdo);
            RecorridoPostordenRecursivo(nodo.derecho);
            Console.Write(nodo.valor + " ");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ArbolBinarioBusqueda abb = new ArbolBinarioBusqueda();

        abb.Insertar(8);
        abb.Insertar(3);
        abb.Insertar(10);
        abb.Insertar(1);
        abb.Insertar(6);
        abb.Insertar(14);
        abb.Insertar(4);
        abb.Insertar(7);
        abb.Insertar(13);

        Console.WriteLine("Árbol Binario de Búsqueda creado.");
        Console.WriteLine("----------------------------------");

        int valorABuscar = 6;
        Console.WriteLine($"Buscando el valor {valorABuscar}: " + (abb.Buscar(valorABuscar) ? "Encontrado" : "No encontrado"));

        valorABuscar = 99;
        Console.WriteLine($"Buscando el valor {valorABuscar}: " + (abb.Buscar(valorABuscar) ? "Encontrado" : "No encontrado"));

        Console.WriteLine("----------------------------------");

        abb.RecorridoInorden();
        abb.RecorridoPreorden();
        abb.RecorridoPostorden();
    }
}
