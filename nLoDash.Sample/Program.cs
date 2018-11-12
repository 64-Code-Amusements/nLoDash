using System;
using System.IO;

using static Floatingman.nLoDash._;
using Floatingman.nLoDash;

namespace nLoDash.Sample {
    class Program {
        static void Main (string[] args) {

            var s = Using<StreamWriter, Option<int>> (File.CreateText (Path.GetTempFileName ()), func => {
                    ((StreamWriter) func).Write ("Hey there");
                    return None;
                });
            Console.WriteLine (s);

            Console.WriteLine (Greet (None));
            Console.WriteLine (Greet ("Walt"));

        }

        static string Greet (Option<string> greetee) => greetee.Match (
            () => "Who is this?",
            (name) => $"Hey {name}."
        );
    }
}