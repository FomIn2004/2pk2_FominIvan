using System;

namespace pz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int k;
           
            Console.WriteLine("Задание 1");
            for (k = 30; k <= 150; k += 15 ) // пока к меньше либо равно 150 - работает, шаг - к+= 15 - через каждые 15 чисел
            {

               Console.WriteLine(k); // вывод
            }
            //Console.ReadLine();


            // Задание 2
            
            Console.WriteLine("Задание 2");
            char sim = 'н'; // объявление
            for (var i = 0; i < 5; i++) // пока i меньше 5, выполняется
            {
                Console.Write(" " + sim); // вывод
                sim++;

           }
            // Задание 3
            Console.WriteLine(" ");
            
            Console.WriteLine("Задание 3");

            var a = "#"; // объявление переменной с символом 
            for (int i = 0; i != 10 ; i++) // пока i не будет 6 - работает
            {
                for (int j = 0; j != 6; j++) // влож. цикл для другой стороны прямоугольника . 10 строчек по 6 символов в строчке
                {
                    Console.Write(a);// вывод


                }
                Console.WriteLine();
            }

            // Задание 4
            Console.WriteLine("Задание 4");
            for (int i = 0; i != 100; i++) // цикл до 100
            {
                var number = i % 18; // если кратно 18 
                if(number == 0) 
                {
                    Console.WriteLine(i); // вывод
                }

            }
            // Задание 5
            Console.WriteLine("Задание 5");
             int j1 = 35; //  объявление переменной, и присвоение ей значения 35
            for (int i = 0; i < j1 + 3; i++) // разница - 3
             {
            Console.WriteLine(i + " " + j1); // вывод
             j1--;
            }
           







        }
    }
}

