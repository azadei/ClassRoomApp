﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using demo_1.Helpers;
using demo_1.Services;
using Microsoft.VisualBasic.FileIO;

namespace demo_1
{
    // teacher = name, surname, salary, bday
    
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            int option;

            do
            {
                Console.WriteLine("1. Student menu");
                Console.WriteLine("2. Teacher menu");
                Console.WriteLine("0. Exit");
                Console.WriteLine("------------------------");
                Console.WriteLine("Please, select an option:");
                Console.WriteLine("------------------------");


                while (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Please, enter a valid option:");
                    Console.WriteLine("------------------------");
                }

                switch (option)
                {
                    case 1:
                        Submenu.StudentSubMenu();
                        break;
                    case 2:
                        Submenu.TeacherSubMenu();
                        break;
                    case 0:
                        Console.WriteLine("Bye");
                        break;
                    default:
                        Console.WriteLine("No such option!");
                        break;
                }

            } while (option!=0);
        }
    }
}