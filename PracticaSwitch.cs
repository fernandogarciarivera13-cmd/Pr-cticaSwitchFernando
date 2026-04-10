using System;
using System.Linq;

namespace Prácticaswitch;

public static class Program
{
    public static void Main()
    {

        int opcion;
        do
        {
            Console.WriteLine("===== MENÚ DE OPCIONES =====");
            Console.WriteLine("1. Calcular potencia");
            Console.WriteLine("2. Convertir km a metros");
            Console.WriteLine("3. Convertir pesos a dólares");
            Console.WriteLine("4. Convertir °C a °F");
            Console.WriteLine("5. Ordenar números");
            Console.WriteLine("6. FizzBuzz");
            Console.WriteLine("0. Salir");
            Console.Write("Selecciona una opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingresa la base: ");
                    double baseNum = double.Parse(Console.ReadLine());
                    Console.Write("Ingresa el exponente: ");
                    double exp = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Resultado: {Math.Pow(baseNum, exp)}");
                    break;

                case 2:
                    Console.Write("Ingresa kilómetros: ");
                    double km = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{km} km = {km * 1000} metros");
                    break;

                case 3:
                    Console.Write("Ingresa cantidad en pesos: ");
                    double pesos = double.Parse(Console.ReadLine());
                    Console.Write("Ingresa tipo de cambio (pesos por dólar): ");
                    double tipoCambio = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{pesos} pesos = {pesos / tipoCambio} dólares");
                    break;

                case 4:
                    Console.Write("Ingresa grados Celsius: ");
                    double celsius = double.Parse(Console.ReadLine());
                    double fahrenheit = (celsius * 9 / 5) + 32;
                    Console.WriteLine($"{celsius} °C = {fahrenheit} °F");
                    break;

                case 5:
                    Console.Write("¿Cuántos números deseas ordenar?: ");
                    int cantidad = int.Parse(Console.ReadLine());
                    int[] numeros = new int[cantidad];
                    for (int i = 0; i < cantidad; i++)
                    {
                        Console.Write($"Número {i + 1}: ");
                        numeros[i] = int.Parse(Console.ReadLine());
                    }
                    Array.Sort(numeros);
                    Console.WriteLine("Números ordenados: " + string.Join(", ", numeros));
                    break;

                case 6:
                    Console.Write("Ingresa el límite para FizzBuzz: ");
                    int limite = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= limite; i++)
                    {
                        if (i % 3 == 0 && i % 5 == 0)
                            Console.WriteLine("FizzBuzz");
                        else if (i % 3 == 0)
                            Console.WriteLine("Fizz");
                        else if (i % 5 == 0)
                            Console.WriteLine("Buzz");
                        else
                            Console.WriteLine(i);
                    }
                    break;

                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción inválida, intenta de nuevo.");
                    break;
            }

            Console.WriteLine(); // Espacio entre ejecuciones
        } while (opcion != 0);
    }
}

