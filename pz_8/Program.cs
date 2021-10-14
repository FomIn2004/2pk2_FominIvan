using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int max;//переменная для нахождения макс.значения
            char[] A = new char[10];// создание массива на 10 элементов

            Console.WriteLine("Введите посимвольно 10 элементов: ");
            for (i = 0; i <= 9; i++)
            {
                A[i] = char.Parse(Console.ReadLine()); // ввод значений с клавиатуры

            }
            Console.WriteLine("Вывод массива в порядке возрастания:");
            for (i = 0; i <= 9; i++)
            {
                Array.Sort(A); // сортировка элементов
                Console.WriteLine(A[i]); // вывод элементов массива в порядке возрастания





            }
            max = A.Max(); // к переменной присвоить макс. значение
            Console.WriteLine("Максимальное значение массива:" + max); // вывод макс. значения массива
            Console.ReadKey();
        }
    }
}
