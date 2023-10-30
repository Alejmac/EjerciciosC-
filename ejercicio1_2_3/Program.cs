using ejercicio1_2_3;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        /**
        Concesionario concesionario = new Concesionario(10);

        coche c1 = new coche(1, "nissan", "versa", 2100, 250000);
        coche c2 = new coche(2, "toyota", "corola", 2100, 250000);
        coche c3 = new coche(3, "nissan", "march", 2100, 250000);
        coche c4 = new coche(4, "nissan", "datsu", 2100, 250000);
        coche c5 = new coche(5, "chevrolet", "spark", 2100, 250000);

        concesionario.anadirCoche(c1);
        concesionario.anadirCoche(c2);
        concesionario.anadirCoche(c3);
        concesionario.anadirCoche(c4);
        concesionario.anadirCoche(c5);

        concesionario.mostrarCoches();
        Console.Write("mostrar coches \n");
        concesionario.eliminarCoche(c1);
        concesionario.eliminarCoche(c3);
        Console.Write("mostrar coches2 \n");
        concesionario.vaciarCoches();
        concesionario.mostrarCoches();
        Console.ReadLine( ); 
        */

        Aleatorios a = new Aleatorios();
        // generar un numero aleatorio entre 1 y 20 
        Console.WriteLine("genero un numero aleatorio entre 1 y 20" );        
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine(a.generarNumeroAleatorio(1, 20));
        }

        // generar numeros aleatorios en un array 
        Console.WriteLine("generar numeros aleatorios por medio de un array \n");
        int[] arr = a.generarNumerosAleatorios(5, 1, 20);

        for (int i = 0; arr != null && i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }

    }
}