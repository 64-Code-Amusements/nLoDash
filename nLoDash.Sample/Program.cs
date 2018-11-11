using System;
using System.IO;

using static Floatingman.nLoDash._;

namespace nLoDash.Sample {
    class Program {
        static void Main (string[] args) {
            Run (Using (File.CreateText (Path.GetTempFileName ()), func => ((StreamWriter) func).Write ("Hey there")));
            Console.WriteLine ("");
        }

        static Option Run<T> (Func<T, Option> func) {
            return func ();
        }
    }
}