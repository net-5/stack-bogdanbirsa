using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    // Show last element without modifying the stack
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stivaMea = new Stack<string>(); //am creat stack
            stivaMea.Push("1");
            stivaMea.Push("2");
            stivaMea.Push("3");
            stivaMea.Push("4");
            stivaMea.Push("5");
            stivaMea.Push("6");

            var nouaStiva = new List<string>();

            while (stivaMea.Count != 0)
            {
                string cifre = stivaMea.Pop();

                nouaStiva.Add(cifre);

                if (stivaMea.Count == 0)
                {
                    Console.WriteLine($"Ultimul element din stiva este {cifre}");
                }
            }
            nouaStiva.Reverse(); //intoarcem stiva

            foreach (string element in nouaStiva)
            {
                stivaMea.Push(element);
            }

            Console.WriteLine($"Primul element din stiva este {stivaMea.Peek()}");

        }
    }
}
