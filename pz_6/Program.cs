using System;

namespace pz_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int summ = 0;
             


            a = int.Parse(Console.ReadLine()); // ввод числа 

            if (a % 2 == 0) // если четное 
            {
                //a = a + 1;
                Console.WriteLine($"Вы ввели число {a} - оно чётное! Следующее число - {a + 1}");
                
               
            }
            else
            {
                Console.WriteLine($"Вы ввели число {a} - нечётное!");
            }
            int i = a;
            if(i%2!=0) // не заходим в этот блок если четное
            {

            
            while (i <= a * 2)  // счетчик диапазона
            {

                
             
               
                for (int i1 = i; i1 < i * 2; i1++) continue; // выбор всех нечетных из диапазона
                {
                    if(i%2!=0)
                    {
                        Console.WriteLine(i); // вывод всех нечетных чисел
                        summ = summ + i; // сложение всех нечетных
                    }

                   

                }
                
                i++; // прибавление счетчика 


            }
            Console.WriteLine("Сумма нечетных равна: " + summ); // вывод суммы нечетных
            }
            Console.ReadKey();



        }


            
            
        }
    }

