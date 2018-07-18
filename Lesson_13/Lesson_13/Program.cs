using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lesson_13
{
    class Program
    {
        static void FirstMehtod()
        {
            while (true)
            {
                Console.WriteLine(new string(' ',20) + "Это первый метод");
            }
        }
        static int deep;
        static void RecursMethod()
        {
            Console.WriteLine("{0} номер потока", Thread.CurrentThread.Name);
            Thread recursMehtod = new Thread(RecursMethod);
            deep++;
            recursMehtod.Name = "Thread " + deep;
            recursMehtod.Start();

        }
        static void Main(string[] args)
        {
            //ThreadStart firstMethod = new ThreadStart(FirstMehtod);
            //Thread thread = new Thread(firstMethod);
            //thread.Start();


            //while (true)
            //{
            //    Console.WriteLine("Это второй метод");

            //}

            Thread thread = new Thread(RecursMethod) { Name = "Thread " + deep };
            thread.Start();

        }
    }
}
