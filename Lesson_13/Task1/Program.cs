using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;//Подключаем пространство имен Threading

namespace Task1
{
    class Program
    {


        static void Matrica()
        {
            //int[] intArr = new int[100]; // массив целых чисел
            Random insert = new Random(); //отступ потока
            Random rand = new Random(); // генерируем случайные числа
            Random lenght = new Random(); // произвольная длина массива
            char[] array = new char[lenght.Next(2, 5)]; //создаем массив в диапазоне длины от 2 до 15 элементов
            for (int i = 0; i < array.Length; i++)//Заполняем массив случайными символами
            {
                array[i] = Convert.ToChar(rand.Next('a', 'a' + 27));
            }

            object obj = new object();


            while (true)
            {
                lock (obj)
                {
                    int step = insert.Next(0, 100);
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (i == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(new string(' ', step) + array[i]);

                        }
                        else if (i == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(new string(' ', step) + array[i]);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine(new string(' ', step) + array[i]);
                        }


                    }
                }

                Thread.Sleep(500);
            }


        }

        static void Main(string[] args)
        {
            ThreadStart matrica = new ThreadStart(Matrica);//создаем делегат
            Thread thread = new Thread(matrica);//создаем класс
            thread.Start();// запускаем поток

            Thread thread2 = new Thread(matrica);//создаем класс
            thread2.Start();// запускаем поток

            Thread thread3 = new Thread(matrica);//создаем класс
            thread3.Start();// запускаем поток

            Matrica();



            Console.ReadKey();
        }
    }
}
