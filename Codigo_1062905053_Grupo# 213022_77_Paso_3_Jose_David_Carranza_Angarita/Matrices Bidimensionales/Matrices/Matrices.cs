/*La La liga de atletismo Corriendo Ligero tiene 6 corredores de 100
metros planos de los cuales necesita clasificar mínimo 2 para las
finales del torneo nacional de atletismo. Almacenar en un vector de
tipo string el nombre de cada atleta y en una matriz de 6X6, tipo
entero, los tiempos de cada carrera realizada, recuerde que cada fila
corresponde a los tiempos de un corredor en las 6 carreras y cada
columna corresponde a los tiempos en cada carrera.
Para la clasificación se usará dos criterios, el primero será el mejor
registro (el menor tiempo) que se ha obtenido en una carrera y el
segundo será el mejor promedio por carrera. Sí alguno de los
tiempos es mayor a 10.4 segundos el atleta queda descalificado. Al
final mostrar por pantalla toda la información de los atletas
3
(nombres y tiempos por carrera) y los nombres de los clasificados
con sus tiempos, en caso de empate se mostrarán todos los nombres
y en caso de descalificación mostrar un mensaje que incluya el
tiempo.
*/

/*
* Nombre: Jose David Carranza Angarita
* Grupo : 213022_77
* Programa : Ingeniería de Sistemas 
* Fuente: autoria propia
* Fecha : 02/09/2023
*/


using System;

namespace Paso_3_Matrices
{
    class Matrices
    {
        static void Main()
        {
            Console.Title = "Matrices Bidimencionales";

            string[] nombres = new string[6];
            double[,] tiempos = new double[6, 6];
            double[] promedios = new double[6];
            double[] mejoresTiempos = new double[6];

            for (int i = 0; i < 6; i++)
            {
                Console.Write("Ingrese el nombre del atleta " + (i + 1) + ": ");
                nombres[i] = Console.ReadLine();

                double mejorTiempo = Double.MaxValue;
                double sumaTiempos = 0;

                for (int j = 0; j < 6; j++)
                {
                    Console.Write("Ingrese el tiempo de la carrera " + (j + 1) + " del atleta " + nombres[i] + ": ");
                    tiempos[i, j] = Double.Parse(Console.ReadLine());

                    if (tiempos[i, j] > 10.4)
                    {
                        Console.WriteLine("El atleta " + nombres[i] + " ha sido descalificado por tener un tiempo mayor a 10.4 segundos.");
                        return;
                    }

                    if (tiempos[i, j] < mejorTiempo)
                    {
                        mejorTiempo = tiempos[i, j];
                    }

                    sumaTiempos += tiempos[i, j];
                }

                mejoresTiempos[i] = mejorTiempo;
                promedios[i] = sumaTiempos / 6.0;
            }

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("\nAtleta: " + nombres[i]);
                Console.WriteLine("Mejor tiempo: " + mejoresTiempos[i]);
                Console.WriteLine("Promedio de tiempos: " + promedios[i]);
            }

            Console.ReadKey();
        }
    }
}
