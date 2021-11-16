using System;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApp1
{
    class program
    {
        static void Main(string[] args)
        {
            var prog = @"C:\Windows\system32\notepad.exe";
            Console.WriteLine("Inicia el proceso el argumento");
            Process.Start(prog);
            
      
        }
    }
}
