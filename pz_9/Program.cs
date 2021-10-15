using System;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[] S = new int[8];// объявление массива для побочной матрицы

            int[,] A = new int[8, 8]; // объявление двумерного массива
            Console.WriteLine("Матрица А:");
            Random rnd = new Random(); // объявление класса Random
            for (i = 0; i <= 7; i++) // строки
            {
                for (j = 0; j <= 7; j++) // столбцы
                {
                    A[i, j] = rnd.Next(10, 90); // запись рандом. чисел в массив
                    Console.Write(A[i, j] + " "); // вывод

                }
                Console.WriteLine();




            }
            Console.WriteLine("Элементы побочной диагонали:");
            for (i = 0; i <= 7; i++) // строки
            {
                for (j = 0; j <= 7; j++) // столбцы
                {
                    if (i == 8 - j - 1) // проверка на побочную диагональ
                    {
                        S[i] = A[i, j]; // присв.

                    }


                }
                Console.Write(S[i] + " "); // вывод 

            }
            Console.WriteLine(" ");
            Array.Sort(S); // сортировка побочной диагонали
            Console.WriteLine("Максимальное число: " + S[7]); // вывод макс. числа побоч. диагонали
            Console.ReadLine();
        }
       
    }
}
