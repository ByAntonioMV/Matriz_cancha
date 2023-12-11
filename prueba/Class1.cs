using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba
{
    public class Class1
    {
        public void CrearMatrizYMostrar()
        {
            // Declarar e inicializar una matriz de 2x3
            int[,] matriz = new int[2, 3];

            // Asignar valores a la matriz
            matriz[0, 0] = 1;
            matriz[0, 1] = 2;
            matriz[0, 2] = 3;
            matriz[1, 0] = 4;
            matriz[1, 1] = 5;
            matriz[1, 2] = 6;

            // Mostrar la matriz
            Console.WriteLine("Matriz:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

