﻿using ConsoleApp1.Classes;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Sprint1Method();
        }

        static void Sprint1Method()
        {
            Console.WriteLine("Here be text!");

            CoolNewClass cnc = new CoolNewClass();
            Console.WriteLine(cnc.GetData());
        }
    }
}
