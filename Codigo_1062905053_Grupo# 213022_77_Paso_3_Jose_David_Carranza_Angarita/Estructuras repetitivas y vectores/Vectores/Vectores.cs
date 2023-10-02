
/*Almacenar en un vector 8 números enteros positivos entre 3 y 6,
ambos incluidos, en caso de no cumplir se debe repetir la solicitud
hasta que se cumpla con la condición. Almacenar en un vector de 4
posiciones la cantidad de veces que se repite cada el 3, 4, 5 y 6. Al
final mostrar el listado de los 8 números ingresados, la cantidad de
veces que se repitió cada número y el valor de cada uno elevado a
la cantidad de veces que se repitió.*/

/*
* Nombre: Jose David Carranza Angarita
* Grupo : 213022_77
* Programa : Ingeniería de Sistemas 
* Fuente: autoria propia
* Fecha : 02/09/2023
*/


using System;

namespace paso_3_vectores
{
    class Vectores
    {
        static void Main()
        {
            Console.Title = " Estructuras Repetitivas y Vectores";

            int[] numeros = new int[8];
            int[] conteo = new int[4];

            for (int i = 0; i < numeros.Length; i++)
            {
                do
                {
                    Console.Write("Ingrese un número entero positivo entre 3 y 6 : " + (i + 1) + ": ");
                    numeros[i] = Convert.ToInt32(Console.ReadLine());
                } while (numeros[i] < 3 || numeros[i] > 6);

                conteo[numeros[i] - 3]++;
            }

            Console.WriteLine("\nNúmeros ingresados:");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Posición " + (i + 1) + ": " + numeros[i]);
            }

            Console.WriteLine("\nConteo de repeticiones y valor elevado a la cantidad de veces que se repitió:");
            for (int i = 0; i < conteo.Length; i++)
            {
                Console.WriteLine("Número " + (i + 3) + " se repitió " + conteo[i] + " veces. Valor elevado a la cantidad de veces que se repitió: " + Math.Pow(i + 3, conteo[i]));
            }

            Console.ReadKey();
        }
    }
}
