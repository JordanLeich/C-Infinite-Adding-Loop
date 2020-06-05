// Made by Jordan Leich on 6/5/2020

using System;
using System.Threading;

namespace Infinite_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the infinite adding loop! ");
            Console.WriteLine("");
            Thread.Sleep(3000);

            int Number = 0;
            int Another_Number = 0;

            while (Number == 0)
            {
                Another_Number += 1;
                Console.WriteLine(Another_Number);
                Thread.Sleep(75);
            }
        }
    }
}
