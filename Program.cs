﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApplication1 {
    class Program {
        static void Main (string[] args) {
            long i = 0;
            DirectoryInfo dirInfo = new DirectoryInfo (@"E:\temp");

            //foreach (var f in Directory.EnumerateFiles(@"E:\temp", "*", SearchOption.AllDirectories)) {
            foreach (var f in Directory.EnumerateDirectories(@"E:\", "*", SearchOption.AllDirectories)) {
                //Console.WriteLine ("{0}", f.ToString());
                i++;
            }
            Console.WriteLine ("{0}", i);
        }
    }
}