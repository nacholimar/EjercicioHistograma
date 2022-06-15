﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHistograma
{
    class Program
    {
        /* 
        Pregunta 10
        Escribir un programa en C# que recorra un arreglo y genere un histograma en base a los números de este. El arreglo se llama myArray y contiene 10 elementos que corresponden a números enteros del 1 al 5. Un histograma representa que tanto un elemento aparece en un conjunto de datos (Debe mostrar la frecuencia para todos los números del 1 al 5, incluso si no están presentes en el arreglo). Por ejemplo, para el arreglo: myArray:=(1,2,1,3,3,1,2,1,5,1) el histograma se vería así:

        1: *****
        2: **
        3: **
        4:
        5: *

        El código para declarar y poblar myArray ya está ahí, puede editarlo para probar con otros valores y puede hacer clic en el botón de actualizar junto a él para volver al valor original que se utilizará para validar su código durante la prueba. Asegúrese de que los resultados se impriman exactamente como aparecen aquí, ya que incluso un espacio faltante o sobrante puede marcar la pregunta como incorrecta (Notar espacio entre los ":" y el primer asterisco).

        Nota: Asumir que esta escribiendo el codigo dentro de una clase, por lo que no debe declarar la clase en si, solo el metodo public static void main para ejecutar su código.
        */
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 1, 3, 3, 1, 2, 1, 5, 1 };

            string uno = "1: ";
            string dos = "2: ";
            string tres = "3: ";
            string cuatro = "4: ";
            string cinco = "5: ";
            string result = "";
            foreach (int item in myArray)
            {
                switch (item)
                {
                    case 1:
                        uno += "*";
                        break;
                    case 2:
                        dos += "*";
                        break;
                    case 3:
                        tres += "*";
                        break;
                    case 4:
                        cuatro += "*";
                        break;
                    case 5:
                        cinco += "*";
                        break;
                }
            }
            result += uno + "\n" + dos + "\n" + tres + "\n" + cuatro + "\n" + cinco;

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
