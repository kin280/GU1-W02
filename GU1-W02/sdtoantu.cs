﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GU1_W02
{
    internal class sdtoantu
    {
        static void Main(string[] args)
        {
            float width;
            float height;

            Console.Write("Enter width: ");
            width = float.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            height = float.Parse(Console.ReadLine());

            float area = width * height;
            Console.WriteLine("Area is: " + area);
        }
    }
}
