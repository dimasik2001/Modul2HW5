﻿using System;
using System.IO;
using Newtonsoft.Json;

namespace Modul2HW5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var starter = new AppStarter();
            starter.Run();
            Console.ReadKey();
        }
    }
}
