using System;
using System.Collections.Generic;

class Program
{
    static Queue<string> colaClientes = new Queue<string>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("[1] Agregar Cliente a la Cola");
            Console.WriteLine("[2] Atender Cliente");
            Console.WriteLine("[3] Ver clientes en la Cola");
            Console.WriteLine("[4] Salir");

            Console.Write("Selecciona una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese el nombre del cliente: ");
                    string nombreCliente = Console.ReadLine();
                    AgregarCliente(nombreCliente);
                    break;
                case "2":
                    AtenderCliente();
                    break;
                case "3":
                    VerCola();
                    break;
                case "4":
                    Console.WriteLine("Saliendo del programa.");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Por favor, elige una opción válida.");
                    break;
            }
        }
    }

    static void AgregarCliente(string nombre)
    {
        colaClientes.Enqueue(nombre);
        Console.WriteLine($"{nombre} ha sido agregado a la cola.");
    }

    static void AtenderCliente()
    {
        if (colaClientes.Count == 0)
        {
            Console.WriteLine("No hay clientes en la cola.");
        }
        else
        {
            string clienteAtendido = colaClientes.Dequeue();
            Console.WriteLine($"Atendiendo a {clienteAtendido}.");
        }
    }

    static void VerCola()
    {
        if (colaClientes.Count == 0)
        {
            Console.WriteLine("La cola está vacía.");
        }
        else
        {
            Console.WriteLine("Clientes en la cola:");
            foreach (string cliente in colaClientes)
            {
                Console.WriteLine(cliente);
            }
        }
    }
}