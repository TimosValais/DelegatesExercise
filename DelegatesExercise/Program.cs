﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeClass home = new HomeClass();
            PrintHome print = i => Console.WriteLine(i.Name + " " + i.Address);
            print(home);
        }

        public delegate void PrintHome(HomeClass home);
    }
}
