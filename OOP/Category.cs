﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void PrintInfo()
        {
            Console.WriteLine($"Id: {Id}\t{Name}");
        }
    }
}
